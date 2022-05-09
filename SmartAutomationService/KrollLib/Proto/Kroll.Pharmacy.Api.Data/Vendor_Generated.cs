
        // Generated from: Vendor.proto
        // Note: requires additional types generated from: UniqueVendorId_Enum.proto
        // Note: requires additional types generated from: UpdateOtherCost_Enum.proto
        // Note: requires additional types generated from: UpdateUpc_Enum.proto
        // Note: requires additional types generated from: DefaultNoPOAction_Enum.proto
        // Note: requires additional types generated from: ElectronicOrderingType_Enum.proto
        // Note: requires additional types generated from: ElectronicReceivingType_Enum.proto
        // Note: requires additional types generated from: PurchaseOrderGroupingType_Enum.proto
        // Note: requires additional types generated from: PrintVendorOrderReportType_Enum.proto
        // Note: requires additional types generated from: PrintVendorReceiveReportType_Enum.proto
        // Note: requires additional types generated from: VendorStoreLink.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Vendor")]
        public partial class Vendor : global::ProtoBuf.IExtensible
        {
        public Vendor() {}
        

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

        private string mDescriptionLong
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DescriptionLong", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DescriptionLong
        {
        get { return mDescriptionLong; }
        set { mDescriptionLong = value; }
        }

        private double mMinimumOrderValue
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"MinimumOrderValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MinimumOrderValue
        {
        get { return mMinimumOrderValue; }
        set { mMinimumOrderValue = value; }
        }

        private bool mMinimumOrderValueSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"MinimumOrderValueSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MinimumOrderValueSpecified
        {
        get { return mMinimumOrderValueSpecified; }
        set { mMinimumOrderValueSpecified = value; }
        }

        private string mPhoneVoice
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PhoneVoice", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PhoneVoice
        {
        get { return mPhoneVoice; }
        set { mPhoneVoice = value; }
        }

        private string mPhoneFax
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"PhoneFax", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PhoneFax
        {
        get { return mPhoneFax; }
        set { mPhoneFax = value; }
        }

        private double mCatalogDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"CatalogDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CatalogDate
        {
        get { return mCatalogDate; }
        set { mCatalogDate = value; }
        }

        private bool mCatalogDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"CatalogDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CatalogDateSpecified
        {
        get { return mCatalogDateSpecified; }
        set { mCatalogDateSpecified = value; }
        }

        private bool mElectronicOrderingEnabled
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"ElectronicOrderingEnabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ElectronicOrderingEnabled
        {
        get { return mElectronicOrderingEnabled; }
        set { mElectronicOrderingEnabled = value; }
        }

        private bool mElectronicReceivingEnabled
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"ElectronicReceivingEnabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ElectronicReceivingEnabled
        {
        get { return mElectronicReceivingEnabled; }
        set { mElectronicReceivingEnabled = value; }
        }

        private Kroll.Pharmacy.Api.Data.UniqueVendorId mUniqueVendorId
            = Kroll.Pharmacy.Api.Data.UniqueVendorId.UniqueVendorId_None;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"UniqueVendorId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UniqueVendorId.UniqueVendorId_None)]
        
        public Kroll.Pharmacy.Api.Data.UniqueVendorId UniqueVendorId
        {
        get { return mUniqueVendorId; }
        set { mUniqueVendorId = value; }
        }

        private bool mAutoGenerateItemIds
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"AutoGenerateItemIds", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AutoGenerateItemIds
        {
        get { return mAutoGenerateItemIds; }
        set { mAutoGenerateItemIds = value; }
        }

        private string mDrgPackTierMapping
            = "";
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"DrgPackTierMapping", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgPackTierMapping
        {
        get { return mDrgPackTierMapping; }
        set { mDrgPackTierMapping = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private Kroll.Pharmacy.Api.Data.UpdateOtherCost mUpdateAcqCostOnCatalogLoad
            = Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"UpdateAcqCostOnCatalogLoad", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never)]
        
        public Kroll.Pharmacy.Api.Data.UpdateOtherCost UpdateAcqCostOnCatalogLoad
        {
        get { return mUpdateAcqCostOnCatalogLoad; }
        set { mUpdateAcqCostOnCatalogLoad = value; }
        }

        private Kroll.Pharmacy.Api.Data.UpdateOtherCost mUpdateSellingCostOnCatalogLoad
            = Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"UpdateSellingCostOnCatalogLoad", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never)]
        
        public Kroll.Pharmacy.Api.Data.UpdateOtherCost UpdateSellingCostOnCatalogLoad
        {
        get { return mUpdateSellingCostOnCatalogLoad; }
        set { mUpdateSellingCostOnCatalogLoad = value; }
        }

        private Kroll.Pharmacy.Api.Data.UpdateOtherCost mUpdateUserCost1OnCatalogLoad
            = Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"UpdateUserCost1OnCatalogLoad", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never)]
        
        public Kroll.Pharmacy.Api.Data.UpdateOtherCost UpdateUserCost1OnCatalogLoad
        {
        get { return mUpdateUserCost1OnCatalogLoad; }
        set { mUpdateUserCost1OnCatalogLoad = value; }
        }

        private Kroll.Pharmacy.Api.Data.UpdateOtherCost mUpdateUserCost4OnCatalogLoad
            = Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"UpdateUserCost4OnCatalogLoad", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never)]
        
        public Kroll.Pharmacy.Api.Data.UpdateOtherCost UpdateUserCost4OnCatalogLoad
        {
        get { return mUpdateUserCost4OnCatalogLoad; }
        set { mUpdateUserCost4OnCatalogLoad = value; }
        }

        private Kroll.Pharmacy.Api.Data.UpdateOtherCost mUpdateUserCost5OnCatalogLoad
            = Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"UpdateUserCost5OnCatalogLoad", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never)]
        
        public Kroll.Pharmacy.Api.Data.UpdateOtherCost UpdateUserCost5OnCatalogLoad
        {
        get { return mUpdateUserCost5OnCatalogLoad; }
        set { mUpdateUserCost5OnCatalogLoad = value; }
        }

        private Kroll.Pharmacy.Api.Data.UpdateOtherCost mUpdateAcqCostWhenReceiving
            = Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"UpdateAcqCostWhenReceiving", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never)]
        
        public Kroll.Pharmacy.Api.Data.UpdateOtherCost UpdateAcqCostWhenReceiving
        {
        get { return mUpdateAcqCostWhenReceiving; }
        set { mUpdateAcqCostWhenReceiving = value; }
        }

        private Kroll.Pharmacy.Api.Data.UpdateOtherCost mUpdateSellingCostWhenReceiving
            = Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"UpdateSellingCostWhenReceiving", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never)]
        
        public Kroll.Pharmacy.Api.Data.UpdateOtherCost UpdateSellingCostWhenReceiving
        {
        get { return mUpdateSellingCostWhenReceiving; }
        set { mUpdateSellingCostWhenReceiving = value; }
        }

        private Kroll.Pharmacy.Api.Data.UpdateOtherCost mUpdateUserCost1WhenReceiving
            = Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"UpdateUserCost1WhenReceiving", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never)]
        
        public Kroll.Pharmacy.Api.Data.UpdateOtherCost UpdateUserCost1WhenReceiving
        {
        get { return mUpdateUserCost1WhenReceiving; }
        set { mUpdateUserCost1WhenReceiving = value; }
        }

        private Kroll.Pharmacy.Api.Data.UpdateOtherCost mUpdateUserCost4WhenReceiving
            = Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"UpdateUserCost4WhenReceiving", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never)]
        
        public Kroll.Pharmacy.Api.Data.UpdateOtherCost UpdateUserCost4WhenReceiving
        {
        get { return mUpdateUserCost4WhenReceiving; }
        set { mUpdateUserCost4WhenReceiving = value; }
        }

        private Kroll.Pharmacy.Api.Data.UpdateOtherCost mUpdateUserCost5WhenReceiving
            = Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"UpdateUserCost5WhenReceiving", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UpdateOtherCost.UpdateOtherCost_Never)]
        
        public Kroll.Pharmacy.Api.Data.UpdateOtherCost UpdateUserCost5WhenReceiving
        {
        get { return mUpdateUserCost5WhenReceiving; }
        set { mUpdateUserCost5WhenReceiving = value; }
        }

        private bool mUpdateAcqCostOnCatalogLoadIncludeDrugsWithPositiveOnHandQty
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"UpdateAcqCostOnCatalogLoadIncludeDrugsWithPositiveOnHandQty", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UpdateAcqCostOnCatalogLoadIncludeDrugsWithPositiveOnHandQty
        {
        get { return mUpdateAcqCostOnCatalogLoadIncludeDrugsWithPositiveOnHandQty; }
        set { mUpdateAcqCostOnCatalogLoadIncludeDrugsWithPositiveOnHandQty = value; }
        }

        private Kroll.Pharmacy.Api.Data.UpdateUpc mUpdateUpcOnCatalogLoad
            = Kroll.Pharmacy.Api.Data.UpdateUpc.UpdateUpc_Never;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"UpdateUpcOnCatalogLoad", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UpdateUpc.UpdateUpc_Never)]
        
        public Kroll.Pharmacy.Api.Data.UpdateUpc UpdateUpcOnCatalogLoad
        {
        get { return mUpdateUpcOnCatalogLoad; }
        set { mUpdateUpcOnCatalogLoad = value; }
        }

        private bool mLinkUnlinkedCatalogItemsToDrgPacksOnCatalogLoad
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"LinkUnlinkedCatalogItemsToDrgPacksOnCatalogLoad", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LinkUnlinkedCatalogItemsToDrgPacksOnCatalogLoad
        {
        get { return mLinkUnlinkedCatalogItemsToDrgPacksOnCatalogLoad; }
        set { mLinkUnlinkedCatalogItemsToDrgPacksOnCatalogLoad = value; }
        }

        private Kroll.Pharmacy.Api.Data.UpdateUpc mAddDrgPackUpcsOnCatalogLoad
            = Kroll.Pharmacy.Api.Data.UpdateUpc.UpdateUpc_Never;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"AddDrgPackUpcsOnCatalogLoad", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UpdateUpc.UpdateUpc_Never)]
        
        public Kroll.Pharmacy.Api.Data.UpdateUpc AddDrgPackUpcsOnCatalogLoad
        {
        get { return mAddDrgPackUpcsOnCatalogLoad; }
        set { mAddDrgPackUpcsOnCatalogLoad = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.VendorStoreLink> mVendorStoreLink = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.VendorStoreLink>();
        [global::ProtoBuf.ProtoMember(34, Name=@"VendorStoreLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.VendorStoreLink> VendorStoreLink
        {
        get { return mVendorStoreLink; }
        }
    

        private Kroll.Pharmacy.Api.Data.DefaultNoPOAction mDefaultNoPOAction
            = Kroll.Pharmacy.Api.Data.DefaultNoPOAction.DefaultNoPOAction_SkipPO;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"DefaultNoPOAction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DefaultNoPOAction.DefaultNoPOAction_SkipPO)]
        
        public Kroll.Pharmacy.Api.Data.DefaultNoPOAction DefaultNoPOAction
        {
        get { return mDefaultNoPOAction; }
        set { mDefaultNoPOAction = value; }
        }

        private Kroll.Pharmacy.Api.Data.ElectronicOrderingType mElectronicOrderingType
            = Kroll.Pharmacy.Api.Data.ElectronicOrderingType.ElectronicOrderingType_None;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"ElectronicOrderingType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ElectronicOrderingType.ElectronicOrderingType_None)]
        
        public Kroll.Pharmacy.Api.Data.ElectronicOrderingType ElectronicOrderingType
        {
        get { return mElectronicOrderingType; }
        set { mElectronicOrderingType = value; }
        }

        private Kroll.Pharmacy.Api.Data.ElectronicReceivingType mElectronicReceivingType
            = Kroll.Pharmacy.Api.Data.ElectronicReceivingType.ElectronicReceivingType_None;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"ElectronicReceivingType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ElectronicReceivingType.ElectronicReceivingType_None)]
        
        public Kroll.Pharmacy.Api.Data.ElectronicReceivingType ElectronicReceivingType
        {
        get { return mElectronicReceivingType; }
        set { mElectronicReceivingType = value; }
        }

        private Kroll.Pharmacy.Api.Data.PurchaseOrderGroupingType mPOGrouping1
            = Kroll.Pharmacy.Api.Data.PurchaseOrderGroupingType.PurchaseOrderGroupingType_None;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"POGrouping1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PurchaseOrderGroupingType.PurchaseOrderGroupingType_None)]
        
        public Kroll.Pharmacy.Api.Data.PurchaseOrderGroupingType POGrouping1
        {
        get { return mPOGrouping1; }
        set { mPOGrouping1 = value; }
        }

        private Kroll.Pharmacy.Api.Data.PurchaseOrderGroupingType mPOGrouping2
            = Kroll.Pharmacy.Api.Data.PurchaseOrderGroupingType.PurchaseOrderGroupingType_None;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"POGrouping2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PurchaseOrderGroupingType.PurchaseOrderGroupingType_None)]
        
        public Kroll.Pharmacy.Api.Data.PurchaseOrderGroupingType POGrouping2
        {
        get { return mPOGrouping2; }
        set { mPOGrouping2 = value; }
        }

        private Kroll.Pharmacy.Api.Data.PrintVendorOrderReportType mPrintOrderReportReport
            = Kroll.Pharmacy.Api.Data.PrintVendorOrderReportType.PrintVendorOrderReportType_Yes;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"PrintOrderReportReport", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PrintVendorOrderReportType.PrintVendorOrderReportType_Yes)]
        
        public Kroll.Pharmacy.Api.Data.PrintVendorOrderReportType PrintOrderReportReport
        {
        get { return mPrintOrderReportReport; }
        set { mPrintOrderReportReport = value; }
        }

        private Kroll.Pharmacy.Api.Data.PrintVendorReceiveReportType mPrintReceiveReport
            = Kroll.Pharmacy.Api.Data.PrintVendorReceiveReportType.PrintVendorReceiveReportType_Yes;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"PrintReceiveReport", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PrintVendorReceiveReportType.PrintVendorReceiveReportType_Yes)]
        
        public Kroll.Pharmacy.Api.Data.PrintVendorReceiveReportType PrintReceiveReport
        {
        get { return mPrintReceiveReport; }
        set { mPrintReceiveReport = value; }
        }

        private bool mZeroReceiveUnfinishedPO
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"ZeroReceiveUnfinishedPO", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ZeroReceiveUnfinishedPO
        {
        get { return mZeroReceiveUnfinishedPO; }
        set { mZeroReceiveUnfinishedPO = value; }
        }

        private bool mAllowReReceiveOfZeroReceivedPO
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"AllowReReceiveOfZeroReceivedPO", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AllowReReceiveOfZeroReceivedPO
        {
        get { return mAllowReReceiveOfZeroReceivedPO; }
        set { mAllowReReceiveOfZeroReceivedPO = value; }
        }

        private int mCentralMaintFieldMask2
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"CentralMaintFieldMask2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask2
        {
        get { return mCentralMaintFieldMask2; }
        set { mCentralMaintFieldMask2 = value; }
        }

        private string mRamqSupplySource
            = "";
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"RamqSupplySource", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RamqSupplySource
        {
        get { return mRamqSupplySource; }
        set { mRamqSupplySource = value; }
        }

        private double mVendorMarkup
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"VendorMarkup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double VendorMarkup
        {
        get { return mVendorMarkup; }
        set { mVendorMarkup = value; }
        }

        private bool mVendorMarkupSpecfied
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"VendorMarkupSpecfied", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool VendorMarkupSpecfied
        {
        get { return mVendorMarkupSpecfied; }
        set { mVendorMarkupSpecfied = value; }
        }

        private double mVendorMarkupCap
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"VendorMarkupCap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double VendorMarkupCap
        {
        get { return mVendorMarkupCap; }
        set { mVendorMarkupCap = value; }
        }

        private bool mVendorMarkupCapSpecfied
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"VendorMarkupCapSpecfied", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool VendorMarkupCapSpecfied
        {
        get { return mVendorMarkupCapSpecfied; }
        set { mVendorMarkupCapSpecfied = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        