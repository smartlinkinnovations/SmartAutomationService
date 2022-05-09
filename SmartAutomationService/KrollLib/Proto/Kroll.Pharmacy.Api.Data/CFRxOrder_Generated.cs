
        // Generated from: CFRxOrder.proto
        // Note: requires additional types generated from: CFRxOrderStatus_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CFRxOrder")]
        public partial class CFRxOrder : global::ProtoBuf.IExtensible
        {
        public CFRxOrder() {}
        

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

        private int mCFOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"CFOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CFOrderId
        {
        get { return mCFOrderId; }
        set { mCFOrderId = value; }
        }

        private bool mCFOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"CFOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CFOrderIdSpecified
        {
        get { return mCFOrderIdSpecified; }
        set { mCFOrderIdSpecified = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private Kroll.Pharmacy.Api.Data.CFRxOrderStatus mStatus
            = Kroll.Pharmacy.Api.Data.CFRxOrderStatus.CFRxOrderStatus_Unknown;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CFRxOrderStatus.CFRxOrderStatus_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.CFRxOrderStatus Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private bool mSnapCaps
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"SnapCaps", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SnapCaps
        {
        get { return mSnapCaps; }
        set { mSnapCaps = value; }
        }

        private bool mPrintCounselling
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PrintCounselling", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintCounselling
        {
        get { return mPrintCounselling; }
        set { mPrintCounselling = value; }
        }

        private bool mBackOrdered
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"BackOrdered", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BackOrdered
        {
        get { return mBackOrdered; }
        set { mBackOrdered = value; }
        }

        private string mOrderedDIN
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"OrderedDIN", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OrderedDIN
        {
        get { return mOrderedDIN; }
        set { mOrderedDIN = value; }
        }

        private double mQuotedPrice
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"QuotedPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double QuotedPrice
        {
        get { return mQuotedPrice; }
        set { mQuotedPrice = value; }
        }

        private bool mQuotedPriceSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"QuotedPriceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool QuotedPriceSpecified
        {
        get { return mQuotedPriceSpecified; }
        set { mQuotedPriceSpecified = value; }
        }

        private bool mVerified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Verified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Verified
        {
        get { return mVerified; }
        set { mVerified = value; }
        }

        private bool mReportBased
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"ReportBased", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ReportBased
        {
        get { return mReportBased; }
        set { mReportBased = value; }
        }

        private int mCFHostId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"CFHostId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CFHostId
        {
        get { return mCFHostId; }
        set { mCFHostId = value; }
        }

        private bool mCFHostIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"CFHostIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CFHostIdSpecified
        {
        get { return mCFHostIdSpecified; }
        set { mCFHostIdSpecified = value; }
        }

        private int mCFPackagerId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"CFPackagerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CFPackagerId
        {
        get { return mCFPackagerId; }
        set { mCFPackagerId = value; }
        }

        private bool mCFPackagerIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"CFPackagerIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CFPackagerIdSpecified
        {
        get { return mCFPackagerIdSpecified; }
        set { mCFPackagerIdSpecified = value; }
        }

        private bool mWasSent
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"WasSent", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WasSent
        {
        get { return mWasSent; }
        set { mWasSent = value; }
        }

        private string mHostPackagerId
            = "";
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"HostPackagerId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string HostPackagerId
        {
        get { return mHostPackagerId; }
        set { mHostPackagerId = value; }
        }

        private bool mLabelPrinted
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"LabelPrinted", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LabelPrinted
        {
        get { return mLabelPrinted; }
        set { mLabelPrinted = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        