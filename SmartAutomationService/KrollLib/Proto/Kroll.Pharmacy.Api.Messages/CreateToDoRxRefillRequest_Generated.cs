
        // Generated from: CreateToDoRxRefillRequest.proto
        // Note: requires additional types generated from: CreateToDoRxRefillRequestData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateToDoRxRefillRequest")]
        public partial class CreateToDoRxRefillRequest : global::ProtoBuf.IExtensible
        {
        public CreateToDoRxRefillRequest() {}
        

        private Kroll.Pharmacy.Api.ActionData.CreateToDoRxRefillRequestData mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.CreateToDoRxRefillRequestData RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        