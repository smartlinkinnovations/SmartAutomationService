
        // Generated from: SearchDrgDepartmentMastRequest.proto
        // Note: requires additional types generated from: DrgDepartmentMastSearchCriteria.proto
        // Note: requires additional types generated from: DrgDepartmentMastSearchOptions.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDrgDepartmentMastRequest")]
        public partial class SearchDrgDepartmentMastRequest : global::ProtoBuf.IExtensible
        {
        public SearchDrgDepartmentMastRequest() {}
        

        private Kroll.Pharmacy.Api.SearchCriteria.DrgDepartmentMastSearchCriteria mSearchCriteria
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SearchCriteria", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.DrgDepartmentMastSearchCriteria SearchCriteria
        {
        get { return mSearchCriteria; }
        set { mSearchCriteria = value; }
        }

        private Kroll.Pharmacy.Api.SearchOptions.DrgDepartmentMastSearchOptions mSearchOptions
            = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SearchOptions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.SearchOptions.DrgDepartmentMastSearchOptions SearchOptions
        {
        get { return mSearchOptions; }
        set { mSearchOptions = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        