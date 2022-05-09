
        // Generated from: UpdateDeliveryOrderRequest.proto
        // Note: requires additional types generated from: UpdateDeliveryOrderRequestData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateDeliveryOrderRequest")]
        public partial class UpdateDeliveryOrderRequest : global::ProtoBuf.IExtensible
        {
        public UpdateDeliveryOrderRequest() {}
        

        private Kroll.Pharmacy.Api.ActionData.UpdateDeliveryOrderRequestData mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.UpdateDeliveryOrderRequestData RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        