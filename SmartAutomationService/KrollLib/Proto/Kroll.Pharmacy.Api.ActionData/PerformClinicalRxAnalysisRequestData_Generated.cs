
        // Generated from: PerformClinicalRxAnalysisRequestData.proto
        // Note: requires additional types generated from: ClinicalAnalysisDrug.proto
        // Note: requires additional types generated from: Allergy.proto
        // Note: requires additional types generated from: MedicalCondition.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PerformClinicalRxAnalysisRequestData")]
        public partial class PerformClinicalRxAnalysisRequestData : global::ProtoBuf.IExtensible
        {
        public PerformClinicalRxAnalysisRequestData() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ClinicalAnalysisDrug> mDrugsToAnalyze = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ClinicalAnalysisDrug>();
        [global::ProtoBuf.ProtoMember(1, Name=@"DrugsToAnalyze", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ClinicalAnalysisDrug> DrugsToAnalyze
        {
        get { return mDrugsToAnalyze; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ClinicalAnalysisDrug> mDrugsToAnalyzeAgainst = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ClinicalAnalysisDrug>();
        [global::ProtoBuf.ProtoMember(2, Name=@"DrugsToAnalyzeAgainst", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ClinicalAnalysisDrug> DrugsToAnalyzeAgainst
        {
        get { return mDrugsToAnalyzeAgainst; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.Allergy> mPatientAllergies = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.Allergy>();
        [global::ProtoBuf.ProtoMember(3, Name=@"PatientAllergies", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.Allergy> PatientAllergies
        {
        get { return mPatientAllergies; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MedicalCondition> mPatientMedicalConditions = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MedicalCondition>();
        [global::ProtoBuf.ProtoMember(4, Name=@"PatientMedicalConditions", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MedicalCondition> PatientMedicalConditions
        {
        get { return mPatientMedicalConditions; }
        }
    

        private byte[] mContextInfo
            = null;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ContextInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ContextInfo
        {
        get { return mContextInfo; }
        set { mContextInfo = value; }
        }

        private bool mDoClinicalDrugLookup
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DoClinicalDrugLookup", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoClinicalDrugLookup
        {
        get { return mDoClinicalDrugLookup; }
        set { mDoClinicalDrugLookup = value; }
        }

        private bool mDoDosageRangeChecking
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"DoDosageRangeChecking", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoDosageRangeChecking
        {
        get { return mDoDosageRangeChecking; }
        set { mDoDosageRangeChecking = value; }
        }

        private bool mDoDrugAllergyChecking
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DoDrugAllergyChecking", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoDrugAllergyChecking
        {
        get { return mDoDrugAllergyChecking; }
        set { mDoDrugAllergyChecking = value; }
        }

        private bool mDoDrugDiseaseContraindications
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DoDrugDiseaseContraindications", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoDrugDiseaseContraindications
        {
        get { return mDoDrugDiseaseContraindications; }
        set { mDoDrugDiseaseContraindications = value; }
        }

        private bool mDoDrugDrugInteractions
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"DoDrugDrugInteractions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoDrugDrugInteractions
        {
        get { return mDoDrugDrugInteractions; }
        set { mDoDrugDrugInteractions = value; }
        }

        private bool mDoDrugFoodInteractions
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DoDrugFoodInteractions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoDrugFoodInteractions
        {
        get { return mDoDrugFoodInteractions; }
        set { mDoDrugFoodInteractions = value; }
        }

        private bool mDoDuplicateTherapy
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DoDuplicateTherapy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoDuplicateTherapy
        {
        get { return mDoDuplicateTherapy; }
        set { mDoDuplicateTherapy = value; }
        }

        private bool mDoIndications
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DoIndications", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoIndications
        {
        get { return mDoIndications; }
        set { mDoIndications = value; }
        }

        private bool mDoMinMaxDosageChecking
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DoMinMaxDosageChecking", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoMinMaxDosageChecking
        {
        get { return mDoMinMaxDosageChecking; }
        set { mDoMinMaxDosageChecking = value; }
        }

        private bool mDoPatientCounseling
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"DoPatientCounseling", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoPatientCounseling
        {
        get { return mDoPatientCounseling; }
        set { mDoPatientCounseling = value; }
        }

        private bool mDoPatientEducation
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"DoPatientEducation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoPatientEducation
        {
        get { return mDoPatientEducation; }
        set { mDoPatientEducation = value; }
        }

        private bool mDoPrecautions
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"DoPrecautions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoPrecautions
        {
        get { return mDoPrecautions; }
        set { mDoPrecautions = value; }
        }

        private bool mDoPriorityWarningLabels
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DoPriorityWarningLabels", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoPriorityWarningLabels
        {
        get { return mDoPriorityWarningLabels; }
        set { mDoPriorityWarningLabels = value; }
        }

        private bool mDoSideEffects
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DoSideEffects", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoSideEffects
        {
        get { return mDoSideEffects; }
        set { mDoSideEffects = value; }
        }

        private string mLocale
            = 
                @"en"
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"Locale", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                @"en"
            )]
        
        public string Locale
        {
        get { return mLocale; }
        set { mLocale = value; }
        }

        private bool mLookupPatientAllergiesAndConditions
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"LookupPatientAllergiesAndConditions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LookupPatientAllergiesAndConditions
        {
        get { return mLookupPatientAllergiesAndConditions; }
        set { mLookupPatientAllergiesAndConditions = value; }
        }

        private bool mLookupRxDrugsToAnalyze
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"LookupRxDrugsToAnalyze", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LookupRxDrugsToAnalyze
        {
        get { return mLookupRxDrugsToAnalyze; }
        set { mLookupRxDrugsToAnalyze = value; }
        }

        private bool mLookupProfileDrugsToAnalyzeAgainst
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"LookupProfileDrugsToAnalyzeAgainst", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LookupProfileDrugsToAnalyzeAgainst
        {
        get { return mLookupProfileDrugsToAnalyzeAgainst; }
        set { mLookupProfileDrugsToAnalyzeAgainst = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private bool mRxNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxNumSpecified
        {
        get { return mRxNumSpecified; }
        set { mRxNumSpecified = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private bool mPatIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatIdSpecified
        {
        get { return mPatIdSpecified; }
        set { mPatIdSpecified = value; }
        }

        private int mDontCheckInteractionsOlderThanDays
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"DontCheckInteractionsOlderThanDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DontCheckInteractionsOlderThanDays
        {
        get { return mDontCheckInteractionsOlderThanDays; }
        set { mDontCheckInteractionsOlderThanDays = value; }
        }

        private bool mDontCheckInteractionsOlderThanDaysSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"DontCheckInteractionsOlderThanDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DontCheckInteractionsOlderThanDaysSpecified
        {
        get { return mDontCheckInteractionsOlderThanDaysSpecified; }
        set { mDontCheckInteractionsOlderThanDaysSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        