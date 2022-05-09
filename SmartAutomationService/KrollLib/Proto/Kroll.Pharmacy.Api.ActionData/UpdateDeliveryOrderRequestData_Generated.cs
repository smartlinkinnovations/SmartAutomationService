
        // Generated from: UpdateDeliveryOrderRequestData.proto
        // Note: requires additional types generated from: DeliveryOrderStatus_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateDeliveryOrderRequestData")]
        public partial class UpdateDeliveryOrderRequestData : global::ProtoBuf.IExtensible
        {
        public UpdateDeliveryOrderRequestData() {}
        

        private int mDeliveryOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DeliveryOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryOrderId
        {
        get { return mDeliveryOrderId; }
        set { mDeliveryOrderId = value; }
        }

        private string mWaybill
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Waybill", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Waybill
        {
        get { return mWaybill; }
        set { mWaybill = value; }
        }

        private bool mUpdateWaybill
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"UpdateWaybill", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UpdateWaybill
        {
        get { return mUpdateWaybill; }
        set { mUpdateWaybill = value; }
        }

        private Kroll.Pharmacy.Api.Data.DeliveryOrderStatus mStatus
            = Kroll.Pharmacy.Api.Data.DeliveryOrderStatus.DeliveryOrderStatus_Pending;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DeliveryOrderStatus.DeliveryOrderStatus_Pending)]
        
        public Kroll.Pharmacy.Api.Data.DeliveryOrderStatus Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private bool mUpdateStatus
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"UpdateStatus", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UpdateStatus
        {
        get { return mUpdateStatus; }
        set { mUpdateStatus = value; }
        }

        private double mDateShipped
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DateShipped", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateShipped
        {
        get { return mDateShipped; }
        set { mDateShipped = value; }
        }

        private bool mUpdateDateShipped
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"UpdateDateShipped", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UpdateDateShipped
        {
        get { return mUpdateDateShipped; }
        set { mUpdateDateShipped = value; }
        }

        private double mDateReceived
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DateReceived", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateReceived
        {
        get { return mDateReceived; }
        set { mDateReceived = value; }
        }

        private bool mUpdateDateReceived
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"UpdateDateReceived", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UpdateDateReceived
        {
        get { return mUpdateDateReceived; }
        set { mUpdateDateReceived = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private bool mUpdateComment
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"UpdateComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UpdateComment
        {
        get { return mUpdateComment; }
        set { mUpdateComment = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        