
        // Generated from: SearchPatPrcGrpRequest.proto
        // Note: requires additional types generated from: PatPrcGrpSearchCriteria.proto
        // Note: requires additional types generated from: PatPrcGrpSearchOptions.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchPatPrcGrpRequest")]
        public partial class SearchPatPrcGrpRequest : global::ProtoBuf.IExtensible
        {
        public SearchPatPrcGrpRequest() {}
        

        private Kroll.Pharmacy.Api.SearchCriteria.PatPrcGrpSearchCriteria mSearchCriteria
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SearchCriteria", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.PatPrcGrpSearchCriteria SearchCriteria
        {
        get { return mSearchCriteria; }
        set { mSearchCriteria = value; }
        }

        private Kroll.Pharmacy.Api.SearchOptions.PatPrcGrpSearchOptions mSearchOptions
            = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SearchOptions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.SearchOptions.PatPrcGrpSearchOptions SearchOptions
        {
        get { return mSearchOptions; }
        set { mSearchOptions = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        