
        // Generated from: SearchDeliveryOrder8Response.proto
        // Note: requires additional types generated from: DeliveryOrder8.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchDeliveryOrder8Response")]
        public partial class SearchDeliveryOrder8Response : global::ProtoBuf.IExtensible
        {
        public SearchDeliveryOrder8Response() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DeliveryOrder8> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DeliveryOrder8>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DeliveryOrder8> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        