
        // Generated from: SearchDrgMixResponse.proto
        // Note: requires additional types generated from: DrgMix.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDrgMixResponse")]
        public partial class SearchDrgMixResponse : global::ProtoBuf.IExtensible
        {
        public SearchDrgMixResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMix> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMix>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMix> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        