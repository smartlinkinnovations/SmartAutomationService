
        // Generated from: SearchPatGrpMastResponse.proto
        // Note: requires additional types generated from: PatGrpMast.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchPatGrpMastResponse")]
        public partial class SearchPatGrpMastResponse : global::ProtoBuf.IExtensible
        {
        public SearchPatGrpMastResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatGrpMast> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatGrpMast>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatGrpMast> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        