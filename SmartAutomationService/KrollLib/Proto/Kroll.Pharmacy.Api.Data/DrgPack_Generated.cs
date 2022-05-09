
        // Generated from: DrgPack.proto
        // Note: requires additional types generated from: DrgCatPackLink.proto
        // Note: requires additional types generated from: DrgPackInvHist.proto
        // Note: requires additional types generated from: DrgPackUpc.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrgPack")]
        public partial class DrgPack : global::ProtoBuf.IExtensible
        {
        public DrgPack() {}
        

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

        private int mDrgId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DrgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgId
        {
        get { return mDrgId; }
        set { mDrgId = value; }
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

        private string mDefaultUpc
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DefaultUpc", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DefaultUpc
        {
        get { return mDefaultUpc; }
        set { mDefaultUpc = value; }
        }

        private double mPackSize
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PackSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double PackSize
        {
        get { return mPackSize; }
        set { mPackSize = value; }
        }

        private string mPackType
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PackType", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PackType
        {
        get { return mPackType; }
        set { mPackType = value; }
        }

        private double mOnHandQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"OnHandQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double OnHandQty
        {
        get { return mOnHandQty; }
        set { mOnHandQty = value; }
        }

        private bool mOnHandQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"OnHandQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OnHandQtySpecified
        {
        get { return mOnHandQtySpecified; }
        set { mOnHandQtySpecified = value; }
        }

        private double mMinOnHandQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"MinOnHandQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MinOnHandQty
        {
        get { return mMinOnHandQty; }
        set { mMinOnHandQty = value; }
        }

        private bool mMinOnHandQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"MinOnHandQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MinOnHandQtySpecified
        {
        get { return mMinOnHandQtySpecified; }
        set { mMinOnHandQtySpecified = value; }
        }

        private double mMaxOnHandQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"MaxOnHandQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MaxOnHandQty
        {
        get { return mMaxOnHandQty; }
        set { mMaxOnHandQty = value; }
        }

        private bool mMaxOnHandQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"MaxOnHandQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MaxOnHandQtySpecified
        {
        get { return mMaxOnHandQtySpecified; }
        set { mMaxOnHandQtySpecified = value; }
        }

        private double mAcqCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"AcqCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AcqCost
        {
        get { return mAcqCost; }
        set { mAcqCost = value; }
        }

        private bool mAcqCostSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"AcqCostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AcqCostSpecified
        {
        get { return mAcqCostSpecified; }
        set { mAcqCostSpecified = value; }
        }

        private double mSellingCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"SellingCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SellingCost
        {
        get { return mSellingCost; }
        set { mSellingCost = value; }
        }

        private bool mSellingCostSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"SellingCostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SellingCostSpecified
        {
        get { return mSellingCostSpecified; }
        set { mSellingCostSpecified = value; }
        }

        private double mUserCost1
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"UserCost1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double UserCost1
        {
        get { return mUserCost1; }
        set { mUserCost1 = value; }
        }

        private bool mUserCost1Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"UserCost1Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost1Specified
        {
        get { return mUserCost1Specified; }
        set { mUserCost1Specified = value; }
        }

        private double mUserCost2
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"UserCost2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double UserCost2
        {
        get { return mUserCost2; }
        set { mUserCost2 = value; }
        }

        private bool mUserCost2Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"UserCost2Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost2Specified
        {
        get { return mUserCost2Specified; }
        set { mUserCost2Specified = value; }
        }

        private double mUserCost3
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"UserCost3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double UserCost3
        {
        get { return mUserCost3; }
        set { mUserCost3 = value; }
        }

        private bool mUserCost3Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"UserCost3Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost3Specified
        {
        get { return mUserCost3Specified; }
        set { mUserCost3Specified = value; }
        }

        private double mUserCost4
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(107, IsRequired = false, Name=@"UserCost4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double UserCost4
        {
        get { return mUserCost4; }
        set { mUserCost4 = value; }
        }

        private bool mUserCost4Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(108, IsRequired = false, Name=@"UserCost4Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost4Specified
        {
        get { return mUserCost4Specified; }
        set { mUserCost4Specified = value; }
        }

        private double mUserCost5
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(109, IsRequired = false, Name=@"UserCost5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double UserCost5
        {
        get { return mUserCost5; }
        set { mUserCost5 = value; }
        }

        private bool mUserCost5Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(110, IsRequired = false, Name=@"UserCost5Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost5Specified
        {
        get { return mUserCost5Specified; }
        set { mUserCost5Specified = value; }
        }

        private double mAcqCostChgdDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"AcqCostChgdDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AcqCostChgdDate
        {
        get { return mAcqCostChgdDate; }
        set { mAcqCostChgdDate = value; }
        }

        private bool mAcqCostChgdDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"AcqCostChgdDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AcqCostChgdDateSpecified
        {
        get { return mAcqCostChgdDateSpecified; }
        set { mAcqCostChgdDateSpecified = value; }
        }

        private double mSellingCostChgdDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"SellingCostChgdDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SellingCostChgdDate
        {
        get { return mSellingCostChgdDate; }
        set { mSellingCostChgdDate = value; }
        }

        private bool mSellingCostChgdDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"SellingCostChgdDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SellingCostChgdDateSpecified
        {
        get { return mSellingCostChgdDateSpecified; }
        set { mSellingCostChgdDateSpecified = value; }
        }

        private double mUserCost1ChgdDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"UserCost1ChgdDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double UserCost1ChgdDate
        {
        get { return mUserCost1ChgdDate; }
        set { mUserCost1ChgdDate = value; }
        }

        private bool mUserCost1ChgdDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"UserCost1ChgdDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost1ChgdDateSpecified
        {
        get { return mUserCost1ChgdDateSpecified; }
        set { mUserCost1ChgdDateSpecified = value; }
        }

        private double mUserCost2ChgdDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"UserCost2ChgdDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double UserCost2ChgdDate
        {
        get { return mUserCost2ChgdDate; }
        set { mUserCost2ChgdDate = value; }
        }

        private bool mUserCost2ChgdDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"UserCost2ChgdDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost2ChgdDateSpecified
        {
        get { return mUserCost2ChgdDateSpecified; }
        set { mUserCost2ChgdDateSpecified = value; }
        }

        private double mUserCost3ChgdDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"UserCost3ChgdDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double UserCost3ChgdDate
        {
        get { return mUserCost3ChgdDate; }
        set { mUserCost3ChgdDate = value; }
        }

        private bool mUserCost3ChgdDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"UserCost3ChgdDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost3ChgdDateSpecified
        {
        get { return mUserCost3ChgdDateSpecified; }
        set { mUserCost3ChgdDateSpecified = value; }
        }

        private double mUserCost4ChgdDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(111, IsRequired = false, Name=@"UserCost4ChgdDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double UserCost4ChgdDate
        {
        get { return mUserCost4ChgdDate; }
        set { mUserCost4ChgdDate = value; }
        }

        private bool mUserCost4ChgdDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(112, IsRequired = false, Name=@"UserCost4ChgdDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost4ChgdDateSpecified
        {
        get { return mUserCost4ChgdDateSpecified; }
        set { mUserCost4ChgdDateSpecified = value; }
        }

        private double mUserCost5ChgdDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(113, IsRequired = false, Name=@"UserCost5ChgdDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double UserCost5ChgdDate
        {
        get { return mUserCost5ChgdDate; }
        set { mUserCost5ChgdDate = value; }
        }

        private bool mUserCost5ChgdDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(114, IsRequired = false, Name=@"UserCost5ChgdDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost5ChgdDateSpecified
        {
        get { return mUserCost5ChgdDateSpecified; }
        set { mUserCost5ChgdDateSpecified = value; }
        }

        private double mLastAcqCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"LastAcqCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastAcqCost
        {
        get { return mLastAcqCost; }
        set { mLastAcqCost = value; }
        }

        private bool mLastAcqCostSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"LastAcqCostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastAcqCostSpecified
        {
        get { return mLastAcqCostSpecified; }
        set { mLastAcqCostSpecified = value; }
        }

        private double mLastSellingCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"LastSellingCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastSellingCost
        {
        get { return mLastSellingCost; }
        set { mLastSellingCost = value; }
        }

        private bool mLastSellingCostSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"LastSellingCostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastSellingCostSpecified
        {
        get { return mLastSellingCostSpecified; }
        set { mLastSellingCostSpecified = value; }
        }

        private double mLastUserCost1
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"LastUserCost1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastUserCost1
        {
        get { return mLastUserCost1; }
        set { mLastUserCost1 = value; }
        }

        private bool mLastUserCost1Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"LastUserCost1Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastUserCost1Specified
        {
        get { return mLastUserCost1Specified; }
        set { mLastUserCost1Specified = value; }
        }

        private double mLastUserCost2
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"LastUserCost2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastUserCost2
        {
        get { return mLastUserCost2; }
        set { mLastUserCost2 = value; }
        }

        private bool mLastUserCost2Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"LastUserCost2Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastUserCost2Specified
        {
        get { return mLastUserCost2Specified; }
        set { mLastUserCost2Specified = value; }
        }

        private double mLastUserCost3
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"LastUserCost3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastUserCost3
        {
        get { return mLastUserCost3; }
        set { mLastUserCost3 = value; }
        }

        private bool mLastUserCost3Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"LastUserCost3Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastUserCost3Specified
        {
        get { return mLastUserCost3Specified; }
        set { mLastUserCost3Specified = value; }
        }

        private double mLastUserCost4
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(115, IsRequired = false, Name=@"LastUserCost4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastUserCost4
        {
        get { return mLastUserCost4; }
        set { mLastUserCost4 = value; }
        }

        private bool mLastUserCost4Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(116, IsRequired = false, Name=@"LastUserCost4Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastUserCost4Specified
        {
        get { return mLastUserCost4Specified; }
        set { mLastUserCost4Specified = value; }
        }

        private double mLastUserCost5
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(117, IsRequired = false, Name=@"LastUserCost5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastUserCost5
        {
        get { return mLastUserCost5; }
        set { mLastUserCost5 = value; }
        }

        private bool mLastUserCost5Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(118, IsRequired = false, Name=@"LastUserCost5Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastUserCost5Specified
        {
        get { return mLastUserCost5Specified; }
        set { mLastUserCost5Specified = value; }
        }

        private string mLot
            = "";
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"Lot", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Lot
        {
        get { return mLot; }
        set { mLot = value; }
        }

        private double mExpiry
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"Expiry", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Expiry
        {
        get { return mExpiry; }
        set { mExpiry = value; }
        }

        private bool mExpirySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"ExpirySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExpirySpecified
        {
        get { return mExpirySpecified; }
        set { mExpirySpecified = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private double mLastUsedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"LastUsedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"LastUsedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastUsedDateSpecified
        {
        get { return mLastUsedDateSpecified; }
        set { mLastUsedDateSpecified = value; }
        }

        private int mExpiryDays
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"ExpiryDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"ExpiryDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExpiryDaysSpecified
        {
        get { return mExpiryDaysSpecified; }
        set { mExpiryDaysSpecified = value; }
        }

        private bool mDisableAutoOrder
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"DisableAutoOrder", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DisableAutoOrder
        {
        get { return mDisableAutoOrder; }
        set { mDisableAutoOrder = value; }
        }

        private bool mDisableInventoryAdjustments
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"DisableInventoryAdjustments", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DisableInventoryAdjustments
        {
        get { return mDisableInventoryAdjustments; }
        set { mDisableInventoryAdjustments = value; }
        }

        private double mMinDays
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"MinDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MinDays
        {
        get { return mMinDays; }
        set { mMinDays = value; }
        }

        private bool mMinDaysSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"MinDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MinDaysSpecified
        {
        get { return mMinDaysSpecified; }
        set { mMinDaysSpecified = value; }
        }

        private double mMaxDays
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"MaxDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MaxDays
        {
        get { return mMaxDays; }
        set { mMaxDays = value; }
        }

        private bool mMaxDaysSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"MaxDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MaxDaysSpecified
        {
        get { return mMaxDaysSpecified; }
        set { mMaxDaysSpecified = value; }
        }

        private int mMinScripts
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"MinScripts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MinScripts
        {
        get { return mMinScripts; }
        set { mMinScripts = value; }
        }

        private bool mMinScriptsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"MinScriptsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MinScriptsSpecified
        {
        get { return mMinScriptsSpecified; }
        set { mMinScriptsSpecified = value; }
        }

        private double mAvgRxQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"AvgRxQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AvgRxQty
        {
        get { return mAvgRxQty; }
        set { mAvgRxQty = value; }
        }

        private bool mAvgRxQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"AvgRxQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AvgRxQtySpecified
        {
        get { return mAvgRxQtySpecified; }
        set { mAvgRxQtySpecified = value; }
        }

        private double mAvgDailyUsage
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"AvgDailyUsage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AvgDailyUsage
        {
        get { return mAvgDailyUsage; }
        set { mAvgDailyUsage = value; }
        }

        private bool mAvgDailyUsageSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"AvgDailyUsageSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AvgDailyUsageSpecified
        {
        get { return mAvgDailyUsageSpecified; }
        set { mAvgDailyUsageSpecified = value; }
        }

        private double mLastAvgCalcDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(72, IsRequired = false, Name=@"LastAvgCalcDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastAvgCalcDate
        {
        get { return mLastAvgCalcDate; }
        set { mLastAvgCalcDate = value; }
        }

        private bool mLastAvgCalcDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(73, IsRequired = false, Name=@"LastAvgCalcDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastAvgCalcDateSpecified
        {
        get { return mLastAvgCalcDateSpecified; }
        set { mLastAvgCalcDateSpecified = value; }
        }

        private string mAcqCostChgdBy
            = "";
        [global::ProtoBuf.ProtoMember(74, IsRequired = false, Name=@"AcqCostChgdBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AcqCostChgdBy
        {
        get { return mAcqCostChgdBy; }
        set { mAcqCostChgdBy = value; }
        }

        private string mSellingCostChgdBy
            = "";
        [global::ProtoBuf.ProtoMember(75, IsRequired = false, Name=@"SellingCostChgdBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SellingCostChgdBy
        {
        get { return mSellingCostChgdBy; }
        set { mSellingCostChgdBy = value; }
        }

        private string mUserCost1ChgdBy
            = "";
        [global::ProtoBuf.ProtoMember(76, IsRequired = false, Name=@"UserCost1ChgdBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserCost1ChgdBy
        {
        get { return mUserCost1ChgdBy; }
        set { mUserCost1ChgdBy = value; }
        }

        private string mUserCost2ChgdBy
            = "";
        [global::ProtoBuf.ProtoMember(77, IsRequired = false, Name=@"UserCost2ChgdBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserCost2ChgdBy
        {
        get { return mUserCost2ChgdBy; }
        set { mUserCost2ChgdBy = value; }
        }

        private string mUserCost3ChgdBy
            = "";
        [global::ProtoBuf.ProtoMember(78, IsRequired = false, Name=@"UserCost3ChgdBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserCost3ChgdBy
        {
        get { return mUserCost3ChgdBy; }
        set { mUserCost3ChgdBy = value; }
        }

        private string mUserCost4ChgdBy
            = "";
        [global::ProtoBuf.ProtoMember(119, IsRequired = false, Name=@"UserCost4ChgdBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserCost4ChgdBy
        {
        get { return mUserCost4ChgdBy; }
        set { mUserCost4ChgdBy = value; }
        }

        private string mUserCost5ChgdBy
            = "";
        [global::ProtoBuf.ProtoMember(120, IsRequired = false, Name=@"UserCost5ChgdBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserCost5ChgdBy
        {
        get { return mUserCost5ChgdBy; }
        set { mUserCost5ChgdBy = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(80, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private int mBaseOrderingOn
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(81, IsRequired = false, Name=@"BaseOrderingOn", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int BaseOrderingOn
        {
        get { return mBaseOrderingOn; }
        set { mBaseOrderingOn = value; }
        }

        private bool mFrontStore
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(82, IsRequired = false, Name=@"FrontStore", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FrontStore
        {
        get { return mFrontStore; }
        set { mFrontStore = value; }
        }

        private int mOrderQtyMultiple
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(83, IsRequired = false, Name=@"OrderQtyMultiple", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OrderQtyMultiple
        {
        get { return mOrderQtyMultiple; }
        set { mOrderQtyMultiple = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(84, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(86, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private int mDrgPackTierId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(87, IsRequired = false, Name=@"DrgPackTierId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgPackTierId
        {
        get { return mDrgPackTierId; }
        set { mDrgPackTierId = value; }
        }

        private int mDefaultVendorId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(88, IsRequired = false, Name=@"DefaultVendorId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DefaultVendorId
        {
        get { return mDefaultVendorId; }
        set { mDefaultVendorId = value; }
        }

        private bool mDefaultVendorIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(89, IsRequired = false, Name=@"DefaultVendorIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DefaultVendorIdSpecified
        {
        get { return mDefaultVendorIdSpecified; }
        set { mDefaultVendorIdSpecified = value; }
        }

        private int mCentralMaintOverrideFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(90, IsRequired = false, Name=@"CentralMaintOverrideFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(91, IsRequired = false, Name=@"CentralMaintAllowOverrideFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintAllowOverrideFieldMask
        {
        get { return mCentralMaintAllowOverrideFieldMask; }
        set { mCentralMaintAllowOverrideFieldMask = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgCatPackLink> mCatalogLinks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgCatPackLink>();
        [global::ProtoBuf.ProtoMember(92, Name=@"CatalogLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgCatPackLink> CatalogLinks
        {
        get { return mCatalogLinks; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPackUpc> mDrgPackUpc = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPackUpc>();
        [global::ProtoBuf.ProtoMember(94, Name=@"DrgPackUpc", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgPackUpc> DrgPackUpc
        {
        get { return mDrgPackUpc; }
        }
    

        private double mLastCycleCountDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(95, IsRequired = false, Name=@"LastCycleCountDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastCycleCountDate
        {
        get { return mLastCycleCountDate; }
        set { mLastCycleCountDate = value; }
        }

        private bool mLastCycleCountDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(96, IsRequired = false, Name=@"LastCycleCountDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastCycleCountDateSpecified
        {
        get { return mLastCycleCountDateSpecified; }
        set { mLastCycleCountDateSpecified = value; }
        }

        private int mAcqCostChgdByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(97, IsRequired = false, Name=@"AcqCostChgdByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AcqCostChgdByUserId
        {
        get { return mAcqCostChgdByUserId; }
        set { mAcqCostChgdByUserId = value; }
        }

        private bool mAcqCostChgdByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(98, IsRequired = false, Name=@"AcqCostChgdByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AcqCostChgdByUserIdSpecified
        {
        get { return mAcqCostChgdByUserIdSpecified; }
        set { mAcqCostChgdByUserIdSpecified = value; }
        }

        private int mSellingCostChgdByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(99, IsRequired = false, Name=@"SellingCostChgdByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SellingCostChgdByUserId
        {
        get { return mSellingCostChgdByUserId; }
        set { mSellingCostChgdByUserId = value; }
        }

        private bool mSellingCostChgdByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(100, IsRequired = false, Name=@"SellingCostChgdByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SellingCostChgdByUserIdSpecified
        {
        get { return mSellingCostChgdByUserIdSpecified; }
        set { mSellingCostChgdByUserIdSpecified = value; }
        }

        private int mUserCost1ChgdByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(101, IsRequired = false, Name=@"UserCost1ChgdByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UserCost1ChgdByUserId
        {
        get { return mUserCost1ChgdByUserId; }
        set { mUserCost1ChgdByUserId = value; }
        }

        private bool mUserCost1ChgdByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(102, IsRequired = false, Name=@"UserCost1ChgdByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost1ChgdByUserIdSpecified
        {
        get { return mUserCost1ChgdByUserIdSpecified; }
        set { mUserCost1ChgdByUserIdSpecified = value; }
        }

        private int mUserCost2ChgdByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(103, IsRequired = false, Name=@"UserCost2ChgdByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UserCost2ChgdByUserId
        {
        get { return mUserCost2ChgdByUserId; }
        set { mUserCost2ChgdByUserId = value; }
        }

        private bool mUserCost2ChgdByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(104, IsRequired = false, Name=@"UserCost2ChgdByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost2ChgdByUserIdSpecified
        {
        get { return mUserCost2ChgdByUserIdSpecified; }
        set { mUserCost2ChgdByUserIdSpecified = value; }
        }

        private int mUserCost3ChgdByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(105, IsRequired = false, Name=@"UserCost3ChgdByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UserCost3ChgdByUserId
        {
        get { return mUserCost3ChgdByUserId; }
        set { mUserCost3ChgdByUserId = value; }
        }

        private bool mUserCost3ChgdByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(106, IsRequired = false, Name=@"UserCost3ChgdByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost3ChgdByUserIdSpecified
        {
        get { return mUserCost3ChgdByUserIdSpecified; }
        set { mUserCost3ChgdByUserIdSpecified = value; }
        }

        private int mUserCost4ChgdByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(121, IsRequired = false, Name=@"UserCost4ChgdByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UserCost4ChgdByUserId
        {
        get { return mUserCost4ChgdByUserId; }
        set { mUserCost4ChgdByUserId = value; }
        }

        private bool mUserCost4ChgdByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(122, IsRequired = false, Name=@"UserCost4ChgdByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost4ChgdByUserIdSpecified
        {
        get { return mUserCost4ChgdByUserIdSpecified; }
        set { mUserCost4ChgdByUserIdSpecified = value; }
        }

        private int mUserCost5ChgdByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(123, IsRequired = false, Name=@"UserCost5ChgdByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UserCost5ChgdByUserId
        {
        get { return mUserCost5ChgdByUserId; }
        set { mUserCost5ChgdByUserId = value; }
        }

        private bool mUserCost5ChgdByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(124, IsRequired = false, Name=@"UserCost5ChgdByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost5ChgdByUserIdSpecified
        {
        get { return mUserCost5ChgdByUserIdSpecified; }
        set { mUserCost5ChgdByUserIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        