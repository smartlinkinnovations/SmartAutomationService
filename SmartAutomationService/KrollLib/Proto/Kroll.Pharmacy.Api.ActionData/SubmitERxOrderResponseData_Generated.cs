
        // Generated from: SubmitERxOrderResponseData.proto
        // Note: requires additional types generated from: SubmitERxOrderResponseType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SubmitERxOrderResponseData")]
        public partial class SubmitERxOrderResponseData : global::ProtoBuf.IExtensible
        {
        public SubmitERxOrderResponseData() {}
        

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

        private Kroll.Pharmacy.Api.ActionData.SubmitERxOrderResponseType mResponseType
            = Kroll.Pharmacy.Api.ActionData.SubmitERxOrderResponseType.SubmitERxOrderResponseType_Accepted;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ResponseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.SubmitERxOrderResponseType.SubmitERxOrderResponseType_Accepted)]
        
        public Kroll.Pharmacy.Api.ActionData.SubmitERxOrderResponseType ResponseType
        {
        get { return mResponseType; }
        set { mResponseType = value; }
        }

        private int mERxId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ERxId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ERxId
        {
        get { return mERxId; }
        set { mERxId = value; }
        }

        private bool mERxIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ERxIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ERxIdSpecified
        {
        get { return mERxIdSpecified; }
        set { mERxIdSpecified = value; }
        }

        private int mERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ERxOrderId
        {
        get { return mERxOrderId; }
        set { mERxOrderId = value; }
        }

        private bool mERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ERxOrderIdSpecified
        {
        get { return mERxOrderIdSpecified; }
        set { mERxOrderIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        