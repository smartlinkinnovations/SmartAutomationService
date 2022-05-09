
        // Generated from: PingRequest.proto
            namespace Kroll.Common.KxProto.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PingRequest")]
        public partial class PingRequest : global::ProtoBuf.IExtensible
        {
        public PingRequest() {}
        

        private string mValue
            = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Value", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Value
        {
        get { return mValue; }
        set { mValue = value; }
        }

        private byte[] mValueBytes
            = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ValueBytes", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ValueBytes
        {
        get { return mValueBytes; }
        set { mValueBytes = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        