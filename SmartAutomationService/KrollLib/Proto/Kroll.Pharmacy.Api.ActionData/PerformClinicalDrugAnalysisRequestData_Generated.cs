
        // Generated from: PerformClinicalDrugAnalysisRequestData.proto
        // Note: requires additional types generated from: ClinicalAnalysisDrug.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PerformClinicalDrugAnalysisRequestData")]
        public partial class PerformClinicalDrugAnalysisRequestData : global::ProtoBuf.IExtensible
        {
        public PerformClinicalDrugAnalysisRequestData() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ClinicalAnalysisDrug> mDrugsToAnalyze = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ClinicalAnalysisDrug>();
        [global::ProtoBuf.ProtoMember(1, Name=@"DrugsToAnalyze", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ClinicalAnalysisDrug> DrugsToAnalyze
        {
        get { return mDrugsToAnalyze; }
        }
    

        private byte[] mContextInfo
            = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ContextInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DoClinicalDrugLookup", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DoDosageRangeChecking", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DoDrugAllergyChecking", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"DoDrugDiseaseContraindications", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DoDrugDrugInteractions", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DoDrugFoodInteractions", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"DoDuplicateTherapy", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DoIndications", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DoMinMaxDosageChecking", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DoPatientCounseling", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DoPatientEducation", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"DoPrecautions", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"DoPriorityWarningLabels", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"DoSideEffects", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"Locale", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                @"en"
            )]
        
        public string Locale
        {
        get { return mLocale; }
        set { mLocale = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        