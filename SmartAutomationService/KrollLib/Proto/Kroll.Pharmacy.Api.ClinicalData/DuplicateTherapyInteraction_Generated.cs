
        // Generated from: DuplicateTherapyInteraction.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DuplicateTherapyInteraction")]
        public partial class DuplicateTherapyInteraction : global::ProtoBuf.IExtensible
        {
        public DuplicateTherapyInteraction() {}
        

        private string mInteractingDrugDin
            = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"InteractingDrugDin", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string InteractingDrugDin
        {
        get { return mInteractingDrugDin; }
        set { mInteractingDrugDin = value; }
        }

        private string mInteractingDrugAlternateDin
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"InteractingDrugAlternateDin", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string InteractingDrugAlternateDin
        {
        get { return mInteractingDrugAlternateDin; }
        set { mInteractingDrugAlternateDin = value; }
        }

        private byte[] mInteractingDrugContextInfo
            = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"InteractingDrugContextInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] InteractingDrugContextInfo
        {
        get { return mInteractingDrugContextInfo; }
        set { mInteractingDrugContextInfo = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private int mDuplicateAllowance
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DuplicateAllowance", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DuplicateAllowance
        {
        get { return mDuplicateAllowance; }
        set { mDuplicateAllowance = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        