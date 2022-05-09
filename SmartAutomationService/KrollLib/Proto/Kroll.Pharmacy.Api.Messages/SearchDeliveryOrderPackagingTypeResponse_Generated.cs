
        // Generated from: SearchDeliveryOrderPackagingTypeResponse.proto
        // Note: requires additional types generated from: DeliveryOrderPackagingType.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDeliveryOrderPackagingTypeResponse")]
        public partial class SearchDeliveryOrderPackagingTypeResponse : global::ProtoBuf.IExtensible
        {
        public SearchDeliveryOrderPackagingTypeResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DeliveryOrderPackagingType> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DeliveryOrderPackagingType>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DeliveryOrderPackagingType> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        