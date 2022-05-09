
        // Generated from: SearchRxTransferStoreResponse.proto
        // Note: requires additional types generated from: RxTransferStore.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchRxTransferStoreResponse")]
        public partial class SearchRxTransferStoreResponse : global::ProtoBuf.IExtensible
        {
        public SearchRxTransferStoreResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxTransferStore> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxTransferStore>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxTransferStore> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        