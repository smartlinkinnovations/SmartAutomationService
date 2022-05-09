
        // Generated from: VendorSearchCriteria.proto
        // Note: requires additional types generated from: StringComparisonOperator_Enum.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
        // Note: requires additional types generated from: UniqueVendorId_Enum.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"VendorSearchCriteria")]
        public partial class VendorSearchCriteria : global::ProtoBuf.IExtensible
        {
        public VendorSearchCriteria() {}
        

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

        private bool mIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IdSpecified
        {
        get { return mIdSpecified; }
        set { mIdSpecified = value; }
        }

        private string mDescShort
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DescShort", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DescShort
        {
        get { return mDescShort; }
        set { mDescShort = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mDescShortComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DescShortComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator DescShortComparisonOperator
        {
        get { return mDescShortComparisonOperator; }
        set { mDescShortComparisonOperator = value; }
        }

        private string mDescLong
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DescLong", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DescLong
        {
        get { return mDescLong; }
        set { mDescLong = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mDescLongComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DescLongComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator DescLongComparisonOperator
        {
        get { return mDescLongComparisonOperator; }
        set { mDescLongComparisonOperator = value; }
        }

        private Kroll.Pharmacy.Api.Data.UniqueVendorId mUniqueVendorId
            = Kroll.Pharmacy.Api.Data.UniqueVendorId.UniqueVendorId_None;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"UniqueVendorId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UniqueVendorId.UniqueVendorId_None)]
        
        public Kroll.Pharmacy.Api.Data.UniqueVendorId UniqueVendorId
        {
        get { return mUniqueVendorId; }
        set { mUniqueVendorId = value; }
        }

        private bool mUniqueVendorIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"UniqueVendorIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UniqueVendorIdSpecified
        {
        get { return mUniqueVendorIdSpecified; }
        set { mUniqueVendorIdSpecified = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private bool mActiveSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ActiveSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ActiveSpecified
        {
        get { return mActiveSpecified; }
        set { mActiveSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink CentralMaintLink
        {
        get { return mCentralMaintLink; }
        set { mCentralMaintLink = value; }
        }

        private bool mCentralMaintLinkSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"CentralMaintLinkSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CentralMaintLinkSpecified
        {
        get { return mCentralMaintLinkSpecified; }
        set { mCentralMaintLinkSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        