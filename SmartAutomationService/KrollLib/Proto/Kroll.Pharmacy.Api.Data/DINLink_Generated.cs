
        // Generated from: DINLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DINLink")]
        public partial class DINLink : global::ProtoBuf.IExtensible
        {
        public DINLink() {}
        

        private string mOldDIN
            = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"OldDIN", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OldDIN
        {
        get { return mOldDIN; }
        set { mOldDIN = value; }
        }

        private string mNewDIN
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"NewDIN", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NewDIN
        {
        get { return mNewDIN; }
        set { mNewDIN = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        