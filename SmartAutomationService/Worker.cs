using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using SmartAutomationService.Model.Connections;
using SmartAutomationService.Model.Data;
using SmartAutomationService.Model.Proto;
using SmartAutomationService.Model.Services;

namespace SmartAutomationService
{
    public class Worker : BackgroundService
    {
        private readonly string _watchFolder;
        private FileSystemWatcher _folderWatcher;
        private readonly UtilService _utilService;
        private readonly AutomationService _automationService;
        private readonly EmailService _emailService;
        private readonly SmartLinkOrdersService _smartLinkOrdersService;

        public Worker(UtilService utilService, IOptions<AppSettings> options,
            EmailService emailService, AutomationService automationService)
        {
            _utilService = utilService ?? throw new ArgumentNullException(nameof(utilService));
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
            _watchFolder = options.Value.WatchFolder;
            _automationService = automationService;
            IDbConnection smartLinkConnection = new SmartLinkConnection();
            _smartLinkOrdersService = new SmartLinkOrdersService(smartLinkConnection);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.CompletedTask;
            }
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            try
            {
                _utilService.WriteToLog("Service Started",
                    "Smart Automation Service Started Successfully",false);
                if (!Directory.Exists(_watchFolder))
                {
                    _utilService.WriteToLog(
                        "Watcher Error", 
                        "Please make sure WatchFolder Path (" + _watchFolder + ") exists, then restart the service.", 
                        true);
                    Console.WriteLine("Please make sure WatchFolder Path (" + _watchFolder + ") exists, then restart the service.");
                    return Task.CompletedTask;
                }
                _utilService.WriteToLog("Watcher",
                    "Start Watching folder in Path (" + _watchFolder + ").",false);
                _folderWatcher = new FileSystemWatcher
                {
                    Path = _watchFolder,
                    NotifyFilter = NotifyFilters.CreationTime | 
                                   NotifyFilters.LastWrite | 
                                   NotifyFilters.FileName |
                                   NotifyFilters.DirectoryName,
                    Filter = "*.*",
                    EnableRaisingEvents = true
                };
                _folderWatcher.Created += OnCreate;
                return base.StartAsync(cancellationToken);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _utilService.WriteToLog(e.Source, e.Message, true);
                return Task.CompletedTask;
            }
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            _utilService.WriteToLog("Service Stopped",
                "Smart Automation Service Stopped",true);
            Console.WriteLine("Service Stopped for unknown reason .......");
            _folderWatcher.EnableRaisingEvents = false;
            // Send Email ......
            var smartEmail = new SmartMail();
            smartEmail.ReplyTo.Add("Technology@SMARTMEDS.CA");
            smartEmail.SendTo.Add("Technology@SMARTMEDS.CA");
            smartEmail.SendTo.Add("tamer.rabie@SMARTMEDS.CA");
            smartEmail.Subject = "Automation Service Stopped !!";
            smartEmail.Body = "Smart Automation Service Stopped at (" + DateTimeOffset.Now.ToString("F") + ")";
            smartEmail.DisplayName = "Technology Team";
            _emailService.SendMail(smartEmail);
            await base.StopAsync(cancellationToken);
        }
        
        public override void Dispose()
        {
            _folderWatcher.Dispose();
            base.Dispose();
        }

        private void OnCreate(object source, FileSystemEventArgs e)
        {
            try
            {
                if (e.ChangeType != WatcherChangeTypes.Created) return;
                if (e.FullPath.LastIndexOf(".", StringComparison.Ordinal) <= 0) return;
                var index = e.Name.LastIndexOf("_", StringComparison.Ordinal);
                if (index <= 0) return;
                var fileName = e.Name.Substring(0, index);
                var ok = long.TryParse(fileName, out var orderId);
                if(!ok) return;
                _utilService.WriteToLog("File Received", "File Name: " + orderId, false);
                // Check if it is Re-Fill Order .............
                var smartLinkOrder = _smartLinkOrdersService.Select("OrderID", orderId);
                if (smartLinkOrder == null)
                {
                    _utilService.WriteToLog("Not Refill Order: ", "File Name: " + orderId, true);
                    return;
                }
                if (string.IsNullOrEmpty(smartLinkOrder.FileName)) return;
                _automationService.CreateRefillOrder(smartLinkOrder);
            }
            catch (Exception exception)
            {
                Console.WriteLine(e);
                _utilService.WriteToLog(exception.Source, exception.Message, true);
            }
        }
    }
}