
        // Generated from: SearchDeliveryOrderResponse.proto
        // Note: requires additional types generated from: DeliveryOrder.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDeliveryOrderResponse")]
        public partial class SearchDeliveryOrderResponse : global::ProtoBuf.IExtensible
        {
        public SearchDeliveryOrderResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DeliveryOrder> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DeliveryOrder>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DeliveryOrder> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        