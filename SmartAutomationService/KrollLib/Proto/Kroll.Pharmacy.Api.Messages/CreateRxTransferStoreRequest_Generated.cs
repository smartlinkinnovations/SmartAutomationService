
        // Generated from: CreateRxTransferStoreRequest.proto
        // Note: requires additional types generated from: CreateRxTransferStoreRequestData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateRxTransferStoreRequest")]
        public partial class CreateRxTransferStoreRequest : global::ProtoBuf.IExtensible
        {
        public CreateRxTransferStoreRequest() {}
        

        private Kroll.Pharmacy.Api.ActionData.CreateRxTransferStoreRequestData mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.CreateRxTransferStoreRequestData RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        