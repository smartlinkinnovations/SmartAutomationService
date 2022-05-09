
        // Generated from: RxTracking.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxTracking")]
        public partial class RxTracking : global::ProtoBuf.IExtensible
        {
        public RxTracking() {}
        

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

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private double mDueDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DueDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DueDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DueDateSpecified
        {
        get { return mDueDateSpecified; }
        set { mDueDateSpecified = value; }
        }

        private int mStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private double mEnteredDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"EnteredDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double EnteredDate
        {
        get { return mEnteredDate; }
        set { mEnteredDate = value; }
        }

        private bool mEnteredDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"EnteredDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EnteredDateSpecified
        {
        get { return mEnteredDateSpecified; }
        set { mEnteredDateSpecified = value; }
        }

        private string mEnteredInit
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"EnteredInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string EnteredInit
        {
        get { return mEnteredInit; }
        set { mEnteredInit = value; }
        }

        private double mEntryVerifiedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"EntryVerifiedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double EntryVerifiedDate
        {
        get { return mEntryVerifiedDate; }
        set { mEntryVerifiedDate = value; }
        }

        private bool mEntryVerifiedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"EntryVerifiedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EntryVerifiedDateSpecified
        {
        get { return mEntryVerifiedDateSpecified; }
        set { mEntryVerifiedDateSpecified = value; }
        }

        private string mEntryVerifiedInit
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"EntryVerifiedInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string EntryVerifiedInit
        {
        get { return mEntryVerifiedInit; }
        set { mEntryVerifiedInit = value; }
        }

        private double mLabelsPrintedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"LabelsPrintedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LabelsPrintedDate
        {
        get { return mLabelsPrintedDate; }
        set { mLabelsPrintedDate = value; }
        }

        private bool mLabelsPrintedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"LabelsPrintedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LabelsPrintedDateSpecified
        {
        get { return mLabelsPrintedDateSpecified; }
        set { mLabelsPrintedDateSpecified = value; }
        }

        private string mLabelsPrintedInit
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"LabelsPrintedInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LabelsPrintedInit
        {
        get { return mLabelsPrintedInit; }
        set { mLabelsPrintedInit = value; }
        }

        private double mAdjudicatedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"AdjudicatedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AdjudicatedDate
        {
        get { return mAdjudicatedDate; }
        set { mAdjudicatedDate = value; }
        }

        private bool mAdjudicatedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"AdjudicatedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AdjudicatedDateSpecified
        {
        get { return mAdjudicatedDateSpecified; }
        set { mAdjudicatedDateSpecified = value; }
        }

        private string mAdjudicatedInit
            = "";
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"AdjudicatedInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AdjudicatedInit
        {
        get { return mAdjudicatedInit; }
        set { mAdjudicatedInit = value; }
        }

        private double mPackagedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"PackagedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double PackagedDate
        {
        get { return mPackagedDate; }
        set { mPackagedDate = value; }
        }

        private bool mPackagedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"PackagedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PackagedDateSpecified
        {
        get { return mPackagedDateSpecified; }
        set { mPackagedDateSpecified = value; }
        }

        private string mPackagedInit
            = "";
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"PackagedInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PackagedInit
        {
        get { return mPackagedInit; }
        set { mPackagedInit = value; }
        }

        private double mPackageVerifiedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"PackageVerifiedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double PackageVerifiedDate
        {
        get { return mPackageVerifiedDate; }
        set { mPackageVerifiedDate = value; }
        }

        private bool mPackageVerifiedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"PackageVerifiedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PackageVerifiedDateSpecified
        {
        get { return mPackageVerifiedDateSpecified; }
        set { mPackageVerifiedDateSpecified = value; }
        }

        private string mPackageVerifiedInit
            = "";
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"PackageVerifiedInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PackageVerifiedInit
        {
        get { return mPackageVerifiedInit; }
        set { mPackageVerifiedInit = value; }
        }

        private double mShippedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"ShippedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ShippedDate
        {
        get { return mShippedDate; }
        set { mShippedDate = value; }
        }

        private bool mShippedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"ShippedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ShippedDateSpecified
        {
        get { return mShippedDateSpecified; }
        set { mShippedDateSpecified = value; }
        }

        private string mShippedInit
            = "";
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"ShippedInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShippedInit
        {
        get { return mShippedInit; }
        set { mShippedInit = value; }
        }

        private double mShippingLogReceivedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"ShippingLogReceivedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ShippingLogReceivedDate
        {
        get { return mShippingLogReceivedDate; }
        set { mShippingLogReceivedDate = value; }
        }

        private bool mShippingLogReceivedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"ShippingLogReceivedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ShippingLogReceivedDateSpecified
        {
        get { return mShippingLogReceivedDateSpecified; }
        set { mShippingLogReceivedDateSpecified = value; }
        }

        private string mShippingLogReceivedInit
            = "";
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"ShippingLogReceivedInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShippingLogReceivedInit
        {
        get { return mShippingLogReceivedInit; }
        set { mShippingLogReceivedInit = value; }
        }

        private double mPickedUpDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"PickedUpDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double PickedUpDate
        {
        get { return mPickedUpDate; }
        set { mPickedUpDate = value; }
        }

        private bool mPickedUpDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"PickedUpDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PickedUpDateSpecified
        {
        get { return mPickedUpDateSpecified; }
        set { mPickedUpDateSpecified = value; }
        }

        private string mPickedUpInit
            = "";
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"PickedUpInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PickedUpInit
        {
        get { return mPickedUpInit; }
        set { mPickedUpInit = value; }
        }

        private double mReceivedFromCFDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"ReceivedFromCFDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ReceivedFromCFDate
        {
        get { return mReceivedFromCFDate; }
        set { mReceivedFromCFDate = value; }
        }

        private bool mReceivedFromCFDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"ReceivedFromCFDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ReceivedFromCFDateSpecified
        {
        get { return mReceivedFromCFDateSpecified; }
        set { mReceivedFromCFDateSpecified = value; }
        }

        private string mReceivedFromCFInit
            = "";
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"ReceivedFromCFInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReceivedFromCFInit
        {
        get { return mReceivedFromCFInit; }
        set { mReceivedFromCFInit = value; }
        }

        private double mScannedAtPOSDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"ScannedAtPOSDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ScannedAtPOSDate
        {
        get { return mScannedAtPOSDate; }
        set { mScannedAtPOSDate = value; }
        }

        private bool mScannedAtPOSDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"ScannedAtPOSDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScannedAtPOSDateSpecified
        {
        get { return mScannedAtPOSDateSpecified; }
        set { mScannedAtPOSDateSpecified = value; }
        }

        private string mScannedAtPOSInfo
            = "";
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"ScannedAtPOSInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ScannedAtPOSInfo
        {
        get { return mScannedAtPOSInfo; }
        set { mScannedAtPOSInfo = value; }
        }

        private double mHardCopyPrintedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"HardCopyPrintedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double HardCopyPrintedDate
        {
        get { return mHardCopyPrintedDate; }
        set { mHardCopyPrintedDate = value; }
        }

        private bool mHardCopyPrintedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"HardCopyPrintedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HardCopyPrintedDateSpecified
        {
        get { return mHardCopyPrintedDateSpecified; }
        set { mHardCopyPrintedDateSpecified = value; }
        }

        private string mHardCopyPrintedInit
            = "";
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"HardCopyPrintedInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string HardCopyPrintedInit
        {
        get { return mHardCopyPrintedInit; }
        set { mHardCopyPrintedInit = value; }
        }

        private double mReceiptPrintedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"ReceiptPrintedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ReceiptPrintedDate
        {
        get { return mReceiptPrintedDate; }
        set { mReceiptPrintedDate = value; }
        }

        private bool mReceiptPrintedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"ReceiptPrintedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ReceiptPrintedDateSpecified
        {
        get { return mReceiptPrintedDateSpecified; }
        set { mReceiptPrintedDateSpecified = value; }
        }

        private string mReceiptPrintedInit
            = "";
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"ReceiptPrintedInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReceiptPrintedInit
        {
        get { return mReceiptPrintedInit; }
        set { mReceiptPrintedInit = value; }
        }

        private double mKrollCarePrintedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"KrollCarePrintedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double KrollCarePrintedDate
        {
        get { return mKrollCarePrintedDate; }
        set { mKrollCarePrintedDate = value; }
        }

        private bool mKrollCarePrintedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"KrollCarePrintedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool KrollCarePrintedDateSpecified
        {
        get { return mKrollCarePrintedDateSpecified; }
        set { mKrollCarePrintedDateSpecified = value; }
        }

        private string mKrollCarePrintedInit
            = "";
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"KrollCarePrintedInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string KrollCarePrintedInit
        {
        get { return mKrollCarePrintedInit; }
        set { mKrollCarePrintedInit = value; }
        }

        private int mErrorCondition
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"ErrorCondition", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ErrorCondition
        {
        get { return mErrorCondition; }
        set { mErrorCondition = value; }
        }

        private bool mErrorConditionSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"ErrorConditionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ErrorConditionSpecified
        {
        get { return mErrorConditionSpecified; }
        set { mErrorConditionSpecified = value; }
        }

        private bool mCompleted
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"Completed", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Completed
        {
        get { return mCompleted; }
        set { mCompleted = value; }
        }

        private int mWorkflowType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"WorkflowType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int WorkflowType
        {
        get { return mWorkflowType; }
        set { mWorkflowType = value; }
        }

        private bool mWorkflowTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"WorkflowTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WorkflowTypeSpecified
        {
        get { return mWorkflowTypeSpecified; }
        set { mWorkflowTypeSpecified = value; }
        }

        private double mReadyForPickupDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"ReadyForPickupDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ReadyForPickupDate
        {
        get { return mReadyForPickupDate; }
        set { mReadyForPickupDate = value; }
        }

        private bool mReadyForPickupDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"ReadyForPickupDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ReadyForPickupDateSpecified
        {
        get { return mReadyForPickupDateSpecified; }
        set { mReadyForPickupDateSpecified = value; }
        }

        private string mReadyForPickupInit
            = "";
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"ReadyForPickupInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReadyForPickupInit
        {
        get { return mReadyForPickupInit; }
        set { mReadyForPickupInit = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        