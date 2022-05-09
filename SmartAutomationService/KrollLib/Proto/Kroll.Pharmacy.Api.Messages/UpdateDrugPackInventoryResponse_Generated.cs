
        // Generated from: UpdateDrugPackInventoryResponse.proto
        // Note: requires additional types generated from: UpdateDrugPackInventoryResponseData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateDrugPackInventoryResponse")]
        public partial class UpdateDrugPackInventoryResponse : global::ProtoBuf.IExtensible
        {
        public UpdateDrugPackInventoryResponse() {}
        

        private Kroll.Pharmacy.Api.ActionData.UpdateDrugPackInventoryResponseData mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.UpdateDrugPackInventoryResponseData ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        