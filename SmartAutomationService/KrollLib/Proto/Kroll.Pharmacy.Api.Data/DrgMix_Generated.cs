
        // Generated from: DrgMix.proto
        // Note: requires additional types generated from: DrgMixCalculationType_Enum.proto
        // Note: requires additional types generated from: CompoundType_Enum.proto
        // Note: requires additional types generated from: PrintInstructionsAtFill_Enum.proto
        // Note: requires additional types generated from: DrgOralWritten_Enum.proto
        // Note: requires additional types generated from: DrgMixAlert.proto
        // Note: requires additional types generated from: DrgMixCom.proto
        // Note: requires additional types generated from: DrgMixGrp.proto
        // Note: requires additional types generated from: DrgMixLink.proto
        // Note: requires additional types generated from: DrgMixPlan.proto
        // Note: requires additional types generated from: ExternalDrgMixLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrgMix")]
        public partial class DrgMix : global::ProtoBuf.IExtensible
        {
        public DrgMix() {}
        

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

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private string mQuickCode
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"QuickCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string QuickCode
        {
        get { return mQuickCode; }
        set { mQuickCode = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrgMixCalculationType mCalculationType
            = Kroll.Pharmacy.Api.Data.DrgMixCalculationType.DrgMixCalculationType_Percentage;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"CalculationType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrgMixCalculationType.DrgMixCalculationType_Percentage)]
        
        public Kroll.Pharmacy.Api.Data.DrgMixCalculationType CalculationType
        {
        get { return mCalculationType; }
        set { mCalculationType = value; }
        }

        private double mCalculationFactor
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"CalculationFactor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CalculationFactor
        {
        get { return mCalculationFactor; }
        set { mCalculationFactor = value; }
        }

        private bool mCalculationFactorSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"CalculationFactorSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CalculationFactorSpecified
        {
        get { return mCalculationFactorSpecified; }
        set { mCalculationFactorSpecified = value; }
        }

        private double mBatchQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"BatchQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double BatchQty
        {
        get { return mBatchQty; }
        set { mBatchQty = value; }
        }

        private bool mBatchQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"BatchQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BatchQtySpecified
        {
        get { return mBatchQtySpecified; }
        set { mBatchQtySpecified = value; }
        }

        private string mSchedule
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Schedule", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Schedule
        {
        get { return mSchedule; }
        set { mSchedule = value; }
        }

        private bool mReportable
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Reportable", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Reportable
        {
        get { return mReportable; }
        set { mReportable = value; }
        }

        private int mPriceGroupId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"PriceGroupId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PriceGroupId
        {
        get { return mPriceGroupId; }
        set { mPriceGroupId = value; }
        }

        private bool mPriceGroupIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"PriceGroupIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PriceGroupIdSpecified
        {
        get { return mPriceGroupIdSpecified; }
        set { mPriceGroupIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.CompoundType mCompoundType
            = Kroll.Pharmacy.Api.Data.CompoundType.CompoundType_Unknown;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"CompoundType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CompoundType.CompoundType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.CompoundType CompoundType
        {
        get { return mCompoundType; }
        set { mCompoundType = value; }
        }

        private int mActive3rdPartyComponentId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"Active3rdPartyComponentId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Active3rdPartyComponentId
        {
        get { return mActive3rdPartyComponentId; }
        set { mActive3rdPartyComponentId = value; }
        }

        private bool mActive3rdPartyComponentIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"Active3rdPartyComponentIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active3rdPartyComponentIdSpecified
        {
        get { return mActive3rdPartyComponentIdSpecified; }
        set { mActive3rdPartyComponentIdSpecified = value; }
        }

        private string mInstructions
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"Instructions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Instructions
        {
        get { return mInstructions; }
        set { mInstructions = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private int mExpiryDays
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"ExpiryDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ExpiryDays
        {
        get { return mExpiryDays; }
        set { mExpiryDays = value; }
        }

        private bool mExpiryDaysSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ExpiryDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExpiryDaysSpecified
        {
        get { return mExpiryDaysSpecified; }
        set { mExpiryDaysSpecified = value; }
        }

        private string mForm
            = "";
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"Form", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Form
        {
        get { return mForm; }
        set { mForm = value; }
        }

        private Kroll.Pharmacy.Api.Data.PrintInstructionsAtFill mPrintInstructionsAtFill
            = Kroll.Pharmacy.Api.Data.PrintInstructionsAtFill.PrintInstructionsAtFill_Never;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"PrintInstructionsAtFill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PrintInstructionsAtFill.PrintInstructionsAtFill_Never)]
        
        public Kroll.Pharmacy.Api.Data.PrintInstructionsAtFill PrintInstructionsAtFill
        {
        get { return mPrintInstructionsAtFill; }
        set { mPrintInstructionsAtFill = value; }
        }

        private bool mPrintBatchAndFill
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"PrintBatchAndFill", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintBatchAndFill
        {
        get { return mPrintBatchAndFill; }
        set { mPrintBatchAndFill = value; }
        }

        private double mChrgQtyThres1
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"ChrgQtyThres1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQtyThres1
        {
        get { return mChrgQtyThres1; }
        set { mChrgQtyThres1 = value; }
        }

        private bool mChrgQtyThres1Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"ChrgQtyThres1Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQtyThres1Specified
        {
        get { return mChrgQtyThres1Specified; }
        set { mChrgQtyThres1Specified = value; }
        }

        private double mChrgQtyThres2
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"ChrgQtyThres2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQtyThres2
        {
        get { return mChrgQtyThres2; }
        set { mChrgQtyThres2 = value; }
        }

        private bool mChrgQtyThres2Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"ChrgQtyThres2Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQtyThres2Specified
        {
        get { return mChrgQtyThres2Specified; }
        set { mChrgQtyThres2Specified = value; }
        }

        private double mChrgQtyThres3
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"ChrgQtyThres3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQtyThres3
        {
        get { return mChrgQtyThres3; }
        set { mChrgQtyThres3 = value; }
        }

        private bool mChrgQtyThres3Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"ChrgQtyThres3Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQtyThres3Specified
        {
        get { return mChrgQtyThres3Specified; }
        set { mChrgQtyThres3Specified = value; }
        }

        private double mChrgQtyThres4
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"ChrgQtyThres4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQtyThres4
        {
        get { return mChrgQtyThres4; }
        set { mChrgQtyThres4 = value; }
        }

        private bool mChrgQtyThres4Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"ChrgQtyThres4Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQtyThres4Specified
        {
        get { return mChrgQtyThres4Specified; }
        set { mChrgQtyThres4Specified = value; }
        }

        private double mChrgQtyThres5
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"ChrgQtyThres5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQtyThres5
        {
        get { return mChrgQtyThres5; }
        set { mChrgQtyThres5 = value; }
        }

        private bool mChrgQtyThres5Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"ChrgQtyThres5Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQtyThres5Specified
        {
        get { return mChrgQtyThres5Specified; }
        set { mChrgQtyThres5Specified = value; }
        }

        private double mChrgQty1
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"ChrgQty1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQty1
        {
        get { return mChrgQty1; }
        set { mChrgQty1 = value; }
        }

        private bool mChrgQty1Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"ChrgQty1Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQty1Specified
        {
        get { return mChrgQty1Specified; }
        set { mChrgQty1Specified = value; }
        }

        private double mChrgQty2
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"ChrgQty2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQty2
        {
        get { return mChrgQty2; }
        set { mChrgQty2 = value; }
        }

        private bool mChrgQty2Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"ChrgQty2Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQty2Specified
        {
        get { return mChrgQty2Specified; }
        set { mChrgQty2Specified = value; }
        }

        private double mChrgQty3
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"ChrgQty3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQty3
        {
        get { return mChrgQty3; }
        set { mChrgQty3 = value; }
        }

        private bool mChrgQty3Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"ChrgQty3Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQty3Specified
        {
        get { return mChrgQty3Specified; }
        set { mChrgQty3Specified = value; }
        }

        private double mChrgQty4
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"ChrgQty4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQty4
        {
        get { return mChrgQty4; }
        set { mChrgQty4 = value; }
        }

        private bool mChrgQty4Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"ChrgQty4Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQty4Specified
        {
        get { return mChrgQty4Specified; }
        set { mChrgQty4Specified = value; }
        }

        private double mChrgQty5
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"ChrgQty5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQty5
        {
        get { return mChrgQty5; }
        set { mChrgQty5 = value; }
        }

        private bool mChrgQty5Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"ChrgQty5Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQty5Specified
        {
        get { return mChrgQty5Specified; }
        set { mChrgQty5Specified = value; }
        }

        private double mLastUsedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"LastUsedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastUsedDate
        {
        get { return mLastUsedDate; }
        set { mLastUsedDate = value; }
        }

        private bool mLastUsedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"LastUsedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastUsedDateSpecified
        {
        get { return mLastUsedDateSpecified; }
        set { mLastUsedDateSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrgOralWritten mOralWritten
            = Kroll.Pharmacy.Api.Data.DrgOralWritten.DrgOralWritten_NotSpecified;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"OralWritten", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrgOralWritten.DrgOralWritten_NotSpecified)]
        
        public Kroll.Pharmacy.Api.Data.DrgOralWritten OralWritten
        {
        get { return mOralWritten; }
        set { mOralWritten = value; }
        }

        private bool mIsMethadone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"IsMethadone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsMethadone
        {
        get { return mIsMethadone; }
        set { mIsMethadone = value; }
        }

        private bool mIsIV
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"IsIV", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsIV
        {
        get { return mIsIV; }
        set { mIsIV = value; }
        }

        private string mDefaultSig
            = "";
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"DefaultSig", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DefaultSig
        {
        get { return mDefaultSig; }
        set { mDefaultSig = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private int mDrgMixTimeLookupId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"DrgMixTimeLookupId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgMixTimeLookupId
        {
        get { return mDrgMixTimeLookupId; }
        set { mDrgMixTimeLookupId = value; }
        }

        private bool mDrgMixTimeLookupIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"DrgMixTimeLookupIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrgMixTimeLookupIdSpecified
        {
        get { return mDrgMixTimeLookupIdSpecified; }
        set { mDrgMixTimeLookupIdSpecified = value; }
        }

        private bool mEligibleForCoupon
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"EligibleForCoupon", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EligibleForCoupon
        {
        get { return mEligibleForCoupon; }
        set { mEligibleForCoupon = value; }
        }

        private int mDrgFormId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"DrgFormId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgFormId
        {
        get { return mDrgFormId; }
        set { mDrgFormId = value; }
        }

        private string mFDBRouteCode
            = "";
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"FDBRouteCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBRouteCode
        {
        get { return mFDBRouteCode; }
        set { mFDBRouteCode = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixAlert> mAlerts = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixAlert>();
        [global::ProtoBuf.ProtoMember(67, Name=@"Alerts", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixAlert> Alerts
        {
        get { return mAlerts; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixCom> mComments = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixCom>();
        [global::ProtoBuf.ProtoMember(59, Name=@"Comments", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixCom> Comments
        {
        get { return mComments; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixGrp> mGroups = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixGrp>();
        [global::ProtoBuf.ProtoMember(60, Name=@"Groups", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixGrp> Groups
        {
        get { return mGroups; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixLink> mIngredients = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixLink>();
        [global::ProtoBuf.ProtoMember(61, Name=@"Ingredients", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixLink> Ingredients
        {
        get { return mIngredients; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixPlan> mPlans = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixPlan>();
        [global::ProtoBuf.ProtoMember(62, Name=@"Plans", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgMixPlan> Plans
        {
        get { return mPlans; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalDrgMixLink> mExternalLinks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalDrgMixLink>();
        [global::ProtoBuf.ProtoMember(63, Name=@"ExternalLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalDrgMixLink> ExternalLinks
        {
        get { return mExternalLinks; }
        }
    

        private int mMergedToId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"MergedToId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MergedToId
        {
        get { return mMergedToId; }
        set { mMergedToId = value; }
        }

        private bool mMergedToIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"MergedToIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MergedToIdSpecified
        {
        get { return mMergedToIdSpecified; }
        set { mMergedToIdSpecified = value; }
        }

        private string mHandlingInstructions
            = "";
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"HandlingInstructions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string HandlingInstructions
        {
        get { return mHandlingInstructions; }
        set { mHandlingInstructions = value; }
        }

        private bool mRequireLotNumWhenPackaging
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"RequireLotNumWhenPackaging", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RequireLotNumWhenPackaging
        {
        get { return mRequireLotNumWhenPackaging; }
        set { mRequireLotNumWhenPackaging = value; }
        }

        private bool mRequireExpiryDateWhenPackaging
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"RequireExpiryDateWhenPackaging", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RequireExpiryDateWhenPackaging
        {
        get { return mRequireExpiryDateWhenPackaging; }
        set { mRequireExpiryDateWhenPackaging = value; }
        }

        private bool mRequireIngredientConfirmationWhenPackaging
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"RequireIngredientConfirmationWhenPackaging", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RequireIngredientConfirmationWhenPackaging
        {
        get { return mRequireIngredientConfirmationWhenPackaging; }
        set { mRequireIngredientConfirmationWhenPackaging = value; }
        }

        private bool mRefrigerated
            = 
                (bool)true;
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"Refrigerated", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                (bool)true)]
        
        public bool Refrigerated
        {
        get { return mRefrigerated; }
        set { mRefrigerated = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        