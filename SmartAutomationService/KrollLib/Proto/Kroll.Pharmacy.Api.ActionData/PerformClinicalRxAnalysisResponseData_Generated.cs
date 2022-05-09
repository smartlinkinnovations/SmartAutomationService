
        // Generated from: PerformClinicalRxAnalysisResponseData.proto
        // Note: requires additional types generated from: PerformClinicalRxAnalysisResponseItem.proto
        // Note: requires additional types generated from: PerformClinicalRxAnalysisResponseType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PerformClinicalRxAnalysisResponseData")]
        public partial class PerformClinicalRxAnalysisResponseData : global::ProtoBuf.IExtensible
        {
        public PerformClinicalRxAnalysisResponseData() {}
        

        private bool mIsSuccessful
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IsSuccessful", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsSuccessful
        {
        get { return mIsSuccessful; }
        set { mIsSuccessful = value; }
        }

        private Kroll.Pharmacy.Api.ActionData.PerformClinicalRxAnalysisResponseType mResponseType
            = Kroll.Pharmacy.Api.ActionData.PerformClinicalRxAnalysisResponseType.PerformClinicalRxAnalysisResponseType_Successful;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ResponseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.PerformClinicalRxAnalysisResponseType.PerformClinicalRxAnalysisResponseType_Successful)]
        
        public Kroll.Pharmacy.Api.ActionData.PerformClinicalRxAnalysisResponseType ResponseType
        {
        get { return mResponseType; }
        set { mResponseType = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.ActionData.PerformClinicalRxAnalysisResponseItem> mAnalysisResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.ActionData.PerformClinicalRxAnalysisResponseItem>();
        [global::ProtoBuf.ProtoMember(4, Name=@"AnalysisResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.ActionData.PerformClinicalRxAnalysisResponseItem> AnalysisResults
        {
        get { return mAnalysisResults; }
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

        private bool mClinicalDrugLookupDone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ClinicalDrugLookupDone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ClinicalDrugLookupDone
        {
        get { return mClinicalDrugLookupDone; }
        set { mClinicalDrugLookupDone = value; }
        }

        private bool mDosageRangeCheckingDone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"DosageRangeCheckingDone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DosageRangeCheckingDone
        {
        get { return mDosageRangeCheckingDone; }
        set { mDosageRangeCheckingDone = value; }
        }

        private bool mDrugAllergyCheckingDone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DrugAllergyCheckingDone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrugAllergyCheckingDone
        {
        get { return mDrugAllergyCheckingDone; }
        set { mDrugAllergyCheckingDone = value; }
        }

        private bool mDrugDiseaseContraindicationsDone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DrugDiseaseContraindicationsDone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrugDiseaseContraindicationsDone
        {
        get { return mDrugDiseaseContraindicationsDone; }
        set { mDrugDiseaseContraindicationsDone = value; }
        }

        private bool mDrugDrugInteractionsDone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"DrugDrugInteractionsDone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrugDrugInteractionsDone
        {
        get { return mDrugDrugInteractionsDone; }
        set { mDrugDrugInteractionsDone = value; }
        }

        private bool mDrugFoodInteractionsDone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DrugFoodInteractionsDone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrugFoodInteractionsDone
        {
        get { return mDrugFoodInteractionsDone; }
        set { mDrugFoodInteractionsDone = value; }
        }

        private bool mDuplicateTherapyDone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DuplicateTherapyDone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DuplicateTherapyDone
        {
        get { return mDuplicateTherapyDone; }
        set { mDuplicateTherapyDone = value; }
        }

        private bool mIndicationsDone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"IndicationsDone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IndicationsDone
        {
        get { return mIndicationsDone; }
        set { mIndicationsDone = value; }
        }

        private bool mMinMaxDosageCheckingDone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"MinMaxDosageCheckingDone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MinMaxDosageCheckingDone
        {
        get { return mMinMaxDosageCheckingDone; }
        set { mMinMaxDosageCheckingDone = value; }
        }

        private bool mPatientCounselingDone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"PatientCounselingDone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatientCounselingDone
        {
        get { return mPatientCounselingDone; }
        set { mPatientCounselingDone = value; }
        }

        private bool mPatientEducationDone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"PatientEducationDone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatientEducationDone
        {
        get { return mPatientEducationDone; }
        set { mPatientEducationDone = value; }
        }

        private bool mPrecautionsDone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"PrecautionsDone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrecautionsDone
        {
        get { return mPrecautionsDone; }
        set { mPrecautionsDone = value; }
        }

        private bool mPriorityWarningLabelsDone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"PriorityWarningLabelsDone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PriorityWarningLabelsDone
        {
        get { return mPriorityWarningLabelsDone; }
        set { mPriorityWarningLabelsDone = value; }
        }

        private bool mSideEffectsDone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"SideEffectsDone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SideEffectsDone
        {
        get { return mSideEffectsDone; }
        set { mSideEffectsDone = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        