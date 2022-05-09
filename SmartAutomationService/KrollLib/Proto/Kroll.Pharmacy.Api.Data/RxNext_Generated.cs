
        // Generated from: RxNext.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxNext")]
        public partial class RxNext : global::ProtoBuf.IExtensible
        {
        public RxNext() {}
        

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

        private bool mPatIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatIdSpecified
        {
        get { return mPatIdSpecified; }
        set { mPatIdSpecified = value; }
        }

        private int mDrgId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DrgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DrgIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"MixId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"MixIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DocId
        {
        get { return mDocId; }
        set { mDocId = value; }
        }

        private bool mDocIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocIdSpecified
        {
        get { return mDocIdSpecified; }
        set { mDocIdSpecified = value; }
        }

        private int mOrigRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"OrigRxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private bool mRxNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxNumSpecified
        {
        get { return mRxNumSpecified; }
        set { mRxNumSpecified = value; }
        }

        private string mInit
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"Init", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"FillDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double FillDate
        {
        get { return mFillDate; }
        set { mFillDate = value; }
        }

        private bool mFillDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"FillDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FillDateSpecified
        {
        get { return mFillDateSpecified; }
        set { mFillDateSpecified = value; }
        }

        private double mCancelDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"CancelDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"CancelDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"FirstFillDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"FirstFillDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FirstFillDateSpecified
        {
        get { return mFirstFillDateSpecified; }
        set { mFirstFillDateSpecified = value; }
        }

        private double mLastFillDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"LastFillDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastFillDate
        {
        get { return mLastFillDate; }
        set { mLastFillDate = value; }
        }

        private bool mLastFillDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"LastFillDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastFillDateSpecified
        {
        get { return mLastFillDateSpecified; }
        set { mLastFillDateSpecified = value; }
        }

        private double mDispQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"DispQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DispQty
        {
        get { return mDispQty; }
        set { mDispQty = value; }
        }

        private bool mDispQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"DispQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DispQtySpecified
        {
        get { return mDispQtySpecified; }
        set { mDispQtySpecified = value; }
        }

        private double mNextFillQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"NextFillQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"NextFillQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NextFillQtySpecified
        {
        get { return mNextFillQtySpecified; }
        set { mNextFillQtySpecified = value; }
        }

        private double mAuthQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"AuthQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AuthQty
        {
        get { return mAuthQty; }
        set { mAuthQty = value; }
        }

        private bool mAuthQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"AuthQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AuthQtySpecified
        {
        get { return mAuthQtySpecified; }
        set { mAuthQtySpecified = value; }
        }

        private double mRemQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"RemQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RemQty
        {
        get { return mRemQty; }
        set { mRemQty = value; }
        }

        private bool mRemQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"RemQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RemQtySpecified
        {
        get { return mRemQtySpecified; }
        set { mRemQtySpecified = value; }
        }

        private int mDaysSupply
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"DaysSupply", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"DaysSupplySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DaysSupplySpecified
        {
        get { return mDaysSupplySpecified; }
        set { mDaysSupplySpecified = value; }
        }

        private string mLabels
            = "";
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"Labels", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Labels
        {
        get { return mLabels; }
        set { mLabels = value; }
        }

        private int mProductSelection
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"ProductSelection", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ProductSelection
        {
        get { return mProductSelection; }
        set { mProductSelection = value; }
        }

        private bool mProductSelectionSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"ProductSelectionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ProductSelectionSpecified
        {
        get { return mProductSelectionSpecified; }
        set { mProductSelectionSpecified = value; }
        }

        private string mOralWritten
            = "";
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"OralWritten", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OralWritten
        {
        get { return mOralWritten; }
        set { mOralWritten = value; }
        }

        private string mSig
            = "";
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"Sig", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Sig
        {
        get { return mSig; }
        set { mSig = value; }
        }

        private string mSigExpansion
            = "";
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"SigExpansion", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"SigExpansionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"Din", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"PackSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"PackSizeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"Aac", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"AacSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"Cost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"CostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"Markup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"MarkupSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"Fee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"FeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"MixTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"MixTimeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"MixFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"MixFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MixFeeSpecified
        {
        get { return mMixFeeSpecified; }
        set { mMixFeeSpecified = value; }
        }

        private double mSSCFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"SSCFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SSCFee
        {
        get { return mSSCFee; }
        set { mSSCFee = value; }
        }

        private bool mSSCFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"SSCFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SSCFeeSpecified
        {
        get { return mSSCFeeSpecified; }
        set { mSSCFeeSpecified = value; }
        }

        private double mPriceDiscount
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"PriceDiscount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double PriceDiscount
        {
        get { return mPriceDiscount; }
        set { mPriceDiscount = value; }
        }

        private bool mPriceDiscountSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"PriceDiscountSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PriceDiscountSpecified
        {
        get { return mPriceDiscountSpecified; }
        set { mPriceDiscountSpecified = value; }
        }

        private double mDeductDiscount
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"DeductDiscount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DeductDiscount
        {
        get { return mDeductDiscount; }
        set { mDeductDiscount = value; }
        }

        private bool mDeductDiscountSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"DeductDiscountSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeductDiscountSpecified
        {
        get { return mDeductDiscountSpecified; }
        set { mDeductDiscountSpecified = value; }
        }

        private bool mManualPrice
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"ManualPrice", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ManualPrice
        {
        get { return mManualPrice; }
        set { mManualPrice = value; }
        }

        private bool mTrialRx
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"TrialRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TrialRx
        {
        get { return mTrialRx; }
        set { mTrialRx = value; }
        }

        private bool mPartialFill
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"PartialFill", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PartialFill
        {
        get { return mPartialFill; }
        set { mPartialFill = value; }
        }

        private double mDrugExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"DrugExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"DrugExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"StopDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"StopDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"RxExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"RxExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxExpiryDateSpecified
        {
        get { return mRxExpiryDateSpecified; }
        set { mRxExpiryDateSpecified = value; }
        }

        private double mFollowUpDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"FollowUpDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double FollowUpDate
        {
        get { return mFollowUpDate; }
        set { mFollowUpDate = value; }
        }

        private bool mFollowUpDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"FollowUpDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FollowUpDateSpecified
        {
        get { return mFollowUpDateSpecified; }
        set { mFollowUpDateSpecified = value; }
        }

        private int mStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private bool mStatusSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(72, IsRequired = false, Name=@"StatusSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StatusSpecified
        {
        get { return mStatusSpecified; }
        set { mStatusSpecified = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(73, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private string mLot
            = "";
        [global::ProtoBuf.ProtoMember(74, IsRequired = false, Name=@"Lot", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Lot
        {
        get { return mLot; }
        set { mLot = value; }
        }

        private string mDocAddressLoc
            = "";
        [global::ProtoBuf.ProtoMember(75, IsRequired = false, Name=@"DocAddressLoc", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DocAddressLoc
        {
        get { return mDocAddressLoc; }
        set { mDocAddressLoc = value; }
        }

        private bool mSplitQty
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(76, IsRequired = false, Name=@"SplitQty", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(77, IsRequired = false, Name=@"SplitEvenly", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(78, IsRequired = false, Name=@"LabelQtySplit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LabelQtySplit
        {
        get { return mLabelQtySplit; }
        set { mLabelQtySplit = value; }
        }

        private int mAdjState
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(79, IsRequired = false, Name=@"AdjState", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AdjState
        {
        get { return mAdjState; }
        set { mAdjState = value; }
        }

        private bool mAdjStateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(80, IsRequired = false, Name=@"AdjStateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AdjStateSpecified
        {
        get { return mAdjStateSpecified; }
        set { mAdjStateSpecified = value; }
        }

        private bool mInactive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(81, IsRequired = false, Name=@"Inactive", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(82, IsRequired = false, Name=@"CopiedTo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(83, IsRequired = false, Name=@"CopiedToSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(84, IsRequired = false, Name=@"CopiedFrom", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(85, IsRequired = false, Name=@"CopiedFromSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(86, IsRequired = false, Name=@"TherapeuticStartDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(87, IsRequired = false, Name=@"TherapeuticStartDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(88, IsRequired = false, Name=@"TransferredFromDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(89, IsRequired = false, Name=@"TransferredFromDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(90, IsRequired = false, Name=@"TransferredToDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(91, IsRequired = false, Name=@"TransferredToDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(93, IsRequired = false, Name=@"DiscountCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(94, IsRequired = false, Name=@"DiscountCostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(95, IsRequired = false, Name=@"DiscountMarkup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(96, IsRequired = false, Name=@"DiscountMarkupSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(97, IsRequired = false, Name=@"DiscountFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(98, IsRequired = false, Name=@"DiscountFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(99, IsRequired = false, Name=@"DiscountMixFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(100, IsRequired = false, Name=@"DiscountMixFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DiscountMixFeeSpecified
        {
        get { return mDiscountMixFeeSpecified; }
        set { mDiscountMixFeeSpecified = value; }
        }

        private double mDiscountSSCFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(101, IsRequired = false, Name=@"DiscountSSCFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DiscountSSCFee
        {
        get { return mDiscountSSCFee; }
        set { mDiscountSSCFee = value; }
        }

        private bool mDiscountSSCFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(102, IsRequired = false, Name=@"DiscountSSCFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DiscountSSCFeeSpecified
        {
        get { return mDiscountSSCFeeSpecified; }
        set { mDiscountSSCFeeSpecified = value; }
        }

        private string mUserInit
            = "";
        [global::ProtoBuf.ProtoMember(103, IsRequired = false, Name=@"UserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(118, IsRequired = false, Name=@"WrittenDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(119, IsRequired = false, Name=@"WrittenDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(120, IsRequired = false, Name=@"MinIntervalDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(121, IsRequired = false, Name=@"MinIntervalDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MinIntervalDaysSpecified
        {
        get { return mMinIntervalDaysSpecified; }
        set { mMinIntervalDaysSpecified = value; }
        }

        private double mBackDatedOn
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(122, IsRequired = false, Name=@"BackDatedOn", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double BackDatedOn
        {
        get { return mBackDatedOn; }
        set { mBackDatedOn = value; }
        }

        private bool mBackDatedOnSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(123, IsRequired = false, Name=@"BackDatedOnSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BackDatedOnSpecified
        {
        get { return mBackDatedOnSpecified; }
        set { mBackDatedOnSpecified = value; }
        }

        private int mPrcStratId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(124, IsRequired = false, Name=@"PrcStratId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PrcStratId
        {
        get { return mPrcStratId; }
        set { mPrcStratId = value; }
        }

        private bool mPrcStratIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(125, IsRequired = false, Name=@"PrcStratIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrcStratIdSpecified
        {
        get { return mPrcStratIdSpecified; }
        set { mPrcStratIdSpecified = value; }
        }

        private string mCorporatePriceId
            = "";
        [global::ProtoBuf.ProtoMember(126, IsRequired = false, Name=@"CorporatePriceId", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(127, IsRequired = false, Name=@"ARCharged", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ARCharged
        {
        get { return mARCharged; }
        set { mARCharged = value; }
        }

        private int mNHCycleId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(129, IsRequired = false, Name=@"NHCycleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(130, IsRequired = false, Name=@"NHCycleIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(131, IsRequired = false, Name=@"NHBatchFill", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(132, IsRequired = false, Name=@"NHUnitDose", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(133, IsRequired = false, Name=@"NHWardStock", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(134, IsRequired = false, Name=@"NHMedTypeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(135, IsRequired = false, Name=@"NHMedTypeIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHMedTypeIdSpecified
        {
        get { return mNHMedTypeIdSpecified; }
        set { mNHMedTypeIdSpecified = value; }
        }

        private double mNHEODStartDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(139, IsRequired = false, Name=@"NHEODStartDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHEODStartDate
        {
        get { return mNHEODStartDate; }
        set { mNHEODStartDate = value; }
        }

        private bool mNHEODStartDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(140, IsRequired = false, Name=@"NHEODStartDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHEODStartDateSpecified
        {
        get { return mNHEODStartDateSpecified; }
        set { mNHEODStartDateSpecified = value; }
        }

        private int mNHLabels
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(143, IsRequired = false, Name=@"NHLabels", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(144, IsRequired = false, Name=@"NHLabelsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHLabelsSpecified
        {
        get { return mNHLabelsSpecified; }
        set { mNHLabelsSpecified = value; }
        }

        private int mFirstDrugName
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(145, IsRequired = false, Name=@"FirstDrugName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int FirstDrugName
        {
        get { return mFirstDrugName; }
        set { mFirstDrugName = value; }
        }

        private bool mFirstDrugNameSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(146, IsRequired = false, Name=@"FirstDrugNameSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FirstDrugNameSpecified
        {
        get { return mFirstDrugNameSpecified; }
        set { mFirstDrugNameSpecified = value; }
        }

        private int mSecondDrugName
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(147, IsRequired = false, Name=@"SecondDrugName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SecondDrugName
        {
        get { return mSecondDrugName; }
        set { mSecondDrugName = value; }
        }

        private bool mSecondDrugNameSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(148, IsRequired = false, Name=@"SecondDrugNameSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SecondDrugNameSpecified
        {
        get { return mSecondDrugNameSpecified; }
        set { mSecondDrugNameSpecified = value; }
        }

        private int mPrintSigSmall
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(149, IsRequired = false, Name=@"PrintSigSmall", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PrintSigSmall
        {
        get { return mPrintSigSmall; }
        set { mPrintSigSmall = value; }
        }

        private bool mPrintSigSmallSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(150, IsRequired = false, Name=@"PrintSigSmallSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintSigSmallSpecified
        {
        get { return mPrintSigSmallSpecified; }
        set { mPrintSigSmallSpecified = value; }
        }

        private int mScriptImageId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(151, IsRequired = false, Name=@"ScriptImageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(152, IsRequired = false, Name=@"ScriptImageIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScriptImageIdSpecified
        {
        get { return mScriptImageIdSpecified; }
        set { mScriptImageIdSpecified = value; }
        }

        private bool mUnlimitedRefills
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(153, IsRequired = false, Name=@"UnlimitedRefills", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(154, IsRequired = false, Name=@"NHComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(155, IsRequired = false, Name=@"RoboticPending", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RoboticPending
        {
        get { return mRoboticPending; }
        set { mRoboticPending = value; }
        }

        private int mNHDaysInUnitDoseCycle
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(156, IsRequired = false, Name=@"NHDaysInUnitDoseCycle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHDaysInUnitDoseCycle
        {
        get { return mNHDaysInUnitDoseCycle; }
        set { mNHDaysInUnitDoseCycle = value; }
        }

        private bool mNHDaysInUnitDoseCycleSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(157, IsRequired = false, Name=@"NHDaysInUnitDoseCycleSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHDaysInUnitDoseCycleSpecified
        {
        get { return mNHDaysInUnitDoseCycleSpecified; }
        set { mNHDaysInUnitDoseCycleSpecified = value; }
        }

        private int mNHCardNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(158, IsRequired = false, Name=@"NHCardNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(159, IsRequired = false, Name=@"NHCardNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(160, IsRequired = false, Name=@"AutoRefill", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(161, IsRequired = false, Name=@"NHSplitQty", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(162, IsRequired = false, Name=@"NHSplitEvenly", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(163, IsRequired = false, Name=@"NHLabelQtySplit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHLabelQtySplit
        {
        get { return mNHLabelQtySplit; }
        set { mNHLabelQtySplit = value; }
        }

        private string mRxPlanStr
            = "";
        [global::ProtoBuf.ProtoMember(164, IsRequired = false, Name=@"RxPlanStr", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RxPlanStr
        {
        get { return mRxPlanStr; }
        set { mRxPlanStr = value; }
        }

        private string mInterventionCodeStr
            = "";
        [global::ProtoBuf.ProtoMember(165, IsRequired = false, Name=@"InterventionCodeStr", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string InterventionCodeStr
        {
        get { return mInterventionCodeStr; }
        set { mInterventionCodeStr = value; }
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

        private string mNoScriptImageReason
            = "";
        [global::ProtoBuf.ProtoMember(168, IsRequired = false, Name=@"NoScriptImageReason", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NoScriptImageReason
        {
        get { return mNoScriptImageReason; }
        set { mNoScriptImageReason = value; }
        }

        private double mMaxDispQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(169, IsRequired = false, Name=@"MaxDispQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(170, IsRequired = false, Name=@"MaxDispQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MaxDispQtySpecified
        {
        get { return mMaxDispQtySpecified; }
        set { mMaxDispQtySpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        