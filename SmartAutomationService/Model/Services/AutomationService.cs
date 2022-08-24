using System;
using SmartAutomationService.Model.Connections;
using SmartAutomationService.Model.Data;
using SmartAutomationService.Model.Proto;

namespace SmartAutomationService.Model.Services
{
    public class AutomationService
    {
        private readonly KrollApiService _krollApiService;
        private readonly UtilService _utilService;
        private readonly KrollToDoService _krollToDoService;
        private readonly SmartLinkOrdersService _smartLinkOrdersService;

        public AutomationService(KrollApiService krollApiService, UtilService utilService, IDbConnection connection)
        {
            _krollApiService = krollApiService ?? throw new ArgumentNullException(nameof(krollApiService));
            _utilService = utilService ?? throw new ArgumentNullException(nameof(utilService));
            _krollToDoService = new KrollToDoService(connection);
            IDbConnection smartLinkConnection = new SmartLinkConnection();
            _smartLinkOrdersService = new SmartLinkOrdersService(smartLinkConnection);
        }

        public void CreateRefillOrder(SmartLinkOrder smartLinkOrder)
        {
            try
            {
                var krollToDo = new KrollToDo();
                var rxNum = Convert.ToInt32(smartLinkOrder.RxNum);
                _utilService.WriteToLog("Print RxNum", rxNum.ToString(), true);
                var rxList = _krollApiService.SearchRx(rxNum);
                if (rxList != null && rxList.Count > 0)
                {
                    var rx = rxList[0];
                    
                    // Demo Home Only For Test ................
                    // if (rx.NHId != 52) return;
                    
                    if (smartLinkOrder.FileName.ToLower().Contains("statbox"))
                    {
                        krollToDo.IsStatbox = true;
                    }

                    if (smartLinkOrder.FileName.ToLower().Contains("medpass"))
                    {
                        krollToDo.IsMedPass = true;
                    }

                    // Create Kroll WorkOrderId Request ................
                    var workOrderResponse = _krollApiService.CreateWorkOrder();
                    if (workOrderResponse == null) return;
                    if (!workOrderResponse.ResponseData.IsAccepted)
                    {
                        _utilService.WriteToLog("WorkOrder Request Failed",
                            "WorkOrder Request for (" + rxNum + ") is not accepted, Please read failed response file.",
                            true);
                        _utilService.CreateJsonFile(workOrderResponse, rxNum);
                        return;
                    }

                    _utilService.WriteToLog("WorkOrder Request Success",
                        "New WorkOrder Created For RxNum: (" + rxNum + ").", false);
                    var workOrderId = workOrderResponse.ResponseData.WorkOrderId;
                    if (!krollToDo.IsStatbox && !krollToDo.IsMedPass)
                    {
                        // Create Kroll ToDoRxRefill Request ................
                        var todoResponse = _krollApiService.CreateToDoRxRefill(rxNum, workOrderId);
                        if (todoResponse.ResponseData == null) return;
                        if (!todoResponse.ResponseData.IsAccepted)
                        {
                            _utilService.WriteToLog("ToDo Request Failed",
                                "ToDo Request for (" + rxNum + ") is not accepted, Please read failed response file.",
                                true);
                            _utilService.CreateJsonFile(todoResponse);
                            return;
                        }

                        _utilService.WriteToLog("ToDo Request Success",
                            "New Entry Created in Kroll ToDo For RxNum: (" + rxNum + ").", false);
                        // Update Orders Table in SmartLink For Green Sign ......
                        var smartLinkOrders = new SmartLinkOrder
                        {
                            ProcessedById = 7802,
                            OrderToolTip = "Smart Automation Service",
                            OrderId = smartLinkOrder.OrderId,
                            DateReadReceiptReceived = DateTime.Now,
                            SmartLinkOrderStatus = new SmartLinkOrderStatus {StatusId = 3}
                        };
                        _smartLinkOrdersService.Update(smartLinkOrders);
                        _utilService.WriteToLog("Update SmartLink Success",
                            "Update SmartLink to green For RxNum: (" + rxNum + ").", false);
                        krollToDo.ToDoId = todoResponse.ResponseData.ToDoId;
                        krollToDo.SharedDbStoreId = todoResponse.ResponseData.SharedDBStoreId;
                        krollToDo.DueDate = UtilService.ConvertDate(todoResponse.ResponseData.DueDate);
                        krollToDo.ToDoOrigin = "Re-Fill Automation";
                        krollToDo.KrollResponseType = new KrollResponseType
                            {Id = Convert.ToInt32(todoResponse.ResponseData.ResponseType)};
                    }
                    else
                    {
                        if (krollToDo.IsMedPass)
                        {
                            _utilService.WriteToLog("MedPass Order", "RxNum: " + smartLinkOrder.RxNum, true);
                        }
                        else if (krollToDo.IsStatbox)
                        {
                            _utilService.WriteToLog("Statbox Order", "RxNum: " + smartLinkOrder.RxNum, true);
                        }
                    }

                    krollToDo.SmartLinkOrderId = smartLinkOrder.OrderId;
                    krollToDo.DateOrderReceived = smartLinkOrder.DateOrderReceived;
                    krollToDo.RxNum = rxNum;
                    krollToDo.OrigRxNum = Convert.ToInt32(smartLinkOrder.OrigRxNum);
                    krollToDo.WorkOrderId = workOrderId;
                    krollToDo.FileName = smartLinkOrder.FileName;
                    krollToDo.IsOrder = smartLinkOrder.IsOrder;
                    krollToDo.IsPenOrder = smartLinkOrder.IsPenOrder;
                    krollToDo.IsSmartDocOrder = smartLinkOrder.IsSmartDocOrder;
                    krollToDo.IsNarcotic = smartLinkOrder.IsNarcotic;
                    krollToDo.IsFaxOrder = smartLinkOrder.IsFaxOrder;
                    krollToDo.IsMedChecks = smartLinkOrder.IsMedChecks;
                    krollToDo.Pat = smartLinkOrder.Pat;
                    krollToDo.Nh = smartLinkOrder.Nh;
                    krollToDo.NhWard = smartLinkOrder.NhWard;
                    krollToDo.SmartLinkOrderStatus = smartLinkOrder.SmartLinkOrderStatus;
                    krollToDo.SmartLinkOrderType = new SmartLinkOrderType {Id = 1};
                    krollToDo.KrollRxStatus = new KrollRxStatus {Id = Convert.ToInt32(rx.Status)};
                    _krollToDoService.Insert(krollToDo);
                    _utilService.WriteToLog("SmartMeds Insert Success",
                        "Insert new record in SmartMeds For RxNum: (" + rxNum + ").", true);
                }
                else
                {
                    _utilService.WriteToLog("Rx Not Found",
                        "RxNum: (" + rxNum + ") Doesn't exist in Kroll DataBase", true);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _utilService.WriteToLog(e.Source, e.Message, true);
            }
        }
    }
}