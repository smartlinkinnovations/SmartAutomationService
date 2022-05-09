using System;
using Kroll.Pharmacy.Api.Data;

namespace SmartAutomationService.Model.Data
{
    public class KrollToDo
    {
        public long Id { get; set; }
        public long SmartLinkOrderId { get; set; }
        public DateTime? DateOrderReceived { get; set; } = new DateTime?();
        public int RxNum { get; set; }
        public int OrigRxNum { get; set; }
        public int NewRxNum { get; set; }
        public int WorkOrderId { get; set; }
        public int ToDoId { get; set; }
        public string ToDoOrigin { get; set; } = string.Empty;
        public int SharedDbStoreId { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Resolved { get; set; }
        public string ResolvedComment { get; set; } = string.Empty;
        public string ResolvedBy { get; set; } = string.Empty;
        public DateTime? ResolvedDate { get; set; } = new DateTime?();
        public int PendingNewRxId { get; set; }
        public string FileName { get; set; } = string.Empty;
        public bool IsOrder { get; set; }
        public bool IsPenOrder { get; set; }
        public bool IsSmartDocOrder { get; set; }
        public int IsFaxOrder { get; set; }
        public int IsMedChecks { get; set; }
        public bool IsNarcotic { get; set; }
        public bool IsStatbox { get; set; }
        public bool IsMedPass { get; set; }
        public Pat Pat { get; set; } = new Pat();
        public Nh Nh { get; set; } = new Nh();
        public NhWard NhWard { get; set; } = new NhWard();
        public SmartLinkOrderType SmartLinkOrderType { get; set; } = new SmartLinkOrderType();
        public SmartLinkOrderStatus SmartLinkOrderStatus { get; set; } = new SmartLinkOrderStatus();
        public KrollResponseType KrollResponseType { get; set; } = new KrollResponseType();
        public KrollRxStatus KrollRxStatus { get; set; } = new KrollRxStatus();
        public ToDoType ToDoType { get; set; } = new ToDoType();
        public ToDoResolvedType ToDoResolvedType { get; set; } = new ToDoResolvedType();
        public DateTime DateCreated { get; set; }
    }
}