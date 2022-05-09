
        // Generated from: DrugDiseaseContraindication.proto
        // Note: requires additional types generated from: MedicalConditionCodeType_Enum.proto
        // Note: requires additional types generated from: DrugDiseaseContraindicationSeverity_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrugDiseaseContraindication")]
        public partial class DrugDiseaseContraindication : global::ProtoBuf.IExtensible
        {
        public DrugDiseaseContraindication() {}
        

        private Kroll.Pharmacy.Api.Data.MedicalConditionCodeType mMedicalConditionCodeType
            = Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_Unknown;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"MedicalConditionCodeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.MedicalConditionCodeType MedicalConditionCodeType
        {
        get { return mMedicalConditionCodeType; }
        set { mMedicalConditionCodeType = value; }
        }

        private string mMedicalConditionCode
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"MedicalConditionCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MedicalConditionCode
        {
        get { return mMedicalConditionCode; }
        set { mMedicalConditionCode = value; }
        }

        private string mMedicalConditionDescription
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"MedicalConditionDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MedicalConditionDescription
        {
        get { return mMedicalConditionDescription; }
        set { mMedicalConditionDescription = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrugDiseaseContraindicationSeverity mSeverity
            = Kroll.Pharmacy.Api.Data.DrugDiseaseContraindicationSeverity.DrugDiseaseContraindicationSeverity_High;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Severity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrugDiseaseContraindicationSeverity.DrugDiseaseContraindicationSeverity_High)]
        
        public Kroll.Pharmacy.Api.Data.DrugDiseaseContraindicationSeverity Severity
        {
        get { return mSeverity; }
        set { mSeverity = value; }
        }

        private string mContraindicationReference
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ContraindicationReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ContraindicationReference
        {
        get { return mContraindicationReference; }
        set { mContraindicationReference = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        