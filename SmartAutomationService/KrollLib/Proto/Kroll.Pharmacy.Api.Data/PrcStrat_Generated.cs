
        // Generated from: PrcStrat.proto
        // Note: requires additional types generated from: PriceLevel_Enum.proto
        // Note: requires additional types generated from: CostLevelType_Enum.proto
        // Note: requires additional types generated from: PrcStratType_Enum.proto
        // Note: requires additional types generated from: MarkupItem.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PrcStrat")]
        public partial class PrcStrat : global::ProtoBuf.IExtensible
        {
        public PrcStrat() {}
        

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

        private string mName
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Name
        {
        get { return mName; }
        set { mName = value; }
        }

        private double mFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Fee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Fee
        {
        get { return mFee; }
        set { mFee = value; }
        }

        private bool mFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"FeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FeeSpecified
        {
        get { return mFeeSpecified; }
        set { mFeeSpecified = value; }
        }

        private string mCorporateId
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"CorporateId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CorporateId
        {
        get { return mCorporateId; }
        set { mCorporateId = value; }
        }

        private int mCostLevels
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"CostLevels", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CostLevels
        {
        get { return mCostLevels; }
        set { mCostLevels = value; }
        }

        private Kroll.Pharmacy.Api.Data.CostLevelType mCostLevelType
            = Kroll.Pharmacy.Api.Data.CostLevelType.CostLevelType_Highest;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"CostLevelType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CostLevelType.CostLevelType_Highest)]
        
        public Kroll.Pharmacy.Api.Data.CostLevelType CostLevelType
        {
        get { return mCostLevelType; }
        set { mCostLevelType = value; }
        }

        private bool mPurchaseCostLevel
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"PurchaseCostLevel", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PurchaseCostLevel
        {
        get { return mPurchaseCostLevel; }
        set { mPurchaseCostLevel = value; }
        }

        private bool mSellingCostLevel
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"SellingCostLevel", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SellingCostLevel
        {
        get { return mSellingCostLevel; }
        set { mSellingCostLevel = value; }
        }

        private bool mUserCost1CostLevel
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"UserCost1CostLevel", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost1CostLevel
        {
        get { return mUserCost1CostLevel; }
        set { mUserCost1CostLevel = value; }
        }

        private bool mUserCost2CostLevel
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"UserCost2CostLevel", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost2CostLevel
        {
        get { return mUserCost2CostLevel; }
        set { mUserCost2CostLevel = value; }
        }

        private bool mUserCost3CostLevel
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"UserCost3CostLevel", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserCost3CostLevel
        {
        get { return mUserCost3CostLevel; }
        set { mUserCost3CostLevel = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink CentralMaintLink
        {
        get { return mCentralMaintLink; }
        set { mCentralMaintLink = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MarkupItem> mMarkupItems = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MarkupItem>();
        [global::ProtoBuf.ProtoMember(18, Name=@"MarkupItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MarkupItem> MarkupItems
        {
        get { return mMarkupItems; }
        }
    

        private Kroll.Pharmacy.Api.Data.PrcStratType mPrcStratType
            = Kroll.Pharmacy.Api.Data.PrcStratType.PrcStratType_Regular;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"PrcStratType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PrcStratType.PrcStratType_Regular)]
        
        public Kroll.Pharmacy.Api.Data.PrcStratType PrcStratType
        {
        get { return mPrcStratType; }
        set { mPrcStratType = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        