
        // Generated from: Config.proto
        // Note: requires additional types generated from: ConfigType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Config")]
        public partial class Config : global::ProtoBuf.IExtensible
        {
        public Config() {}
        

        private Kroll.Pharmacy.Api.Data.ConfigType mType
            = Kroll.Pharmacy.Api.Data.ConfigType.ConfigType_Unknown;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ConfigType.ConfigType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ConfigType Type
        {
        get { return mType; }
        set { mType = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private byte[] mData
            = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Data", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] Data
        {
        get { return mData; }
        set { mData = value; }
        }

        private string mDataString
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DataString", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DataString
        {
        get { return mDataString; }
        set { mDataString = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        