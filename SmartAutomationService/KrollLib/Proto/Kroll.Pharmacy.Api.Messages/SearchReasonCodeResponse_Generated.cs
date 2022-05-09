
        // Generated from: SearchReasonCodeResponse.proto
        // Note: requires additional types generated from: ReasonCode.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchReasonCodeResponse")]
        public partial class SearchReasonCodeResponse : global::ProtoBuf.IExtensible
        {
        public SearchReasonCodeResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ReasonCode> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ReasonCode>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ReasonCode> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        