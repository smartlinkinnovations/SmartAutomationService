
        // Generated from: SearchWorkOrderRequest.proto
        // Note: requires additional types generated from: WorkOrderSearchCriteria.proto
        // Note: requires additional types generated from: WorkOrderSearchOptions.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchWorkOrderRequest")]
        public partial class SearchWorkOrderRequest : global::ProtoBuf.IExtensible
        {
        public SearchWorkOrderRequest() {}
        

        private Kroll.Pharmacy.Api.SearchCriteria.WorkOrderSearchCriteria mSearchCriteria
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SearchCriteria", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.WorkOrderSearchCriteria SearchCriteria
        {
        get { return mSearchCriteria; }
        set { mSearchCriteria = value; }
        }

        private Kroll.Pharmacy.Api.SearchOptions.WorkOrderSearchOptions mSearchOptions
            = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SearchOptions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.SearchOptions.WorkOrderSearchOptions SearchOptions
        {
        get { return mSearchOptions; }
        set { mSearchOptions = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        