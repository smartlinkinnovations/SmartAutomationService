
        // Generated from: ARElectronicPayment.proto
        // Note: requires additional types generated from: ARElectronicPaymentItem.proto
        // Note: requires additional types generated from: PaymentCardType_Enum.proto
        // Note: requires additional types generated from: ARElectronicPaymentStatus_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ARElectronicPayment")]
        public partial class ARElectronicPayment : global::ProtoBuf.IExtensible
        {
        public ARElectronicPayment() {}
        

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

        private Kroll.Pharmacy.Api.Data.ARElectronicPaymentStatus mStatus
            = Kroll.Pharmacy.Api.Data.ARElectronicPaymentStatus.ARElectronicPaymentStatus_Pending;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ARElectronicPaymentStatus.ARElectronicPaymentStatus_Pending)]
        
        public Kroll.Pharmacy.Api.Data.ARElectronicPaymentStatus Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private Kroll.Pharmacy.Api.Data.PaymentCardType mDebitType
            = Kroll.Pharmacy.Api.Data.PaymentCardType.PaymentCardType_CreditCard;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DebitType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PaymentCardType.PaymentCardType_CreditCard)]
        
        public Kroll.Pharmacy.Api.Data.PaymentCardType DebitType
        {
        get { return mDebitType; }
        set { mDebitType = value; }
        }

        private int mItemCount
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ItemCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ItemCount
        {
        get { return mItemCount; }
        set { mItemCount = value; }
        }

        private double mItemTotal
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ItemTotal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ItemTotal
        {
        get { return mItemTotal; }
        set { mItemTotal = value; }
        }

        private int mCreatedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"CreatedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CreatedByUserId
        {
        get { return mCreatedByUserId; }
        set { mCreatedByUserId = value; }
        }

        private bool mCreatedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"CreatedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CreatedByUserIdSpecified
        {
        get { return mCreatedByUserIdSpecified; }
        set { mCreatedByUserIdSpecified = value; }
        }

        private int mCreatedByUserInit
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CreatedByUserInit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CreatedByUserInit
        {
        get { return mCreatedByUserInit; }
        set { mCreatedByUserInit = value; }
        }

        private double mDateRequestFinalized
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"DateRequestFinalized", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateRequestFinalized
        {
        get { return mDateRequestFinalized; }
        set { mDateRequestFinalized = value; }
        }

        private bool mDateRequestFinalizedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DateRequestFinalizedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateRequestFinalizedSpecified
        {
        get { return mDateRequestFinalizedSpecified; }
        set { mDateRequestFinalizedSpecified = value; }
        }

        private int mRequestFinalizedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"RequestFinalizedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RequestFinalizedByUserId
        {
        get { return mRequestFinalizedByUserId; }
        set { mRequestFinalizedByUserId = value; }
        }

        private bool mRequestFinalizedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"RequestFinalizedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RequestFinalizedByUserIdSpecified
        {
        get { return mRequestFinalizedByUserIdSpecified; }
        set { mRequestFinalizedByUserIdSpecified = value; }
        }

        private string mRequestFinalizedByUserInit
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"RequestFinalizedByUserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RequestFinalizedByUserInit
        {
        get { return mRequestFinalizedByUserInit; }
        set { mRequestFinalizedByUserInit = value; }
        }

        private double mDateRequestExported
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"DateRequestExported", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateRequestExported
        {
        get { return mDateRequestExported; }
        set { mDateRequestExported = value; }
        }

        private bool mDateRequestExportedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"DateRequestExportedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateRequestExportedSpecified
        {
        get { return mDateRequestExportedSpecified; }
        set { mDateRequestExportedSpecified = value; }
        }

        private int mRequestExportedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"RequestExportedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RequestExportedByUserId
        {
        get { return mRequestExportedByUserId; }
        set { mRequestExportedByUserId = value; }
        }

        private bool mRequestExportedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"RequestExportedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RequestExportedByUserIdSpecified
        {
        get { return mRequestExportedByUserIdSpecified; }
        set { mRequestExportedByUserIdSpecified = value; }
        }

        private string mRequestExportedByUserInit
            = "";
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"RequestExportedByUserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RequestExportedByUserInit
        {
        get { return mRequestExportedByUserInit; }
        set { mRequestExportedByUserInit = value; }
        }

        private double mDateReconciled
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DateReconciled", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateReconciled
        {
        get { return mDateReconciled; }
        set { mDateReconciled = value; }
        }

        private bool mDateReconciledSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"DateReconciledSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateReconciledSpecified
        {
        get { return mDateReconciledSpecified; }
        set { mDateReconciledSpecified = value; }
        }

        private int mReconciledByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"ReconciledByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ReconciledByUserId
        {
        get { return mReconciledByUserId; }
        set { mReconciledByUserId = value; }
        }

        private bool mReconciledByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ReconciledByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ReconciledByUserIdSpecified
        {
        get { return mReconciledByUserIdSpecified; }
        set { mReconciledByUserIdSpecified = value; }
        }

        private string mReconciledByUserInit
            = "";
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"ReconciledByUserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReconciledByUserInit
        {
        get { return mReconciledByUserInit; }
        set { mReconciledByUserInit = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARElectronicPaymentItem> mElectronicPayments = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARElectronicPaymentItem>();
        [global::ProtoBuf.ProtoMember(25, Name=@"ElectronicPayments", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARElectronicPaymentItem> ElectronicPayments
        {
        get { return mElectronicPayments; }
        }
    

        private int mDocumentContentId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"DocumentContentId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DocumentContentId
        {
        get { return mDocumentContentId; }
        set { mDocumentContentId = value; }
        }

        private bool mDocumentContentIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"DocumentContentIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocumentContentIdSpecified
        {
        get { return mDocumentContentIdSpecified; }
        set { mDocumentContentIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        