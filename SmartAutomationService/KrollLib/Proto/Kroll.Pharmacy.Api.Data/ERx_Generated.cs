
        // Generated from: ERx.proto
        // Note: requires additional types generated from: ERxAdministration.proto
        // Note: requires additional types generated from: ERxDispense.proto
        // Note: requires additional types generated from: ERxLink.proto
        // Note: requires additional types generated from: ERxOrder.proto
        // Note: requires additional types generated from: ERxTransmission.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ERx")]
        public partial class ERx : global::ProtoBuf.IExtensible
        {
        public ERx() {}
        

        private int mId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Id
        {
        get { return mId; }
        set { mId = value; }
        }

        private int mExternalInterfaceId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ExternalInterfaceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ExternalInterfaceId
        {
        get { return mExternalInterfaceId; }
        set { mExternalInterfaceId = value; }
        }

        private string mExternalRxReference
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ExternalRxReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalRxReference
        {
        get { return mExternalRxReference; }
        set { mExternalRxReference = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private bool mPatIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatIdSpecified
        {
        get { return mPatIdSpecified; }
        set { mPatIdSpecified = value; }
        }

        private string mExternalPatReference
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ExternalPatReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalPatReference
        {
        get { return mExternalPatReference; }
        set { mExternalPatReference = value; }
        }

        private double mLastInboundOrderDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"LastInboundOrderDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastInboundOrderDate
        {
        get { return mLastInboundOrderDate; }
        set { mLastInboundOrderDate = value; }
        }

        private bool mLastInboundOrderDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"LastInboundOrderDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastInboundOrderDateSpecified
        {
        get { return mLastInboundOrderDateSpecified; }
        set { mLastInboundOrderDateSpecified = value; }
        }

        private double mLastOutboundOrderDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"LastOutboundOrderDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastOutboundOrderDate
        {
        get { return mLastOutboundOrderDate; }
        set { mLastOutboundOrderDate = value; }
        }

        private bool mLastOutboundOrderDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"LastOutboundOrderDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastOutboundOrderDateSpecified
        {
        get { return mLastOutboundOrderDateSpecified; }
        set { mLastOutboundOrderDateSpecified = value; }
        }

        private double mLastOrderProcessedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"LastOrderProcessedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastOrderProcessedDate
        {
        get { return mLastOrderProcessedDate; }
        set { mLastOrderProcessedDate = value; }
        }

        private bool mLastOrderProcessedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"LastOrderProcessedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastOrderProcessedDateSpecified
        {
        get { return mLastOrderProcessedDateSpecified; }
        set { mLastOrderProcessedDateSpecified = value; }
        }

        private int mCurrentERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"CurrentERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CurrentERxOrderId
        {
        get { return mCurrentERxOrderId; }
        set { mCurrentERxOrderId = value; }
        }

        private bool mCurrentERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"CurrentERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CurrentERxOrderIdSpecified
        {
        get { return mCurrentERxOrderIdSpecified; }
        set { mCurrentERxOrderIdSpecified = value; }
        }

        private int mLastProcessedERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"LastProcessedERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int LastProcessedERxOrderId
        {
        get { return mLastProcessedERxOrderId; }
        set { mLastProcessedERxOrderId = value; }
        }

        private bool mLastProcessedERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"LastProcessedERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastProcessedERxOrderIdSpecified
        {
        get { return mLastProcessedERxOrderIdSpecified; }
        set { mLastProcessedERxOrderIdSpecified = value; }
        }

        private int mCurrentMistakeERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"CurrentMistakeERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CurrentMistakeERxOrderId
        {
        get { return mCurrentMistakeERxOrderId; }
        set { mCurrentMistakeERxOrderId = value; }
        }

        private bool mCurrentMistakeERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"CurrentMistakeERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CurrentMistakeERxOrderIdSpecified
        {
        get { return mCurrentMistakeERxOrderIdSpecified; }
        set { mCurrentMistakeERxOrderIdSpecified = value; }
        }

        private int mLastProcessedMistakeERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"LastProcessedMistakeERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int LastProcessedMistakeERxOrderId
        {
        get { return mLastProcessedMistakeERxOrderId; }
        set { mLastProcessedMistakeERxOrderId = value; }
        }

        private bool mLastProcessedMistakeERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"LastProcessedMistakeERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastProcessedMistakeERxOrderIdSpecified
        {
        get { return mLastProcessedMistakeERxOrderIdSpecified; }
        set { mLastProcessedMistakeERxOrderIdSpecified = value; }
        }

        private int mCurrentDiscontinueERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"CurrentDiscontinueERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CurrentDiscontinueERxOrderId
        {
        get { return mCurrentDiscontinueERxOrderId; }
        set { mCurrentDiscontinueERxOrderId = value; }
        }

        private bool mCurrentDiscontinueERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"CurrentDiscontinueERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CurrentDiscontinueERxOrderIdSpecified
        {
        get { return mCurrentDiscontinueERxOrderIdSpecified; }
        set { mCurrentDiscontinueERxOrderIdSpecified = value; }
        }

        private int mLastProcessedDiscontinueERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"LastProcessedDiscontinueERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int LastProcessedDiscontinueERxOrderId
        {
        get { return mLastProcessedDiscontinueERxOrderId; }
        set { mLastProcessedDiscontinueERxOrderId = value; }
        }

        private bool mLastProcessedDiscontinueERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"LastProcessedDiscontinueERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastProcessedDiscontinueERxOrderIdSpecified
        {
        get { return mLastProcessedDiscontinueERxOrderIdSpecified; }
        set { mLastProcessedDiscontinueERxOrderIdSpecified = value; }
        }

        private int mCurrentSuspendERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"CurrentSuspendERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CurrentSuspendERxOrderId
        {
        get { return mCurrentSuspendERxOrderId; }
        set { mCurrentSuspendERxOrderId = value; }
        }

        private bool mCurrentSuspendERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"CurrentSuspendERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CurrentSuspendERxOrderIdSpecified
        {
        get { return mCurrentSuspendERxOrderIdSpecified; }
        set { mCurrentSuspendERxOrderIdSpecified = value; }
        }

        private int mLastProcessedSuspendERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"LastProcessedSuspendERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int LastProcessedSuspendERxOrderId
        {
        get { return mLastProcessedSuspendERxOrderId; }
        set { mLastProcessedSuspendERxOrderId = value; }
        }

        private bool mLastProcessedSuspendERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"LastProcessedSuspendERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastProcessedSuspendERxOrderIdSpecified
        {
        get { return mLastProcessedSuspendERxOrderIdSpecified; }
        set { mLastProcessedSuspendERxOrderIdSpecified = value; }
        }

        private int mCurrentResumeERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"CurrentResumeERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CurrentResumeERxOrderId
        {
        get { return mCurrentResumeERxOrderId; }
        set { mCurrentResumeERxOrderId = value; }
        }

        private bool mCurrentResumeERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"CurrentResumeERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CurrentResumeERxOrderIdSpecified
        {
        get { return mCurrentResumeERxOrderIdSpecified; }
        set { mCurrentResumeERxOrderIdSpecified = value; }
        }

        private int mLastProcessedResumeERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"LastProcessedResumeERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int LastProcessedResumeERxOrderId
        {
        get { return mLastProcessedResumeERxOrderId; }
        set { mLastProcessedResumeERxOrderId = value; }
        }

        private bool mLastProcessedResumeERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"LastProcessedResumeERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastProcessedResumeERxOrderIdSpecified
        {
        get { return mLastProcessedResumeERxOrderIdSpecified; }
        set { mLastProcessedResumeERxOrderIdSpecified = value; }
        }

        private int mCurrentRefillERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"CurrentRefillERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CurrentRefillERxOrderId
        {
        get { return mCurrentRefillERxOrderId; }
        set { mCurrentRefillERxOrderId = value; }
        }

        private bool mCurrentRefillERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"CurrentRefillERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CurrentRefillERxOrderIdSpecified
        {
        get { return mCurrentRefillERxOrderIdSpecified; }
        set { mCurrentRefillERxOrderIdSpecified = value; }
        }

        private int mLastProcessedRefillERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"LastProcessedRefillERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int LastProcessedRefillERxOrderId
        {
        get { return mLastProcessedRefillERxOrderId; }
        set { mLastProcessedRefillERxOrderId = value; }
        }

        private bool mLastProcessedRefillERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"LastProcessedRefillERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastProcessedRefillERxOrderIdSpecified
        {
        get { return mLastProcessedRefillERxOrderIdSpecified; }
        set { mLastProcessedRefillERxOrderIdSpecified = value; }
        }

        private bool mHasERxOrderRequiringProcessing
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"HasERxOrderRequiringProcessing", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HasERxOrderRequiringProcessing
        {
        get { return mHasERxOrderRequiringProcessing; }
        set { mHasERxOrderRequiringProcessing = value; }
        }

        private int mCopiedFromERxId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"CopiedFromERxId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CopiedFromERxId
        {
        get { return mCopiedFromERxId; }
        set { mCopiedFromERxId = value; }
        }

        private bool mCopiedFromERxIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"CopiedFromERxIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CopiedFromERxIdSpecified
        {
        get { return mCopiedFromERxIdSpecified; }
        set { mCopiedFromERxIdSpecified = value; }
        }

        private int mCopiedToERxId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"CopiedToERxId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CopiedToERxId
        {
        get { return mCopiedToERxId; }
        set { mCopiedToERxId = value; }
        }

        private bool mCopiedToERxIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"CopiedToERxIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CopiedToERxIdSpecified
        {
        get { return mCopiedToERxIdSpecified; }
        set { mCopiedToERxIdSpecified = value; }
        }

        private bool mIsClosed
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"IsClosed", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsClosed
        {
        get { return mIsClosed; }
        set { mIsClosed = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateCreated
        {
        get { return mDateCreated; }
        set { mDateCreated = value; }
        }

        private bool mDateCreatedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateCreatedSpecified
        {
        get { return mDateCreatedSpecified; }
        set { mDateCreatedSpecified = value; }
        }

        private double mDateChanged
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateChanged
        {
        get { return mDateChanged; }
        set { mDateChanged = value; }
        }

        private bool mDateChangedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxAdministration> mERxAdministrations = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxAdministration>();
        [global::ProtoBuf.ProtoMember(48, Name=@"ERxAdministrations", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxAdministration> ERxAdministrations
        {
        get { return mERxAdministrations; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxDispense> mERxDispenses = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxDispense>();
        [global::ProtoBuf.ProtoMember(49, Name=@"ERxDispenses", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxDispense> ERxDispenses
        {
        get { return mERxDispenses; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxLink> mERxLinks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxLink>();
        [global::ProtoBuf.ProtoMember(50, Name=@"ERxLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxLink> ERxLinks
        {
        get { return mERxLinks; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxOrder> mERxOrders = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxOrder>();
        [global::ProtoBuf.ProtoMember(51, Name=@"ERxOrders", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxOrder> ERxOrders
        {
        get { return mERxOrders; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxTransmission> mERxTransmissions = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxTransmission>();
        [global::ProtoBuf.ProtoMember(52, Name=@"ERxTransmissions", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxTransmission> ERxTransmissions
        {
        get { return mERxTransmissions; }
        }
    

        private string mPriorExternalRxReference
            = "";
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"PriorExternalRxReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PriorExternalRxReference
        {
        get { return mPriorExternalRxReference; }
        set { mPriorExternalRxReference = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        