
        // Generated from: UpdateDeliveryOrderResponseData.proto
        // Note: requires additional types generated from: UpdateDeliveryOrderResponseType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateDeliveryOrderResponseData")]
        public partial class UpdateDeliveryOrderResponseData : global::ProtoBuf.IExtensible
        {
        public UpdateDeliveryOrderResponseData() {}
        

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

        private Kroll.Pharmacy.Api.ActionData.UpdateDeliveryOrderResponseType mResponseType
            = Kroll.Pharmacy.Api.ActionData.UpdateDeliveryOrderResponseType.UpdateDeliveryOrderResponseType_Accepted;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ResponseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.UpdateDeliveryOrderResponseType.UpdateDeliveryOrderResponseType_Accepted)]
        
        public Kroll.Pharmacy.Api.ActionData.UpdateDeliveryOrderResponseType ResponseType
        {
        get { return mResponseType; }
        set { mResponseType = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        