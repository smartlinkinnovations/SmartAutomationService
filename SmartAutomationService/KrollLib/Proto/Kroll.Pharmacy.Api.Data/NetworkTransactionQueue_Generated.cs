
        // Generated from: NetworkTransactionQueue.proto
        // Note: requires additional types generated from: NetworkQueueTransactionType_Enum.proto
        // Note: requires additional types generated from: ParserType_Enum.proto
        // Note: requires additional types generated from: AdjReadWriteLockType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NetworkTransactionQueue")]
        public partial class NetworkTransactionQueue : global::ProtoBuf.IExtensible
        {
        public NetworkTransactionQueue() {}
        

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

        private int mQueueType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"QueueType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int QueueType
        {
        get { return mQueueType; }
        set { mQueueType = value; }
        }

        private Kroll.Pharmacy.Api.Data.NetworkQueueTransactionType mTransactionType
            = Kroll.Pharmacy.Api.Data.NetworkQueueTransactionType.NetworkQueueTransactionType_None;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"TransactionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NetworkQueueTransactionType.NetworkQueueTransactionType_None)]
        
        public Kroll.Pharmacy.Api.Data.NetworkQueueTransactionType TransactionType
        {
        get { return mTransactionType; }
        set { mTransactionType = value; }
        }

        private double mQueueDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"QueueDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double QueueDate
        {
        get { return mQueueDate; }
        set { mQueueDate = value; }
        }

        private string mUserInit
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"UserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserInit
        {
        get { return mUserInit; }
        set { mUserInit = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatIdSpecified
        {
        get { return mPatIdSpecified; }
        set { mPatIdSpecified = value; }
        }

        private int mDrgId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DrgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgId
        {
        get { return mDrgId; }
        set { mDrgId = value; }
        }

        private bool mDrgIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DrgIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrgIdSpecified
        {
        get { return mDrgIdSpecified; }
        set { mDrgIdSpecified = value; }
        }

        private int mMixId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"MixId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MixId
        {
        get { return mMixId; }
        set { mMixId = value; }
        }

        private bool mMixIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"MixIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MixIdSpecified
        {
        get { return mMixIdSpecified; }
        set { mMixIdSpecified = value; }
        }

        private int mDocId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DocId
        {
        get { return mDocId; }
        set { mDocId = value; }
        }

        private bool mDocIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocIdSpecified
        {
        get { return mDocIdSpecified; }
        set { mDocIdSpecified = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private bool mRxNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxNumSpecified
        {
        get { return mRxNumSpecified; }
        set { mRxNumSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.ParserType mParserType
            = Kroll.Pharmacy.Api.Data.ParserType.ParserType_LegacyParser;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ParserType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ParserType.ParserType_LegacyParser)]
        
        public Kroll.Pharmacy.Api.Data.ParserType ParserType
        {
        get { return mParserType; }
        set { mParserType = value; }
        }

        private byte[] mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
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

        private int mState
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"State", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int State
        {
        get { return mState; }
        set { mState = value; }
        }

        private bool mStateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"StateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StateSpecified
        {
        get { return mStateSpecified; }
        set { mStateSpecified = value; }
        }

        private int mResultCode
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"ResultCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ResultCode
        {
        get { return mResultCode; }
        set { mResultCode = value; }
        }

        private bool mResultCodeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"ResultCodeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ResultCodeSpecified
        {
        get { return mResultCodeSpecified; }
        set { mResultCodeSpecified = value; }
        }

        private int mRxPlnAdjId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"RxPlnAdjId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxPlnAdjId
        {
        get { return mRxPlnAdjId; }
        set { mRxPlnAdjId = value; }
        }

        private bool mRxPlnAdjIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"RxPlnAdjIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxPlnAdjIdSpecified
        {
        get { return mRxPlnAdjIdSpecified; }
        set { mRxPlnAdjIdSpecified = value; }
        }

        private int mTransmissionMethod
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"TransmissionMethod", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int TransmissionMethod
        {
        get { return mTransmissionMethod; }
        set { mTransmissionMethod = value; }
        }

        private int mAdjHostId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"AdjHostId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AdjHostId
        {
        get { return mAdjHostId; }
        set { mAdjHostId = value; }
        }

        private bool mAdjHostIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"AdjHostIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AdjHostIdSpecified
        {
        get { return mAdjHostIdSpecified; }
        set { mAdjHostIdSpecified = value; }
        }

        private string mTransactionClass
            = "";
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"TransactionClass", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string TransactionClass
        {
        get { return mTransactionClass; }
        set { mTransactionClass = value; }
        }

        private string mSubPlanCode
            = "";
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"SubPlanCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SubPlanCode
        {
        get { return mSubPlanCode; }
        set { mSubPlanCode = value; }
        }

        private bool mWasSent
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"WasSent", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WasSent
        {
        get { return mWasSent; }
        set { mWasSent = value; }
        }

        private int mProcessingStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"ProcessingStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ProcessingStatus
        {
        get { return mProcessingStatus; }
        set { mProcessingStatus = value; }
        }

        private bool mProcessingStatusSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"ProcessingStatusSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ProcessingStatusSpecified
        {
        get { return mProcessingStatusSpecified; }
        set { mProcessingStatusSpecified = value; }
        }

        private int mProcessingErrorLevel
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"ProcessingErrorLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ProcessingErrorLevel
        {
        get { return mProcessingErrorLevel; }
        set { mProcessingErrorLevel = value; }
        }

        private bool mProcessingErrorLevelSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"ProcessingErrorLevelSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ProcessingErrorLevelSpecified
        {
        get { return mProcessingErrorLevelSpecified; }
        set { mProcessingErrorLevelSpecified = value; }
        }

        private string mProcessingMessage
            = "";
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"ProcessingMessage", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ProcessingMessage
        {
        get { return mProcessingMessage; }
        set { mProcessingMessage = value; }
        }

        private string mCeRxId
            = "";
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"CeRxId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CeRxId
        {
        get { return mCeRxId; }
        set { mCeRxId = value; }
        }

        private int mLocalId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"LocalId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int LocalId
        {
        get { return mLocalId; }
        set { mLocalId = value; }
        }

        private bool mLocalIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"LocalIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LocalIdSpecified
        {
        get { return mLocalIdSpecified; }
        set { mLocalIdSpecified = value; }
        }

        private int mAdjRouteId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"AdjRouteId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"AdjRouteIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private byte[] mKrollRequestData
            = null;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"KrollRequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] KrollRequestData
        {
        get { return mKrollRequestData; }
        set { mKrollRequestData = value; }
        }

        private byte[] mKrollResponseData
            = null;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"KrollResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] KrollResponseData
        {
        get { return mKrollResponseData; }
        set { mKrollResponseData = value; }
        }

        private int mOrigRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"OrigRxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OrigRxNum
        {
        get { return mOrigRxNum; }
        set { mOrigRxNum = value; }
        }

        private string mOrigUserInit
            = "";
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"OrigUserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OrigUserInit
        {
        get { return mOrigUserInit; }
        set { mOrigUserInit = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdjReadWriteLockType mReadWriteLockType
            = Kroll.Pharmacy.Api.Data.AdjReadWriteLockType.AdjReadWriteLockType_None;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"ReadWriteLockType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdjReadWriteLockType.AdjReadWriteLockType_None)]
        
        public Kroll.Pharmacy.Api.Data.AdjReadWriteLockType ReadWriteLockType
        {
        get { return mReadWriteLockType; }
        set { mReadWriteLockType = value; }
        }

        private string mReadWriteLockValue
            = "";
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"ReadWriteLockValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReadWriteLockValue
        {
        get { return mReadWriteLockValue; }
        set { mReadWriteLockValue = value; }
        }

        private int mRxWorkflowId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"RxWorkflowId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxWorkflowId
        {
        get { return mRxWorkflowId; }
        set { mRxWorkflowId = value; }
        }

        private bool mRxWorkflowIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"RxWorkflowIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxWorkflowIdSpecified
        {
        get { return mRxWorkflowIdSpecified; }
        set { mRxWorkflowIdSpecified = value; }
        }

        private int mUserTokenUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"UserTokenUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UserTokenUserId
        {
        get { return mUserTokenUserId; }
        set { mUserTokenUserId = value; }
        }

        private bool mUserTokenUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"UserTokenUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserTokenUserIdSpecified
        {
        get { return mUserTokenUserIdSpecified; }
        set { mUserTokenUserIdSpecified = value; }
        }

        private int mOrigUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"OrigUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OrigUserId
        {
        get { return mOrigUserId; }
        set { mOrigUserId = value; }
        }

        private bool mOrigUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"OrigUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OrigUserIdSpecified
        {
        get { return mOrigUserIdSpecified; }
        set { mOrigUserIdSpecified = value; }
        }

        private int mUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"UserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"UserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"AdjResponseDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"AdjResponseDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AdjResponseDateSpecified
        {
        get { return mAdjResponseDateSpecified; }
        set { mAdjResponseDateSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        