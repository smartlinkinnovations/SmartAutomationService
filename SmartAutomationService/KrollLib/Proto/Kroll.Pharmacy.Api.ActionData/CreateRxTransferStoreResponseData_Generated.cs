
        // Generated from: CreateRxTransferStoreResponseData.proto
        // Note: requires additional types generated from: CreateRxTransferStoreResponseType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateRxTransferStoreResponseData")]
        public partial class CreateRxTransferStoreResponseData : global::ProtoBuf.IExtensible
        {
        public CreateRxTransferStoreResponseData() {}
        

        private bool mIsAccepted
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IsAccepted", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsAccepted
        {
        get { return mIsAccepted; }
        set { mIsAccepted = value; }
        }

        private Kroll.Pharmacy.Api.ActionData.CreateRxTransferStoreResponseType mResponseType
            = Kroll.Pharmacy.Api.ActionData.CreateRxTransferStoreResponseType.CreateRxTransferStoreResponseType_Accepted;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ResponseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.CreateRxTransferStoreResponseType.CreateRxTransferStoreResponseType_Accepted)]
        
        public Kroll.Pharmacy.Api.ActionData.CreateRxTransferStoreResponseType ResponseType
        {
        get { return mResponseType; }
        set { mResponseType = value; }
        }

        private int mRxTransferStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"RxTransferStoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxTransferStoreId
        {
        get { return mRxTransferStoreId; }
        set { mRxTransferStoreId = value; }
        }

        private bool mRxTransferStoreIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"RxTransferStoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxTransferStoreIdSpecified
        {
        get { return mRxTransferStoreIdSpecified; }
        set { mRxTransferStoreIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        