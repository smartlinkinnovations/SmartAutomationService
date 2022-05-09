
        // Generated from: KeyValuePair.proto
            namespace Kroll.Common.KxProto.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"KeyValuePair")]
        public partial class KeyValuePair : global::ProtoBuf.IExtensible
        {
        public KeyValuePair() {}
        
        private string mKey;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Key", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public string Key
        {
        get { return mKey; }
        set { mKey = value; }
        }

        private string mValue
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Value", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Value
        {
        get { return mValue; }
        set { mValue = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        