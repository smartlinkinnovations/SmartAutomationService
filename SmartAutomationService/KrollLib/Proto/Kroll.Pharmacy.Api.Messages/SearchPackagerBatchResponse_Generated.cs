
        // Generated from: SearchPackagerBatchResponse.proto
        // Note: requires additional types generated from: PackagerBatch.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchPackagerBatchResponse")]
        public partial class SearchPackagerBatchResponse : global::ProtoBuf.IExtensible
        {
        public SearchPackagerBatchResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PackagerBatch> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PackagerBatch>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PackagerBatch> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        