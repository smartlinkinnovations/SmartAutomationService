
        // Generated from: Rx.proto
        // Note: requires additional types generated from: ProductSelection_Enum.proto
        // Note: requires additional types generated from: RxOralWritten_Enum.proto
        // Note: requires additional types generated from: RxStatus_Enum.proto
        // Note: requires additional types generated from: RxAdjState_Enum.proto
        // Note: requires additional types generated from: DrugLabelName_Enum.proto
        // Note: requires additional types generated from: FeeForServiceType_Enum.proto
        // Note: requires additional types generated from: NHUnitDoseType_Enum.proto
        // Note: requires additional types generated from: RxAutoRefillRequested_Enum.proto
        // Note: requires additional types generated from: RxPickupNotificationRequested_Enum.proto
        // Note: requires additional types generated from: CopyRxReason_Enum.proto
        // Note: requires additional types generated from: CeRxOrderType_Enum.proto
        // Note: requires additional types generated from: RxCancelRefillType_Enum.proto
        // Note: requires additional types generated from: RxCounselingRequired_Enum.proto
        // Note: requires additional types generated from: RxCounselingResponse_Enum.proto
        // Note: requires additional types generated from: RxCounselingReason_Enum.proto
        // Note: requires additional types generated from: ChargeToAR_Enum.proto
        // Note: requires additional types generated from: NHBatchType_Enum.proto
        // Note: requires additional types generated from: CompressionType_Enum.proto
        // Note: requires additional types generated from: IdentificationRequiredOnDelivery_Enum.proto
        // Note: requires additional types generated from: PrescriptiveAuthority_Enum.proto
        // Note: requires additional types generated from: RxCom.proto
        // Note: requires additional types generated from: RxIndications.proto
        // Note: requires additional types generated from: RxLot.proto
        // Note: requires additional types generated from: RxMix.proto
        // Note: requires additional types generated from: RxPasstime.proto
        // Note: requires additional types generated from: RxPln.proto
        // Note: requires additional types generated from: RxPack.proto
        // Note: requires additional types generated from: CFRxOrder.proto
        // Note: requires additional types generated from: RxTracking.proto
        // Note: requires additional types generated from: RxSuspend.proto
        // Note: requires additional types generated from: RxTransfer.proto
        // Note: requires additional types generated from: RxWorkflow.proto
        // Note: requires additional types generated from: RxScriptImage.proto
        // Note: requires additional types generated from: ExternalRxLink.proto
        // Note: requires additional types generated from: TreatmentType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Rx")]
        public partial class Rx : global::ProtoBuf.IExtensible
        {
        public Rx() {}
        

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

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private int mDrgId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DrgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgId
        {
        get { return mDrgId; }
        set { mDrgId = value; }
        }

        private bool mDrgIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DrgIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrgIdSpecified
        {
        get { return mDrgIdSpecified; }
        set { mDrgIdSpecified = value; }
        }

        private int mMixId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"MixId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MixId
        {
        get { return mMixId; }
        set { mMixId = value; }
        }

        private bool mMixIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"MixIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MixIdSpecified
        {
        get { return mMixIdSpecified; }
        set { mMixIdSpecified = value; }
        }

        private int mDocId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DocId
        {
        get { return mDocId; }
        set { mDocId = value; }
        }

        private int mOrigRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"OrigRxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OrigRxNum
        {
        get { return mOrigRxNum; }
        set { mOrigRxNum = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private string mInit
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Init", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Init
        {
        get { return mInit; }
        set { mInit = value; }
        }

        private double mFillDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"FillDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double FillDate
        {
        get { return mFillDate; }
        set { mFillDate = value; }
        }

        private double mCancelDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"CancelDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CancelDate
        {
        get { return mCancelDate; }
        set { mCancelDate = value; }
        }

        private bool mCancelDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"CancelDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CancelDateSpecified
        {
        get { return mCancelDateSpecified; }
        set { mCancelDateSpecified = value; }
        }

        private double mFirstFillDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"FirstFillDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double FirstFillDate
        {
        get { return mFirstFillDate; }
        set { mFirstFillDate = value; }
        }

        private bool mFirstFillDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"FirstFillDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FirstFillDateSpecified
        {
        get { return mFirstFillDateSpecified; }
        set { mFirstFillDateSpecified = value; }
        }

        private double mDispensingQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DispensingQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DispensingQty
        {
        get { return mDispensingQty; }
        set { mDispensingQty = value; }
        }

        private bool mDispensingQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DispensingQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DispensingQtySpecified
        {
        get { return mDispensingQtySpecified; }
        set { mDispensingQtySpecified = value; }
        }

        private double mNextFillQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"NextFillQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NextFillQty
        {
        get { return mNextFillQty; }
        set { mNextFillQty = value; }
        }

        private bool mNextFillQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"NextFillQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NextFillQtySpecified
        {
        get { return mNextFillQtySpecified; }
        set { mNextFillQtySpecified = value; }
        }

        private double mAuthorizedQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"AuthorizedQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AuthorizedQty
        {
        get { return mAuthorizedQty; }
        set { mAuthorizedQty = value; }
        }

        private bool mAuthorizedQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"AuthorizedQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AuthorizedQtySpecified
        {
        get { return mAuthorizedQtySpecified; }
        set { mAuthorizedQtySpecified = value; }
        }

        private double mRemainingQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"RemainingQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RemainingQty
        {
        get { return mRemainingQty; }
        set { mRemainingQty = value; }
        }

        private bool mRemainingQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"RemainingQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RemainingQtySpecified
        {
        get { return mRemainingQtySpecified; }
        set { mRemainingQtySpecified = value; }
        }

        private int mDaysSupply
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"DaysSupply", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DaysSupply
        {
        get { return mDaysSupply; }
        set { mDaysSupply = value; }
        }

        private bool mDaysSupplySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"DaysSupplySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DaysSupplySpecified
        {
        get { return mDaysSupplySpecified; }
        set { mDaysSupplySpecified = value; }
        }

        private int mLabels
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"Labels", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Labels
        {
        get { return mLabels; }
        set { mLabels = value; }
        }

        private Kroll.Pharmacy.Api.Data.ProductSelection mProductSelection
            = Kroll.Pharmacy.Api.Data.ProductSelection.ProductSelection_None;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"ProductSelection", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ProductSelection.ProductSelection_None)]
        
        public Kroll.Pharmacy.Api.Data.ProductSelection ProductSelection
        {
        get { return mProductSelection; }
        set { mProductSelection = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxOralWritten mOralWritten
            = Kroll.Pharmacy.Api.Data.RxOralWritten.RxOralWritten_Unknown;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"OralWritten", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxOralWritten.RxOralWritten_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.RxOralWritten OralWritten
        {
        get { return mOralWritten; }
        set { mOralWritten = value; }
        }

        private string mSig
            = "";
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"Sig", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Sig
        {
        get { return mSig; }
        set { mSig = value; }
        }

        private string mSigExpansion
            = "";
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"SigExpansion", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SigExpansion
        {
        get { return mSigExpansion; }
        set { mSigExpansion = value; }
        }

        private bool mSigExpansionSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"SigExpansionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SigExpansionSpecified
        {
        get { return mSigExpansionSpecified; }
        set { mSigExpansionSpecified = value; }
        }

        private string mDin
            = "";
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"Din", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Din
        {
        get { return mDin; }
        set { mDin = value; }
        }

        private double mPackSize
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"PackSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double PackSize
        {
        get { return mPackSize; }
        set { mPackSize = value; }
        }

        private bool mPackSizeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"PackSizeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PackSizeSpecified
        {
        get { return mPackSizeSpecified; }
        set { mPackSizeSpecified = value; }
        }

        private double mAac
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"Aac", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Aac
        {
        get { return mAac; }
        set { mAac = value; }
        }

        private bool mAacSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"AacSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AacSpecified
        {
        get { return mAacSpecified; }
        set { mAacSpecified = value; }
        }

        private double mCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"Cost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Cost
        {
        get { return mCost; }
        set { mCost = value; }
        }

        private bool mCostSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"CostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CostSpecified
        {
        get { return mCostSpecified; }
        set { mCostSpecified = value; }
        }

        private double mMarkup
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"Markup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Markup
        {
        get { return mMarkup; }
        set { mMarkup = value; }
        }

        private bool mMarkupSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"MarkupSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MarkupSpecified
        {
        get { return mMarkupSpecified; }
        set { mMarkupSpecified = value; }
        }

        private double mFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"Fee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"FeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FeeSpecified
        {
        get { return mFeeSpecified; }
        set { mFeeSpecified = value; }
        }

        private int mMixTime
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"MixTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MixTime
        {
        get { return mMixTime; }
        set { mMixTime = value; }
        }

        private bool mMixTimeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"MixTimeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MixTimeSpecified
        {
        get { return mMixTimeSpecified; }
        set { mMixTimeSpecified = value; }
        }

        private double mMixFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"MixFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MixFee
        {
        get { return mMixFee; }
        set { mMixFee = value; }
        }

        private bool mMixFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"MixFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MixFeeSpecified
        {
        get { return mMixFeeSpecified; }
        set { mMixFeeSpecified = value; }
        }

        private double mSscFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"SscFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SscFee
        {
        get { return mSscFee; }
        set { mSscFee = value; }
        }

        private bool mSscFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"SscFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SscFeeSpecified
        {
        get { return mSscFeeSpecified; }
        set { mSscFeeSpecified = value; }
        }

        private bool mManualPrice
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"ManualPrice", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ManualPrice
        {
        get { return mManualPrice; }
        set { mManualPrice = value; }
        }

        private bool mIsTrialRx
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"IsTrialRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsTrialRx
        {
        get { return mIsTrialRx; }
        set { mIsTrialRx = value; }
        }

        private bool mIsPartialFill
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"IsPartialFill", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsPartialFill
        {
        get { return mIsPartialFill; }
        set { mIsPartialFill = value; }
        }

        private double mDrugExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"DrugExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DrugExpiryDate
        {
        get { return mDrugExpiryDate; }
        set { mDrugExpiryDate = value; }
        }

        private bool mDrugExpiryDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"DrugExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrugExpiryDateSpecified
        {
        get { return mDrugExpiryDateSpecified; }
        set { mDrugExpiryDateSpecified = value; }
        }

        private double mStopDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"StopDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double StopDate
        {
        get { return mStopDate; }
        set { mStopDate = value; }
        }

        private bool mStopDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"StopDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StopDateSpecified
        {
        get { return mStopDateSpecified; }
        set { mStopDateSpecified = value; }
        }

        private double mRxExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"RxExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RxExpiryDate
        {
        get { return mRxExpiryDate; }
        set { mRxExpiryDate = value; }
        }

        private bool mRxExpiryDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"RxExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxExpiryDateSpecified
        {
        get { return mRxExpiryDateSpecified; }
        set { mRxExpiryDateSpecified = value; }
        }

        private double mFollowupDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"FollowupDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double FollowupDate
        {
        get { return mFollowupDate; }
        set { mFollowupDate = value; }
        }

        private bool mFollowupDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"FollowupDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FollowupDateSpecified
        {
        get { return mFollowupDateSpecified; }
        set { mFollowupDateSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxStatus mStatus
            = Kroll.Pharmacy.Api.Data.RxStatus.RxStatus_Unknown;
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxStatus.RxStatus_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.RxStatus Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private string mDocAddressLocation
            = "";
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"DocAddressLocation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DocAddressLocation
        {
        get { return mDocAddressLocation; }
        set { mDocAddressLocation = value; }
        }

        private bool mSplitQty
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"SplitQty", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SplitQty
        {
        get { return mSplitQty; }
        set { mSplitQty = value; }
        }

        private bool mSplitEvenly
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"SplitEvenly", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SplitEvenly
        {
        get { return mSplitEvenly; }
        set { mSplitEvenly = value; }
        }

        private string mLabelQtySplit
            = "";
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"LabelQtySplit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LabelQtySplit
        {
        get { return mLabelQtySplit; }
        set { mLabelQtySplit = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxAdjState mAdjState
            = Kroll.Pharmacy.Api.Data.RxAdjState.RxAdjState_NotAdjudicated;
        [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"AdjState", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxAdjState.RxAdjState_NotAdjudicated)]
        
        public Kroll.Pharmacy.Api.Data.RxAdjState AdjState
        {
        get { return mAdjState; }
        set { mAdjState = value; }
        }

        private bool mInactive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"Inactive", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Inactive
        {
        get { return mInactive; }
        set { mInactive = value; }
        }

        private int mCopiedTo
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"CopiedTo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CopiedTo
        {
        get { return mCopiedTo; }
        set { mCopiedTo = value; }
        }

        private bool mCopiedToSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"CopiedToSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CopiedToSpecified
        {
        get { return mCopiedToSpecified; }
        set { mCopiedToSpecified = value; }
        }

        private int mCopiedFrom
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"CopiedFrom", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CopiedFrom
        {
        get { return mCopiedFrom; }
        set { mCopiedFrom = value; }
        }

        private bool mCopiedFromSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(72, IsRequired = false, Name=@"CopiedFromSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CopiedFromSpecified
        {
        get { return mCopiedFromSpecified; }
        set { mCopiedFromSpecified = value; }
        }

        private double mTherapeuticStartDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(73, IsRequired = false, Name=@"TherapeuticStartDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TherapeuticStartDate
        {
        get { return mTherapeuticStartDate; }
        set { mTherapeuticStartDate = value; }
        }

        private bool mTherapeuticStartDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(74, IsRequired = false, Name=@"TherapeuticStartDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TherapeuticStartDateSpecified
        {
        get { return mTherapeuticStartDateSpecified; }
        set { mTherapeuticStartDateSpecified = value; }
        }

        private double mTransferredFromDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(75, IsRequired = false, Name=@"TransferredFromDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TransferredFromDate
        {
        get { return mTransferredFromDate; }
        set { mTransferredFromDate = value; }
        }

        private bool mTransferredFromDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(76, IsRequired = false, Name=@"TransferredFromDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TransferredFromDateSpecified
        {
        get { return mTransferredFromDateSpecified; }
        set { mTransferredFromDateSpecified = value; }
        }

        private double mTransferredToDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(77, IsRequired = false, Name=@"TransferredToDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TransferredToDate
        {
        get { return mTransferredToDate; }
        set { mTransferredToDate = value; }
        }

        private bool mTransferredToDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(78, IsRequired = false, Name=@"TransferredToDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TransferredToDateSpecified
        {
        get { return mTransferredToDateSpecified; }
        set { mTransferredToDateSpecified = value; }
        }

        private double mDiscountCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(79, IsRequired = false, Name=@"DiscountCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DiscountCost
        {
        get { return mDiscountCost; }
        set { mDiscountCost = value; }
        }

        private bool mDiscountCostSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(80, IsRequired = false, Name=@"DiscountCostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DiscountCostSpecified
        {
        get { return mDiscountCostSpecified; }
        set { mDiscountCostSpecified = value; }
        }

        private double mDiscountMarkup
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(81, IsRequired = false, Name=@"DiscountMarkup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DiscountMarkup
        {
        get { return mDiscountMarkup; }
        set { mDiscountMarkup = value; }
        }

        private bool mDiscountMarkupSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(82, IsRequired = false, Name=@"DiscountMarkupSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DiscountMarkupSpecified
        {
        get { return mDiscountMarkupSpecified; }
        set { mDiscountMarkupSpecified = value; }
        }

        private double mDiscountFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(83, IsRequired = false, Name=@"DiscountFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DiscountFee
        {
        get { return mDiscountFee; }
        set { mDiscountFee = value; }
        }

        private bool mDiscountFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(84, IsRequired = false, Name=@"DiscountFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DiscountFeeSpecified
        {
        get { return mDiscountFeeSpecified; }
        set { mDiscountFeeSpecified = value; }
        }

        private double mDiscountMixFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(85, IsRequired = false, Name=@"DiscountMixFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DiscountMixFee
        {
        get { return mDiscountMixFee; }
        set { mDiscountMixFee = value; }
        }

        private bool mDiscountMixFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(86, IsRequired = false, Name=@"DiscountMixFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DiscountMixFeeSpecified
        {
        get { return mDiscountMixFeeSpecified; }
        set { mDiscountMixFeeSpecified = value; }
        }

        private double mDiscountSscFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(87, IsRequired = false, Name=@"DiscountSscFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DiscountSscFee
        {
        get { return mDiscountSscFee; }
        set { mDiscountSscFee = value; }
        }

        private bool mDiscountSscFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(88, IsRequired = false, Name=@"DiscountSscFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DiscountSscFeeSpecified
        {
        get { return mDiscountSscFeeSpecified; }
        set { mDiscountSscFeeSpecified = value; }
        }

        private string mUserInit
            = "";
        [global::ProtoBuf.ProtoMember(89, IsRequired = false, Name=@"UserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserInit
        {
        get { return mUserInit; }
        set { mUserInit = value; }
        }

        private double mWrittenDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(90, IsRequired = false, Name=@"WrittenDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double WrittenDate
        {
        get { return mWrittenDate; }
        set { mWrittenDate = value; }
        }

        private bool mWrittenDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(91, IsRequired = false, Name=@"WrittenDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WrittenDateSpecified
        {
        get { return mWrittenDateSpecified; }
        set { mWrittenDateSpecified = value; }
        }

        private int mMinIntervalDays
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(92, IsRequired = false, Name=@"MinIntervalDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MinIntervalDays
        {
        get { return mMinIntervalDays; }
        set { mMinIntervalDays = value; }
        }

        private bool mMinIntervalDaysSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(93, IsRequired = false, Name=@"MinIntervalDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MinIntervalDaysSpecified
        {
        get { return mMinIntervalDaysSpecified; }
        set { mMinIntervalDaysSpecified = value; }
        }

        private double mBackdatedOnDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(94, IsRequired = false, Name=@"BackdatedOnDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double BackdatedOnDate
        {
        get { return mBackdatedOnDate; }
        set { mBackdatedOnDate = value; }
        }

        private bool mBackdatedOnDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(95, IsRequired = false, Name=@"BackdatedOnDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BackdatedOnDateSpecified
        {
        get { return mBackdatedOnDateSpecified; }
        set { mBackdatedOnDateSpecified = value; }
        }

        private int mPricingStrategyId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(96, IsRequired = false, Name=@"PricingStrategyId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PricingStrategyId
        {
        get { return mPricingStrategyId; }
        set { mPricingStrategyId = value; }
        }

        private bool mPricingStrategyIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(97, IsRequired = false, Name=@"PricingStrategyIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PricingStrategyIdSpecified
        {
        get { return mPricingStrategyIdSpecified; }
        set { mPricingStrategyIdSpecified = value; }
        }

        private string mCorporatePriceId
            = "";
        [global::ProtoBuf.ProtoMember(98, IsRequired = false, Name=@"CorporatePriceId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CorporatePriceId
        {
        get { return mCorporatePriceId; }
        set { mCorporatePriceId = value; }
        }

        private bool mARCharged
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(99, IsRequired = false, Name=@"ARCharged", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ARCharged
        {
        get { return mARCharged; }
        set { mARCharged = value; }
        }

        private bool mPosPending
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(100, IsRequired = false, Name=@"PosPending", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PosPending
        {
        get { return mPosPending; }
        set { mPosPending = value; }
        }

        private int mNHCycleId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(101, IsRequired = false, Name=@"NHCycleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHCycleId
        {
        get { return mNHCycleId; }
        set { mNHCycleId = value; }
        }

        private bool mNHCycleIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(102, IsRequired = false, Name=@"NHCycleIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHCycleIdSpecified
        {
        get { return mNHCycleIdSpecified; }
        set { mNHCycleIdSpecified = value; }
        }

        private bool mNHBatchFill
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(103, IsRequired = false, Name=@"NHBatchFill", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHBatchFill
        {
        get { return mNHBatchFill; }
        set { mNHBatchFill = value; }
        }

        private bool mNHUnitDose
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(104, IsRequired = false, Name=@"NHUnitDose", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHUnitDose
        {
        get { return mNHUnitDose; }
        set { mNHUnitDose = value; }
        }

        private bool mNHWardStock
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(105, IsRequired = false, Name=@"NHWardStock", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHWardStock
        {
        get { return mNHWardStock; }
        set { mNHWardStock = value; }
        }

        private int mNHMedTypeId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(106, IsRequired = false, Name=@"NHMedTypeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHMedTypeId
        {
        get { return mNHMedTypeId; }
        set { mNHMedTypeId = value; }
        }

        private bool mNHMedTypeIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(107, IsRequired = false, Name=@"NHMedTypeIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHMedTypeIdSpecified
        {
        get { return mNHMedTypeIdSpecified; }
        set { mNHMedTypeIdSpecified = value; }
        }

        private double mNHUnitDoseAnchorDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(108, IsRequired = false, Name=@"NHUnitDoseAnchorDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHUnitDoseAnchorDate
        {
        get { return mNHUnitDoseAnchorDate; }
        set { mNHUnitDoseAnchorDate = value; }
        }

        private bool mNHUnitDoseAnchorDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(109, IsRequired = false, Name=@"NHUnitDoseAnchorDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHUnitDoseAnchorDateSpecified
        {
        get { return mNHUnitDoseAnchorDateSpecified; }
        set { mNHUnitDoseAnchorDateSpecified = value; }
        }

        private int mNHLabels
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(110, IsRequired = false, Name=@"NHLabels", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHLabels
        {
        get { return mNHLabels; }
        set { mNHLabels = value; }
        }

        private bool mNHLabelsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(111, IsRequired = false, Name=@"NHLabelsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHLabelsSpecified
        {
        get { return mNHLabelsSpecified; }
        set { mNHLabelsSpecified = value; }
        }

        private int mScriptImageId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(112, IsRequired = false, Name=@"ScriptImageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ScriptImageId
        {
        get { return mScriptImageId; }
        set { mScriptImageId = value; }
        }

        private bool mScriptImageIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(113, IsRequired = false, Name=@"ScriptImageIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScriptImageIdSpecified
        {
        get { return mScriptImageIdSpecified; }
        set { mScriptImageIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrugLabelName mFirstDrugName
            = Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default;
        [global::ProtoBuf.ProtoMember(114, IsRequired = false, Name=@"FirstDrugName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default)]
        
        public Kroll.Pharmacy.Api.Data.DrugLabelName FirstDrugName
        {
        get { return mFirstDrugName; }
        set { mFirstDrugName = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrugLabelName mSecondDrugName
            = Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default;
        [global::ProtoBuf.ProtoMember(115, IsRequired = false, Name=@"SecondDrugName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default)]
        
        public Kroll.Pharmacy.Api.Data.DrugLabelName SecondDrugName
        {
        get { return mSecondDrugName; }
        set { mSecondDrugName = value; }
        }

        private int mPrintSigSmall
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(116, IsRequired = false, Name=@"PrintSigSmall", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PrintSigSmall
        {
        get { return mPrintSigSmall; }
        set { mPrintSigSmall = value; }
        }

        private bool mUnlimitedRefills
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(117, IsRequired = false, Name=@"UnlimitedRefills", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UnlimitedRefills
        {
        get { return mUnlimitedRefills; }
        set { mUnlimitedRefills = value; }
        }

        private string mNHComment
            = "";
        [global::ProtoBuf.ProtoMember(118, IsRequired = false, Name=@"NHComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHComment
        {
        get { return mNHComment; }
        set { mNHComment = value; }
        }

        private bool mRoboticPending
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(119, IsRequired = false, Name=@"RoboticPending", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RoboticPending
        {
        get { return mRoboticPending; }
        set { mRoboticPending = value; }
        }

        private double mNHBatchCycleStartDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(120, IsRequired = false, Name=@"NHBatchCycleStartDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHBatchCycleStartDate
        {
        get { return mNHBatchCycleStartDate; }
        set { mNHBatchCycleStartDate = value; }
        }

        private bool mNHBatchCycleStartDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(121, IsRequired = false, Name=@"NHBatchCycleStartDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHBatchCycleStartDateSpecified
        {
        get { return mNHBatchCycleStartDateSpecified; }
        set { mNHBatchCycleStartDateSpecified = value; }
        }

        private int mNHUnitDoseFreq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(122, IsRequired = false, Name=@"NHUnitDoseFreq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHUnitDoseFreq
        {
        get { return mNHUnitDoseFreq; }
        set { mNHUnitDoseFreq = value; }
        }

        private bool mNHUnitDoseFreqSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(123, IsRequired = false, Name=@"NHUnitDoseFreqSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHUnitDoseFreqSpecified
        {
        get { return mNHUnitDoseFreqSpecified; }
        set { mNHUnitDoseFreqSpecified = value; }
        }

        private int mNHCardNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(124, IsRequired = false, Name=@"NHCardNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHCardNum
        {
        get { return mNHCardNum; }
        set { mNHCardNum = value; }
        }

        private bool mNHCardNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(125, IsRequired = false, Name=@"NHCardNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHCardNumSpecified
        {
        get { return mNHCardNumSpecified; }
        set { mNHCardNumSpecified = value; }
        }

        private bool mAutoRefill
            = 
                default(bool)
            ;
        [global::System.Obsolete, global::ProtoBuf.ProtoMember(126, IsRequired = false, Name=@"AutoRefill", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AutoRefill
        {
        get { return mAutoRefill; }
        set { mAutoRefill = value; }
        }

        private bool mNHSplitQty
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(127, IsRequired = false, Name=@"NHSplitQty", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHSplitQty
        {
        get { return mNHSplitQty; }
        set { mNHSplitQty = value; }
        }

        private bool mNHSplitEvenly
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(128, IsRequired = false, Name=@"NHSplitEvenly", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHSplitEvenly
        {
        get { return mNHSplitEvenly; }
        set { mNHSplitEvenly = value; }
        }

        private string mNHLabelQtySplit
            = "";
        [global::ProtoBuf.ProtoMember(129, IsRequired = false, Name=@"NHLabelQtySplit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHLabelQtySplit
        {
        get { return mNHLabelQtySplit; }
        set { mNHLabelQtySplit = value; }
        }

        private bool mNHBatchUseBatchValues
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(130, IsRequired = false, Name=@"NHBatchUseBatchValues", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHBatchUseBatchValues
        {
        get { return mNHBatchUseBatchValues; }
        set { mNHBatchUseBatchValues = value; }
        }

        private double mNHBatchDailyDosage
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(131, IsRequired = false, Name=@"NHBatchDailyDosage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHBatchDailyDosage
        {
        get { return mNHBatchDailyDosage; }
        set { mNHBatchDailyDosage = value; }
        }

        private bool mNHBatchDailyDosageSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(132, IsRequired = false, Name=@"NHBatchDailyDosageSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHBatchDailyDosageSpecified
        {
        get { return mNHBatchDailyDosageSpecified; }
        set { mNHBatchDailyDosageSpecified = value; }
        }

        private int mNHBatchRegLabels
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(133, IsRequired = false, Name=@"NHBatchRegLabels", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHBatchRegLabels
        {
        get { return mNHBatchRegLabels; }
        set { mNHBatchRegLabels = value; }
        }

        private bool mNHBatchRegLabelsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(134, IsRequired = false, Name=@"NHBatchRegLabelsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHBatchRegLabelsSpecified
        {
        get { return mNHBatchRegLabelsSpecified; }
        set { mNHBatchRegLabelsSpecified = value; }
        }

        private int mNHBatchNHLabels
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(135, IsRequired = false, Name=@"NHBatchNHLabels", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHBatchNHLabels
        {
        get { return mNHBatchNHLabels; }
        set { mNHBatchNHLabels = value; }
        }

        private bool mNHBatchNHLabelsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(136, IsRequired = false, Name=@"NHBatchNHLabelsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHBatchNHLabelsSpecified
        {
        get { return mNHBatchNHLabelsSpecified; }
        set { mNHBatchNHLabelsSpecified = value; }
        }

        private int mPosTrigger
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(137, IsRequired = false, Name=@"PosTrigger", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PosTrigger
        {
        get { return mPosTrigger; }
        set { mPosTrigger = value; }
        }

        private double mMethadoneIngestDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(138, IsRequired = false, Name=@"MethadoneIngestDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MethadoneIngestDate
        {
        get { return mMethadoneIngestDate; }
        set { mMethadoneIngestDate = value; }
        }

        private bool mMethadoneIngestDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(139, IsRequired = false, Name=@"MethadoneIngestDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MethadoneIngestDateSpecified
        {
        get { return mMethadoneIngestDateSpecified; }
        set { mMethadoneIngestDateSpecified = value; }
        }

        private bool mIsHidden
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(140, IsRequired = false, Name=@"IsHidden", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsHidden
        {
        get { return mIsHidden; }
        set { mIsHidden = value; }
        }

        private string mNarcRefNum
            = "";
        [global::ProtoBuf.ProtoMember(141, IsRequired = false, Name=@"NarcRefNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NarcRefNum
        {
        get { return mNarcRefNum; }
        set { mNarcRefNum = value; }
        }

        private bool mIsMistake
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(142, IsRequired = false, Name=@"IsMistake", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsMistake
        {
        get { return mIsMistake; }
        set { mIsMistake = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(143, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private int mNHId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(144, IsRequired = false, Name=@"NHId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHId
        {
        get { return mNHId; }
        set { mNHId = value; }
        }

        private bool mNHIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(145, IsRequired = false, Name=@"NHIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHIdSpecified
        {
        get { return mNHIdSpecified; }
        set { mNHIdSpecified = value; }
        }

        private int mNHWardId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(146, IsRequired = false, Name=@"NHWardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHWardId
        {
        get { return mNHWardId; }
        set { mNHWardId = value; }
        }

        private bool mNHWardIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(147, IsRequired = false, Name=@"NHWardIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHWardIdSpecified
        {
        get { return mNHWardIdSpecified; }
        set { mNHWardIdSpecified = value; }
        }

        private double mRxChangedOnDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(150, IsRequired = false, Name=@"RxChangedOnDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RxChangedOnDate
        {
        get { return mRxChangedOnDate; }
        set { mRxChangedOnDate = value; }
        }

        private bool mRxChangedOnDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(151, IsRequired = false, Name=@"RxChangedOnDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxChangedOnDateSpecified
        {
        get { return mRxChangedOnDateSpecified; }
        set { mRxChangedOnDateSpecified = value; }
        }

        private int mDrgPackTierId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(152, IsRequired = false, Name=@"DrgPackTierId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgPackTierId
        {
        get { return mDrgPackTierId; }
        set { mDrgPackTierId = value; }
        }

        private int mWorkOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(153, IsRequired = false, Name=@"WorkOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int WorkOrderId
        {
        get { return mWorkOrderId; }
        set { mWorkOrderId = value; }
        }

        private bool mWorkOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(154, IsRequired = false, Name=@"WorkOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WorkOrderIdSpecified
        {
        get { return mWorkOrderIdSpecified; }
        set { mWorkOrderIdSpecified = value; }
        }

        private bool mForceReportable
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(155, IsRequired = false, Name=@"ForceReportable", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ForceReportable
        {
        get { return mForceReportable; }
        set { mForceReportable = value; }
        }

        private string mCeRxRxId
            = "";
        [global::ProtoBuf.ProtoMember(156, IsRequired = false, Name=@"CeRxRxId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CeRxRxId
        {
        get { return mCeRxRxId; }
        set { mCeRxRxId = value; }
        }

        private string mCeRxDispenseId
            = "";
        [global::ProtoBuf.ProtoMember(157, IsRequired = false, Name=@"CeRxDispenseId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CeRxDispenseId
        {
        get { return mCeRxDispenseId; }
        set { mCeRxDispenseId = value; }
        }

        private int mUnitDosePrcStratId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(158, IsRequired = false, Name=@"UnitDosePrcStratId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UnitDosePrcStratId
        {
        get { return mUnitDosePrcStratId; }
        set { mUnitDosePrcStratId = value; }
        }

        private bool mUnitDosePrcStratIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(159, IsRequired = false, Name=@"UnitDosePrcStratIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UnitDosePrcStratIdSpecified
        {
        get { return mUnitDosePrcStratIdSpecified; }
        set { mUnitDosePrcStratIdSpecified = value; }
        }

        private bool mMerged
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(160, IsRequired = false, Name=@"Merged", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Merged
        {
        get { return mMerged; }
        set { mMerged = value; }
        }

        private Kroll.Pharmacy.Api.Data.FeeForServiceType mFeeForServiceType
            = Kroll.Pharmacy.Api.Data.FeeForServiceType.FeeForServiceType_None;
        [global::ProtoBuf.ProtoMember(161, IsRequired = false, Name=@"FeeForServiceType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.FeeForServiceType.FeeForServiceType_None)]
        
        public Kroll.Pharmacy.Api.Data.FeeForServiceType FeeForServiceType
        {
        get { return mFeeForServiceType; }
        set { mFeeForServiceType = value; }
        }

        private string mUserField1
            = "";
        [global::ProtoBuf.ProtoMember(162, IsRequired = false, Name=@"UserField1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserField1
        {
        get { return mUserField1; }
        set { mUserField1 = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxStatus mLastRxStatus
            = Kroll.Pharmacy.Api.Data.RxStatus.RxStatus_Unknown;
        [global::ProtoBuf.ProtoMember(163, IsRequired = false, Name=@"LastRxStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxStatus.RxStatus_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.RxStatus LastRxStatus
        {
        get { return mLastRxStatus; }
        set { mLastRxStatus = value; }
        }

        private double mInactivatedOnDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(164, IsRequired = false, Name=@"InactivatedOnDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double InactivatedOnDate
        {
        get { return mInactivatedOnDate; }
        set { mInactivatedOnDate = value; }
        }

        private bool mInactivatedOnDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(165, IsRequired = false, Name=@"InactivatedOnDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InactivatedOnDateSpecified
        {
        get { return mInactivatedOnDateSpecified; }
        set { mInactivatedOnDateSpecified = value; }
        }

        private string mFDBRouteCode
            = "";
        [global::ProtoBuf.ProtoMember(166, IsRequired = false, Name=@"FDBRouteCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBRouteCode
        {
        get { return mFDBRouteCode; }
        set { mFDBRouteCode = value; }
        }

        private string mFDBDosageFormCode
            = "";
        [global::ProtoBuf.ProtoMember(167, IsRequired = false, Name=@"FDBDosageFormCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBDosageFormCode
        {
        get { return mFDBDosageFormCode; }
        set { mFDBDosageFormCode = value; }
        }

        private bool mIsMixture
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(178, IsRequired = false, Name=@"IsMixture", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsMixture
        {
        get { return mIsMixture; }
        set { mIsMixture = value; }
        }

        private double mTransactionDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(180, IsRequired = false, Name=@"TransactionDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TransactionDate
        {
        get { return mTransactionDate; }
        set { mTransactionDate = value; }
        }

        private bool mIsReversal
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(182, IsRequired = false, Name=@"IsReversal", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsReversal
        {
        get { return mIsReversal; }
        set { mIsReversal = value; }
        }

        private int mRefillsAuthorized
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(183, IsRequired = false, Name=@"RefillsAuthorized", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RefillsAuthorized
        {
        get { return mRefillsAuthorized; }
        set { mRefillsAuthorized = value; }
        }

        private int mRefillsRemaining
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(184, IsRequired = false, Name=@"RefillsRemaining", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RefillsRemaining
        {
        get { return mRefillsRemaining; }
        set { mRefillsRemaining = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHUnitDoseType mNHUnitDoseType
            = Kroll.Pharmacy.Api.Data.NHUnitDoseType.NHUnitDoseType_EveryDay;
        [global::ProtoBuf.ProtoMember(185, IsRequired = false, Name=@"NHUnitDoseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHUnitDoseType.NHUnitDoseType_EveryDay)]
        
        public Kroll.Pharmacy.Api.Data.NHUnitDoseType NHUnitDoseType
        {
        get { return mNHUnitDoseType; }
        set { mNHUnitDoseType = value; }
        }

        private bool mWasUndeliverable
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(186, IsRequired = false, Name=@"WasUndeliverable", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WasUndeliverable
        {
        get { return mWasUndeliverable; }
        set { mWasUndeliverable = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxPickupNotificationRequested mPickupNotificationRequested
            = Kroll.Pharmacy.Api.Data.RxPickupNotificationRequested.RxPickupNotificationRequested_No;
        [global::ProtoBuf.ProtoMember(187, IsRequired = false, Name=@"PickupNotificationRequested", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxPickupNotificationRequested.RxPickupNotificationRequested_No)]
        
        public Kroll.Pharmacy.Api.Data.RxPickupNotificationRequested PickupNotificationRequested
        {
        get { return mPickupNotificationRequested; }
        set { mPickupNotificationRequested = value; }
        }

        private Kroll.Pharmacy.Api.Data.CeRxOrderType mCeRxOrderType
            = Kroll.Pharmacy.Api.Data.CeRxOrderType.CeRxOrderType_None;
        [global::ProtoBuf.ProtoMember(188, IsRequired = false, Name=@"CeRxOrderType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CeRxOrderType.CeRxOrderType_None)]
        
        public Kroll.Pharmacy.Api.Data.CeRxOrderType CeRxOrderType
        {
        get { return mCeRxOrderType; }
        set { mCeRxOrderType = value; }
        }

        private Kroll.Pharmacy.Api.Data.CopyRxReason mCopiedFromReason
            = Kroll.Pharmacy.Api.Data.CopyRxReason.CopyRxReason_None;
        [global::ProtoBuf.ProtoMember(189, IsRequired = false, Name=@"CopiedFromReason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CopyRxReason.CopyRxReason_None)]
        
        public Kroll.Pharmacy.Api.Data.CopyRxReason CopiedFromReason
        {
        get { return mCopiedFromReason; }
        set { mCopiedFromReason = value; }
        }

        private Kroll.Pharmacy.Api.Data.CopyRxReason mCopiedToReason
            = Kroll.Pharmacy.Api.Data.CopyRxReason.CopyRxReason_None;
        [global::ProtoBuf.ProtoMember(190, IsRequired = false, Name=@"CopiedToReason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CopyRxReason.CopyRxReason_None)]
        
        public Kroll.Pharmacy.Api.Data.CopyRxReason CopiedToReason
        {
        get { return mCopiedToReason; }
        set { mCopiedToReason = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxCancelRefillType mCancelRefillType
            = Kroll.Pharmacy.Api.Data.RxCancelRefillType.RxCancelRefillType_NotSet;
        [global::ProtoBuf.ProtoMember(191, IsRequired = false, Name=@"CancelRefillType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxCancelRefillType.RxCancelRefillType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.RxCancelRefillType CancelRefillType
        {
        get { return mCancelRefillType; }
        set { mCancelRefillType = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHBatchType mNHBatchType
            = Kroll.Pharmacy.Api.Data.NHBatchType.NHBatchType_None;
        [global::ProtoBuf.ProtoMember(192, IsRequired = false, Name=@"NHBatchType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHBatchType.NHBatchType_None)]
        
        public Kroll.Pharmacy.Api.Data.NHBatchType NHBatchType
        {
        get { return mNHBatchType; }
        set { mNHBatchType = value; }
        }

        private bool mLegacyWorkflow
            = 
                (bool)true;
        [global::ProtoBuf.ProtoMember(193, IsRequired = false, Name=@"LegacyWorkflow", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                (bool)true)]
        
        public bool LegacyWorkflow
        {
        get { return mLegacyWorkflow; }
        set { mLegacyWorkflow = value; }
        }

        private int mScriptImagePosition
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(194, IsRequired = false, Name=@"ScriptImagePosition", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ScriptImagePosition
        {
        get { return mScriptImagePosition; }
        set { mScriptImagePosition = value; }
        }

        private bool mScriptImagePositionSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(195, IsRequired = false, Name=@"ScriptImagePositionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScriptImagePositionSpecified
        {
        get { return mScriptImagePositionSpecified; }
        set { mScriptImagePositionSpecified = value; }
        }

        private int mScriptImagePage
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(196, IsRequired = false, Name=@"ScriptImagePage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ScriptImagePage
        {
        get { return mScriptImagePage; }
        set { mScriptImagePage = value; }
        }

        private bool mScriptImagePageSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(197, IsRequired = false, Name=@"ScriptImagePageSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScriptImagePageSpecified
        {
        get { return mScriptImagePageSpecified; }
        set { mScriptImagePageSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.ChargeToAR mChargeToAR
            = Kroll.Pharmacy.Api.Data.ChargeToAR.ChargeToAR_Prompt;
        [global::ProtoBuf.ProtoMember(198, IsRequired = false, Name=@"ChargeToAR", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ChargeToAR.ChargeToAR_Prompt)]
        
        public Kroll.Pharmacy.Api.Data.ChargeToAR ChargeToAR
        {
        get { return mChargeToAR; }
        set { mChargeToAR = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxAutoRefillRequested mAutoRefillRequested
            = Kroll.Pharmacy.Api.Data.RxAutoRefillRequested.RxAutoRefillRequested_Prompt;
        [global::ProtoBuf.ProtoMember(199, IsRequired = false, Name=@"AutoRefillRequested", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxAutoRefillRequested.RxAutoRefillRequested_Prompt)]
        
        public Kroll.Pharmacy.Api.Data.RxAutoRefillRequested AutoRefillRequested
        {
        get { return mAutoRefillRequested; }
        set { mAutoRefillRequested = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxCounselingRequired mCounselingRequired
            = Kroll.Pharmacy.Api.Data.RxCounselingRequired.RxCounselingRequired_AutoNotRequested;
        [global::ProtoBuf.ProtoMember(230, IsRequired = false, Name=@"CounselingRequired", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxCounselingRequired.RxCounselingRequired_AutoNotRequested)]
        
        public Kroll.Pharmacy.Api.Data.RxCounselingRequired CounselingRequired
        {
        get { return mCounselingRequired; }
        set { mCounselingRequired = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxCounselingResponse mCounselingResponse
            = Kroll.Pharmacy.Api.Data.RxCounselingResponse.RxCounselingResponse_Unknown;
        [global::ProtoBuf.ProtoMember(231, IsRequired = false, Name=@"CounselingResponse", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxCounselingResponse.RxCounselingResponse_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.RxCounselingResponse CounselingResponse
        {
        get { return mCounselingResponse; }
        set { mCounselingResponse = value; }
        }

        private Kroll.Pharmacy.Api.Data.IdentificationRequiredOnDelivery mIdentificationRequiredOnDelivery
            = Kroll.Pharmacy.Api.Data.IdentificationRequiredOnDelivery.IdentificationRequiredOnDelivery_None;
        [global::ProtoBuf.ProtoMember(232, IsRequired = false, Name=@"IdentificationRequiredOnDelivery", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.IdentificationRequiredOnDelivery.IdentificationRequiredOnDelivery_None)]
        
        public Kroll.Pharmacy.Api.Data.IdentificationRequiredOnDelivery IdentificationRequiredOnDelivery
        {
        get { return mIdentificationRequiredOnDelivery; }
        set { mIdentificationRequiredOnDelivery = value; }
        }

        private byte[] mRxContextInfo
            = null;
        [global::ProtoBuf.ProtoMember(233, IsRequired = false, Name=@"RxContextInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] RxContextInfo
        {
        get { return mRxContextInfo; }
        set { mRxContextInfo = value; }
        }

        private Kroll.Pharmacy.Api.Data.CompressionType mRxContextInfoCompressionType
            = Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_None;
        [global::ProtoBuf.ProtoMember(234, IsRequired = false, Name=@"RxContextInfoCompressionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_None)]
        
        public Kroll.Pharmacy.Api.Data.CompressionType RxContextInfoCompressionType
        {
        get { return mRxContextInfoCompressionType; }
        set { mRxContextInfoCompressionType = value; }
        }

        private bool mOrderCreatedFromNetwork
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(235, IsRequired = false, Name=@"OrderCreatedFromNetwork", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OrderCreatedFromNetwork
        {
        get { return mOrderCreatedFromNetwork; }
        set { mOrderCreatedFromNetwork = value; }
        }

        private string mPasstimeCode
            = "";
        [global::ProtoBuf.ProtoMember(236, IsRequired = false, Name=@"PasstimeCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PasstimeCode
        {
        get { return mPasstimeCode; }
        set { mPasstimeCode = value; }
        }

        private int mDrugSource
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(237, IsRequired = false, Name=@"DrugSource", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrugSource
        {
        get { return mDrugSource; }
        set { mDrugSource = value; }
        }

        private bool mIsPharmacistPrescribe
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(238, IsRequired = false, Name=@"IsPharmacistPrescribe", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsPharmacistPrescribe
        {
        get { return mIsPharmacistPrescribe; }
        set { mIsPharmacistPrescribe = value; }
        }

        private Kroll.Pharmacy.Api.Data.PrescriptiveAuthority mPrescriptiveAuthority
            = Kroll.Pharmacy.Api.Data.PrescriptiveAuthority.PrescriptiveAuthority_Paper;
        [global::ProtoBuf.ProtoMember(239, IsRequired = false, Name=@"PrescriptiveAuthority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PrescriptiveAuthority.PrescriptiveAuthority_Paper)]
        
        public Kroll.Pharmacy.Api.Data.PrescriptiveAuthority PrescriptiveAuthority
        {
        get { return mPrescriptiveAuthority; }
        set { mPrescriptiveAuthority = value; }
        }

        private int mUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(240, IsRequired = false, Name=@"UserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UserId
        {
        get { return mUserId; }
        set { mUserId = value; }
        }

        private bool mUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(241, IsRequired = false, Name=@"UserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserIdSpecified
        {
        get { return mUserIdSpecified; }
        set { mUserIdSpecified = value; }
        }

        private int mUserUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(242, IsRequired = false, Name=@"UserUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UserUserId
        {
        get { return mUserUserId; }
        set { mUserUserId = value; }
        }

        private bool mUserUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(243, IsRequired = false, Name=@"UserUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserUserIdSpecified
        {
        get { return mUserUserIdSpecified; }
        set { mUserUserIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxCounselingReason mCounselingReason
            = Kroll.Pharmacy.Api.Data.RxCounselingReason.RxCounselingReason_None;
        [global::ProtoBuf.ProtoMember(244, IsRequired = false, Name=@"CounselingReason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxCounselingReason.RxCounselingReason_None)]
        
        public Kroll.Pharmacy.Api.Data.RxCounselingReason CounselingReason
        {
        get { return mCounselingReason; }
        set { mCounselingReason = value; }
        }

        private double mBaseCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(245, IsRequired = false, Name=@"BaseCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double BaseCost
        {
        get { return mBaseCost; }
        set { mBaseCost = value; }
        }

        private bool mBaseCostSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(246, IsRequired = false, Name=@"BaseCostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BaseCostSpecified
        {
        get { return mBaseCostSpecified; }
        set { mBaseCostSpecified = value; }
        }

        private double mCouponValue
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(247, IsRequired = false, Name=@"CouponValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CouponValue
        {
        get { return mCouponValue; }
        set { mCouponValue = value; }
        }

        private bool mCouponValueSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(248, IsRequired = false, Name=@"CouponValueSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CouponValueSpecified
        {
        get { return mCouponValueSpecified; }
        set { mCouponValueSpecified = value; }
        }

        private double mDoNotDispenseBeforeDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(249, IsRequired = false, Name=@"DoNotDispenseBeforeDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DoNotDispenseBeforeDate
        {
        get { return mDoNotDispenseBeforeDate; }
        set { mDoNotDispenseBeforeDate = value; }
        }

        private bool mDoNotDispenseBeforeDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(250, IsRequired = false, Name=@"DoNotDispenseBeforeDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoNotDispenseBeforeDateSpecified
        {
        get { return mDoNotDispenseBeforeDateSpecified; }
        set { mDoNotDispenseBeforeDateSpecified = value; }
        }

        private int mCarryNumber
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(251, IsRequired = false, Name=@"CarryNumber", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CarryNumber
        {
        get { return mCarryNumber; }
        set { mCarryNumber = value; }
        }

        private bool mCarryNumberSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(252, IsRequired = false, Name=@"CarryNumberSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CarryNumberSpecified
        {
        get { return mCarryNumberSpecified; }
        set { mCarryNumberSpecified = value; }
        }

        private bool mPharmacistPrescribeMedReviewRxId
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(253, IsRequired = false, Name=@"PharmacistPrescribeMedReviewRxId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PharmacistPrescribeMedReviewRxId
        {
        get { return mPharmacistPrescribeMedReviewRxId; }
        set { mPharmacistPrescribeMedReviewRxId = value; }
        }

        private bool mPharmacistPrescribeMedReviewRxIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(254, IsRequired = false, Name=@"PharmacistPrescribeMedReviewRxIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PharmacistPrescribeMedReviewRxIdSpecified
        {
        get { return mPharmacistPrescribeMedReviewRxIdSpecified; }
        set { mPharmacistPrescribeMedReviewRxIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.TreatmentType mTreatmentType
            = Kroll.Pharmacy.Api.Data.TreatmentType.TreatmentType_NotSpecified;
        [global::ProtoBuf.ProtoMember(255, IsRequired = false, Name=@"TreatmentType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.TreatmentType.TreatmentType_NotSpecified)]
        
        public Kroll.Pharmacy.Api.Data.TreatmentType TreatmentType
        {
        get { return mTreatmentType; }
        set { mTreatmentType = value; }
        }

        private double mMaxDispQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(256, IsRequired = false, Name=@"MaxDispQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MaxDispQty
        {
        get { return mMaxDispQty; }
        set { mMaxDispQty = value; }
        }

        private bool mMaxDispQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(257, IsRequired = false, Name=@"MaxDispQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MaxDispQtySpecified
        {
        get { return mMaxDispQtySpecified; }
        set { mMaxDispQtySpecified = value; }
        }

        private bool mNoDocERenewal
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(258, IsRequired = false, Name=@"NoDocERenewal", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoDocERenewal
        {
        get { return mNoDocERenewal; }
        set { mNoDocERenewal = value; }
        }

        private bool mNoDocERenewalSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(259, IsRequired = false, Name=@"NoDocERenewalSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoDocERenewalSpecified
        {
        get { return mNoDocERenewalSpecified; }
        set { mNoDocERenewalSpecified = value; }
        }

        private double mNHDoNotBatchFillBeforeDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(260, IsRequired = false, Name=@"NHDoNotBatchFillBeforeDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHDoNotBatchFillBeforeDate
        {
        get { return mNHDoNotBatchFillBeforeDate; }
        set { mNHDoNotBatchFillBeforeDate = value; }
        }

        private bool mNHDoNotBatchFillBeforeDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(261, IsRequired = false, Name=@"NHDoNotBatchFillBeforeDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHDoNotBatchFillBeforeDateSpecified
        {
        get { return mNHDoNotBatchFillBeforeDateSpecified; }
        set { mNHDoNotBatchFillBeforeDateSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.CFRxOrder> mRxCentralFill = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.CFRxOrder>();
        [global::ProtoBuf.ProtoMember(201, Name=@"RxCentralFill", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.CFRxOrder> RxCentralFill
        {
        get { return mRxCentralFill; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxCom> mComments = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxCom>();
        [global::ProtoBuf.ProtoMember(202, Name=@"Comments", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxCom> Comments
        {
        get { return mComments; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxIndications> mIndications = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxIndications>();
        [global::ProtoBuf.ProtoMember(203, Name=@"Indications", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxIndications> Indications
        {
        get { return mIndications; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxLot> mLotNumbers = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxLot>();
        [global::ProtoBuf.ProtoMember(204, Name=@"LotNumbers", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxLot> LotNumbers
        {
        get { return mLotNumbers; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxMix> mMixtureComponents = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxMix>();
        [global::ProtoBuf.ProtoMember(205, Name=@"MixtureComponents", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxMix> MixtureComponents
        {
        get { return mMixtureComponents; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPack> mPacks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPack>();
        [global::ProtoBuf.ProtoMember(206, Name=@"Packs", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPack> Packs
        {
        get { return mPacks; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPasstime> mPasstimes = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPasstime>();
        [global::ProtoBuf.ProtoMember(207, Name=@"Passtimes", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPasstime> Passtimes
        {
        get { return mPasstimes; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPln> mPlans = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPln>();
        [global::ProtoBuf.ProtoMember(208, Name=@"Plans", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPln> Plans
        {
        get { return mPlans; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxTracking> mRxTracking = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxTracking>();
        [global::ProtoBuf.ProtoMember(209, Name=@"RxTracking", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxTracking> RxTracking
        {
        get { return mRxTracking; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxTransfer> mRxTransfer = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxTransfer>();
        [global::ProtoBuf.ProtoMember(210, Name=@"RxTransfer", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxTransfer> RxTransfer
        {
        get { return mRxTransfer; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalRxLink> mExternalLinks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalRxLink>();
        [global::ProtoBuf.ProtoMember(211, Name=@"ExternalLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalRxLink> ExternalLinks
        {
        get { return mExternalLinks; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxSuspend> mRxSuspend = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxSuspend>();
        [global::ProtoBuf.ProtoMember(212, Name=@"RxSuspend", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxSuspend> RxSuspend
        {
        get { return mRxSuspend; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflow> mRxWorkflow = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflow>();
        [global::ProtoBuf.ProtoMember(213, Name=@"RxWorkflow", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflow> RxWorkflow
        {
        get { return mRxWorkflow; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxScriptImage> mRxScriptImage = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxScriptImage>();
        [global::ProtoBuf.ProtoMember(214, Name=@"RxScriptImage", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxScriptImage> RxScriptImage
        {
        get { return mRxScriptImage; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        