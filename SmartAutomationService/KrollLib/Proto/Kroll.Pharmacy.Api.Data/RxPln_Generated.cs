
        // Generated from: RxPln.proto
        // Note: requires additional types generated from: TransactionType_Enum.proto
        // Note: requires additional types generated from: RxPlnAdjState_Enum.proto
        // Note: requires additional types generated from: ClaimType_Enum.proto
        // Note: requires additional types generated from: DinType_Enum.proto
        // Note: requires additional types generated from: RxPlnAdj.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxPln")]
        public partial class RxPln : global::ProtoBuf.IExtensible
        {
        public RxPln() {}
        

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

        private int mSeq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Seq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Seq
        {
        get { return mSeq; }
        set { mSeq = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private int mPatPlnId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"PatPlnId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatPlnId
        {
        get { return mPatPlnId; }
        set { mPatPlnId = value; }
        }

        private bool mPatPlnIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"PatPlnIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatPlnIdSpecified
        {
        get { return mPatPlnIdSpecified; }
        set { mPatPlnIdSpecified = value; }
        }

        private double mPays
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Pays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Pays
        {
        get { return mPays; }
        set { mPays = value; }
        }

        private Kroll.Pharmacy.Api.Data.TransactionType mTranType
            = Kroll.Pharmacy.Api.Data.TransactionType.TransactionType_Unknown;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"TranType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.TransactionType.TransactionType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.TransactionType TranType
        {
        get { return mTranType; }
        set { mTranType = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxPlnAdjState mAdjState
            = Kroll.Pharmacy.Api.Data.RxPlnAdjState.RxPlnAdjState_NotAdjudicated;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"AdjState", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxPlnAdjState.RxPlnAdjState_NotAdjudicated)]
        
        public Kroll.Pharmacy.Api.Data.RxPlnAdjState AdjState
        {
        get { return mAdjState; }
        set { mAdjState = value; }
        }

        private string mSubPlanCode
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"SubPlanCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SubPlanCode
        {
        get { return mSubPlanCode; }
        set { mSubPlanCode = value; }
        }

        private bool mIsRT
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"IsRT", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsRT
        {
        get { return mIsRT; }
        set { mIsRT = value; }
        }

        private double mAdjDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"AdjDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AdjDate
        {
        get { return mAdjDate; }
        set { mAdjDate = value; }
        }

        private bool mAdjDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"AdjDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AdjDateSpecified
        {
        get { return mAdjDateSpecified; }
        set { mAdjDateSpecified = value; }
        }

        private string mSsc
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"Ssc", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Ssc
        {
        get { return mSsc; }
        set { mSsc = value; }
        }

        private double mSscFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"SscFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SscFee
        {
        get { return mSscFee; }
        set { mSscFee = value; }
        }

        private bool mSscFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"SscFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SscFeeSpecified
        {
        get { return mSscFeeSpecified; }
        set { mSscFeeSpecified = value; }
        }

        private string mSANum
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"SANum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SANum
        {
        get { return mSANum; }
        set { mSANum = value; }
        }

        private string mInterventions
            = "";
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"Interventions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Interventions
        {
        get { return mInterventions; }
        set { mInterventions = value; }
        }

        private string mReasonCodeRef
            = "";
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"ReasonCodeRef", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReasonCodeRef
        {
        get { return mReasonCodeRef; }
        set { mReasonCodeRef = value; }
        }

        private string mReasonCode
            = "";
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"ReasonCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReasonCode
        {
        get { return mReasonCode; }
        set { mReasonCode = value; }
        }

        private Kroll.Pharmacy.Api.Data.ClaimType mClaimType
            = Kroll.Pharmacy.Api.Data.ClaimType.ClaimType_Rx;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"ClaimType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ClaimType.ClaimType_Rx)]
        
        public Kroll.Pharmacy.Api.Data.ClaimType ClaimType
        {
        get { return mClaimType; }
        set { mClaimType = value; }
        }

        private double mAdjSendDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"AdjSendDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AdjSendDate
        {
        get { return mAdjSendDate; }
        set { mAdjSendDate = value; }
        }

        private bool mAdjSendDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"AdjSendDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AdjSendDateSpecified
        {
        get { return mAdjSendDateSpecified; }
        set { mAdjSendDateSpecified = value; }
        }

        private int mAdjustmentStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"AdjustmentStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AdjustmentStatus
        {
        get { return mAdjustmentStatus; }
        set { mAdjustmentStatus = value; }
        }

        private string mPseudoDin
            = "";
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"PseudoDin", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PseudoDin
        {
        get { return mPseudoDin; }
        set { mPseudoDin = value; }
        }

        private int mAdjudicationLevel
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"AdjudicationLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AdjudicationLevel
        {
        get { return mAdjudicationLevel; }
        set { mAdjudicationLevel = value; }
        }

        private int mPaymentSeq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"PaymentSeq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PaymentSeq
        {
        get { return mPaymentSeq; }
        set { mPaymentSeq = value; }
        }

        private bool mPaymentSeqSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"PaymentSeqSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PaymentSeqSpecified
        {
        get { return mPaymentSeqSpecified; }
        set { mPaymentSeqSpecified = value; }
        }

        private int mNonDUESeq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"NonDUESeq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NonDUESeq
        {
        get { return mNonDUESeq; }
        set { mNonDUESeq = value; }
        }

        private bool mNonDUESeqSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"NonDUESeqSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NonDUESeqSpecified
        {
        get { return mNonDUESeqSpecified; }
        set { mNonDUESeqSpecified = value; }
        }

        private double mDiscountSSCFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"DiscountSSCFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DiscountSSCFee
        {
        get { return mDiscountSSCFee; }
        set { mDiscountSSCFee = value; }
        }

        private bool mDiscountSSCFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"DiscountSSCFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DiscountSSCFeeSpecified
        {
        get { return mDiscountSSCFeeSpecified; }
        set { mDiscountSSCFeeSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.DinType mPseudoDinType
            = Kroll.Pharmacy.Api.Data.DinType.DinType_Din;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"PseudoDinType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DinType.DinType_Din)]
        
        public Kroll.Pharmacy.Api.Data.DinType PseudoDinType
        {
        get { return mPseudoDinType; }
        set { mPseudoDinType = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPlnAdj> mAdjudicationDetails = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPlnAdj>();
        [global::ProtoBuf.ProtoMember(36, Name=@"AdjudicationDetails", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPlnAdj> AdjudicationDetails
        {
        get { return mAdjudicationDetails; }
        }
    

        private bool mClaimTypeOverride
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"ClaimTypeOverride", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ClaimTypeOverride
        {
        get { return mClaimTypeOverride; }
        set { mClaimTypeOverride = value; }
        }

        private bool mIsClinicalPlan
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"IsClinicalPlan", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsClinicalPlan
        {
        get { return mIsClinicalPlan; }
        set { mIsClinicalPlan = value; }
        }

        private int mCancelsRxPlnId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"CancelsRxPlnId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CancelsRxPlnId
        {
        get { return mCancelsRxPlnId; }
        set { mCancelsRxPlnId = value; }
        }

        private bool mCancelsRxPlnIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"CancelsRxPlnIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CancelsRxPlnIdSpecified
        {
        get { return mCancelsRxPlnIdSpecified; }
        set { mCancelsRxPlnIdSpecified = value; }
        }

        private int mCopayStratMastId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"CopayStratMastId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CopayStratMastId
        {
        get { return mCopayStratMastId; }
        set { mCopayStratMastId = value; }
        }

        private bool mCopayStratMastIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"CopayStratMastIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CopayStratMastIdSpecified
        {
        get { return mCopayStratMastIdSpecified; }
        set { mCopayStratMastIdSpecified = value; }
        }

        private double mCutbackDiscountCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"CutbackDiscountCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CutbackDiscountCost
        {
        get { return mCutbackDiscountCost; }
        set { mCutbackDiscountCost = value; }
        }

        private double mCutbackDiscountMarkup
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"CutbackDiscountMarkup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CutbackDiscountMarkup
        {
        get { return mCutbackDiscountMarkup; }
        set { mCutbackDiscountMarkup = value; }
        }

        private double mCutbackDiscountFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"CutbackDiscountFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CutbackDiscountFee
        {
        get { return mCutbackDiscountFee; }
        set { mCutbackDiscountFee = value; }
        }

        private double mCutbackDiscountMixFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"CutbackDiscountMixFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CutbackDiscountMixFee
        {
        get { return mCutbackDiscountMixFee; }
        set { mCutbackDiscountMixFee = value; }
        }

        private double mCutbackDiscountSSCFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"CutbackDiscountSSCFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CutbackDiscountSSCFee
        {
        get { return mCutbackDiscountSSCFee; }
        set { mCutbackDiscountSSCFee = value; }
        }

        private double mCopayDiscountCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"CopayDiscountCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CopayDiscountCost
        {
        get { return mCopayDiscountCost; }
        set { mCopayDiscountCost = value; }
        }

        private double mCopayDiscountMarkup
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"CopayDiscountMarkup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CopayDiscountMarkup
        {
        get { return mCopayDiscountMarkup; }
        set { mCopayDiscountMarkup = value; }
        }

        private double mCopayDiscountFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"CopayDiscountFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CopayDiscountFee
        {
        get { return mCopayDiscountFee; }
        set { mCopayDiscountFee = value; }
        }

        private double mCopayDiscountMixFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"CopayDiscountMixFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CopayDiscountMixFee
        {
        get { return mCopayDiscountMixFee; }
        set { mCopayDiscountMixFee = value; }
        }

        private double mCopayDiscountSSCFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"CopayDiscountSSCFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CopayDiscountSSCFee
        {
        get { return mCopayDiscountSSCFee; }
        set { mCopayDiscountSSCFee = value; }
        }

        private bool mSSCOverride
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"SSCOverride", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SSCOverride
        {
        get { return mSSCOverride; }
        set { mSSCOverride = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        