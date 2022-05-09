
        // Generated from: NHSearchCriteria.proto
        // Note: requires additional types generated from: NHType_Enum.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NHSearchCriteria")]
        public partial class NHSearchCriteria : global::ProtoBuf.IExtensible
        {
        public NHSearchCriteria() {}
        

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

        private string mShortFormCode
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ShortFormCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShortFormCode
        {
        get { return mShortFormCode; }
        set { mShortFormCode = value; }
        }

        private bool mShortFormCodeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ShortFormCodeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ShortFormCodeSpecified
        {
        get { return mShortFormCodeSpecified; }
        set { mShortFormCodeSpecified = value; }
        }

        private string mFacilityId
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"FacilityId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FacilityId
        {
        get { return mFacilityId; }
        set { mFacilityId = value; }
        }

        private bool mFacilityIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"FacilityIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FacilityIdSpecified
        {
        get { return mFacilityIdSpecified; }
        set { mFacilityIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHType mNHType
            = Kroll.Pharmacy.Api.Data.NHType.NHType_Unknown;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"NHType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHType.NHType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.NHType NHType
        {
        get { return mNHType; }
        set { mNHType = value; }
        }

        private bool mNHTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"NHTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHTypeSpecified
        {
        get { return mNHTypeSpecified; }
        set { mNHTypeSpecified = value; }
        }

        private string mCorporateId
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"CorporateId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CorporateId
        {
        get { return mCorporateId; }
        set { mCorporateId = value; }
        }

        private bool mCorporateIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"CorporateIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CorporateIdSpecified
        {
        get { return mCorporateIdSpecified; }
        set { mCorporateIdSpecified = value; }
        }

        private int mPackagerId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"PackagerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PackagerId
        {
        get { return mPackagerId; }
        set { mPackagerId = value; }
        }

        private bool mPackagerIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"PackagerIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PackagerIdSpecified
        {
        get { return mPackagerIdSpecified; }
        set { mPackagerIdSpecified = value; }
        }

        private int mUnitDosePatPrcGrpId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"UnitDosePatPrcGrpId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UnitDosePatPrcGrpId
        {
        get { return mUnitDosePatPrcGrpId; }
        set { mUnitDosePatPrcGrpId = value; }
        }

        private bool mUnitDosePatPrcGrpIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"UnitDosePatPrcGrpIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UnitDosePatPrcGrpIdSpecified
        {
        get { return mUnitDosePatPrcGrpIdSpecified; }
        set { mUnitDosePatPrcGrpIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        