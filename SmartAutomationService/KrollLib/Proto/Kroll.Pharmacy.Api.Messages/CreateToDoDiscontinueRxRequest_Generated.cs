
        // Generated from: CreateToDoDiscontinueRxRequest.proto
        // Note: requires additional types generated from: CreateToDoDiscontinueRxRequestData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateToDoDiscontinueRxRequest")]
        public partial class CreateToDoDiscontinueRxRequest : global::ProtoBuf.IExtensible
        {
        public CreateToDoDiscontinueRxRequest() {}
        

        private Kroll.Pharmacy.Api.ActionData.CreateToDoDiscontinueRxRequestData mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.CreateToDoDiscontinueRxRequestData RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        