
        // Generated from: CreateRxTransferStoreRequestData.proto
        // Note: requires additional types generated from: RxTransferStore.proto
        // Note: requires additional types generated from: RxTransferStoreType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateRxTransferStoreRequestData")]
        public partial class CreateRxTransferStoreRequestData : global::ProtoBuf.IExtensible
        {
        public CreateRxTransferStoreRequestData() {}
        

        private string mStoreName
            = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"StoreName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string StoreName
        {
        get { return mStoreName; }
        set { mStoreName = value; }
        }

        private string mAddress
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Address", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address
        {
        get { return mAddress; }
        set { mAddress = value; }
        }

        private string mCity
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"City", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string City
        {
        get { return mCity; }
        set { mCity = value; }
        }

        private string mProv
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Prov", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Prov
        {
        get { return mProv; }
        set { mProv = value; }
        }

        private string mPostal
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Postal", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Postal
        {
        get { return mPostal; }
        set { mPostal = value; }
        }

        private string mPhone
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Phone
        {
        get { return mPhone; }
        set { mPhone = value; }
        }

        private string mFax
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Fax", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Fax
        {
        get { return mFax; }
        set { mFax = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private string mChain
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Chain", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Chain
        {
        get { return mChain; }
        set { mChain = value; }
        }

        private string mNetworkId
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"NetworkId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NetworkId
        {
        get { return mNetworkId; }
        set { mNetworkId = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxTransferStore mRxTransferStore
            = null;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"RxTransferStore", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.RxTransferStore RxTransferStore
        {
        get { return mRxTransferStore; }
        set { mRxTransferStore = value; }
        }

        private bool mRxTransferStoreSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"RxTransferStoreSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxTransferStoreSpecified
        {
        get { return mRxTransferStoreSpecified; }
        set { mRxTransferStoreSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxTransferStoreType mStoreType
            = Kroll.Pharmacy.Api.Data.RxTransferStoreType.RxTransferStoreType_Unknown;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"StoreType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxTransferStoreType.RxTransferStoreType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.RxTransferStoreType StoreType
        {
        get { return mStoreType; }
        set { mStoreType = value; }
        }

        private string mNetworkIdRoot
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"NetworkIdRoot", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NetworkIdRoot
        {
        get { return mNetworkIdRoot; }
        set { mNetworkIdRoot = value; }
        }

        private bool mPhoneLongDistance
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"PhoneLongDistance", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PhoneLongDistance
        {
        get { return mPhoneLongDistance; }
        set { mPhoneLongDistance = value; }
        }

        private bool mFaxLongDistance
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"FaxLongDistance", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FaxLongDistance
        {
        get { return mFaxLongDistance; }
        set { mFaxLongDistance = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        