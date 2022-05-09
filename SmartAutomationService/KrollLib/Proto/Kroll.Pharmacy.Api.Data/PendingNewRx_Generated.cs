
        // Generated from: PendingNewRx.proto
        // Note: requires additional types generated from: RxOralWritten_Enum.proto
        // Note: requires additional types generated from: RxStatus_Enum.proto
        // Note: requires additional types generated from: ChargeToAR_Enum.proto
        // Note: requires additional types generated from: RxAutoRefillRequested_Enum.proto
        // Note: requires additional types generated from: RxPickupNotificationRequested_Enum.proto
        // Note: requires additional types generated from: RxCounselingRequired_Enum.proto
        // Note: requires additional types generated from: RxCounselingResponse_Enum.proto
        // Note: requires additional types generated from: TreatmentType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PendingNewRx")]
        public partial class PendingNewRx : global::ProtoBuf.IExtensible
        {
        public PendingNewRx() {}
        

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

        private int mToDoId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ToDoId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ToDoId
        {
        get { return mToDoId; }
        set { mToDoId = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxNumSpecified
        {
        get { return mRxNumSpecified; }
        set { mRxNumSpecified = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatIdSpecified
        {
        get { return mPatIdSpecified; }
        set { mPatIdSpecified = value; }
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

        private bool mDocIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocIdSpecified
        {
        get { return mDocIdSpecified; }
        set { mDocIdSpecified = value; }
        }

        private int mDrgId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DrgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"DrgIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"MixId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"MixIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MixIdSpecified
        {
        get { return mMixIdSpecified; }
        set { mMixIdSpecified = value; }
        }

        private string mDIN
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DIN", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DIN
        {
        get { return mDIN; }
        set { mDIN = value; }
        }

        private double mPackSize
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"PackSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"PackSizeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PackSizeSpecified
        {
        get { return mPackSizeSpecified; }
        set { mPackSizeSpecified = value; }
        }

        private string mPatName
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"PatName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PatName
        {
        get { return mPatName; }
        set { mPatName = value; }
        }

        private string mDocName
            = "";
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"DocName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DocName
        {
        get { return mDocName; }
        set { mDocName = value; }
        }

        private string mDrgName
            = "";
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DrgName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgName
        {
        get { return mDrgName; }
        set { mDrgName = value; }
        }

        private int mScriptImageId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"ScriptImageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"ScriptImageIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScriptImageIdSpecified
        {
        get { return mScriptImageIdSpecified; }
        set { mScriptImageIdSpecified = value; }
        }

        private string mSig
            = "";
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"Sig", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Sig
        {
        get { return mSig; }
        set { mSig = value; }
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

        private double mAuthQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"AuthQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"AuthQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AuthQtySpecified
        {
        get { return mAuthQtySpecified; }
        set { mAuthQtySpecified = value; }
        }

        private bool mUnlimitedRefills
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"UnlimitedRefills", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UnlimitedRefills
        {
        get { return mUnlimitedRefills; }
        set { mUnlimitedRefills = value; }
        }

        private double mRxExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"RxExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"RxExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxExpiryDateSpecified
        {
        get { return mRxExpiryDateSpecified; }
        set { mRxExpiryDateSpecified = value; }
        }

        private int mDaysSupply
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"DaysSupply", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"DaysSupplySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DaysSupplySpecified
        {
        get { return mDaysSupplySpecified; }
        set { mDaysSupplySpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxOralWritten mOralWritten
            = Kroll.Pharmacy.Api.Data.RxOralWritten.RxOralWritten_Unknown;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"OralWritten", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxOralWritten.RxOralWritten_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.RxOralWritten OralWritten
        {
        get { return mOralWritten; }
        set { mOralWritten = value; }
        }

        private double mStartDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"StartDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double StartDate
        {
        get { return mStartDate; }
        set { mStartDate = value; }
        }

        private bool mStartDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"StartDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StartDateSpecified
        {
        get { return mStartDateSpecified; }
        set { mStartDateSpecified = value; }
        }

        private double mStopDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"StopDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"StopDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StopDateSpecified
        {
        get { return mStopDateSpecified; }
        set { mStopDateSpecified = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private int mExternalInterfaceId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"ExternalInterfaceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ExternalInterfaceId
        {
        get { return mExternalInterfaceId; }
        set { mExternalInterfaceId = value; }
        }

        private bool mExternalInterfaceIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"ExternalInterfaceIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExternalInterfaceIdSpecified
        {
        get { return mExternalInterfaceIdSpecified; }
        set { mExternalInterfaceIdSpecified = value; }
        }

        private string mExternalRxReference
            = "";
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"ExternalRxReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalRxReference
        {
        get { return mExternalRxReference; }
        set { mExternalRxReference = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxStatus mStatus
            = Kroll.Pharmacy.Api.Data.RxStatus.RxStatus_Unknown;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxStatus.RxStatus_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.RxStatus Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private string mReasonCode
            = "";
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"ReasonCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReasonCode
        {
        get { return mReasonCode; }
        set { mReasonCode = value; }
        }

        private int mRxTransferId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"RxTransferId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxTransferId
        {
        get { return mRxTransferId; }
        set { mRxTransferId = value; }
        }

        private bool mRxTransferIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"RxTransferIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxTransferIdSpecified
        {
        get { return mRxTransferIdSpecified; }
        set { mRxTransferIdSpecified = value; }
        }

        private int mProductSelection
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"ProductSelection", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"ProductSelectionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ProductSelectionSpecified
        {
        get { return mProductSelectionSpecified; }
        set { mProductSelectionSpecified = value; }
        }

        private int mMinIntervalDays
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"MinIntervalDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"MinIntervalDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MinIntervalDaysSpecified
        {
        get { return mMinIntervalDaysSpecified; }
        set { mMinIntervalDaysSpecified = value; }
        }

        private string mFDBRouteCode
            = "";
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"FDBRouteCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBRouteCode
        {
        get { return mFDBRouteCode; }
        set { mFDBRouteCode = value; }
        }

        private string mFDBDosageFormCode
            = "";
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"FDBDosageFormCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBDosageFormCode
        {
        get { return mFDBDosageFormCode; }
        set { mFDBDosageFormCode = value; }
        }

        private int mScriptImagePosition
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"ScriptImagePosition", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"ScriptImagePositionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"ScriptImagePage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"ScriptImagePageSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"ChargeToAR", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ChargeToAR.ChargeToAR_Prompt)]
        
        public Kroll.Pharmacy.Api.Data.ChargeToAR ChargeToAR
        {
        get { return mChargeToAR; }
        set { mChargeToAR = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxAutoRefillRequested mAutoRefillRequested
            = Kroll.Pharmacy.Api.Data.RxAutoRefillRequested.RxAutoRefillRequested_Prompt;
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"AutoRefillRequested", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxAutoRefillRequested.RxAutoRefillRequested_Prompt)]
        
        public Kroll.Pharmacy.Api.Data.RxAutoRefillRequested AutoRefillRequested
        {
        get { return mAutoRefillRequested; }
        set { mAutoRefillRequested = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxPickupNotificationRequested mPickupNotificationRequested
            = Kroll.Pharmacy.Api.Data.RxPickupNotificationRequested.RxPickupNotificationRequested_Prompt;
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"PickupNotificationRequested", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxPickupNotificationRequested.RxPickupNotificationRequested_Prompt)]
        
        public Kroll.Pharmacy.Api.Data.RxPickupNotificationRequested PickupNotificationRequested
        {
        get { return mPickupNotificationRequested; }
        set { mPickupNotificationRequested = value; }
        }

        private double mWrittenDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"WrittenDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"WrittenDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WrittenDateSpecified
        {
        get { return mWrittenDateSpecified; }
        set { mWrittenDateSpecified = value; }
        }

        private bool mOrderReceived
            = 
                (bool)true;
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"OrderReceived", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                (bool)true)]
        
        public bool OrderReceived
        {
        get { return mOrderReceived; }
        set { mOrderReceived = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxCounselingRequired mCounselingRequired
            = Kroll.Pharmacy.Api.Data.RxCounselingRequired.RxCounselingRequired_AutoNotRequested;
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"CounselingRequired", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxCounselingRequired.RxCounselingRequired_AutoNotRequested)]
        
        public Kroll.Pharmacy.Api.Data.RxCounselingRequired CounselingRequired
        {
        get { return mCounselingRequired; }
        set { mCounselingRequired = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxCounselingResponse mCounselingResponse
            = Kroll.Pharmacy.Api.Data.RxCounselingResponse.RxCounselingResponse_Unknown;
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"CounselingResponse", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxCounselingResponse.RxCounselingResponse_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.RxCounselingResponse CounselingResponse
        {
        get { return mCounselingResponse; }
        set { mCounselingResponse = value; }
        }

        private bool mManualPrice
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"ManualPrice", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ManualPrice
        {
        get { return mManualPrice; }
        set { mManualPrice = value; }
        }

        private bool mManualPriceSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"ManualPriceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ManualPriceSpecified
        {
        get { return mManualPriceSpecified; }
        set { mManualPriceSpecified = value; }
        }

        private double mCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"Cost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"CostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CostSpecified
        {
        get { return mCostSpecified; }
        set { mCostSpecified = value; }
        }

        private double mDiscountCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"DiscountCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"DiscountCostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DiscountCostSpecified
        {
        get { return mDiscountCostSpecified; }
        set { mDiscountCostSpecified = value; }
        }

        private double mMarkup
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"Markup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(72, IsRequired = false, Name=@"MarkupSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MarkupSpecified
        {
        get { return mMarkupSpecified; }
        set { mMarkupSpecified = value; }
        }

        private double mDiscountMarkup
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(73, IsRequired = false, Name=@"DiscountMarkup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(74, IsRequired = false, Name=@"DiscountMarkupSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DiscountMarkupSpecified
        {
        get { return mDiscountMarkupSpecified; }
        set { mDiscountMarkupSpecified = value; }
        }

        private double mFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(75, IsRequired = false, Name=@"Fee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(76, IsRequired = false, Name=@"FeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FeeSpecified
        {
        get { return mFeeSpecified; }
        set { mFeeSpecified = value; }
        }

        private double mDiscountFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(77, IsRequired = false, Name=@"DiscountFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(78, IsRequired = false, Name=@"DiscountFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DiscountFeeSpecified
        {
        get { return mDiscountFeeSpecified; }
        set { mDiscountFeeSpecified = value; }
        }

        private double mMixFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(79, IsRequired = false, Name=@"MixFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(80, IsRequired = false, Name=@"MixFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MixFeeSpecified
        {
        get { return mMixFeeSpecified; }
        set { mMixFeeSpecified = value; }
        }

        private double mDiscountMixFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(81, IsRequired = false, Name=@"DiscountMixFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(82, IsRequired = false, Name=@"DiscountMixFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DiscountMixFeeSpecified
        {
        get { return mDiscountMixFeeSpecified; }
        set { mDiscountMixFeeSpecified = value; }
        }

        private double mSscFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(83, IsRequired = false, Name=@"SscFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(84, IsRequired = false, Name=@"SscFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SscFeeSpecified
        {
        get { return mSscFeeSpecified; }
        set { mSscFeeSpecified = value; }
        }

        private double mDiscountSscFee
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(85, IsRequired = false, Name=@"DiscountSscFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(86, IsRequired = false, Name=@"DiscountSscFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DiscountSscFeeSpecified
        {
        get { return mDiscountSscFeeSpecified; }
        set { mDiscountSscFeeSpecified = value; }
        }

        private string mDocAddressLoc
            = "";
        [global::ProtoBuf.ProtoMember(87, IsRequired = false, Name=@"DocAddressLoc", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DocAddressLoc
        {
        get { return mDocAddressLoc; }
        set { mDocAddressLoc = value; }
        }

        private Kroll.Pharmacy.Api.Data.TreatmentType mTreatmentType
            = Kroll.Pharmacy.Api.Data.TreatmentType.TreatmentType_NotSpecified;
        [global::ProtoBuf.ProtoMember(88, IsRequired = false, Name=@"TreatmentType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(89, IsRequired = false, Name=@"MaxDispQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(90, IsRequired = false, Name=@"MaxDispQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        