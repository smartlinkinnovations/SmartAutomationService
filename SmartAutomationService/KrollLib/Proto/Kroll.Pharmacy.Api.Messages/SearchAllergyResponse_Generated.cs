
        // Generated from: SearchAllergyResponse.proto
        // Note: requires additional types generated from: AllergyPickListItem.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchAllergyResponse")]
        public partial class SearchAllergyResponse : global::ProtoBuf.IExtensible
        {
        public SearchAllergyResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AllergyPickListItem> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AllergyPickListItem>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AllergyPickListItem> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        