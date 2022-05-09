using SmartAutomationService.Model.Proto;

namespace SmartAutomationService.Model.Queries
{
    public class SmartLinkOrdersQueries : IDbQuery
    {
        private const string Body = 
            @"
        select  
            orders.OrderID, DateOrderReceived, [FileName], IsOrder, IsPenOrder, IsFaxOrder, IsMedChecks, 
            IsSmartDocOrder, orders.IsDeleted, orderstatus.StatusID, orderstatus.Status,
            SmartRefillOrders.PatientID, SmartRefillOrders.PatientName, SmartRefillOrders.RxNum, 
            SmartRefillOrders.OrigRxNum, SmartRefillOrders.IsNarcotic, IsCancelled,
            wards.WardID, wards.WardName, wards.KrollWardID,
            homes.HomeID, homes.HomeName, homes.KrollHomeID 
        from orders 
        join orderstatus on orders.StatusID = orderstatus.StatusID  
        join SmartRefillOrders on orders.OrderID = SmartRefillOrders.OrderID  
        join wards on orders.WardID = wards.WardID 
        join homes on wards.HomeID = homes.HomeID 
            ";
        
        public string Insert()
        {
            throw new System.NotImplementedException();
        }

        public string Update()
        {
            return @"update orders set 
                        StatusID = @StatusID, Proccessedby = @Proccessedby, OrderToolTip = @OrderToolTip, 
                        DateReadReceiptReceived = @DateReadReceiptReceived 
                     where 
                        OrderID = @OrderID;";
        }

        public string Delete()
        {
            throw new System.NotImplementedException();
        }

        public string SelectByParam(string param)
        {
            return Body + " where orders.OrderID = @OrderID;";
        }

        public string ListByParam(string param)
        {
            return Body + " where orders." + param + " = " + param;
        }
    }
}