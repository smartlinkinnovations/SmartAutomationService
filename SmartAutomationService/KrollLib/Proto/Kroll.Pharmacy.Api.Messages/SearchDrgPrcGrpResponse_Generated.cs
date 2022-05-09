
        // Generated from: SearchDrgPrcGrpResponse.proto
        // Note: requires additional types generated from: DrgPrcGrp.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDrgPrcGrpResponse")]
        public partial class SearchDrgPrcGrpResponse : global::ProtoBuf.IExtensible
        {
        public SearchDrgPrcGrpResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPrcGrp> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPrcGrp>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPrcGrp> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        