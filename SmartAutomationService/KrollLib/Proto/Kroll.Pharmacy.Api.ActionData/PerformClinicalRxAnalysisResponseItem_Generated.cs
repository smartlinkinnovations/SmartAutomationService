
        // Generated from: PerformClinicalRxAnalysisResponseItem.proto
        // Note: requires additional types generated from: ClinicalAnalysisDrug.proto
        // Note: requires additional types generated from: ClinicalDrug.proto
        // Note: requires additional types generated from: DrugAllergyInteraction.proto
        // Note: requires additional types generated from: DrugDiseaseContraindicationInteraction.proto
        // Note: requires additional types generated from: DrugDrugInteraction.proto
        // Note: requires additional types generated from: DrugFoodInteraction.proto
        // Note: requires additional types generated from: DuplicateTherapyInteraction.proto
        // Note: requires additional types generated from: Indication.proto
        // Note: requires additional types generated from: PatientCounseling.proto
        // Note: requires additional types generated from: PatientEducation.proto
        // Note: requires additional types generated from: PriorityWarningLabel.proto
        // Note: requires additional types generated from: SideEffect.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PerformClinicalRxAnalysisResponseItem")]
        public partial class PerformClinicalRxAnalysisResponseItem : global::ProtoBuf.IExtensible
        {
        public PerformClinicalRxAnalysisResponseItem() {}
        

        private Kroll.Pharmacy.Api.Data.ClinicalAnalysisDrug mDrugAnalyzed
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DrugAnalyzed", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.ClinicalAnalysisDrug DrugAnalyzed
        {
        get { return mDrugAnalyzed; }
        set { mDrugAnalyzed = value; }
        }

        private bool mClinicalAnalysisPerformed
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ClinicalAnalysisPerformed", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ClinicalAnalysisPerformed
        {
        get { return mClinicalAnalysisPerformed; }
        set { mClinicalAnalysisPerformed = value; }
        }

        private Kroll.Pharmacy.Api.Data.ClinicalDrug mClinicalDrug
            = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ClinicalDrug", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.ClinicalDrug ClinicalDrug
        {
        get { return mClinicalDrug; }
        set { mClinicalDrug = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrugAllergyInteraction> mDrugAllergyInteractions = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrugAllergyInteraction>();
        [global::ProtoBuf.ProtoMember(4, Name=@"DrugAllergyInteractions", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrugAllergyInteraction> DrugAllergyInteractions
        {
        get { return mDrugAllergyInteractions; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrugDiseaseContraindicationInteraction> mDrugDiseaseContraindications = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrugDiseaseContraindicationInteraction>();
        [global::ProtoBuf.ProtoMember(5, Name=@"DrugDiseaseContraindications", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrugDiseaseContraindicationInteraction> DrugDiseaseContraindications
        {
        get { return mDrugDiseaseContraindications; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrugDrugInteraction> mDrugDrugInteractions = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrugDrugInteraction>();
        [global::ProtoBuf.ProtoMember(6, Name=@"DrugDrugInteractions", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrugDrugInteraction> DrugDrugInteractions
        {
        get { return mDrugDrugInteractions; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrugFoodInteraction> mDrugFoodInteractions = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrugFoodInteraction>();
        [global::ProtoBuf.ProtoMember(7, Name=@"DrugFoodInteractions", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrugFoodInteraction> DrugFoodInteractions
        {
        get { return mDrugFoodInteractions; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DuplicateTherapyInteraction> mDuplicateTherapyInteractions = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DuplicateTherapyInteraction>();
        [global::ProtoBuf.ProtoMember(8, Name=@"DuplicateTherapyInteractions", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DuplicateTherapyInteraction> DuplicateTherapyInteractions
        {
        get { return mDuplicateTherapyInteractions; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.Indication> mIndications = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.Indication>();
        [global::ProtoBuf.ProtoMember(9, Name=@"Indications", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.Indication> Indications
        {
        get { return mIndications; }
        }
    

        private Kroll.Pharmacy.Api.Data.PatientCounseling mPatientCounseling
            = null;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"PatientCounseling", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.PatientCounseling PatientCounseling
        {
        get { return mPatientCounseling; }
        set { mPatientCounseling = value; }
        }

        private Kroll.Pharmacy.Api.Data.PatientEducation mPatientEducation
            = null;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"PatientEducation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.PatientEducation PatientEducation
        {
        get { return mPatientEducation; }
        set { mPatientEducation = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PriorityWarningLabel> mPriorityWarningLabels = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PriorityWarningLabel>();
        [global::ProtoBuf.ProtoMember(12, Name=@"PriorityWarningLabels", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PriorityWarningLabel> PriorityWarningLabels
        {
        get { return mPriorityWarningLabels; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.SideEffect> mSideEffects = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.SideEffect>();
        [global::ProtoBuf.ProtoMember(13, Name=@"SideEffects", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.SideEffect> SideEffects
        {
        get { return mSideEffects; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        