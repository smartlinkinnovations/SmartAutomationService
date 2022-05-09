
        // Generated from: SearchWorkflowQueueResponse.proto
        // Note: requires additional types generated from: WorkflowQueue.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchWorkflowQueueResponse")]
        public partial class SearchWorkflowQueueResponse : global::ProtoBuf.IExtensible
        {
        public SearchWorkflowQueueResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkflowQueue> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkflowQueue>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkflowQueue> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        