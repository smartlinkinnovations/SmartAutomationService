
        // Generated from: SearchDeliveryOrderPackagingTypeRequest.proto
        // Note: requires additional types generated from: DeliveryOrderPackagingTypeSearchCriteria.proto
        // Note: requires additional types generated from: DeliveryOrderPackagingTypeSearchOptions.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDeliveryOrderPackagingTypeRequest")]
        public partial class SearchDeliveryOrderPackagingTypeRequest : global::ProtoBuf.IExtensible
        {
        public SearchDeliveryOrderPackagingTypeRequest() {}
        

        private Kroll.Pharmacy.Api.SearchCriteria.DeliveryOrderPackagingTypeSearchCriteria mSearchCriteria
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SearchCriteria", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.DeliveryOrderPackagingTypeSearchCriteria SearchCriteria
        {
        get { return mSearchCriteria; }
        set { mSearchCriteria = value; }
        }

        private Kroll.Pharmacy.Api.SearchOptions.DeliveryOrderPackagingTypeSearchOptions mSearchOptions
            = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SearchOptions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.SearchOptions.DeliveryOrderPackagingTypeSearchOptions SearchOptions
        {
        get { return mSearchOptions; }
        set { mSearchOptions = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        