
        // Generated from: DrugFoodInteractionMonograph.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrugFoodInteractionMonograph")]
        public partial class DrugFoodInteractionMonograph : global::ProtoBuf.IExtensible
        {
        public DrugFoodInteractionMonograph() {}
        

        private string mMonographTitle
            = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"MonographTitle", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MonographTitle
        {
        get { return mMonographTitle; }
        set { mMonographTitle = value; }
        }

        private string mMechanismOfAction
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"MechanismOfAction", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MechanismOfAction
        {
        get { return mMechanismOfAction; }
        set { mMechanismOfAction = value; }
        }

        private string mDiscussion
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Discussion", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Discussion
        {
        get { return mDiscussion; }
        set { mDiscussion = value; }
        }

        private string mClinicalEffects
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ClinicalEffects", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ClinicalEffects
        {
        get { return mClinicalEffects; }
        set { mClinicalEffects = value; }
        }

        private string mSignificanceLevel
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"SignificanceLevel", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SignificanceLevel
        {
        get { return mSignificanceLevel; }
        set { mSignificanceLevel = value; }
        }

        private string mPatientManagement
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PatientManagement", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PatientManagement
        {
        get { return mPatientManagement; }
        set { mPatientManagement = value; }
        }

        private string mReference
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Reference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Reference
        {
        get { return mReference; }
        set { mReference = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        