
        // Generated from: SearchWorkflowActionDescriptionRequest.proto
        // Note: requires additional types generated from: WorkflowActionDescriptionSearchCriteria.proto
        // Note: requires additional types generated from: WorkflowActionDescriptionSearchOptions.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchWorkflowActionDescriptionRequest")]
        public partial class SearchWorkflowActionDescriptionRequest : global::ProtoBuf.IExtensible
        {
        public SearchWorkflowActionDescriptionRequest() {}
        

        private Kroll.Pharmacy.Api.SearchCriteria.WorkflowActionDescriptionSearchCriteria mSearchCriteria
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SearchCriteria", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.WorkflowActionDescriptionSearchCriteria SearchCriteria
        {
        get { return mSearchCriteria; }
        set { mSearchCriteria = value; }
        }

        private Kroll.Pharmacy.Api.SearchOptions.WorkflowActionDescriptionSearchOptions mSearchOptions
            = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SearchOptions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.SearchOptions.WorkflowActionDescriptionSearchOptions SearchOptions
        {
        get { return mSearchOptions; }
        set { mSearchOptions = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        