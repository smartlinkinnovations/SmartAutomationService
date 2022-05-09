
        // Generated from: PlnSub.proto
        // Note: requires additional types generated from: ManualBillingReportType_Enum.proto
        // Note: requires additional types generated from: DeductType_Enum.proto
        // Note: requires additional types generated from: PrcStratLookup.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlnSub")]
        public partial class PlnSub : global::ProtoBuf.IExtensible
        {
        public PlnSub() {}
        

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

        private int mPlnId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PlnId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PlnId
        {
        get { return mPlnId; }
        set { mPlnId = value; }
        }

        private string mSubPlanCode
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SubPlanCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SubPlanCode
        {
        get { return mSubPlanCode; }
        set { mSubPlanCode = value; }
        }

        private bool mIsDefaultSubPlan
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"IsDefaultSubPlan", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsDefaultSubPlan
        {
        get { return mIsDefaultSubPlan; }
        set { mIsDefaultSubPlan = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private bool mCarrierIdReadOnly
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"CarrierIdReadOnly", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CarrierIdReadOnly
        {
        get { return mCarrierIdReadOnly; }
        set { mCarrierIdReadOnly = value; }
        }

        private bool mGroupReadOnly
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"GroupReadOnly", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool GroupReadOnly
        {
        get { return mGroupReadOnly; }
        set { mGroupReadOnly = value; }
        }

        private bool mClientReadOnly
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"ClientReadOnly", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ClientReadOnly
        {
        get { return mClientReadOnly; }
        set { mClientReadOnly = value; }
        }

        private bool mCphaReadOnly
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"CphaReadOnly", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CphaReadOnly
        {
        get { return mCphaReadOnly; }
        set { mCphaReadOnly = value; }
        }

        private bool mRelReadOnly
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"RelReadOnly", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RelReadOnly
        {
        get { return mRelReadOnly; }
        set { mRelReadOnly = value; }
        }

        private bool mExpiryReadOnly
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ExpiryReadOnly", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExpiryReadOnly
        {
        get { return mExpiryReadOnly; }
        set { mExpiryReadOnly = value; }
        }

        private bool mCarrierIdRequired
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"CarrierIdRequired", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CarrierIdRequired
        {
        get { return mCarrierIdRequired; }
        set { mCarrierIdRequired = value; }
        }

        private bool mGroupRequired
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"GroupRequired", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool GroupRequired
        {
        get { return mGroupRequired; }
        set { mGroupRequired = value; }
        }

        private bool mClientRequired
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"ClientRequired", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ClientRequired
        {
        get { return mClientRequired; }
        set { mClientRequired = value; }
        }

        private bool mCphaRequired
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"CphaRequired", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CphaRequired
        {
        get { return mCphaRequired; }
        set { mCphaRequired = value; }
        }

        private bool mRelRequired
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"RelRequired", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RelRequired
        {
        get { return mRelRequired; }
        set { mRelRequired = value; }
        }

        private bool mExpiryRequired
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"ExpiryRequired", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExpiryRequired
        {
        get { return mExpiryRequired; }
        set { mExpiryRequired = value; }
        }

        private bool mDeductRequired
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"DeductRequired", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeductRequired
        {
        get { return mDeductRequired; }
        set { mDeductRequired = value; }
        }

        private bool mBirthRequired
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"BirthRequired", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BirthRequired
        {
        get { return mBirthRequired; }
        set { mBirthRequired = value; }
        }

        private string mDefaultCarrierId
            = "";
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"DefaultCarrierId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DefaultCarrierId
        {
        get { return mDefaultCarrierId; }
        set { mDefaultCarrierId = value; }
        }

        private string mDefaultGroupId
            = "";
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"DefaultGroupId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DefaultGroupId
        {
        get { return mDefaultGroupId; }
        set { mDefaultGroupId = value; }
        }

        private string mDefaultClientId
            = "";
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"DefaultClientId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DefaultClientId
        {
        get { return mDefaultClientId; }
        set { mDefaultClientId = value; }
        }

        private string mDefaultCphaPatCode
            = "";
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"DefaultCphaPatCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DefaultCphaPatCode
        {
        get { return mDefaultCphaPatCode; }
        set { mDefaultCphaPatCode = value; }
        }

        private bool mUsePlanPricing
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"UsePlanPricing", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UsePlanPricing
        {
        get { return mUsePlanPricing; }
        set { mUsePlanPricing = value; }
        }

        private bool mUsePlanPatInfo
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"UsePlanPatInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UsePlanPatInfo
        {
        get { return mUsePlanPatInfo; }
        set { mUsePlanPatInfo = value; }
        }

        private Kroll.Pharmacy.Api.Data.ManualBillingReportType mManualBillingReportType
            = Kroll.Pharmacy.Api.Data.ManualBillingReportType.ManualBillingReportType_Unknown;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"ManualBillingReportType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ManualBillingReportType.ManualBillingReportType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ManualBillingReportType ManualBillingReportType
        {
        get { return mManualBillingReportType; }
        set { mManualBillingReportType = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private string mCorporateId
            = "";
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"CorporateId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CorporateId
        {
        get { return mCorporateId; }
        set { mCorporateId = value; }
        }

        private Kroll.Pharmacy.Api.Data.DeductType mDefaultDeductType
            = Kroll.Pharmacy.Api.Data.DeductType.DeductType_Unknown;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"DefaultDeductType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DeductType.DeductType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.DeductType DefaultDeductType
        {
        get { return mDefaultDeductType; }
        set { mDefaultDeductType = value; }
        }

        private string mDefaultDeductValue
            = "";
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"DefaultDeductValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DefaultDeductValue
        {
        get { return mDefaultDeductValue; }
        set { mDefaultDeductValue = value; }
        }

        private bool mExcludeFromNetworkTotals
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"ExcludeFromNetworkTotals", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExcludeFromNetworkTotals
        {
        get { return mExcludeFromNetworkTotals; }
        set { mExcludeFromNetworkTotals = value; }
        }

        private string mHelpString
            = "";
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"HelpString", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string HelpString
        {
        get { return mHelpString; }
        set { mHelpString = value; }
        }

        private bool mDeferPricingToSecondPlan
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"DeferPricingToSecondPlan", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeferPricingToSecondPlan
        {
        get { return mDeferPricingToSecondPlan; }
        set { mDeferPricingToSecondPlan = value; }
        }

        private bool mAllowFillIfPlanExpired
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"AllowFillIfPlanExpired", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AllowFillIfPlanExpired
        {
        get { return mAllowFillIfPlanExpired; }
        set { mAllowFillIfPlanExpired = value; }
        }

        private bool mIgnorePatPrcGrp
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"IgnorePatPrcGrp", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IgnorePatPrcGrp
        {
        get { return mIgnorePatPrcGrp; }
        set { mIgnorePatPrcGrp = value; }
        }

        private bool mPromptForDeductWhenBillingManually
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"PromptForDeductWhenBillingManually", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PromptForDeductWhenBillingManually
        {
        get { return mPromptForDeductWhenBillingManually; }
        set { mPromptForDeductWhenBillingManually = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private int mCentralMaintFieldMask2
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"CentralMaintFieldMask2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask2
        {
        get { return mCentralMaintFieldMask2; }
        set { mCentralMaintFieldMask2 = value; }
        }

        private int mDrgPackTierId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"DrgPackTierId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgPackTierId
        {
        get { return mDrgPackTierId; }
        set { mDrgPackTierId = value; }
        }

        private bool mDUEOnly
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"DUEOnly", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DUEOnly
        {
        get { return mDUEOnly; }
        set { mDUEOnly = value; }
        }

        private bool mTreatAsDUEIfPlanPaysZero
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"TreatAsDUEIfPlanPaysZero", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TreatAsDUEIfPlanPaysZero
        {
        get { return mTreatAsDUEIfPlanPaysZero; }
        set { mTreatAsDUEIfPlanPaysZero = value; }
        }

        private bool mAllowManualBilling
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"AllowManualBilling", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AllowManualBilling
        {
        get { return mAllowManualBilling; }
        set { mAllowManualBilling = value; }
        }

        private double mCouponPercentage
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"CouponPercentage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CouponPercentage
        {
        get { return mCouponPercentage; }
        set { mCouponPercentage = value; }
        }

        private bool mCouponPercentageSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"CouponPercentageSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CouponPercentageSpecified
        {
        get { return mCouponPercentageSpecified; }
        set { mCouponPercentageSpecified = value; }
        }

        private double mCouponMinimumValue
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"CouponMinimumValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CouponMinimumValue
        {
        get { return mCouponMinimumValue; }
        set { mCouponMinimumValue = value; }
        }

        private bool mCouponMinimumValueSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"CouponMinimumValueSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CouponMinimumValueSpecified
        {
        get { return mCouponMinimumValueSpecified; }
        set { mCouponMinimumValueSpecified = value; }
        }

        private bool mIsPreferredProviderSubPlan
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"IsPreferredProviderSubPlan", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsPreferredProviderSubPlan
        {
        get { return mIsPreferredProviderSubPlan; }
        set { mIsPreferredProviderSubPlan = value; }
        }

        private bool mDoPreferredProviderSubPlanSubstitution
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"DoPreferredProviderSubPlanSubstitution", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoPreferredProviderSubPlanSubstitution
        {
        get { return mDoPreferredProviderSubPlanSubstitution; }
        set { mDoPreferredProviderSubPlanSubstitution = value; }
        }

        private bool mIgnoreDrgPrcGrp
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"IgnoreDrgPrcGrp", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IgnoreDrgPrcGrp
        {
        get { return mIgnoreDrgPrcGrp; }
        set { mIgnoreDrgPrcGrp = value; }
        }

        private bool mSingleUse
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"SingleUse", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SingleUse
        {
        get { return mSingleUse; }
        set { mSingleUse = value; }
        }

        private string mGLAccountNumber
            = "";
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"GLAccountNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string GLAccountNumber
        {
        get { return mGLAccountNumber; }
        set { mGLAccountNumber = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PrcStratLookup> mPricingStrategyLookup = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PrcStratLookup>();
        [global::ProtoBuf.ProtoMember(61, Name=@"PricingStrategyLookup", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PrcStratLookup> PricingStrategyLookup
        {
        get { return mPricingStrategyLookup; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        