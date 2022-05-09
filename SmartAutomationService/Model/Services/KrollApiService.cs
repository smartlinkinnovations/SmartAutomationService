using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Kroll.KxProto.Client;
using Kroll.Pharmacy.Api.ActionData;
using Kroll.Pharmacy.Api.Data;
using Kroll.Pharmacy.Api.Messages;
using Kroll.Pharmacy.Api.SearchCriteria;
using Kroll.Pharmacy.Api.SearchOptions;
using Microsoft.Extensions.Hosting;

namespace SmartAutomationService.Model.Services
{
    public class KrollApiService
    {
        private readonly IHostEnvironment _env;
        private readonly UtilService _utilService;
        private const string CertificatePassword = "SmartMeds1252!";
        private const string HostServiceName = "KrollAPIService";
        private const string HostName = "10.33.2.56";
        private const int HostPort = 38332;
        private readonly TimeSpan _connectionTimeout;

        public KrollApiService(IHostEnvironment env, UtilService utilService)
        {
            _env = env ?? throw new ArgumentNullException(nameof(env));
            _utilService = utilService ?? throw new ArgumentNullException(nameof(utilService));
            _connectionTimeout = new TimeSpan(0, 0, 60);
        }
        
        private IKxProtoTlsClient GetKrollAPiClient()
        {
            IKxProtoTlsClient client = new KxProtoTlsClient();
            try
            {
                var certificateFullFileName =
                    Path.Combine(Directory.GetCurrentDirectory(), @"KrollLib\Certificates\certificate.p12");
                var cert = new X509Certificate2(certificateFullFileName, CertificatePassword);
                client.Connect(HostName, HostPort, HostServiceName, cert, _connectionTimeout, 
                    KxProtoMessageSerializationType.KxProto);
                return client;
            }
            catch (Exception e)
            {
                _utilService.WriteToLog(e.Source, e.Message, true);
                Console.WriteLine(e);
                return null;
            }
        }
        
        public List<Rx> SearchRx(int rxNum)
        {
            var client = GetKrollAPiClient();
            if (client == null) return null;
            try
            {
                var searchCriteria = new RxSearchCriteria
                {
                    RxNum = rxNum,
                    RxNumSpecified = true
                };
                var searchOptions = new RxSearchOptions();
                var request = new SearchRxRequest
                {
                    SearchCriteria = searchCriteria,
                    SearchOptions = searchOptions
                };
                var searchRxResponse = client.SendMessageAndWait<SearchRxRequest, SearchRxResponse>
                    (request, request.GetType().Name, "1.0", _connectionTimeout);
                return searchRxResponse.SearchResults;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _utilService.WriteToLog(e.Source, e.Message, true);
                return null;
            }
            finally
            {
                client.Disconnect();
            }
        }
        
        public CreateWorkOrderResponse CreateWorkOrder()
        {
            var client = GetKrollAPiClient();
            if (client == null) return null;
            try
            {
                var requestData = new CreateWorkOrderRequestData
                {
                    Description = "Create WorkOrder For SMART_AUTOMATION_SERVICE",
                    CreatedBy = "SMART_AUTOMATION_SERVICE"
                };
                var request = new CreateWorkOrderRequest
                {
                    RequestData = requestData
                };
                return client.SendMessageAndWait<CreateWorkOrderRequest, CreateWorkOrderResponse>
                    (request, request.GetType().Name, "1.0", _connectionTimeout);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _utilService.WriteToLog(e.Source, e.Message, true);
                return null;
            }
            finally
            {
                client.Disconnect();
            }
        }
        
        public CreateToDoRxRefillResponse CreateToDoRxRefill(int rxNum, int workOrderId)
        {
            var client = GetKrollAPiClient();
            if (client == null) return null;
            try
            {
                var requestData = new CreateToDoRxRefillRequestData
                {
                    RxNum = rxNum,
                    SharedDBStoreId = 1,
                    SharedDBStoreIdSpecified = true,
                    WorkOrderId = workOrderId,
                    WorkOrderIdSpecified = true,
                    Comment = "Re-Fill Orders",
                    ToDoOrigin = "@Re-fill"
                };
                var refillRequest = new CreateToDoRxRefillRequest
                {
                    RequestData = requestData
                };
                return client.SendMessageAndWait<CreateToDoRxRefillRequest, CreateToDoRxRefillResponse>
                (refillRequest, refillRequest.GetType().Name, "1.0", 
                    new TimeSpan(0, 0, 10));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _utilService.WriteToLog(e.Source, e.Message, true);
                return null;
            }
            finally
            {
                client.Disconnect();
            }
        }

    }
}