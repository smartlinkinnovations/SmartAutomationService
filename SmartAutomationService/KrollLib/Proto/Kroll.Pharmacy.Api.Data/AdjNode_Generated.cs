
        // Generated from: AdjNode.proto
        // Note: requires additional types generated from: AdjNodeType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AdjNode")]
        public partial class AdjNode : global::ProtoBuf.IExtensible
        {
        public AdjNode() {}
        

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

        private string mStation
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Station", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Station
        {
        get { return mStation; }
        set { mStation = value; }
        }

        private bool mUseTAPI
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"UseTAPI", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseTAPI
        {
        get { return mUseTAPI; }
        set { mUseTAPI = value; }
        }

        private int mComPort
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ComPort", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ComPort
        {
        get { return mComPort; }
        set { mComPort = value; }
        }

        private string mModem
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Modem", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Modem
        {
        get { return mModem; }
        set { mModem = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdjNodeType mNodeType
            = Kroll.Pharmacy.Api.Data.AdjNodeType.AdjNodeType_NotSet;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"NodeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdjNodeType.AdjNodeType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.AdjNodeType NodeType
        {
        get { return mNodeType; }
        set { mNodeType = value; }
        }

        private string mPhonePrefix
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PhonePrefix", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PhonePrefix
        {
        get { return mPhonePrefix; }
        set { mPhonePrefix = value; }
        }

        private int mPriority
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"PrioritySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrioritySpecified
        {
        get { return mPrioritySpecified; }
        set { mPrioritySpecified = value; }
        }

        private bool mDataLog
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"DataLog", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DataLog
        {
        get { return mDataLog; }
        set { mDataLog = value; }
        }

        private bool mTimingLog
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"TimingLog", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TimingLog
        {
        get { return mTimingLog; }
        set { mTimingLog = value; }
        }

        private string mCertificateFileName
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"CertificateFileName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CertificateFileName
        {
        get { return mCertificateFileName; }
        set { mCertificateFileName = value; }
        }

        private int mAdjRouteId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"AdjRouteId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"AdjRouteIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"StoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StoreIdSpecified
        {
        get { return mStoreIdSpecified; }
        set { mStoreIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        