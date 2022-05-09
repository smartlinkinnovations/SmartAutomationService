
        // Generated from: SearchPatPrcGrpResponse.proto
        // Note: requires additional types generated from: PatPrcGrp.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchPatPrcGrpResponse")]
        public partial class SearchPatPrcGrpResponse : global::ProtoBuf.IExtensible
        {
        public SearchPatPrcGrpResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatPrcGrp> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatPrcGrp>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatPrcGrp> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        