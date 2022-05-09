
        // Generated from: Adt.proto
        // Note: requires additional types generated from: AdtType_Enum.proto
        // Note: requires additional types generated from: AdtDirection_Enum.proto
        // Note: requires additional types generated from: AdtStatus_Enum.proto
        // Note: requires additional types generated from: AdtPat.proto
        // Note: requires additional types generated from: CompressionType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Adt")]
        public partial class Adt : global::ProtoBuf.IExtensible
        {
        public Adt() {}
        

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

        private Kroll.Pharmacy.Api.Data.AdtType mAdtType
            = Kroll.Pharmacy.Api.Data.AdtType.AdtType_Unknown;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"AdtType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdtType.AdtType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.AdtType AdtType
        {
        get { return mAdtType; }
        set { mAdtType = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdtDirection mDirection
            = Kroll.Pharmacy.Api.Data.AdtDirection.AdtDirection_Output;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Direction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdtDirection.AdtDirection_Output)]
        
        public Kroll.Pharmacy.Api.Data.AdtDirection Direction
        {
        get { return mDirection; }
        set { mDirection = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdtStatus mStatus
            = Kroll.Pharmacy.Api.Data.AdtStatus.AdtStatus_Unknown;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdtStatus.AdtStatus_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.AdtStatus Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private double mEffectiveDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"EffectiveDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double EffectiveDate
        {
        get { return mEffectiveDate; }
        set { mEffectiveDate = value; }
        }

        private double mInitiatedOnDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"InitiatedOnDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double InitiatedOnDate
        {
        get { return mInitiatedOnDate; }
        set { mInitiatedOnDate = value; }
        }

        private bool mInitiatedOnDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"InitiatedOnDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InitiatedOnDateSpecified
        {
        get { return mInitiatedOnDateSpecified; }
        set { mInitiatedOnDateSpecified = value; }
        }

        private string mInitiatedBy
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"InitiatedBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string InitiatedBy
        {
        get { return mInitiatedBy; }
        set { mInitiatedBy = value; }
        }

        private double mHandledOnDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"HandledOnDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double HandledOnDate
        {
        get { return mHandledOnDate; }
        set { mHandledOnDate = value; }
        }

        private bool mHandledOnDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"HandledOnDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HandledOnDateSpecified
        {
        get { return mHandledOnDateSpecified; }
        set { mHandledOnDateSpecified = value; }
        }

        private string mHandledBy
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"HandledBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string HandledBy
        {
        get { return mHandledBy; }
        set { mHandledBy = value; }
        }

        private int mExternalInterfaceId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"ExternalInterfaceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ExternalInterfaceId
        {
        get { return mExternalInterfaceId; }
        set { mExternalInterfaceId = value; }
        }

        private string mExternalMessageId
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"ExternalMessageId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalMessageId
        {
        get { return mExternalMessageId; }
        set { mExternalMessageId = value; }
        }

        private string mExternalReference
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ExternalReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalReference
        {
        get { return mExternalReference; }
        set { mExternalReference = value; }
        }

        private byte[] mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }

        private Kroll.Pharmacy.Api.Data.CompressionType mRequestDataCompressionType
            = Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"RequestDataCompressionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.CompressionType RequestDataCompressionType
        {
        get { return mRequestDataCompressionType; }
        set { mRequestDataCompressionType = value; }
        }

        private byte[] mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }

        private Kroll.Pharmacy.Api.Data.CompressionType mResponseDataCompressionType
            = Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"ResponseDataCompressionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.CompressionType ResponseDataCompressionType
        {
        get { return mResponseDataCompressionType; }
        set { mResponseDataCompressionType = value; }
        }

        private bool mIsCancelRequest
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"IsCancelRequest", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsCancelRequest
        {
        get { return mIsCancelRequest; }
        set { mIsCancelRequest = value; }
        }

        private int mAdtIdToCancel
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"AdtIdToCancel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AdtIdToCancel
        {
        get { return mAdtIdToCancel; }
        set { mAdtIdToCancel = value; }
        }

        private bool mAdtIdToCancelSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"AdtIdToCancelSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AdtIdToCancelSpecified
        {
        get { return mAdtIdToCancelSpecified; }
        set { mAdtIdToCancelSpecified = value; }
        }

        private int mCancelledByAdtId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"CancelledByAdtId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CancelledByAdtId
        {
        get { return mCancelledByAdtId; }
        set { mCancelledByAdtId = value; }
        }

        private bool mCancelledByAdtIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"CancelledByAdtIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CancelledByAdtIdSpecified
        {
        get { return mCancelledByAdtIdSpecified; }
        set { mCancelledByAdtIdSpecified = value; }
        }

        private string mMessages
            = "";
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"Messages", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Messages
        {
        get { return mMessages; }
        set { mMessages = value; }
        }

        private double mDeferUntilDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"DeferUntilDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DeferUntilDate
        {
        get { return mDeferUntilDate; }
        set { mDeferUntilDate = value; }
        }

        private bool mDeferUntilDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"DeferUntilDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeferUntilDateSpecified
        {
        get { return mDeferUntilDateSpecified; }
        set { mDeferUntilDateSpecified = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private bool mStoreIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"StoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StoreIdSpecified
        {
        get { return mStoreIdSpecified; }
        set { mStoreIdSpecified = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPat> mAdtPat = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPat>();
        [global::ProtoBuf.ProtoMember(34, Name=@"AdtPat", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPat> AdtPat
        {
        get { return mAdtPat; }
        }
    

        private int mHandledStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"HandledStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int HandledStatus
        {
        get { return mHandledStatus; }
        set { mHandledStatus = value; }
        }

        private int mHandledByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"HandledByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int HandledByUserId
        {
        get { return mHandledByUserId; }
        set { mHandledByUserId = value; }
        }

        private bool mHandledByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"HandledByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HandledByUserIdSpecified
        {
        get { return mHandledByUserIdSpecified; }
        set { mHandledByUserIdSpecified = value; }
        }

        private int mInitiatedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"InitiatedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int InitiatedByUserId
        {
        get { return mInitiatedByUserId; }
        set { mInitiatedByUserId = value; }
        }

        private bool mInitiatedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"InitiatedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InitiatedByUserIdSpecified
        {
        get { return mInitiatedByUserIdSpecified; }
        set { mInitiatedByUserIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        