
        // Generated from: NetworkTransactionLog.proto
        // Note: requires additional types generated from: ParserType_Enum.proto
        // Note: requires additional types generated from: CompressionType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NetworkTransactionLog")]
        public partial class NetworkTransactionLog : global::ProtoBuf.IExtensible
        {
        public NetworkTransactionLog() {}
        

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

        private int mLogType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"LogType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int LogType
        {
        get { return mLogType; }
        set { mLogType = value; }
        }

        private int mTransactionType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"TransactionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int TransactionType
        {
        get { return mTransactionType; }
        set { mTransactionType = value; }
        }

        private double mLogDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"LogDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LogDate
        {
        get { return mLogDate; }
        set { mLogDate = value; }
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

        private Kroll.Pharmacy.Api.Data.ParserType mParserType
            = Kroll.Pharmacy.Api.Data.ParserType.ParserType_LegacyParser;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ParserType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ParserType.ParserType_LegacyParser)]
        
        public Kroll.Pharmacy.Api.Data.ParserType ParserType
        {
        get { return mParserType; }
        set { mParserType = value; }
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

        private byte[] mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }

        private Kroll.Pharmacy.Api.Data.CompressionType mRequestCompressionType
            = Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"RequestCompressionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.CompressionType RequestCompressionType
        {
        get { return mRequestCompressionType; }
        set { mRequestCompressionType = value; }
        }

        private Kroll.Pharmacy.Api.Data.CompressionType mResponseCompressionType
            = Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"ResponseCompressionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.CompressionType ResponseCompressionType
        {
        get { return mResponseCompressionType; }
        set { mResponseCompressionType = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private int mRxWorkflowId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"RxWorkflowId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"RxWorkflowIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxWorkflowIdSpecified
        {
        get { return mRxWorkflowIdSpecified; }
        set { mRxWorkflowIdSpecified = value; }
        }

        private int mOrigUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"OrigUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"OrigUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"UserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"UserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"AdjResponseDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"AdjResponseDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        