using System;

namespace SmartAutomationService.Model.Data
{
    public class SmartLinkOrder
    {
        // orders Table ...........
        public long OrderId { get; set; }
        public DateTime? DateOrderReceived { get; set; }
        public string FileName { get; set; }
        public bool IsOrder { get; set; }
        public bool IsPenOrder { get; set; }
        public int IsFaxOrder { get; set; }
        public int IsMedChecks { get; set; }
        public bool IsSmartDocOrder { get; set; }
        public bool IsDeleted { get; set; }
        public SmartLinkOrderStatus SmartLinkOrderStatus { get; set; }
        public DateTime DateReadReceiptReceived { get; set; }
        public int ProcessedById { get; set; }
        public string OrderToolTip { get; set; }
        // SmartRefillOrders Table ...........
        public Pat Pat { get; set; }
        public string RxNum { get; set; }
        public string OrigRxNum { get; set; }
        public bool IsNarcotic { get; set; }
        public bool IsCancelled { get; set; }
        public NhWard NhWard { get; set; }
        public Nh Nh { get; set; }
    }
}