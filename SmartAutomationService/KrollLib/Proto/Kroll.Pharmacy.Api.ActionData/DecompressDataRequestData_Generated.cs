
        // Generated from: DecompressDataRequestData.proto
        // Note: requires additional types generated from: CompressionType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DecompressDataRequestData")]
        public partial class DecompressDataRequestData : global::ProtoBuf.IExtensible
        {
        public DecompressDataRequestData() {}
        

        private byte[] mData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Data", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] Data
        {
        get { return mData; }
        set { mData = value; }
        }

        private Kroll.Pharmacy.Api.Data.CompressionType mCompressionType
            = Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"CompressionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.CompressionType CompressionType
        {
        get { return mCompressionType; }
        set { mCompressionType = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        