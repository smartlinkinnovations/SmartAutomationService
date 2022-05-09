using System;
using System.IO;
using System.Text.Json;
using Kroll.Pharmacy.Api.Messages;
using Microsoft.Extensions.Hosting;

namespace SmartAutomationService.Model.Services
{
    public class UtilService
    {
        private readonly IHostEnvironment _env;
        private const string LogFileName = "log.txt";
        private const string DbPath = "Db";
        private const string FailedResponsesPath = "Failed_Responses";

        public UtilService(IHostEnvironment env)
        {
            _env = env ?? throw new ArgumentNullException(nameof(env));
        }
        
        public void WriteToLog(string messageType, string txt, bool isBreak)
        {
            var filePath = Path.Combine(_env.ContentRootPath, LogFileName);
            if (!File.Exists(filePath))
            {
                using var myFile = File.Create(filePath);
                myFile.Dispose();
            }
            var writer = new StreamWriter(filePath, true);
            writer.WriteLine(messageType + ": " + txt);
            writer.WriteLine("DateTime: " + DateTimeOffset.Now.ToString("F"));
            if (isBreak)
            {
                writer.WriteLine("*********************************************");
                writer.WriteLine();
            }
            writer.Close();
        }
        
        public void CreateJsonFile(CreateToDoRxRefillResponse response)
        {
            try
            {
                var filePath = Path.Combine(GetDbDir(), response.ResponseData.RxNum + ".json");
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                using var myFile = File.Create(filePath);
                myFile.Dispose();
                var str = JsonSerializer.Serialize(response.ResponseData);
                var writer = new StreamWriter(filePath, true);
                writer.WriteLine(str);
                writer.Dispose();
            }
            catch (Exception e)
            {
                WriteToLog(e.Source, e.Message, true);
            }
        }
        
        public void CreateJsonFile(CreateWorkOrderResponse response, int rxNum)
        {
            try
            {
                var filePath = Path.Combine(GetDbDir(), "WorkOrder_" + rxNum + ".json");
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                using var myFile = File.Create(filePath);
                myFile.Dispose();
                var str = JsonSerializer.Serialize(response.ResponseData);
                var writer = new StreamWriter(filePath, true);
                writer.WriteLine(str);
                writer.Dispose();
            }
            catch (Exception e)
            {
                WriteToLog(e.Source, e.Message, true);
            }
        }
        
        
        private string GetDbDir()
        {
            var dir = Path.Combine(_env.ContentRootPath, FailedResponsesPath);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
        
        public static DateTime? ConvertDate(double d)
        {
            return d == 0 ? new DateTime?() : new DateTime(1970, 1, 1).AddDays(d).ToUniversalTime();
        }
        
    }
}