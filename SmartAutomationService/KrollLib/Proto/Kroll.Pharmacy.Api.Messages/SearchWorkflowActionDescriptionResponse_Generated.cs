
        // Generated from: SearchWorkflowActionDescriptionResponse.proto
        // Note: requires additional types generated from: WorkflowActionDescription.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchWorkflowActionDescriptionResponse")]
        public partial class SearchWorkflowActionDescriptionResponse : global::ProtoBuf.IExtensible
        {
        public SearchWorkflowActionDescriptionResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkflowActionDescription> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkflowActionDescription>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkflowActionDescription> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        