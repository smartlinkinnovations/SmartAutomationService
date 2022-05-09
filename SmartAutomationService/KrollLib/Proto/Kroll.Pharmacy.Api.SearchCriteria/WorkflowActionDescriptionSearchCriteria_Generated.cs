
        // Generated from: WorkflowActionDescriptionSearchCriteria.proto
        // Note: requires additional types generated from: StringComparisonOperator_Enum.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorkflowActionDescriptionSearchCriteria")]
        public partial class WorkflowActionDescriptionSearchCriteria : global::ProtoBuf.IExtensible
        {
        public WorkflowActionDescriptionSearchCriteria() {}
        

        private int mWorkflowActionType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"WorkflowActionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int WorkflowActionType
        {
        get { return mWorkflowActionType; }
        set { mWorkflowActionType = value; }
        }

        private bool mWorkflowActionTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"WorkflowActionTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WorkflowActionTypeSpecified
        {
        get { return mWorkflowActionTypeSpecified; }
        set { mWorkflowActionTypeSpecified = value; }
        }

        private string mLanguage
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Language", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Language
        {
        get { return mLanguage; }
        set { mLanguage = value; }
        }

        private bool mLanguageSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"LanguageSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LanguageSpecified
        {
        get { return mLanguageSpecified; }
        set { mLanguageSpecified = value; }
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
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        