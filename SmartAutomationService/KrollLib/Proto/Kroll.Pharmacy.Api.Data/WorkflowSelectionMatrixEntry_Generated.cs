
        // Generated from: WorkflowSelectionMatrixEntry.proto
        // Note: requires additional types generated from: WorkflowSelectionMatrixChoice_Enum.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorkflowSelectionMatrixEntry")]
        public partial class WorkflowSelectionMatrixEntry : global::ProtoBuf.IExtensible
        {
        public WorkflowSelectionMatrixEntry() {}
        

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

        private int mWorkflowSelectionMatrixId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"WorkflowSelectionMatrixId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int WorkflowSelectionMatrixId
        {
        get { return mWorkflowSelectionMatrixId; }
        set { mWorkflowSelectionMatrixId = value; }
        }

        private int mRxWorkflowType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"RxWorkflowType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxWorkflowType
        {
        get { return mRxWorkflowType; }
        set { mRxWorkflowType = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private bool mStoreIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"StoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StoreIdSpecified
        {
        get { return mStoreIdSpecified; }
        set { mStoreIdSpecified = value; }
        }

        private int mSortOrder
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"SortOrder", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SortOrder
        {
        get { return mSortOrder; }
        set { mSortOrder = value; }
        }

        private int mWorkflowId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"WorkflowId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int WorkflowId
        {
        get { return mWorkflowId; }
        set { mWorkflowId = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsFill
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"IsFill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsFill
        {
        get { return mIsFill; }
        set { mIsFill = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsUnfill
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"IsUnfill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsUnfill
        {
        get { return mIsUnfill; }
        set { mIsUnfill = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsNotDispensed
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"IsNotDispensed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsNotDispensed
        {
        get { return mIsNotDispensed; }
        set { mIsNotDispensed = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsFeeForService
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"IsFeeForService", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsFeeForService
        {
        get { return mIsFeeForService; }
        set { mIsFeeForService = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsStockTransfer
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"IsStockTransfer", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsStockTransfer
        {
        get { return mIsStockTransfer; }
        set { mIsStockTransfer = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsNewRxWithUnfill
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"IsNewRxWithUnfill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsNewRxWithUnfill
        {
        get { return mIsNewRxWithUnfill; }
        set { mIsNewRxWithUnfill = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsNewRxWithoutUnfill
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"IsNewRxWithoutUnfill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsNewRxWithoutUnfill
        {
        get { return mIsNewRxWithoutUnfill; }
        set { mIsNewRxWithoutUnfill = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsRefill
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"IsRefill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsRefill
        {
        get { return mIsRefill; }
        set { mIsRefill = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsUnitDose
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"IsUnitDose", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsUnitDose
        {
        get { return mIsUnitDose; }
        set { mIsUnitDose = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsWardStock
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"IsWardStock", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsWardStock
        {
        get { return mIsWardStock; }
        set { mIsWardStock = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsNHBatchFill
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"IsNHBatchFill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsNHBatchFill
        {
        get { return mIsNHBatchFill; }
        set { mIsNHBatchFill = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsMixture
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"IsMixture", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsMixture
        {
        get { return mIsMixture; }
        set { mIsMixture = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsCentralFill
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"IsCentralFill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsCentralFill
        {
        get { return mIsCentralFill; }
        set { mIsCentralFill = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsNarcotic
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"IsNarcotic", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsNarcotic
        {
        get { return mIsNarcotic; }
        set { mIsNarcotic = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsMethadone
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"IsMethadone", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsMethadone
        {
        get { return mIsMethadone; }
        set { mIsMethadone = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsIV
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"IsIV", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsIV
        {
        get { return mIsIV; }
        set { mIsIV = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsNHRx
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"IsNHRx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsNHRx
        {
        get { return mIsNHRx; }
        set { mIsNHRx = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsRetailNHType
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"IsRetailNHType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsRetailNHType
        {
        get { return mIsRetailNHType; }
        set { mIsRetailNHType = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsRoboticEligible
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"IsRoboticEligible", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsRoboticEligible
        {
        get { return mIsRoboticEligible; }
        set { mIsRoboticEligible = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsMultiDosePackaged
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"IsMultiDosePackaged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsMultiDosePackaged
        {
        get { return mIsMultiDosePackaged; }
        set { mIsMultiDosePackaged = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsDeliveryRoutePickup
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"IsDeliveryRoutePickup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsDeliveryRoutePickup
        {
        get { return mIsDeliveryRoutePickup; }
        set { mIsDeliveryRoutePickup = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsDeliveryRouteStoreDelivery
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"IsDeliveryRouteStoreDelivery", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsDeliveryRouteStoreDelivery
        {
        get { return mIsDeliveryRouteStoreDelivery; }
        set { mIsDeliveryRouteStoreDelivery = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsDeliveryRouteMailOrderCourier
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"IsDeliveryRouteMailOrderCourier", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsDeliveryRouteMailOrderCourier
        {
        get { return mIsDeliveryRouteMailOrderCourier; }
        set { mIsDeliveryRouteMailOrderCourier = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mWasNHBatchFilled
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"WasNHBatchFilled", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice WasNHBatchFilled
        {
        get { return mWasNHBatchFilled; }
        set { mWasNHBatchFilled = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mWasAutoFillBatchFilled
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"WasAutoFillBatchFilled", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice WasAutoFillBatchFilled
        {
        get { return mWasAutoFillBatchFilled; }
        set { mWasAutoFillBatchFilled = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mWasFilledInteractively
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"WasFilledInteractively", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice WasFilledInteractively
        {
        get { return mWasFilledInteractively; }
        set { mWasFilledInteractively = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsScheduleNarcotic
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"IsScheduleNarcotic", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsScheduleNarcotic
        {
        get { return mIsScheduleNarcotic; }
        set { mIsScheduleNarcotic = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsScheduleControlled
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"IsScheduleControlled", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsScheduleControlled
        {
        get { return mIsScheduleControlled; }
        set { mIsScheduleControlled = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsScheduleTargeted
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"IsScheduleTargeted", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsScheduleTargeted
        {
        get { return mIsScheduleTargeted; }
        set { mIsScheduleTargeted = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice mIsImmunization
            = Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"IsImmunization", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice.WorkflowSelectionMatrixChoice_Ignore)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowSelectionMatrixChoice IsImmunization
        {
        get { return mIsImmunization; }
        set { mIsImmunization = value; }
        }

        private int mDrgGrpMastId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"DrgGrpMastId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgGrpMastId
        {
        get { return mDrgGrpMastId; }
        set { mDrgGrpMastId = value; }
        }

        private bool mDrgGrpMastIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"DrgGrpMastIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrgGrpMastIdSpecified
        {
        get { return mDrgGrpMastIdSpecified; }
        set { mDrgGrpMastIdSpecified = value; }
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
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        