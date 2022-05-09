
        // Generated from: RxTransferStore.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
        // Note: requires additional types generated from: RxTransferStoreType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxTransferStore")]
        public partial class RxTransferStore : global::ProtoBuf.IExtensible
        {
        public RxTransferStore() {}
        

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

        private string mStoreName
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"StoreName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string StoreName
        {
        get { return mStoreName; }
        set { mStoreName = value; }
        }

        private string mAddress
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Address", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address
        {
        get { return mAddress; }
        set { mAddress = value; }
        }

        private string mCity
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"City", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string City
        {
        get { return mCity; }
        set { mCity = value; }
        }

        private string mProv
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Prov", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Prov
        {
        get { return mProv; }
        set { mProv = value; }
        }

        private string mPostal
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Postal", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Postal
        {
        get { return mPostal; }
        set { mPostal = value; }
        }

        private string mPhone
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Phone
        {
        get { return mPhone; }
        set { mPhone = value; }
        }

        private string mFax
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Fax", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Fax
        {
        get { return mFax; }
        set { mFax = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"StoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StoreIdSpecified
        {
        get { return mStoreIdSpecified; }
        set { mStoreIdSpecified = value; }
        }

        private int mPreferredSortOrder
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"PreferredSortOrder", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PreferredSortOrder
        {
        get { return mPreferredSortOrder; }
        set { mPreferredSortOrder = value; }
        }

        private bool mPreferredSortOrderSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"PreferredSortOrderSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PreferredSortOrderSpecified
        {
        get { return mPreferredSortOrderSpecified; }
        set { mPreferredSortOrderSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink CentralMaintLink
        {
        get { return mCentralMaintLink; }
        set { mCentralMaintLink = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"Chain", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Chain
        {
        get { return mChain; }
        set { mChain = value; }
        }

        private string mNetworkId
            = "";
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"NetworkId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NetworkId
        {
        get { return mNetworkId; }
        set { mNetworkId = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxTransferStoreType mStoreType
            = Kroll.Pharmacy.Api.Data.RxTransferStoreType.RxTransferStoreType_Unknown;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"StoreType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxTransferStoreType.RxTransferStoreType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.RxTransferStoreType StoreType
        {
        get { return mStoreType; }
        set { mStoreType = value; }
        }

        private string mNetworkIdRoot
            = "";
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"NetworkIdRoot", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"PhoneLongDistance", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"FaxLongDistance", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        