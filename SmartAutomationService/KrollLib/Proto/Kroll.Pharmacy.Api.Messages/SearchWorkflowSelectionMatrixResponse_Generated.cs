
        // Generated from: SearchWorkflowSelectionMatrixResponse.proto
        // Note: requires additional types generated from: WorkflowSelectionMatrix.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchWorkflowSelectionMatrixResponse")]
        public partial class SearchWorkflowSelectionMatrixResponse : global::ProtoBuf.IExtensible
        {
        public SearchWorkflowSelectionMatrixResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrix> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrix>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrix> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        