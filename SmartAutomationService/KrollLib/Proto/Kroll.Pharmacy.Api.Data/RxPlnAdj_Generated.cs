
        // Generated from: RxPlnAdj.proto
        // Note: requires additional types generated from: ParserType_Enum.proto
        // Note: requires additional types generated from: CompressionType_Enum.proto
        // Note: requires additional types generated from: ClaimType_Enum.proto
        // Note: requires additional types generated from: ClaimResult_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxPlnAdj")]
        public partial class RxPlnAdj : global::ProtoBuf.IExtensible
        {
        public RxPlnAdj() {}
        

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

        private double mTimeStamp
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"TimeStamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TimeStamp
        {
        get { return mTimeStamp; }
        set { mTimeStamp = value; }
        }

        private int mRxPlnId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"RxPlnId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxPlnId
        {
        get { return mRxPlnId; }
        set { mRxPlnId = value; }
        }

        private string mResultCode
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ResultCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResultCode
        {
        get { return mResultCode; }
        set { mResultCode = value; }
        }

        private double mAdjDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"AdjDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AdjDate
        {
        get { return mAdjDate; }
        set { mAdjDate = value; }
        }

        private bool mAdjDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"AdjDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AdjDateSpecified
        {
        get { return mAdjDateSpecified; }
        set { mAdjDateSpecified = value; }
        }

        private string mInterventionCodes
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"InterventionCodes", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string InterventionCodes
        {
        get { return mInterventionCodes; }
        set { mInterventionCodes = value; }
        }

        private string mTraceNum
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"TraceNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string TraceNum
        {
        get { return mTraceNum; }
        set { mTraceNum = value; }
        }

        private string mRefNum
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"RefNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RefNum
        {
        get { return mRefNum; }
        set { mRefNum = value; }
        }

        private string mErrorCodes
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ErrorCodes", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ErrorCodes
        {
        get { return mErrorCodes; }
        set { mErrorCodes = value; }
        }

        private string mMessages
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Messages", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Messages
        {
        get { return mMessages; }
        set { mMessages = value; }
        }

        private double mAcceptedCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"AcceptedCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AcceptedCost
        {
        get { return mAcceptedCost; }
        set { mAcceptedCost = value; }
        }

        private bool mAcceptedCostSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"AcceptedCostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AcceptedCostSpecified
        {
        get { return mAcceptedCostSpecified; }
        set { mAcceptedCostSpecified = value; }
        }

        private double mAcceptedMarkup
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"AcceptedMarkup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AcceptedMarkup
        {
        get { return mAcceptedMarkup; }
        set { mAcceptedMarkup = value; }
        }

        private bool mAcceptedMarkupSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"AcceptedMarkupSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AcceptedMarkupSpecified
        {
        get { return mAcceptedMarkupSpecified; }
        set { mAcceptedMarkupSpecified = value; }
        }

        private double mAcceptedFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"AcceptedFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AcceptedFee
        {
        get { return mAcceptedFee; }
        set { mAcceptedFee = value; }
        }

        private bool mAcceptedFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"AcceptedFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AcceptedFeeSpecified
        {
        get { return mAcceptedFeeSpecified; }
        set { mAcceptedFeeSpecified = value; }
        }

        private double mAcceptedMixFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"AcceptedMixFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AcceptedMixFee
        {
        get { return mAcceptedMixFee; }
        set { mAcceptedMixFee = value; }
        }

        private bool mAcceptedMixFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"AcceptedMixFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AcceptedMixFeeSpecified
        {
        get { return mAcceptedMixFeeSpecified; }
        set { mAcceptedMixFeeSpecified = value; }
        }

        private double mAcceptedSSCFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"AcceptedSSCFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AcceptedSSCFee
        {
        get { return mAcceptedSSCFee; }
        set { mAcceptedSSCFee = value; }
        }

        private bool mAcceptedSSCFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"AcceptedSSCFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AcceptedSSCFeeSpecified
        {
        get { return mAcceptedSSCFeeSpecified; }
        set { mAcceptedSSCFeeSpecified = value; }
        }

        private double mPlanPays
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"PlanPays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double PlanPays
        {
        get { return mPlanPays; }
        set { mPlanPays = value; }
        }

        private bool mPlanPaysSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"PlanPaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PlanPaysSpecified
        {
        get { return mPlanPaysSpecified; }
        set { mPlanPaysSpecified = value; }
        }

        private double mSubmittedCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"SubmittedCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SubmittedCost
        {
        get { return mSubmittedCost; }
        set { mSubmittedCost = value; }
        }

        private bool mSubmittedCostSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"SubmittedCostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SubmittedCostSpecified
        {
        get { return mSubmittedCostSpecified; }
        set { mSubmittedCostSpecified = value; }
        }

        private double mSubmittedMarkup
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"SubmittedMarkup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SubmittedMarkup
        {
        get { return mSubmittedMarkup; }
        set { mSubmittedMarkup = value; }
        }

        private bool mSubmittedMarkupSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"SubmittedMarkupSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SubmittedMarkupSpecified
        {
        get { return mSubmittedMarkupSpecified; }
        set { mSubmittedMarkupSpecified = value; }
        }

        private double mSubmittedFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"SubmittedFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SubmittedFee
        {
        get { return mSubmittedFee; }
        set { mSubmittedFee = value; }
        }

        private bool mSubmittedFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"SubmittedFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SubmittedFeeSpecified
        {
        get { return mSubmittedFeeSpecified; }
        set { mSubmittedFeeSpecified = value; }
        }

        private double mSubmittedMixFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"SubmittedMixFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SubmittedMixFee
        {
        get { return mSubmittedMixFee; }
        set { mSubmittedMixFee = value; }
        }

        private bool mSubmittedMixFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"SubmittedMixFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SubmittedMixFeeSpecified
        {
        get { return mSubmittedMixFeeSpecified; }
        set { mSubmittedMixFeeSpecified = value; }
        }

        private double mSubmittedSSCFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"SubmittedSSCFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SubmittedSSCFee
        {
        get { return mSubmittedSSCFee; }
        set { mSubmittedSSCFee = value; }
        }

        private bool mSubmittedSSCFeeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"SubmittedSSCFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SubmittedSSCFeeSpecified
        {
        get { return mSubmittedSSCFeeSpecified; }
        set { mSubmittedSSCFeeSpecified = value; }
        }

        private double mPrevPaid
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"PrevPaid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double PrevPaid
        {
        get { return mPrevPaid; }
        set { mPrevPaid = value; }
        }

        private bool mPrevPaidSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"PrevPaidSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrevPaidSpecified
        {
        get { return mPrevPaidSpecified; }
        set { mPrevPaidSpecified = value; }
        }

        private string mSSC
            = "";
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"SSC", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SSC
        {
        get { return mSSC; }
        set { mSSC = value; }
        }

        private string mSANum
            = "";
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"SANum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SANum
        {
        get { return mSANum; }
        set { mSANum = value; }
        }

        private int mAdjudicationLevel
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"AdjudicationLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AdjudicationLevel
        {
        get { return mAdjudicationLevel; }
        set { mAdjudicationLevel = value; }
        }

        private string mDin
            = "";
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"Din", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Din
        {
        get { return mDin; }
        set { mDin = value; }
        }

        private byte[] mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }

        private byte[] mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }

        private int mTransmissionStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"TransmissionStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int TransmissionStatus
        {
        get { return mTransmissionStatus; }
        set { mTransmissionStatus = value; }
        }

        private double mAdjResponseDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"AdjResponseDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AdjResponseDate
        {
        get { return mAdjResponseDate; }
        set { mAdjResponseDate = value; }
        }

        private bool mAdjResponseDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"AdjResponseDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AdjResponseDateSpecified
        {
        get { return mAdjResponseDateSpecified; }
        set { mAdjResponseDateSpecified = value; }
        }

        private string mRequestEncoding
            = "";
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"RequestEncoding", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RequestEncoding
        {
        get { return mRequestEncoding; }
        set { mRequestEncoding = value; }
        }

        private string mResponseEncoding
            = "";
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"ResponseEncoding", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResponseEncoding
        {
        get { return mResponseEncoding; }
        set { mResponseEncoding = value; }
        }

        private Kroll.Pharmacy.Api.Data.ClaimType mClaimType
            = Kroll.Pharmacy.Api.Data.ClaimType.ClaimType_Rx;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"ClaimType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ClaimType.ClaimType_Rx)]
        
        public Kroll.Pharmacy.Api.Data.ClaimType ClaimType
        {
        get { return mClaimType; }
        set { mClaimType = value; }
        }

        private Kroll.Pharmacy.Api.Data.ClaimResult mClaimResult
            = Kroll.Pharmacy.Api.Data.ClaimResult.ClaimResult_Unknown;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"ClaimResult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ClaimResult.ClaimResult_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ClaimResult ClaimResult
        {
        get { return mClaimResult; }
        set { mClaimResult = value; }
        }

        private int mAdjRouteId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"AdjRouteId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AdjRouteId
        {
        get { return mAdjRouteId; }
        set { mAdjRouteId = value; }
        }

        private bool mAdjRouteIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"AdjRouteIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AdjRouteIdSpecified
        {
        get { return mAdjRouteIdSpecified; }
        set { mAdjRouteIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        