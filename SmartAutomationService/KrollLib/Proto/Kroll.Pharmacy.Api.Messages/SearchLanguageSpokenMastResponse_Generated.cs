
        // Generated from: SearchLanguageSpokenMastResponse.proto
        // Note: requires additional types generated from: LanguageSpokenMast.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchLanguageSpokenMastResponse")]
        public partial class SearchLanguageSpokenMastResponse : global::ProtoBuf.IExtensible
        {
        public SearchLanguageSpokenMastResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.LanguageSpokenMast> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.LanguageSpokenMast>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.LanguageSpokenMast> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        