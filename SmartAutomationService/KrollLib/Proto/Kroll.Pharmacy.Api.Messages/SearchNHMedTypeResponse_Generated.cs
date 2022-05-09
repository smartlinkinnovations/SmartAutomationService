
        // Generated from: SearchNHMedTypeResponse.proto
        // Note: requires additional types generated from: NHMedType.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchNHMedTypeResponse")]
        public partial class SearchNHMedTypeResponse : global::ProtoBuf.IExtensible
        {
        public SearchNHMedTypeResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHMedType> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHMedType>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHMedType> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        