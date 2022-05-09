
        // Generated from: SearchMedicalConditionResponse.proto
        // Note: requires additional types generated from: MedicalConditionPickListItem.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchMedicalConditionResponse")]
        public partial class SearchMedicalConditionResponse : global::ProtoBuf.IExtensible
        {
        public SearchMedicalConditionResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MedicalConditionPickListItem> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MedicalConditionPickListItem>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MedicalConditionPickListItem> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        