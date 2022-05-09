
        // Generated from: DrgSearchCriteria.proto
        // Note: requires additional types generated from: StringComparisonOperator_Enum.proto
        // Note: requires additional types generated from: DrgOralWritten_Enum.proto
        // Note: requires additional types generated from: DrugLabelName_Enum.proto
        // Note: requires additional types generated from: BrandGenericType_Enum.proto
        // Note: requires additional types generated from: FeeForServiceType_Enum.proto
        // Note: requires additional types generated from: DinType_Enum.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrgSearchCriteria")]
        public partial class DrgSearchCriteria : global::ProtoBuf.IExtensible
        {
        public DrgSearchCriteria() {}
        

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

        private bool mIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IdSpecified
        {
        get { return mIdSpecified; }
        set { mIdSpecified = value; }
        }

        private string mBrandName
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"BrandName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string BrandName
        {
        get { return mBrandName; }
        set { mBrandName = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mBrandNameComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"BrandNameComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator BrandNameComparisonOperator
        {
        get { return mBrandNameComparisonOperator; }
        set { mBrandNameComparisonOperator = value; }
        }

        private string mGenericName
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"GenericName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string GenericName
        {
        get { return mGenericName; }
        set { mGenericName = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mGenericNameComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"GenericNameComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator GenericNameComparisonOperator
        {
        get { return mGenericNameComparisonOperator; }
        set { mGenericNameComparisonOperator = value; }
        }

        private string mDin
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Din", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Din
        {
        get { return mDin; }
        set { mDin = value; }
        }

        private bool mDinSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DinSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DinSpecified
        {
        get { return mDinSpecified; }
        set { mDinSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.DinType mDinType
            = Kroll.Pharmacy.Api.Data.DinType.DinType_Din;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DinType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DinType.DinType_Din)]
        
        public Kroll.Pharmacy.Api.Data.DinType DinType
        {
        get { return mDinType; }
        set { mDinType = value; }
        }

        private bool mDinTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"DinTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DinTypeSpecified
        {
        get { return mDinTypeSpecified; }
        set { mDinTypeSpecified = value; }
        }

        private string mManufacturer
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Manufacturer", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Manufacturer
        {
        get { return mManufacturer; }
        set { mManufacturer = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mManufacturerComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"ManufacturerComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator ManufacturerComparisonOperator
        {
        get { return mManufacturerComparisonOperator; }
        set { mManufacturerComparisonOperator = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mDescriptionComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DescriptionComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator DescriptionComparisonOperator
        {
        get { return mDescriptionComparisonOperator; }
        set { mDescriptionComparisonOperator = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private bool mActiveSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ActiveSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ActiveSpecified
        {
        get { return mActiveSpecified; }
        set { mActiveSpecified = value; }
        }

        private string mForm
            = "";
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"Form", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Form
        {
        get { return mForm; }
        set { mForm = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mFormComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"FormComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator FormComparisonOperator
        {
        get { return mFormComparisonOperator; }
        set { mFormComparisonOperator = value; }
        }

        private int mDrgFormId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DrgFormId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DrgFormIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"FDBRouteCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBRouteCode
        {
        get { return mFDBRouteCode; }
        set { mFDBRouteCode = value; }
        }

        private bool mFDBRouteCodeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"FDBRouteCodeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FDBRouteCodeSpecified
        {
        get { return mFDBRouteCodeSpecified; }
        set { mFDBRouteCodeSpecified = value; }
        }

        private string mStrength
            = "";
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"Strength", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Strength
        {
        get { return mStrength; }
        set { mStrength = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mStrengthComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"StrengthComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator StrengthComparisonOperator
        {
        get { return mStrengthComparisonOperator; }
        set { mStrengthComparisonOperator = value; }
        }

        private bool mPackage
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"Package", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Package
        {
        get { return mPackage; }
        set { mPackage = value; }
        }

        private bool mPackageSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"PackageSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PackageSpecified
        {
        get { return mPackageSpecified; }
        set { mPackageSpecified = value; }
        }

        private string mSchedule
            = "";
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"Schedule", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Schedule
        {
        get { return mSchedule; }
        set { mSchedule = value; }
        }

        private bool mScheduleSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"ScheduleSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScheduleSpecified
        {
        get { return mScheduleSpecified; }
        set { mScheduleSpecified = value; }
        }

        private bool mReportable
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"Reportable", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Reportable
        {
        get { return mReportable; }
        set { mReportable = value; }
        }

        private bool mReportableSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"ReportableSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ReportableSpecified
        {
        get { return mReportableSpecified; }
        set { mReportableSpecified = value; }
        }

        private int mPriceGroupId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"PriceGroupId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"PriceGroupIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"ExpiryDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"ExpiryDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"FollowupDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"FollowupDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FollowupDaysSpecified
        {
        get { return mFollowupDaysSpecified; }
        set { mFollowupDaysSpecified = value; }
        }

        private string mEquivTo
            = "";
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"EquivTo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string EquivTo
        {
        get { return mEquivTo; }
        set { mEquivTo = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mEquivToComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"EquivToComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator EquivToComparisonOperator
        {
        get { return mEquivToComparisonOperator; }
        set { mEquivToComparisonOperator = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrgOralWritten mOralWritten
            = Kroll.Pharmacy.Api.Data.DrgOralWritten.DrgOralWritten_NotSpecified;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"OralWritten", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrgOralWritten.DrgOralWritten_NotSpecified)]
        
        public Kroll.Pharmacy.Api.Data.DrgOralWritten OralWritten
        {
        get { return mOralWritten; }
        set { mOralWritten = value; }
        }

        private bool mOralWrittenSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"OralWrittenSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OralWrittenSpecified
        {
        get { return mOralWrittenSpecified; }
        set { mOralWrittenSpecified = value; }
        }

        private int mSubstituteDrgId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"SubstituteDrgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"SubstituteDrgIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SubstituteDrgIdSpecified
        {
        get { return mSubstituteDrgIdSpecified; }
        set { mSubstituteDrgIdSpecified = value; }
        }

        private bool mIsWardStock
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"IsWardStock", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsWardStock
        {
        get { return mIsWardStock; }
        set { mIsWardStock = value; }
        }

        private bool mIsWardStockSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"IsWardStockSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsWardStockSpecified
        {
        get { return mIsWardStockSpecified; }
        set { mIsWardStockSpecified = value; }
        }

        private bool mIsFlavorRx
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"IsFlavorRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsFlavorRx
        {
        get { return mIsFlavorRx; }
        set { mIsFlavorRx = value; }
        }

        private bool mIsFlavorRxSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"IsFlavorRxSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsFlavorRxSpecified
        {
        get { return mIsFlavorRxSpecified; }
        set { mIsFlavorRxSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink CentralMaintLink
        {
        get { return mCentralMaintLink; }
        set { mCentralMaintLink = value; }
        }

        private bool mCentralMaintLinkSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"CentralMaintLinkSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CentralMaintLinkSpecified
        {
        get { return mCentralMaintLinkSpecified; }
        set { mCentralMaintLinkSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.BrandGenericType mBrandGenericType
            = Kroll.Pharmacy.Api.Data.BrandGenericType.BrandGenericType_Unknown;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"BrandGenericType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.BrandGenericType.BrandGenericType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.BrandGenericType BrandGenericType
        {
        get { return mBrandGenericType; }
        set { mBrandGenericType = value; }
        }

        private bool mBrandGenericTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"BrandGenericTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BrandGenericTypeSpecified
        {
        get { return mBrandGenericTypeSpecified; }
        set { mBrandGenericTypeSpecified = value; }
        }

        private string mTADin
            = "";
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"TADin", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string TADin
        {
        get { return mTADin; }
        set { mTADin = value; }
        }

        private bool mTADinSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"TADinSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TADinSpecified
        {
        get { return mTADinSpecified; }
        set { mTADinSpecified = value; }
        }

        private int mDepartmentId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"DepartmentId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"DepartmentIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"DrugMessageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"DrugMessageIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"EligibleForCoupon", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EligibleForCoupon
        {
        get { return mEligibleForCoupon; }
        set { mEligibleForCoupon = value; }
        }

        private bool mEligibleForCouponSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"EligibleForCouponSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EligibleForCouponSpecified
        {
        get { return mEligibleForCouponSpecified; }
        set { mEligibleForCouponSpecified = value; }
        }

        private bool mIsDevice
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"IsDevice", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsDevice
        {
        get { return mIsDevice; }
        set { mIsDevice = value; }
        }

        private bool mIsDeviceSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"IsDeviceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsDeviceSpecified
        {
        get { return mIsDeviceSpecified; }
        set { mIsDeviceSpecified = value; }
        }

        private bool mIsImmunization
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"IsImmunization", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsImmunization
        {
        get { return mIsImmunization; }
        set { mIsImmunization = value; }
        }

        private bool mIsImmunizationSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"IsImmunizationSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsImmunizationSpecified
        {
        get { return mIsImmunizationSpecified; }
        set { mIsImmunizationSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.FeeForServiceType mFeeForServiceType
            = Kroll.Pharmacy.Api.Data.FeeForServiceType.FeeForServiceType_None;
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"FeeForServiceType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.FeeForServiceType.FeeForServiceType_None)]
        
        public Kroll.Pharmacy.Api.Data.FeeForServiceType FeeForServiceType
        {
        get { return mFeeForServiceType; }
        set { mFeeForServiceType = value; }
        }

        private bool mFeeForServiceTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"FeeForServiceTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FeeForServiceTypeSpecified
        {
        get { return mFeeForServiceTypeSpecified; }
        set { mFeeForServiceTypeSpecified = value; }
        }

        private string mExternalDrgReference
            = "";
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"ExternalDrgReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalDrgReference
        {
        get { return mExternalDrgReference; }
        set { mExternalDrgReference = value; }
        }

        private bool mExternalDrgReferenceSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"ExternalDrgReferenceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExternalDrgReferenceSpecified
        {
        get { return mExternalDrgReferenceSpecified; }
        set { mExternalDrgReferenceSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        