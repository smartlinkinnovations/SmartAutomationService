
        // Generated from: CopayStratMast.proto
        // Note: requires additional types generated from: CopayStrat.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CopayStratMast")]
        public partial class CopayStratMast : global::ProtoBuf.IExtensible
        {
        public CopayStratMast() {}
        

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

        private int mSubPlanId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SubPlanId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SubPlanId
        {
        get { return mSubPlanId; }
        set { mSubPlanId = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private bool mIncludeCutbacksInCopayReturned
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"IncludeCutbacksInCopayReturned", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeCutbacksInCopayReturned
        {
        get { return mIncludeCutbacksInCopayReturned; }
        set { mIncludeCutbacksInCopayReturned = value; }
        }

        private double mCopayReturned
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"CopayReturned", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CopayReturned
        {
        get { return mCopayReturned; }
        set { mCopayReturned = value; }
        }

        private double mMaxCopayReturned
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"MaxCopayReturned", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MaxCopayReturned
        {
        get { return mMaxCopayReturned; }
        set { mMaxCopayReturned = value; }
        }

        private int mFirstXRxOfTheMonthCount
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"FirstXRxOfTheMonthCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int FirstXRxOfTheMonthCount
        {
        get { return mFirstXRxOfTheMonthCount; }
        set { mFirstXRxOfTheMonthCount = value; }
        }

        private int mRxCountOfTheMonthDuration
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"RxCountOfTheMonthDuration", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxCountOfTheMonthDuration
        {
        get { return mRxCountOfTheMonthDuration; }
        set { mRxCountOfTheMonthDuration = value; }
        }

        private double mChargeXForFirstRxOfTheMonth
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ChargeXForFirstRxOfTheMonth", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChargeXForFirstRxOfTheMonth
        {
        get { return mChargeXForFirstRxOfTheMonth; }
        set { mChargeXForFirstRxOfTheMonth = value; }
        }

        private bool mChargeXForFirstRxOfTheMonthSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ChargeXForFirstRxOfTheMonthSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChargeXForFirstRxOfTheMonthSpecified
        {
        get { return mChargeXForFirstRxOfTheMonthSpecified; }
        set { mChargeXForFirstRxOfTheMonthSpecified = value; }
        }

        private int mChargeWaiveTypeForFirstRxOfTheMonth
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"ChargeWaiveTypeForFirstRxOfTheMonth", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ChargeWaiveTypeForFirstRxOfTheMonth
        {
        get { return mChargeWaiveTypeForFirstRxOfTheMonth; }
        set { mChargeWaiveTypeForFirstRxOfTheMonth = value; }
        }

        private double mChargeXForSubsequentRxsOfTheMonth
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ChargeXForSubsequentRxsOfTheMonth", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChargeXForSubsequentRxsOfTheMonth
        {
        get { return mChargeXForSubsequentRxsOfTheMonth; }
        set { mChargeXForSubsequentRxsOfTheMonth = value; }
        }

        private bool mChargeXForSubsequentRxsOfTheMonthSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"ChargeXForSubsequentRxsOfTheMonthSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChargeXForSubsequentRxsOfTheMonthSpecified
        {
        get { return mChargeXForSubsequentRxsOfTheMonthSpecified; }
        set { mChargeXForSubsequentRxsOfTheMonthSpecified = value; }
        }

        private int mChargeWaiveTypeForSubsequentRxsOfTheMonth
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"ChargeWaiveTypeForSubsequentRxsOfTheMonth", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ChargeWaiveTypeForSubsequentRxsOfTheMonth
        {
        get { return mChargeWaiveTypeForSubsequentRxsOfTheMonth; }
        set { mChargeWaiveTypeForSubsequentRxsOfTheMonth = value; }
        }

        private int mLimitToXCopaysPerMonth
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"LimitToXCopaysPerMonth", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int LimitToXCopaysPerMonth
        {
        get { return mLimitToXCopaysPerMonth; }
        set { mLimitToXCopaysPerMonth = value; }
        }

        private bool mLimitToXCopaysPerMonthSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"LimitToXCopaysPerMonthSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LimitToXCopaysPerMonthSpecified
        {
        get { return mLimitToXCopaysPerMonthSpecified; }
        set { mLimitToXCopaysPerMonthSpecified = value; }
        }

        private bool mApplyDiscountBeforeAdjudicatingSubsequentPlans
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"ApplyDiscountBeforeAdjudicatingSubsequentPlans", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ApplyDiscountBeforeAdjudicatingSubsequentPlans
        {
        get { return mApplyDiscountBeforeAdjudicatingSubsequentPlans; }
        set { mApplyDiscountBeforeAdjudicatingSubsequentPlans = value; }
        }

        private bool mIgnoreIfThisPlanIsNotTheLastPayingPlan
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"IgnoreIfThisPlanIsNotTheLastPayingPlan", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IgnoreIfThisPlanIsNotTheLastPayingPlan
        {
        get { return mIgnoreIfThisPlanIsNotTheLastPayingPlan; }
        set { mIgnoreIfThisPlanIsNotTheLastPayingPlan = value; }
        }

        private bool mApplyToNonBatchedNHRxs
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"ApplyToNonBatchedNHRxs", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ApplyToNonBatchedNHRxs
        {
        get { return mApplyToNonBatchedNHRxs; }
        set { mApplyToNonBatchedNHRxs = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink CentralMaintLink
        {
        get { return mCentralMaintLink; }
        set { mCentralMaintLink = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.CopayStrat> mCopayStrat = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.CopayStrat>();
        [global::ProtoBuf.ProtoMember(17, Name=@"CopayStrat", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.CopayStrat> CopayStrat
        {
        get { return mCopayStrat; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        