
        // Generated from: DrgAlertMast.proto
        // Note: requires additional types generated from: DrgAlertType_Enum.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrgAlertMast")]
        public partial class DrgAlertMast : global::ProtoBuf.IExtensible
        {
        public DrgAlertMast() {}
        

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

        private Kroll.Pharmacy.Api.Data.DrgAlertType mDrgAlertType
            = Kroll.Pharmacy.Api.Data.DrgAlertType.DrgAlertType_Unknown;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DrgAlertType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrgAlertType.DrgAlertType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.DrgAlertType DrgAlertType
        {
        get { return mDrgAlertType; }
        set { mDrgAlertType = value; }
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

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private string mMessage
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Message", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Message
        {
        get { return mMessage; }
        set { mMessage = value; }
        }

        private int mAlertLevel
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"AlertLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AlertLevel
        {
        get { return mAlertLevel; }
        set { mAlertLevel = value; }
        }

        private bool mApplyToAllPatients
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ApplyToAllPatients", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ApplyToAllPatients
        {
        get { return mApplyToAllPatients; }
        set { mApplyToAllPatients = value; }
        }

        private string mSex
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Sex", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Sex
        {
        get { return mSex; }
        set { mSex = value; }
        }

        private bool mApplyToAnimals
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"ApplyToAnimals", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ApplyToAnimals
        {
        get { return mApplyToAnimals; }
        set { mApplyToAnimals = value; }
        }

        private int mOnlyAlertForDataNewerThanXDaysAgo
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"OnlyAlertForDataNewerThanXDaysAgo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OnlyAlertForDataNewerThanXDaysAgo
        {
        get { return mOnlyAlertForDataNewerThanXDaysAgo; }
        set { mOnlyAlertForDataNewerThanXDaysAgo = value; }
        }

        private bool mOnlyAlertForDataNewerThanXDaysAgoSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"OnlyAlertForDataNewerThanXDaysAgoSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OnlyAlertForDataNewerThanXDaysAgoSpecified
        {
        get { return mOnlyAlertForDataNewerThanXDaysAgoSpecified; }
        set { mOnlyAlertForDataNewerThanXDaysAgoSpecified = value; }
        }

        private bool mApplyToFirstFills
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"ApplyToFirstFills", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ApplyToFirstFills
        {
        get { return mApplyToFirstFills; }
        set { mApplyToFirstFills = value; }
        }

        private bool mApplyToRefills
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"ApplyToRefills", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ApplyToRefills
        {
        get { return mApplyToRefills; }
        set { mApplyToRefills = value; }
        }

        private bool mApplyToUnfills
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"ApplyToUnfills", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ApplyToUnfills
        {
        get { return mApplyToUnfills; }
        set { mApplyToUnfills = value; }
        }

        private bool mApplyToNotDispensed
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ApplyToNotDispensed", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ApplyToNotDispensed
        {
        get { return mApplyToNotDispensed; }
        set { mApplyToNotDispensed = value; }
        }

        private bool mApplyToStockTransfers
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ApplyToStockTransfers", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ApplyToStockTransfers
        {
        get { return mApplyToStockTransfers; }
        set { mApplyToStockTransfers = value; }
        }

        private double mMinValue1
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"MinValue1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MinValue1
        {
        get { return mMinValue1; }
        set { mMinValue1 = value; }
        }

        private bool mMinValue1Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"MinValue1Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MinValue1Specified
        {
        get { return mMinValue1Specified; }
        set { mMinValue1Specified = value; }
        }

        private double mMaxValue1
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"MaxValue1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MaxValue1
        {
        get { return mMaxValue1; }
        set { mMaxValue1 = value; }
        }

        private bool mMaxValue1Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"MaxValue1Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MaxValue1Specified
        {
        get { return mMaxValue1Specified; }
        set { mMaxValue1Specified = value; }
        }

        private double mMinValue2
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"MinValue2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MinValue2
        {
        get { return mMinValue2; }
        set { mMinValue2 = value; }
        }

        private bool mMinValue2Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"MinValue2Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MinValue2Specified
        {
        get { return mMinValue2Specified; }
        set { mMinValue2Specified = value; }
        }

        private double mMaxValue2
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"MaxValue2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MaxValue2
        {
        get { return mMaxValue2; }
        set { mMaxValue2 = value; }
        }

        private bool mMaxValue2Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"MaxValue2Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MaxValue2Specified
        {
        get { return mMaxValue2Specified; }
        set { mMaxValue2Specified = value; }
        }

        private double mMinValue3
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"MinValue3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MinValue3
        {
        get { return mMinValue3; }
        set { mMinValue3 = value; }
        }

        private bool mMinValue3Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"MinValue3Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MinValue3Specified
        {
        get { return mMinValue3Specified; }
        set { mMinValue3Specified = value; }
        }

        private double mMaxValue3
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"MaxValue3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MaxValue3
        {
        get { return mMaxValue3; }
        set { mMaxValue3 = value; }
        }

        private bool mMaxValue3Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"MaxValue3Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MaxValue3Specified
        {
        get { return mMaxValue3Specified; }
        set { mMaxValue3Specified = value; }
        }

        private double mMinAge
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"MinAge", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MinAge
        {
        get { return mMinAge; }
        set { mMinAge = value; }
        }

        private bool mMinAgeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"MinAgeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MinAgeSpecified
        {
        get { return mMinAgeSpecified; }
        set { mMinAgeSpecified = value; }
        }

        private double mMaxAge
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"MaxAge", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MaxAge
        {
        get { return mMaxAge; }
        set { mMaxAge = value; }
        }

        private bool mMaxAgeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"MaxAgeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MaxAgeSpecified
        {
        get { return mMaxAgeSpecified; }
        set { mMaxAgeSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        