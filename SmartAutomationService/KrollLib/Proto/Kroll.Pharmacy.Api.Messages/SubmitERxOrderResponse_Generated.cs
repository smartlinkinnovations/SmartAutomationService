
        // Generated from: SubmitERxOrderResponse.proto
        // Note: requires additional types generated from: SubmitERxOrderResponseData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SubmitERxOrderResponse")]
        public partial class SubmitERxOrderResponse : global::ProtoBuf.IExtensible
        {
        public SubmitERxOrderResponse() {}
        

        private Kroll.Pharmacy.Api.ActionData.SubmitERxOrderResponseData mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.SubmitERxOrderResponseData ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        