
        // Generated from: UpdateDeliveryOrderResponse.proto
        // Note: requires additional types generated from: UpdateDeliveryOrderResponseData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateDeliveryOrderResponse")]
        public partial class UpdateDeliveryOrderResponse : global::ProtoBuf.IExtensible
        {
        public UpdateDeliveryOrderResponse() {}
        

        private Kroll.Pharmacy.Api.ActionData.UpdateDeliveryOrderResponseData mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.UpdateDeliveryOrderResponseData ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        