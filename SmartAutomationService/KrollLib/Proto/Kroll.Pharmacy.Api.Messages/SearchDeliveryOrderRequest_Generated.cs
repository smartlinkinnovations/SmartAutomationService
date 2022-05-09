
        // Generated from: SearchDeliveryOrderRequest.proto
        // Note: requires additional types generated from: DeliveryOrderSearchCriteria.proto
        // Note: requires additional types generated from: DeliveryOrderSearchOptions.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDeliveryOrderRequest")]
        public partial class SearchDeliveryOrderRequest : global::ProtoBuf.IExtensible
        {
        public SearchDeliveryOrderRequest() {}
        

        private Kroll.Pharmacy.Api.SearchCriteria.DeliveryOrderSearchCriteria mSearchCriteria
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SearchCriteria", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.DeliveryOrderSearchCriteria SearchCriteria
        {
        get { return mSearchCriteria; }
        set { mSearchCriteria = value; }
        }

        private Kroll.Pharmacy.Api.SearchOptions.DeliveryOrderSearchOptions mSearchOptions
            = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SearchOptions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.SearchOptions.DeliveryOrderSearchOptions SearchOptions
        {
        get { return mSearchOptions; }
        set { mSearchOptions = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        