
        // Generated from: PatMedReview.proto
        // Note: requires additional types generated from: MedReviewSchemaType_Enum.proto
        // Note: requires additional types generated from: MedReviewAction_Enum.proto
        // Note: requires additional types generated from: MedReviewCounselingMethod_Enum.proto
        // Note: requires additional types generated from: MedReviewRejectReason_Enum.proto
        // Note: requires additional types generated from: MedReviewCounselingAgentType_Enum.proto
        // Note: requires additional types generated from: Sex_Enum.proto
        // Note: requires additional types generated from: PatRelationshipType_Enum.proto
        // Note: requires additional types generated from: MedReviewFeeAction_Enum.proto
        // Note: requires additional types generated from: MedReviewShouldPrintPatLetter_Enum.Proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatMedReview")]
        public partial class PatMedReview : global::ProtoBuf.IExtensible
        {
        public PatMedReview() {}
        

        private int mId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Id
        {
        get { return mId; }
        set { mId = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private Kroll.Pharmacy.Api.Data.MedReviewSchemaType mMedReviewSchemaType
            = Kroll.Pharmacy.Api.Data.MedReviewSchemaType.MedReviewSchemaType_Unknown;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"MedReviewSchemaType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedReviewSchemaType.MedReviewSchemaType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.MedReviewSchemaType MedReviewSchemaType
        {
        get { return mMedReviewSchemaType; }
        set { mMedReviewSchemaType = value; }
        }

        private int mMedReviewId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"MedReviewId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MedReviewId
        {
        get { return mMedReviewId; }
        set { mMedReviewId = value; }
        }

        private bool mMedReviewIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"MedReviewIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MedReviewIdSpecified
        {
        get { return mMedReviewIdSpecified; }
        set { mMedReviewIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.MedReviewAction mMedReviewAction
            = Kroll.Pharmacy.Api.Data.MedReviewAction.MedReviewAction_Unknown;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"MedReviewAction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedReviewAction.MedReviewAction_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.MedReviewAction MedReviewAction
        {
        get { return mMedReviewAction; }
        set { mMedReviewAction = value; }
        }

        private double mDontPromptUntilDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DontPromptUntilDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DontPromptUntilDate
        {
        get { return mDontPromptUntilDate; }
        set { mDontPromptUntilDate = value; }
        }

        private bool mDontPromptUntilDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DontPromptUntilDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DontPromptUntilDateSpecified
        {
        get { return mDontPromptUntilDateSpecified; }
        set { mDontPromptUntilDateSpecified = value; }
        }

        private bool mIsCompleted
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"IsCompleted", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsCompleted
        {
        get { return mIsCompleted; }
        set { mIsCompleted = value; }
        }

        private double mDateStarted
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DateStarted", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateStarted
        {
        get { return mDateStarted; }
        set { mDateStarted = value; }
        }

        private string mStartedByUserInit
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"StartedByUserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string StartedByUserInit
        {
        get { return mStartedByUserInit; }
        set { mStartedByUserInit = value; }
        }

        private int mStartedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"StartedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StartedByUserId
        {
        get { return mStartedByUserId; }
        set { mStartedByUserId = value; }
        }

        private bool mStartedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"StartedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StartedByUserIdSpecified
        {
        get { return mStartedByUserIdSpecified; }
        set { mStartedByUserIdSpecified = value; }
        }

        private double mDateCompleted
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"DateCompleted", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateCompleted
        {
        get { return mDateCompleted; }
        set { mDateCompleted = value; }
        }

        private bool mDateCompletedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"DateCompletedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateCompletedSpecified
        {
        get { return mDateCompletedSpecified; }
        set { mDateCompletedSpecified = value; }
        }

        private string mCompletedByUserInit
            = "";
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"CompletedByUserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CompletedByUserInit
        {
        get { return mCompletedByUserInit; }
        set { mCompletedByUserInit = value; }
        }

        private int mCompletedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"CompletedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CompletedByUserId
        {
        get { return mCompletedByUserId; }
        set { mCompletedByUserId = value; }
        }

        private bool mCompletedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"CompletedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CompletedByUserIdSpecified
        {
        get { return mCompletedByUserIdSpecified; }
        set { mCompletedByUserIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.MedReviewCounselingMethod mCounselingMethod
            = Kroll.Pharmacy.Api.Data.MedReviewCounselingMethod.MedReviewCounselingMethod_Unknown;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"CounselingMethod", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedReviewCounselingMethod.MedReviewCounselingMethod_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.MedReviewCounselingMethod CounselingMethod
        {
        get { return mCounselingMethod; }
        set { mCounselingMethod = value; }
        }

        private Kroll.Pharmacy.Api.Data.MedReviewRejectReason mRejectedReason
            = Kroll.Pharmacy.Api.Data.MedReviewRejectReason.MedReviewRejectReason_Unknown;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"RejectedReason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedReviewRejectReason.MedReviewRejectReason_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.MedReviewRejectReason RejectedReason
        {
        get { return mRejectedReason; }
        set { mRejectedReason = value; }
        }

        private string mRejectedComment
            = "";
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"RejectedComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RejectedComment
        {
        get { return mRejectedComment; }
        set { mRejectedComment = value; }
        }

        private Kroll.Pharmacy.Api.Data.MedReviewCounselingAgentType mAgentType
            = Kroll.Pharmacy.Api.Data.MedReviewCounselingAgentType.MedReviewCounselingAgentType_Unknown;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"AgentType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedReviewCounselingAgentType.MedReviewCounselingAgentType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.MedReviewCounselingAgentType AgentType
        {
        get { return mAgentType; }
        set { mAgentType = value; }
        }

        private int mAgentPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"AgentPatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AgentPatId
        {
        get { return mAgentPatId; }
        set { mAgentPatId = value; }
        }

        private bool mAgentPatIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"AgentPatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AgentPatIdSpecified
        {
        get { return mAgentPatIdSpecified; }
        set { mAgentPatIdSpecified = value; }
        }

        private string mAgentLastName
            = "";
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"AgentLastName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AgentLastName
        {
        get { return mAgentLastName; }
        set { mAgentLastName = value; }
        }

        private string mAgentFirstName
            = "";
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"AgentFirstName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AgentFirstName
        {
        get { return mAgentFirstName; }
        set { mAgentFirstName = value; }
        }

        private Kroll.Pharmacy.Api.Data.Sex mAgentSex
            = Kroll.Pharmacy.Api.Data.Sex.Sex_Unknown;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"AgentSex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.Sex.Sex_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.Sex AgentSex
        {
        get { return mAgentSex; }
        set { mAgentSex = value; }
        }

        private Kroll.Pharmacy.Api.Data.PatRelationshipType mAgentRelationshipType
            = Kroll.Pharmacy.Api.Data.PatRelationshipType.PatRelationshipType_Unknown;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"AgentRelationshipType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatRelationshipType.PatRelationshipType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PatRelationshipType AgentRelationshipType
        {
        get { return mAgentRelationshipType; }
        set { mAgentRelationshipType = value; }
        }

        private int mFeeToDoId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"FeeToDoId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int FeeToDoId
        {
        get { return mFeeToDoId; }
        set { mFeeToDoId = value; }
        }

        private bool mFeeToDoIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"FeeToDoIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FeeToDoIdSpecified
        {
        get { return mFeeToDoIdSpecified; }
        set { mFeeToDoIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.MedReviewFeeAction mFeeAction
            = Kroll.Pharmacy.Api.Data.MedReviewFeeAction.MedReviewFeeAction_Unknown;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"FeeAction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedReviewFeeAction.MedReviewFeeAction_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.MedReviewFeeAction FeeAction
        {
        get { return mFeeAction; }
        set { mFeeAction = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxNumSpecified
        {
        get { return mRxNumSpecified; }
        set { mRxNumSpecified = value; }
        }

        private int mDocId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DocId
        {
        get { return mDocId; }
        set { mDocId = value; }
        }

        private bool mDocIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"DocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocIdSpecified
        {
        get { return mDocIdSpecified; }
        set { mDocIdSpecified = value; }
        }

        private int mElectronicSignatureId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"ElectronicSignatureId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ElectronicSignatureId
        {
        get { return mElectronicSignatureId; }
        set { mElectronicSignatureId = value; }
        }

        private bool mElectronicSignatureIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"ElectronicSignatureIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ElectronicSignatureIdSpecified
        {
        get { return mElectronicSignatureIdSpecified; }
        set { mElectronicSignatureIdSpecified = value; }
        }

        private int mPatElectronicSignatureId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"PatElectronicSignatureId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatElectronicSignatureId
        {
        get { return mPatElectronicSignatureId; }
        set { mPatElectronicSignatureId = value; }
        }

        private bool mPatElectronicSignatureIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"PatElectronicSignatureIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatElectronicSignatureIdSpecified
        {
        get { return mPatElectronicSignatureIdSpecified; }
        set { mPatElectronicSignatureIdSpecified = value; }
        }

        private int mLegacyInterventionId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"LegacyInterventionId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int LegacyInterventionId
        {
        get { return mLegacyInterventionId; }
        set { mLegacyInterventionId = value; }
        }

        private bool mLegacyInterventionIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"LegacyInterventionIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LegacyInterventionIdSpecified
        {
        get { return mLegacyInterventionIdSpecified; }
        set { mLegacyInterventionIdSpecified = value; }
        }

        private int mPatDocumentId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"PatDocumentId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatDocumentId
        {
        get { return mPatDocumentId; }
        set { mPatDocumentId = value; }
        }

        private bool mPatDocumentIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"PatDocumentIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatDocumentIdSpecified
        {
        get { return mPatDocumentIdSpecified; }
        set { mPatDocumentIdSpecified = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateCreated
        {
        get { return mDateCreated; }
        set { mDateCreated = value; }
        }

        private bool mDateCreatedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateCreatedSpecified
        {
        get { return mDateCreatedSpecified; }
        set { mDateCreatedSpecified = value; }
        }

        private double mDateChanged
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateChanged
        {
        get { return mDateChanged; }
        set { mDateChanged = value; }
        }

        private bool mDateChangedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.MedReviewShouldPrintPatLetter mShouldPrintPatLetter
            = Kroll.Pharmacy.Api.Data.MedReviewShouldPrintPatLetter.MedReviewShouldPrintPatLetter_Unknown;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"ShouldPrintPatLetter", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedReviewShouldPrintPatLetter.MedReviewShouldPrintPatLetter_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.MedReviewShouldPrintPatLetter ShouldPrintPatLetter
        {
        get { return mShouldPrintPatLetter; }
        set { mShouldPrintPatLetter = value; }
        }

        private bool mPrintedPatLetter
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"PrintedPatLetter", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintedPatLetter
        {
        get { return mPrintedPatLetter; }
        set { mPrintedPatLetter = value; }
        }

        private bool mHasPharmacistRxs
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"HasPharmacistRxs", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HasPharmacistRxs
        {
        get { return mHasPharmacistRxs; }
        set { mHasPharmacistRxs = value; }
        }

        private string mAgentPhone
            = "";
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"AgentPhone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AgentPhone
        {
        get { return mAgentPhone; }
        set { mAgentPhone = value; }
        }

        private string mAgentPhoneExtension
            = "";
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"AgentPhoneExtension", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AgentPhoneExtension
        {
        get { return mAgentPhoneExtension; }
        set { mAgentPhoneExtension = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        