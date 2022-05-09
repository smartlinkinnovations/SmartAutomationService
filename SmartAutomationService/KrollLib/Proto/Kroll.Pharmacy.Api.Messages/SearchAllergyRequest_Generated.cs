
        // Generated from: SearchAllergyRequest.proto
        // Note: requires additional types generated from: AllergySearchCriteria.proto
        // Note: requires additional types generated from: AllergySearchOptions.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchAllergyRequest")]
        public partial class SearchAllergyRequest : global::ProtoBuf.IExtensible
        {
        public SearchAllergyRequest() {}
        

        private Kroll.Pharmacy.Api.SearchCriteria.AllergySearchCriteria mSearchCriteria
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SearchCriteria", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.AllergySearchCriteria SearchCriteria
        {
        get { return mSearchCriteria; }
        set { mSearchCriteria = value; }
        }

        private Kroll.Pharmacy.Api.SearchOptions.AllergySearchOptions mSearchOptions
            = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SearchOptions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.SearchOptions.AllergySearchOptions SearchOptions
        {
        get { return mSearchOptions; }
        set { mSearchOptions = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        