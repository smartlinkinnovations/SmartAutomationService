
        // Generated from: SearchPrcStratResponse.proto
        // Note: requires additional types generated from: PrcStrat.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchPrcStratResponse")]
        public partial class SearchPrcStratResponse : global::ProtoBuf.IExtensible
        {
        public SearchPrcStratResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PrcStrat> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PrcStrat>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PrcStrat> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        