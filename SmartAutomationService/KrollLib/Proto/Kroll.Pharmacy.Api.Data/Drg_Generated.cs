
        // Generated from: Drg.proto
        // Note: requires additional types generated from: DrgOralWritten_Enum.proto
        // Note: requires additional types generated from: DrugLabelName_Enum.proto
        // Note: requires additional types generated from: BrandGenericType_Enum.proto
        // Note: requires additional types generated from: ExternalDrgLink.proto
        // Note: requires additional types generated from: FeeForServiceType_Enum.proto
        // Note: requires additional types generated from: DinType_Enum.proto
        // Note: requires additional types generated from: DrgCardType_Enum.proto
        // Note: requires additional types generated from: DrgAlert.proto
        // Note: requires additional types generated from: DrgCom.proto
        // Note: requires additional types generated from: DrgExcp.proto
        // Note: requires additional types generated from: DrgFormulary.proto
        // Note: requires additional types generated from: DrgGrp.proto
        // Note: requires additional types generated from: DrgPack.proto
        // Note: requires additional types generated from: DrgPicture.proto
        // Note: requires additional types generated from: DrgPlan.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Drg")]
        public partial class Drg : global::ProtoBuf.IExtensible
        {
        public Drg() {}
        

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

        private string mBrandName
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"BrandName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string BrandName
        {
        get { return mBrandName; }
        set { mBrandName = value; }
        }

        private string mGenericName
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"GenericName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string GenericName
        {
        get { return mGenericName; }
        set { mGenericName = value; }
        }

        private string mDin
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Din", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Din
        {
        get { return mDin; }
        set { mDin = value; }
        }

        private string mManufacturer
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Manufacturer", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Manufacturer
        {
        get { return mManufacturer; }
        set { mManufacturer = value; }
        }

        private string mManufacturerAbbreviation
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ManufacturerAbbreviation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ManufacturerAbbreviation
        {
        get { return mManufacturerAbbreviation; }
        set { mManufacturerAbbreviation = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private string mForm
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Form", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Form
        {
        get { return mForm; }
        set { mForm = value; }
        }

        private string mFormAbbreviation
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"FormAbbreviation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FormAbbreviation
        {
        get { return mFormAbbreviation; }
        set { mFormAbbreviation = value; }
        }

        private string mStrength
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Strength", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Strength
        {
        get { return mStrength; }
        set { mStrength = value; }
        }

        private bool mPackage
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Package", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Package
        {
        get { return mPackage; }
        set { mPackage = value; }
        }

        private string mSchedule
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"Schedule", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"Reportable", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Reportable
        {
        get { return mReportable; }
        set { mReportable = value; }
        }

        private string mDefaultSig
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"DefaultSig", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DefaultSig
        {
        get { return mDefaultSig; }
        set { mDefaultSig = value; }
        }

        private int mPriceGroupId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"PriceGroupId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"PriceGroupIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PriceGroupIdSpecified
        {
        get { return mPriceGroupIdSpecified; }
        set { mPriceGroupIdSpecified = value; }
        }

        private int mExpiryDays
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ExpiryDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"ExpiryDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExpiryDaysSpecified
        {
        get { return mExpiryDaysSpecified; }
        set { mExpiryDaysSpecified = value; }
        }

        private int mFollowupDays
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"FollowupDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int FollowupDays
        {
        get { return mFollowupDays; }
        set { mFollowupDays = value; }
        }

        private bool mFollowupDaysSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"FollowupDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FollowupDaysSpecified
        {
        get { return mFollowupDaysSpecified; }
        set { mFollowupDaysSpecified = value; }
        }

        private string mAutoDispLocation
            = "";
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"AutoDispLocation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AutoDispLocation
        {
        get { return mAutoDispLocation; }
        set { mAutoDispLocation = value; }
        }

        private string mLocation
            = "";
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"Location", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Location
        {
        get { return mLocation; }
        set { mLocation = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private string mEquivTo
            = "";
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"EquivTo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string EquivTo
        {
        get { return mEquivTo; }
        set { mEquivTo = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrgOralWritten mOralWritten
            = Kroll.Pharmacy.Api.Data.DrgOralWritten.DrgOralWritten_NotSpecified;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"OralWritten", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrgOralWritten.DrgOralWritten_NotSpecified)]
        
        public Kroll.Pharmacy.Api.Data.DrgOralWritten OralWritten
        {
        get { return mOralWritten; }
        set { mOralWritten = value; }
        }

        private int mSubstituteDrgId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"SubstituteDrgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SubstituteDrgId
        {
        get { return mSubstituteDrgId; }
        set { mSubstituteDrgId = value; }
        }

        private bool mSubstituteDrgIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"SubstituteDrgIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SubstituteDrgIdSpecified
        {
        get { return mSubstituteDrgIdSpecified; }
        set { mSubstituteDrgIdSpecified = value; }
        }

        private bool mPrintCompliance
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"PrintCompliance", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintCompliance
        {
        get { return mPrintCompliance; }
        set { mPrintCompliance = value; }
        }

        private bool mIsTrial
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"IsTrial", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsTrial
        {
        get { return mIsTrial; }
        set { mIsTrial = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrugLabelName mFirstDrugName
            = Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"FirstDrugName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default)]
        
        public Kroll.Pharmacy.Api.Data.DrugLabelName FirstDrugName
        {
        get { return mFirstDrugName; }
        set { mFirstDrugName = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrugLabelName mSecondDrugName
            = Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"SecondDrugName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default)]
        
        public Kroll.Pharmacy.Api.Data.DrugLabelName SecondDrugName
        {
        get { return mSecondDrugName; }
        set { mSecondDrugName = value; }
        }

        private bool mIsWardStock
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"IsWardStock", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsWardStock
        {
        get { return mIsWardStock; }
        set { mIsWardStock = value; }
        }

        private bool mIsNarcotic
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"IsNarcotic", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsNarcotic
        {
        get { return mIsNarcotic; }
        set { mIsNarcotic = value; }
        }

        private bool mIsControlled
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"IsControlled", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsControlled
        {
        get { return mIsControlled; }
        set { mIsControlled = value; }
        }

        private bool mIsFlavorRx
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"IsFlavorRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsFlavorRx
        {
        get { return mIsFlavorRx; }
        set { mIsFlavorRx = value; }
        }

        private bool mHalfSizeSig
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"HalfSizeSig", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HalfSizeSig
        {
        get { return mHalfSizeSig; }
        set { mHalfSizeSig = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"CentralMaintFieldMask2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask2
        {
        get { return mCentralMaintFieldMask2; }
        set { mCentralMaintFieldMask2 = value; }
        }

        private int mInterchangeablePriority
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"InterchangeablePriority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int InterchangeablePriority
        {
        get { return mInterchangeablePriority; }
        set { mInterchangeablePriority = value; }
        }

        private bool mInterchangeablePrioritySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"InterchangeablePrioritySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InterchangeablePrioritySpecified
        {
        get { return mInterchangeablePrioritySpecified; }
        set { mInterchangeablePrioritySpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.BrandGenericType mBrandGenericType
            = Kroll.Pharmacy.Api.Data.BrandGenericType.BrandGenericType_Unknown;
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"BrandGenericType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.BrandGenericType.BrandGenericType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.BrandGenericType BrandGenericType
        {
        get { return mBrandGenericType; }
        set { mBrandGenericType = value; }
        }

        private string mTADin
            = "";
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"TADin", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string TADin
        {
        get { return mTADin; }
        set { mTADin = value; }
        }

        private int mDepartmentId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"DepartmentId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DepartmentId
        {
        get { return mDepartmentId; }
        set { mDepartmentId = value; }
        }

        private bool mDepartmentIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(76, IsRequired = false, Name=@"DepartmentIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DepartmentIdSpecified
        {
        get { return mDepartmentIdSpecified; }
        set { mDepartmentIdSpecified = value; }
        }

        private int mDrugMessageId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"DrugMessageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrugMessageId
        {
        get { return mDrugMessageId; }
        set { mDrugMessageId = value; }
        }

        private bool mDrugMessageIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(77, IsRequired = false, Name=@"DrugMessageIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrugMessageIdSpecified
        {
        get { return mDrugMessageIdSpecified; }
        set { mDrugMessageIdSpecified = value; }
        }

        private bool mEligibleForCoupon
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"EligibleForCoupon", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EligibleForCoupon
        {
        get { return mEligibleForCoupon; }
        set { mEligibleForCoupon = value; }
        }

        private bool mIsDevice
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"IsDevice", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsDevice
        {
        get { return mIsDevice; }
        set { mIsDevice = value; }
        }

        private Kroll.Pharmacy.Api.Data.FeeForServiceType mFeeForServiceType
            = Kroll.Pharmacy.Api.Data.FeeForServiceType.FeeForServiceType_None;
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"FeeForServiceType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.FeeForServiceType.FeeForServiceType_None)]
        
        public Kroll.Pharmacy.Api.Data.FeeForServiceType FeeForServiceType
        {
        get { return mFeeForServiceType; }
        set { mFeeForServiceType = value; }
        }

        private Kroll.Pharmacy.Api.Data.DinType mDinType
            = Kroll.Pharmacy.Api.Data.DinType.DinType_Din;
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"DinType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DinType.DinType_Din)]
        
        public Kroll.Pharmacy.Api.Data.DinType DinType
        {
        get { return mDinType; }
        set { mDinType = value; }
        }

        private int mDrgFormId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"DrgFormId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgFormId
        {
        get { return mDrgFormId; }
        set { mDrgFormId = value; }
        }

        private bool mDrgFormIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(78, IsRequired = false, Name=@"DrgFormIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrgFormIdSpecified
        {
        get { return mDrgFormIdSpecified; }
        set { mDrgFormIdSpecified = value; }
        }

        private string mFDBRouteCode
            = "";
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"FDBRouteCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBRouteCode
        {
        get { return mFDBRouteCode; }
        set { mFDBRouteCode = value; }
        }

        private int mMergedToId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(79, IsRequired = false, Name=@"MergedToId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(80, IsRequired = false, Name=@"MergedToIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(81, IsRequired = false, Name=@"HandlingInstructions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string HandlingInstructions
        {
        get { return mHandlingInstructions; }
        set { mHandlingInstructions = value; }
        }

        private string mDescription2
            = "";
        [global::ProtoBuf.ProtoMember(82, IsRequired = false, Name=@"Description2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description2
        {
        get { return mDescription2; }
        set { mDescription2 = value; }
        }

        private int mCentralMaintOverrideFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(83, IsRequired = false, Name=@"CentralMaintOverrideFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintOverrideFieldMask
        {
        get { return mCentralMaintOverrideFieldMask; }
        set { mCentralMaintOverrideFieldMask = value; }
        }

        private int mCentralMaintAllowOverrideFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(84, IsRequired = false, Name=@"CentralMaintAllowOverrideFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintAllowOverrideFieldMask
        {
        get { return mCentralMaintAllowOverrideFieldMask; }
        set { mCentralMaintAllowOverrideFieldMask = value; }
        }

        private int mCentralMaintOverrideFieldMask2
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(85, IsRequired = false, Name=@"CentralMaintOverrideFieldMask2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintOverrideFieldMask2
        {
        get { return mCentralMaintOverrideFieldMask2; }
        set { mCentralMaintOverrideFieldMask2 = value; }
        }

        private int mCentralMaintAllowOverrideFieldMask2
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(86, IsRequired = false, Name=@"CentralMaintAllowOverrideFieldMask2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintAllowOverrideFieldMask2
        {
        get { return mCentralMaintAllowOverrideFieldMask2; }
        set { mCentralMaintAllowOverrideFieldMask2 = value; }
        }

        private int mShapeId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(88, IsRequired = false, Name=@"ShapeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ShapeId
        {
        get { return mShapeId; }
        set { mShapeId = value; }
        }

        private bool mShapeIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(89, IsRequired = false, Name=@"ShapeIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ShapeIdSpecified
        {
        get { return mShapeIdSpecified; }
        set { mShapeIdSpecified = value; }
        }

        private int mColourId1
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(90, IsRequired = false, Name=@"ColourId1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ColourId1
        {
        get { return mColourId1; }
        set { mColourId1 = value; }
        }

        private bool mColourId1Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(91, IsRequired = false, Name=@"ColourId1Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ColourId1Specified
        {
        get { return mColourId1Specified; }
        set { mColourId1Specified = value; }
        }

        private int mColourId2
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(92, IsRequired = false, Name=@"ColourId2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ColourId2
        {
        get { return mColourId2; }
        set { mColourId2 = value; }
        }

        private bool mColourId2Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(93, IsRequired = false, Name=@"ColourId2Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ColourId2Specified
        {
        get { return mColourId2Specified; }
        set { mColourId2Specified = value; }
        }

        private string mMarkings1
            = "";
        [global::ProtoBuf.ProtoMember(94, IsRequired = false, Name=@"Markings1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Markings1
        {
        get { return mMarkings1; }
        set { mMarkings1 = value; }
        }

        private string mMarkings2
            = "";
        [global::ProtoBuf.ProtoMember(95, IsRequired = false, Name=@"Markings2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Markings2
        {
        get { return mMarkings2; }
        set { mMarkings2 = value; }
        }

        private bool mRequireLotNumWhenPackaging
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(96, IsRequired = false, Name=@"RequireLotNumWhenPackaging", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(97, IsRequired = false, Name=@"RequireExpiryDateWhenPackaging", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RequireExpiryDateWhenPackaging
        {
        get { return mRequireExpiryDateWhenPackaging; }
        set { mRequireExpiryDateWhenPackaging = value; }
        }

        private bool mRefrigerated
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(98, IsRequired = false, Name=@"Refrigerated", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Refrigerated
        {
        get { return mRefrigerated; }
        set { mRefrigerated = value; }
        }

        private bool mIsMethadone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(99, IsRequired = false, Name=@"IsMethadone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsMethadone
        {
        get { return mIsMethadone; }
        set { mIsMethadone = value; }
        }

        private bool mRxSync
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(100, IsRequired = false, Name=@"RxSync", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxSync
        {
        get { return mRxSync; }
        set { mRxSync = value; }
        }

        private bool mDoubleCount
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(101, IsRequired = false, Name=@"DoubleCount", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoubleCount
        {
        get { return mDoubleCount; }
        set { mDoubleCount = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrgCardType mDrgCardType
            = Kroll.Pharmacy.Api.Data.DrgCardType.DrgCardType_Default;
        [global::ProtoBuf.ProtoMember(102, IsRequired = false, Name=@"DrgCardType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrgCardType.DrgCardType_Default)]
        
        public Kroll.Pharmacy.Api.Data.DrgCardType DrgCardType
        {
        get { return mDrgCardType; }
        set { mDrgCardType = value; }
        }

        private bool mDrgCardTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(103, IsRequired = false, Name=@"DrgCardTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrgCardTypeSpecified
        {
        get { return mDrgCardTypeSpecified; }
        set { mDrgCardTypeSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalDrgLink> mExternalLinks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalDrgLink>();
        [global::ProtoBuf.ProtoMember(68, Name=@"ExternalLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalDrgLink> ExternalLinks
        {
        get { return mExternalLinks; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgCom> mComments = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgCom>();
        [global::ProtoBuf.ProtoMember(69, Name=@"Comments", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgCom> Comments
        {
        get { return mComments; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgExcp> mExceptions = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgExcp>();
        [global::ProtoBuf.ProtoMember(70, Name=@"Exceptions", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgExcp> Exceptions
        {
        get { return mExceptions; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgFormulary> mFormulary = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgFormulary>();
        [global::ProtoBuf.ProtoMember(71, Name=@"Formulary", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgFormulary> Formulary
        {
        get { return mFormulary; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgGrp> mGroups = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgGrp>();
        [global::ProtoBuf.ProtoMember(72, Name=@"Groups", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgGrp> Groups
        {
        get { return mGroups; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPack> mPacks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPack>();
        [global::ProtoBuf.ProtoMember(73, Name=@"Packs", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPack> Packs
        {
        get { return mPacks; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPicture> mPictures = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPicture>();
        [global::ProtoBuf.ProtoMember(74, Name=@"Pictures", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPicture> Pictures
        {
        get { return mPictures; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPlan> mPlans = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPlan>();
        [global::ProtoBuf.ProtoMember(75, Name=@"Plans", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPlan> Plans
        {
        get { return mPlans; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgAlert> mAlerts = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgAlert>();
        [global::ProtoBuf.ProtoMember(87, Name=@"Alerts", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgAlert> Alerts
        {
        get { return mAlerts; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        