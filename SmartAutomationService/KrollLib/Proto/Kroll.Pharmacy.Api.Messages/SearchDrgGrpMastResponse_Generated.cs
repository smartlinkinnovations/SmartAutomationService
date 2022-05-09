
        // Generated from: SearchDrgGrpMastResponse.proto
        // Note: requires additional types generated from: DrgGrpMast.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDrgGrpMastResponse")]
        public partial class SearchDrgGrpMastResponse : global::ProtoBuf.IExtensible
        {
        public SearchDrgGrpMastResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgGrpMast> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgGrpMast>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgGrpMast> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        