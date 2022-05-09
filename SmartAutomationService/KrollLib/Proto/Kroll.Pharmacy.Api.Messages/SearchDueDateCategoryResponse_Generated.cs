
        // Generated from: SearchDueDateCategoryResponse.proto
        // Note: requires additional types generated from: DueDateCategory.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDueDateCategoryResponse")]
        public partial class SearchDueDateCategoryResponse : global::ProtoBuf.IExtensible
        {
        public SearchDueDateCategoryResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DueDateCategory> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DueDateCategory>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DueDateCategory> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        