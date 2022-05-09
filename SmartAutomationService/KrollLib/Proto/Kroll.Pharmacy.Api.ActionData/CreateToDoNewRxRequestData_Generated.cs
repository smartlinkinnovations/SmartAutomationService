
        // Generated from: CreateToDoNewRxRequestData.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
        // Note: requires additional types generated from: RxOralWritten_Enum.proto
        // Note: requires additional types generated from: ProductSelection_Enum.proto
        // Note: requires additional types generated from: RxStatus_Enum.proto
        // Note: requires additional types generated from: DeliveryRouteType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateToDoNewRxRequestData")]
        public partial class CreateToDoNewRxRequestData : global::ProtoBuf.IExtensible
        {
        public CreateToDoNewRxRequestData() {}
        

        private double mDueDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DueDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DueDate
        {
        get { return mDueDate; }
        set { mDueDate = value; }
        }

        private bool mDueDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DueDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DueDateSpecified
        {
        get { return mDueDateSpecified; }
        set { mDueDateSpecified = value; }
        }

        private string mToDoComment
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ToDoComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ToDoComment
        {
        get { return mToDoComment; }
        set { mToDoComment = value; }
        }

        private string mToDoOrigin
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ToDoOrigin", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ToDoOrigin
        {
        get { return mToDoOrigin; }
        set { mToDoOrigin = value; }
        }

        private int mWorkOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"WorkOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"WorkOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WorkOrderIdSpecified
        {
        get { return mWorkOrderIdSpecified; }
        set { mWorkOrderIdSpecified = value; }
        }

        private int mSharedDBStoreId
            = 
                (int)1;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"SharedDBStoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                (int)1)]
        
        public int SharedDBStoreId
        {
        get { return mSharedDBStoreId; }
        set { mSharedDBStoreId = value; }
        }

        private bool mSharedDBStoreIdSpecified
            = 
                (bool)true;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"SharedDBStoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                (bool)true)]
        
        public bool SharedDBStoreIdSpecified
        {
        get { return mSharedDBStoreIdSpecified; }
        set { mSharedDBStoreIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mSharedDBStoreCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"SharedDBStoreCentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink SharedDBStoreCentralMaintLink
        {
        get { return mSharedDBStoreCentralMaintLink; }
        set { mSharedDBStoreCentralMaintLink = value; }
        }

        private bool mSharedDBStoreCentralMaintLinkSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"SharedDBStoreCentralMaintLinkSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SharedDBStoreCentralMaintLinkSpecified
        {
        get { return mSharedDBStoreCentralMaintLinkSpecified; }
        set { mSharedDBStoreCentralMaintLinkSpecified = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"DocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"DrgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"DrgIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"MixId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"MixIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"DIN", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"PackSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"PackSizeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PackSizeSpecified
        {
        get { return mPackSizeSpecified; }
        set { mPackSizeSpecified = value; }
        }

        private string mPatientName
            = "";
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"PatientName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PatientName
        {
        get { return mPatientName; }
        set { mPatientName = value; }
        }

        private string mDoctorName
            = "";
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"DoctorName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DoctorName
        {
        get { return mDoctorName; }
        set { mDoctorName = value; }
        }

        private string mDrugName
            = "";
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"DrugName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrugName
        {
        get { return mDrugName; }
        set { mDrugName = value; }
        }

        private int mScriptImageId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"ScriptImageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"ScriptImageIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"Sig", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"DispQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"DispQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"AuthQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"AuthQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"UnlimitedRefills", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"RxExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"RxExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"DaysSupply", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"DaysSupplySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"OralWritten", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"StartDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"StartDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"StopDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"StopDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StopDateSpecified
        {
        get { return mStopDateSpecified; }
        set { mStopDateSpecified = value; }
        }

        private string mRxComment
            = "";
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"RxComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RxComment
        {
        get { return mRxComment; }
        set { mRxComment = value; }
        }

        private string mExternalRxReference
            = "";
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"ExternalRxReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalRxReference
        {
        get { return mExternalRxReference; }
        set { mExternalRxReference = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxStatus mRxStatus
            = Kroll.Pharmacy.Api.Data.RxStatus.RxStatus_Fill;
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"RxStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxStatus.RxStatus_Fill)]
        
        public Kroll.Pharmacy.Api.Data.RxStatus RxStatus
        {
        get { return mRxStatus; }
        set { mRxStatus = value; }
        }

        private string mReasonCode
            = "";
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"ReasonCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReasonCode
        {
        get { return mReasonCode; }
        set { mReasonCode = value; }
        }

        private Kroll.Pharmacy.Api.Data.ProductSelection mProductSelection
            = Kroll.Pharmacy.Api.Data.ProductSelection.ProductSelection_None;
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"ProductSelection", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ProductSelection.ProductSelection_None)]
        
        public Kroll.Pharmacy.Api.Data.ProductSelection ProductSelection
        {
        get { return mProductSelection; }
        set { mProductSelection = value; }
        }

        private int mMinIntervalDays
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"MinIntervalDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"MinIntervalDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"FDBRouteCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBRouteCode
        {
        get { return mFDBRouteCode; }
        set { mFDBRouteCode = value; }
        }

        private string mFDBDosageFormCode
            = "";
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"FDBDosageFormCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBDosageFormCode
        {
        get { return mFDBDosageFormCode; }
        set { mFDBDosageFormCode = value; }
        }

        private bool mRxTransferIn
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"RxTransferIn", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxTransferIn
        {
        get { return mRxTransferIn; }
        set { mRxTransferIn = value; }
        }

        private int mRxTransferStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"RxTransferStoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxTransferStoreId
        {
        get { return mRxTransferStoreId; }
        set { mRxTransferStoreId = value; }
        }

        private double mRxTransferDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(72, IsRequired = false, Name=@"RxTransferDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RxTransferDate
        {
        get { return mRxTransferDate; }
        set { mRxTransferDate = value; }
        }

        private string mRxTransferOtherStorePharmacist
            = "";
        [global::ProtoBuf.ProtoMember(73, IsRequired = false, Name=@"RxTransferOtherStorePharmacist", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RxTransferOtherStorePharmacist
        {
        get { return mRxTransferOtherStorePharmacist; }
        set { mRxTransferOtherStorePharmacist = value; }
        }

        private string mRxTransferComment
            = "";
        [global::ProtoBuf.ProtoMember(74, IsRequired = false, Name=@"RxTransferComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RxTransferComment
        {
        get { return mRxTransferComment; }
        set { mRxTransferComment = value; }
        }

        private double mRxTransferOtherStoreFirstFillDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(75, IsRequired = false, Name=@"RxTransferOtherStoreFirstFillDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RxTransferOtherStoreFirstFillDate
        {
        get { return mRxTransferOtherStoreFirstFillDate; }
        set { mRxTransferOtherStoreFirstFillDate = value; }
        }

        private bool mRxTransferOtherStoreFirstFillDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(76, IsRequired = false, Name=@"RxTransferOtherStoreFirstFillDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxTransferOtherStoreFirstFillDateSpecified
        {
        get { return mRxTransferOtherStoreFirstFillDateSpecified; }
        set { mRxTransferOtherStoreFirstFillDateSpecified = value; }
        }

        private double mRxTransferOtherStoreLastFillDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(77, IsRequired = false, Name=@"RxTransferOtherStoreLastFillDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RxTransferOtherStoreLastFillDate
        {
        get { return mRxTransferOtherStoreLastFillDate; }
        set { mRxTransferOtherStoreLastFillDate = value; }
        }

        private bool mRxTransferOtherStoreLastFillDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(78, IsRequired = false, Name=@"RxTransferOtherStoreLastFillDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxTransferOtherStoreLastFillDateSpecified
        {
        get { return mRxTransferOtherStoreLastFillDateSpecified; }
        set { mRxTransferOtherStoreLastFillDateSpecified = value; }
        }

        private string mRxTransferOtherStoreRxNum
            = "";
        [global::ProtoBuf.ProtoMember(79, IsRequired = false, Name=@"RxTransferOtherStoreRxNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RxTransferOtherStoreRxNum
        {
        get { return mRxTransferOtherStoreRxNum; }
        set { mRxTransferOtherStoreRxNum = value; }
        }

        private int mRxTransferOtherStoreOriginalFills
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(80, IsRequired = false, Name=@"RxTransferOtherStoreOriginalFills", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxTransferOtherStoreOriginalFills
        {
        get { return mRxTransferOtherStoreOriginalFills; }
        set { mRxTransferOtherStoreOriginalFills = value; }
        }

        private bool mRxTransferOtherStoreOriginalFillsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(81, IsRequired = false, Name=@"RxTransferOtherStoreOriginalFillsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxTransferOtherStoreOriginalFillsSpecified
        {
        get { return mRxTransferOtherStoreOriginalFillsSpecified; }
        set { mRxTransferOtherStoreOriginalFillsSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.DeliveryRouteType mDeliveryRouteType
            = Kroll.Pharmacy.Api.Data.DeliveryRouteType.DeliveryRouteType_Default;
        [global::ProtoBuf.ProtoMember(82, IsRequired = false, Name=@"DeliveryRouteType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DeliveryRouteType.DeliveryRouteType_Default)]
        
        public Kroll.Pharmacy.Api.Data.DeliveryRouteType DeliveryRouteType
        {
        get { return mDeliveryRouteType; }
        set { mDeliveryRouteType = value; }
        }

        private int mCopyFromRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(83, IsRequired = false, Name=@"CopyFromRxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CopyFromRxNum
        {
        get { return mCopyFromRxNum; }
        set { mCopyFromRxNum = value; }
        }

        private bool mCopyFromRxNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(84, IsRequired = false, Name=@"CopyFromRxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CopyFromRxNumSpecified
        {
        get { return mCopyFromRxNumSpecified; }
        set { mCopyFromRxNumSpecified = value; }
        }

        private string mToDoOriginContext
            = "";
        [global::ProtoBuf.ProtoMember(85, IsRequired = false, Name=@"ToDoOriginContext", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ToDoOriginContext
        {
        get { return mToDoOriginContext; }
        set { mToDoOriginContext = value; }
        }

        private int mDueDateCategoryId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(86, IsRequired = false, Name=@"DueDateCategoryId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DueDateCategoryId
        {
        get { return mDueDateCategoryId; }
        set { mDueDateCategoryId = value; }
        }

        private bool mDueDateCategoryIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(87, IsRequired = false, Name=@"DueDateCategoryIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DueDateCategoryIdSpecified
        {
        get { return mDueDateCategoryIdSpecified; }
        set { mDueDateCategoryIdSpecified = value; }
        }

        private bool mManualPrice
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(88, IsRequired = false, Name=@"ManualPrice", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(89, IsRequired = false, Name=@"ManualPriceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(90, IsRequired = false, Name=@"Cost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(91, IsRequired = false, Name=@"CostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(92, IsRequired = false, Name=@"DiscountCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(93, IsRequired = false, Name=@"DiscountCostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(94, IsRequired = false, Name=@"Markup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(95, IsRequired = false, Name=@"MarkupSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(96, IsRequired = false, Name=@"DiscountMarkup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(97, IsRequired = false, Name=@"DiscountMarkupSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(98, IsRequired = false, Name=@"Fee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(99, IsRequired = false, Name=@"FeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(100, IsRequired = false, Name=@"DiscountFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(101, IsRequired = false, Name=@"DiscountFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(102, IsRequired = false, Name=@"MixFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(103, IsRequired = false, Name=@"MixFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(104, IsRequired = false, Name=@"DiscountMixFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(105, IsRequired = false, Name=@"DiscountMixFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(106, IsRequired = false, Name=@"SscFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(107, IsRequired = false, Name=@"SscFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(108, IsRequired = false, Name=@"DiscountSscFee", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(109, IsRequired = false, Name=@"DiscountSscFeeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(110, IsRequired = false, Name=@"DocAddressLoc", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DocAddressLoc
        {
        get { return mDocAddressLoc; }
        set { mDocAddressLoc = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        