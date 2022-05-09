
        // Generated from: SubmitERxOrderRequest.proto
        // Note: requires additional types generated from: SubmitERxOrderRequestData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SubmitERxOrderRequest")]
        public partial class SubmitERxOrderRequest : global::ProtoBuf.IExtensible
        {
        public SubmitERxOrderRequest() {}
        

        private Kroll.Pharmacy.Api.ActionData.SubmitERxOrderRequestData mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.SubmitERxOrderRequestData RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        