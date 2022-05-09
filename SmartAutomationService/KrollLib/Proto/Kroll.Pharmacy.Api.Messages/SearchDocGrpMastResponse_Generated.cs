
        // Generated from: SearchDocGrpMastResponse.proto
        // Note: requires additional types generated from: DocGrpMast.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDocGrpMastResponse")]
        public partial class SearchDocGrpMastResponse : global::ProtoBuf.IExtensible
        {
        public SearchDocGrpMastResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocGrpMast> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocGrpMast>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocGrpMast> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        