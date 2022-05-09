
        // Generated from: SearchRxProfileResponse.proto
        // Note: requires additional types generated from: Rx.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchRxProfileResponse")]
        public partial class SearchRxProfileResponse : global::ProtoBuf.IExtensible
        {
        public SearchRxProfileResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.Rx> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.Rx>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.Rx> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        