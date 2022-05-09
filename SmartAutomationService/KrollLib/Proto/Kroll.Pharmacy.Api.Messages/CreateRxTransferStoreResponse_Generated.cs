
        // Generated from: CreateRxTransferStoreResponse.proto
        // Note: requires additional types generated from: CreateRxTransferStoreResponseData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateRxTransferStoreResponse")]
        public partial class CreateRxTransferStoreResponse : global::ProtoBuf.IExtensible
        {
        public CreateRxTransferStoreResponse() {}
        

        private Kroll.Pharmacy.Api.ActionData.CreateRxTransferStoreResponseData mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.CreateRxTransferStoreResponseData ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        