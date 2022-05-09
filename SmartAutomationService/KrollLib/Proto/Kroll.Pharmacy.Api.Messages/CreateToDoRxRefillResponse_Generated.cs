
        // Generated from: CreateToDoRxRefillResponse.proto
        // Note: requires additional types generated from: CreateToDoRxRefillResponseData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateToDoRxRefillResponse")]
        public partial class CreateToDoRxRefillResponse : global::ProtoBuf.IExtensible
        {
        public CreateToDoRxRefillResponse() {}
        

        private Kroll.Pharmacy.Api.ActionData.CreateToDoRxRefillResponseData mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.CreateToDoRxRefillResponseData ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        