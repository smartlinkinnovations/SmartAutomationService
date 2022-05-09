
        // Generated from: SearchDrgDepartmentMastResponse.proto
        // Note: requires additional types generated from: DrgDepartmentMast.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDrgDepartmentMastResponse")]
        public partial class SearchDrgDepartmentMastResponse : global::ProtoBuf.IExtensible
        {
        public SearchDrgDepartmentMastResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgDepartmentMast> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgDepartmentMast>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgDepartmentMast> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        