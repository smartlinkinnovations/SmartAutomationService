
        // Generated from: UpdateDrugPackInventoryResponseData.proto
        // Note: requires additional types generated from: UpdateDrugPackInventoryResponseType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateDrugPackInventoryResponseData")]
        public partial class UpdateDrugPackInventoryResponseData : global::ProtoBuf.IExtensible
        {
        public UpdateDrugPackInventoryResponseData() {}
        

        private Kroll.Pharmacy.Api.ActionData.UpdateDrugPackInventoryResponseType mResponseType
            = Kroll.Pharmacy.Api.ActionData.UpdateDrugPackInventoryResponseType.UpdateDrugPackInventoryResponseType_Accepted;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ResponseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.UpdateDrugPackInventoryResponseType.UpdateDrugPackInventoryResponseType_Accepted)]
        
        public Kroll.Pharmacy.Api.ActionData.UpdateDrugPackInventoryResponseType ResponseType
        {
        get { return mResponseType; }
        set { mResponseType = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        