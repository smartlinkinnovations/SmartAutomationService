
        // Generated from: DecompressDataResponseData.proto
        // Note: requires additional types generated from: DecompressDataResponseType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DecompressDataResponseData")]
        public partial class DecompressDataResponseData : global::ProtoBuf.IExtensible
        {
        public DecompressDataResponseData() {}
        

        private bool mIsSuccessful
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IsSuccessful", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsSuccessful
        {
        get { return mIsSuccessful; }
        set { mIsSuccessful = value; }
        }

        private Kroll.Pharmacy.Api.ActionData.DecompressDataResponseType mResponseType
            = Kroll.Pharmacy.Api.ActionData.DecompressDataResponseType.DecompressDataResponseType_Successful;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ResponseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.DecompressDataResponseType.DecompressDataResponseType_Successful)]
        
        public Kroll.Pharmacy.Api.ActionData.DecompressDataResponseType ResponseType
        {
        get { return mResponseType; }
        set { mResponseType = value; }
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
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        