
        // Generated from: DrugDiseaseContraindicationInteraction.proto
        // Note: requires additional types generated from: MedicalConditionCodeType_Enum.proto
        // Note: requires additional types generated from: DrugDiseaseContraindicationSeverity_Enum.proto
        // Note: requires additional types generated from: MedicalConditionRelationScope_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrugDiseaseContraindicationInteraction")]
        public partial class DrugDiseaseContraindicationInteraction : global::ProtoBuf.IExtensible
        {
        public DrugDiseaseContraindicationInteraction() {}
        

        private Kroll.Pharmacy.Api.Data.MedicalConditionCodeType mPatientMedicalConditionCodeType
            = Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_Unknown;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"PatientMedicalConditionCodeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.MedicalConditionCodeType PatientMedicalConditionCodeType
        {
        get { return mPatientMedicalConditionCodeType; }
        set { mPatientMedicalConditionCodeType = value; }
        }

        private string mPatientMedicalConditionCode
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PatientMedicalConditionCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PatientMedicalConditionCode
        {
        get { return mPatientMedicalConditionCode; }
        set { mPatientMedicalConditionCode = value; }
        }

        private string mPatientMedicalConditionDescription
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"PatientMedicalConditionDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PatientMedicalConditionDescription
        {
        get { return mPatientMedicalConditionDescription; }
        set { mPatientMedicalConditionDescription = value; }
        }

        private Kroll.Pharmacy.Api.Data.MedicalConditionCodeType mAnalyzedMedicalConditionCodeType
            = Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_Unknown;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"AnalyzedMedicalConditionCodeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.MedicalConditionCodeType AnalyzedMedicalConditionCodeType
        {
        get { return mAnalyzedMedicalConditionCodeType; }
        set { mAnalyzedMedicalConditionCodeType = value; }
        }

        private string mAnalyzedMedicalConditionCode
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"AnalyzedMedicalConditionCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AnalyzedMedicalConditionCode
        {
        get { return mAnalyzedMedicalConditionCode; }
        set { mAnalyzedMedicalConditionCode = value; }
        }

        private string mAnalyzedMedicalConditionDescription
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"AnalyzedMedicalConditionDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AnalyzedMedicalConditionDescription
        {
        get { return mAnalyzedMedicalConditionDescription; }
        set { mAnalyzedMedicalConditionDescription = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrugDiseaseContraindicationSeverity mSeverity
            = Kroll.Pharmacy.Api.Data.DrugDiseaseContraindicationSeverity.DrugDiseaseContraindicationSeverity_High;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Severity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrugDiseaseContraindicationSeverity.DrugDiseaseContraindicationSeverity_High)]
        
        public Kroll.Pharmacy.Api.Data.DrugDiseaseContraindicationSeverity Severity
        {
        get { return mSeverity; }
        set { mSeverity = value; }
        }

        private Kroll.Pharmacy.Api.Data.MedicalConditionRelationScope mScope
            = Kroll.Pharmacy.Api.Data.MedicalConditionRelationScope.MedicalConditionRelationScope_Equal;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Scope", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedicalConditionRelationScope.MedicalConditionRelationScope_Equal)]
        
        public Kroll.Pharmacy.Api.Data.MedicalConditionRelationScope Scope
        {
        get { return mScope; }
        set { mScope = value; }
        }

        private string mContraindicationReference
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"ContraindicationReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ContraindicationReference
        {
        get { return mContraindicationReference; }
        set { mContraindicationReference = value; }
        }

        private bool mIsRelatedMedicalCondition
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"IsRelatedMedicalCondition", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsRelatedMedicalCondition
        {
        get { return mIsRelatedMedicalCondition; }
        set { mIsRelatedMedicalCondition = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        