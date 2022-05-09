
        // Generated from: LanguageSpokenMastSearchCriteria.proto
        // Note: requires additional types generated from: StringComparisonOperator_Enum.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LanguageSpokenMastSearchCriteria")]
        public partial class LanguageSpokenMastSearchCriteria : global::ProtoBuf.IExtensible
        {
        public LanguageSpokenMastSearchCriteria() {}
        

        private string mLanguageCode
            = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"LanguageCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LanguageCode
        {
        get { return mLanguageCode; }
        set { mLanguageCode = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mDescriptionComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DescriptionComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator DescriptionComparisonOperator
        {
        get { return mDescriptionComparisonOperator; }
        set { mDescriptionComparisonOperator = value; }
        }

        private string mMacroLanguageCode
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"MacroLanguageCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MacroLanguageCode
        {
        get { return mMacroLanguageCode; }
        set { mMacroLanguageCode = value; }
        }

        private string mMacroLanguageDescription
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"MacroLanguageDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MacroLanguageDescription
        {
        get { return mMacroLanguageDescription; }
        set { mMacroLanguageDescription = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mMacroLanguageDescriptionComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"MacroLanguageDescriptionComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator MacroLanguageDescriptionComparisonOperator
        {
        get { return mMacroLanguageDescriptionComparisonOperator; }
        set { mMacroLanguageDescriptionComparisonOperator = value; }
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
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        