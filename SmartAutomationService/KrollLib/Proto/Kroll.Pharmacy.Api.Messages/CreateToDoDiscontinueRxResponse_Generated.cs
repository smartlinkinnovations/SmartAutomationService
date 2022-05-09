
        // Generated from: CreateToDoDiscontinueRxResponse.proto
        // Note: requires additional types generated from: CreateToDoDiscontinueRxResponseData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateToDoDiscontinueRxResponse")]
        public partial class CreateToDoDiscontinueRxResponse : global::ProtoBuf.IExtensible
        {
        public CreateToDoDiscontinueRxResponse() {}
        

        private Kroll.Pharmacy.Api.ActionData.CreateToDoDiscontinueRxResponseData mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.CreateToDoDiscontinueRxResponseData ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        