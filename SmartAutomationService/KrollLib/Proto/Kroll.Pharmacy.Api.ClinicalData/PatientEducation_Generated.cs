
        // Generated from: PatientEducation.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatientEducation")]
        public partial class PatientEducation : global::ProtoBuf.IExtensible
        {
        public PatientEducation() {}
        

        private string mTitle
            = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Title", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Title
        {
        get { return mTitle; }
        set { mTitle = value; }
        }

        private string mCommonBrandNames
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"CommonBrandNames", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CommonBrandNames
        {
        get { return mCommonBrandNames; }
        set { mCommonBrandNames = value; }
        }

        private string mPronunciation
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Pronunciation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Pronunciation
        {
        get { return mPronunciation; }
        set { mPronunciation = value; }
        }

        private string mDisclaimer
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Disclaimer", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Disclaimer
        {
        get { return mDisclaimer; }
        set { mDisclaimer = value; }
        }

        private string mWarning
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Warning", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Warning
        {
        get { return mWarning; }
        set { mWarning = value; }
        }

        private string mUses
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Uses", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Uses
        {
        get { return mUses; }
        set { mUses = value; }
        }

        private string mHowToUse
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"HowToUse", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string HowToUse
        {
        get { return mHowToUse; }
        set { mHowToUse = value; }
        }

        private string mSideEffects
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"SideEffects", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SideEffects
        {
        get { return mSideEffects; }
        set { mSideEffects = value; }
        }

        private string mPrecautions
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Precautions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Precautions
        {
        get { return mPrecautions; }
        set { mPrecautions = value; }
        }

        private string mDrugInteractions
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"DrugInteractions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrugInteractions
        {
        get { return mDrugInteractions; }
        set { mDrugInteractions = value; }
        }

        private string mOverdose
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Overdose", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Overdose
        {
        get { return mOverdose; }
        set { mOverdose = value; }
        }

        private string mNotes
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Notes", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Notes
        {
        get { return mNotes; }
        set { mNotes = value; }
        }

        private string mMissedDose
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"MissedDose", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MissedDose
        {
        get { return mMissedDose; }
        set { mMissedDose = value; }
        }

        private string mMedicalAlert
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"MedicalAlert", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MedicalAlert
        {
        get { return mMedicalAlert; }
        set { mMedicalAlert = value; }
        }

        private string mOtherUses
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"OtherUses", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OtherUses
        {
        get { return mOtherUses; }
        set { mOtherUses = value; }
        }

        private string mDocumentInformation
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"DocumentInformation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DocumentInformation
        {
        get { return mDocumentInformation; }
        set { mDocumentInformation = value; }
        }

        private string mCopyrightText
            = "";
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"CopyrightText", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CopyrightText
        {
        get { return mCopyrightText; }
        set { mCopyrightText = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        