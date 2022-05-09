
        // Generated from: UpdateDrugPackInventoryRequest.proto
        // Note: requires additional types generated from: UpdateDrugPackInventoryRequestData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateDrugPackInventoryRequest")]
        public partial class UpdateDrugPackInventoryRequest : global::ProtoBuf.IExtensible
        {
        public UpdateDrugPackInventoryRequest() {}
        

        private Kroll.Pharmacy.Api.ActionData.UpdateDrugPackInventoryRequestData mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.UpdateDrugPackInventoryRequestData RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        