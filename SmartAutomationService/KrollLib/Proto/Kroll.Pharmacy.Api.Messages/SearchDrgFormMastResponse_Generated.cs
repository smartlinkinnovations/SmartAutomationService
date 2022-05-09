
        // Generated from: SearchDrgFormMastResponse.proto
        // Note: requires additional types generated from: DrgFormMast.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDrgFormMastResponse")]
        public partial class SearchDrgFormMastResponse : global::ProtoBuf.IExtensible
        {
        public SearchDrgFormMastResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgFormMast> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgFormMast>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgFormMast> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        