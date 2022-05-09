
        // Generated from: CreateWorkOrderRequestData.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateWorkOrderRequestData")]
        public partial class CreateWorkOrderRequestData : global::ProtoBuf.IExtensible
        {
        public CreateWorkOrderRequestData() {}
        

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private string mCreatedBy
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"CreatedBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CreatedBy
        {
        get { return mCreatedBy; }
        set { mCreatedBy = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        