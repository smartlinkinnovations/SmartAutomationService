
        // Generated from: AdjQue.proto
        // Note: requires additional types generated from: AdjNodeType_Enum.proto
        // Note: requires additional types generated from: AdjQueState_Enum.proto
        // Note: requires additional types generated from: AdjQueResultCode_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AdjQue")]
        public partial class AdjQue : global::ProtoBuf.IExtensible
        {
        public AdjQue() {}
        

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

        private Kroll.Pharmacy.Api.Data.AdjNodeType mNodeType
            = Kroll.Pharmacy.Api.Data.AdjNodeType.AdjNodeType_NotSet;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"NodeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdjNodeType.AdjNodeType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.AdjNodeType NodeType
        {
        get { return mNodeType; }
        set { mNodeType = value; }
        }

        private int mPriority
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Priority
        {
        get { return mPriority; }
        set { mPriority = value; }
        }

        private bool mPrioritySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"PrioritySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrioritySpecified
        {
        get { return mPrioritySpecified; }
        set { mPrioritySpecified = value; }
        }

        private int mClaimId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ClaimId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ClaimId
        {
        get { return mClaimId; }
        set { mClaimId = value; }
        }

        private int mRxId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"RxId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxId
        {
        get { return mRxId; }
        set { mRxId = value; }
        }

        private int mAdjHostId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"AdjHostId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AdjHostId
        {
        get { return mAdjHostId; }
        set { mAdjHostId = value; }
        }

        private string mRxNum
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdjQueState mState
            = Kroll.Pharmacy.Api.Data.AdjQueState.AdjQueState_OnHold;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"State", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdjQueState.AdjQueState_OnHold)]
        
        public Kroll.Pharmacy.Api.Data.AdjQueState State
        {
        get { return mState; }
        set { mState = value; }
        }

        private byte[] mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdjQueResultCode mResultCode
            = Kroll.Pharmacy.Api.Data.AdjQueResultCode.AdjQueResultCode_NotSet;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"ResultCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdjQueResultCode.AdjQueResultCode_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.AdjQueResultCode ResultCode
        {
        get { return mResultCode; }
        set { mResultCode = value; }
        }

        private byte[] mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }

        private string mPatName
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"PatName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PatName
        {
        get { return mPatName; }
        set { mPatName = value; }
        }

        private string mSubPlan
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"SubPlan", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SubPlan
        {
        get { return mSubPlan; }
        set { mSubPlan = value; }
        }

        private string mStation
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"Station", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Station
        {
        get { return mStation; }
        set { mStation = value; }
        }

        private string mUserInit
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"UserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserInit
        {
        get { return mUserInit; }
        set { mUserInit = value; }
        }

        private bool mWasSent
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"WasSent", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WasSent
        {
        get { return mWasSent; }
        set { mWasSent = value; }
        }

        private bool mNoHangup
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"NoHangup", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoHangup
        {
        get { return mNoHangup; }
        set { mNoHangup = value; }
        }

        private string mErrorMessages
            = "";
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"ErrorMessages", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ErrorMessages
        {
        get { return mErrorMessages; }
        set { mErrorMessages = value; }
        }

        private int mAdjRouteId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"AdjRouteId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AdjRouteId
        {
        get { return mAdjRouteId; }
        set { mAdjRouteId = value; }
        }

        private bool mAdjRouteIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"AdjRouteIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AdjRouteIdSpecified
        {
        get { return mAdjRouteIdSpecified; }
        set { mAdjRouteIdSpecified = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private int mUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"UserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UserId
        {
        get { return mUserId; }
        set { mUserId = value; }
        }

        private bool mUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"UserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserIdSpecified
        {
        get { return mUserIdSpecified; }
        set { mUserIdSpecified = value; }
        }

        private double mAdjResponseDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"AdjResponseDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AdjResponseDate
        {
        get { return mAdjResponseDate; }
        set { mAdjResponseDate = value; }
        }

        private bool mAdjResponseDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"AdjResponseDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AdjResponseDateSpecified
        {
        get { return mAdjResponseDateSpecified; }
        set { mAdjResponseDateSpecified = value; }
        }

        private string mRequestEncoding
            = "";
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"RequestEncoding", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RequestEncoding
        {
        get { return mRequestEncoding; }
        set { mRequestEncoding = value; }
        }

        private string mResponseEncoding
            = "";
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"ResponseEncoding", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResponseEncoding
        {
        get { return mResponseEncoding; }
        set { mResponseEncoding = value; }
        }

        private int mParserType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"ParserType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ParserType
        {
        get { return mParserType; }
        set { mParserType = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        