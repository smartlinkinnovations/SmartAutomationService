
        // Generated from: SearchDocumentContentResponse.proto
        // Note: requires additional types generated from: DocumentContent.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDocumentContentResponse")]
        public partial class SearchDocumentContentResponse : global::ProtoBuf.IExtensible
        {
        public SearchDocumentContentResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocumentContent> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocumentContent>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocumentContent> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        