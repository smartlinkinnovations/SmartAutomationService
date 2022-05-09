
        // Generated from: MedicalConditionSearchCriteria.proto
        // Note: requires additional types generated from: MedicalConditionCodeType_Enum.proto
        // Note: requires additional types generated from: StringComparisonOperator_Enum.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MedicalConditionSearchCriteria")]
        public partial class MedicalConditionSearchCriteria : global::ProtoBuf.IExtensible
        {
        public MedicalConditionSearchCriteria() {}
        

        private Kroll.Pharmacy.Api.Data.MedicalConditionCodeType mCodeType
            = Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_FdbdxCode;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"CodeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_FdbdxCode)]
        
        public Kroll.Pharmacy.Api.Data.MedicalConditionCodeType CodeType
        {
        get { return mCodeType; }
        set { mCodeType = value; }
        }

        private bool mCodeTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"CodeTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CodeTypeSpecified
        {
        get { return mCodeTypeSpecified; }
        set { mCodeTypeSpecified = value; }
        }

        private string mCode
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Code", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Code
        {
        get { return mCode; }
        set { mCode = value; }
        }

        private bool mCodeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"CodeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CodeSpecified
        {
        get { return mCodeSpecified; }
        set { mCodeSpecified = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mDescriptionComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DescriptionComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator DescriptionComparisonOperator
        {
        get { return mDescriptionComparisonOperator; }
        set { mDescriptionComparisonOperator = value; }
        }

        private bool mIsScreened
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"IsScreened", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsScreened
        {
        get { return mIsScreened; }
        set { mIsScreened = value; }
        }

        private bool mIsScreenedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"IsScreenedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsScreenedSpecified
        {
        get { return mIsScreenedSpecified; }
        set { mIsScreenedSpecified = value; }
        }

        private string mLanguageCode
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"LanguageCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LanguageCode
        {
        get { return mLanguageCode; }
        set { mLanguageCode = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        