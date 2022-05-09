
        // Generated from: SearchDrgMessageMastResponse.proto
        // Note: requires additional types generated from: DrgMessageMast.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDrgMessageMastResponse")]
        public partial class SearchDrgMessageMastResponse : global::ProtoBuf.IExtensible
        {
        public SearchDrgMessageMastResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMessageMast> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMessageMast>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMessageMast> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        