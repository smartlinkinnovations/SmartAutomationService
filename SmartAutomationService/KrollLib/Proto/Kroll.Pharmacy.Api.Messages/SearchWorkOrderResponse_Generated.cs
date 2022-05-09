
        // Generated from: SearchWorkOrderResponse.proto
        // Note: requires additional types generated from: WorkOrder.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchWorkOrderResponse")]
        public partial class SearchWorkOrderResponse : global::ProtoBuf.IExtensible
        {
        public SearchWorkOrderResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkOrder> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkOrder>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkOrder> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        