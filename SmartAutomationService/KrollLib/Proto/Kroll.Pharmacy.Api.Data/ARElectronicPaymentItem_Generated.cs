
        // Generated from: ARElectronicPaymentItem.proto
        // Note: requires additional types generated from: ARPayment.proto
        // Note: requires additional types generated from: ARElectronicPaymentItemStatus_Enum.proto
        // Note: requires additional types generated from: ARElectronicPaymentItemPaymentStatus_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ARElectronicPaymentItem")]
        public partial class ARElectronicPaymentItem : global::ProtoBuf.IExtensible
        {
        public ARElectronicPaymentItem() {}
        

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

        private int mARElectronicPaymentId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ARElectronicPaymentId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ARElectronicPaymentId
        {
        get { return mARElectronicPaymentId; }
        set { mARElectronicPaymentId = value; }
        }

        private int mARId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ARId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ARId
        {
        get { return mARId; }
        set { mARId = value; }
        }

        private int mARPaymentId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ARPaymentId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ARPaymentId
        {
        get { return mARPaymentId; }
        set { mARPaymentId = value; }
        }

        private int mReversalARPaymentId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ReversalARPaymentId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ReversalARPaymentId
        {
        get { return mReversalARPaymentId; }
        set { mReversalARPaymentId = value; }
        }

        private bool mREversalARPaymentIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"REversalARPaymentIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool REversalARPaymentIdSpecified
        {
        get { return mREversalARPaymentIdSpecified; }
        set { mREversalARPaymentIdSpecified = value; }
        }

        private int mPatCreditCardId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PatCreditCardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatCreditCardId
        {
        get { return mPatCreditCardId; }
        set { mPatCreditCardId = value; }
        }

        private bool mPatCreditCardIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"PatCreditCardIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatCreditCardIdSpecified
        {
        get { return mPatCreditCardIdSpecified; }
        set { mPatCreditCardIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.ARElectronicPaymentItemStatus mStatus
            = Kroll.Pharmacy.Api.Data.ARElectronicPaymentItemStatus.ARElectronicPaymentItemStatus_Pending;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ARElectronicPaymentItemStatus.ARElectronicPaymentItemStatus_Pending)]
        
        public Kroll.Pharmacy.Api.Data.ARElectronicPaymentItemStatus Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private double mARBalance
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ARBalance", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ARBalance
        {
        get { return mARBalance; }
        set { mARBalance = value; }
        }

        private double mPaymentAmount
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"PaymentAmount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double PaymentAmount
        {
        get { return mPaymentAmount; }
        set { mPaymentAmount = value; }
        }

        private Kroll.Pharmacy.Api.Data.ARElectronicPaymentItemPaymentStatus mPaymentStatus
            = Kroll.Pharmacy.Api.Data.ARElectronicPaymentItemPaymentStatus.ARElectronicPaymentItemPaymentStatus_Pending;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"PaymentStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ARElectronicPaymentItemPaymentStatus.ARElectronicPaymentItemPaymentStatus_Pending)]
        
        public Kroll.Pharmacy.Api.Data.ARElectronicPaymentItemPaymentStatus PaymentStatus
        {
        get { return mPaymentStatus; }
        set { mPaymentStatus = value; }
        }

        private string mPaymentCardType
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"PaymentCardType", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PaymentCardType
        {
        get { return mPaymentCardType; }
        set { mPaymentCardType = value; }
        }

        private double mPaymentCardExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"PaymentCardExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double PaymentCardExpiryDate
        {
        get { return mPaymentCardExpiryDate; }
        set { mPaymentCardExpiryDate = value; }
        }

        private string mPaymentMaskedCardNumber
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"PaymentMaskedCardNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PaymentMaskedCardNumber
        {
        get { return mPaymentMaskedCardNumber; }
        set { mPaymentMaskedCardNumber = value; }
        }

        private int mPaymentMessageLevel
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"PaymentMessageLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PaymentMessageLevel
        {
        get { return mPaymentMessageLevel; }
        set { mPaymentMessageLevel = value; }
        }

        private string mPaymentMessage
            = "";
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"PaymentMessage", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PaymentMessage
        {
        get { return mPaymentMessage; }
        set { mPaymentMessage = value; }
        }

        private string mReferenceNum
            = "";
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"ReferenceNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReferenceNum
        {
        get { return mReferenceNum; }
        set { mReferenceNum = value; }
        }

        private string mResponseCode
            = "";
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"ResponseCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResponseCode
        {
        get { return mResponseCode; }
        set { mResponseCode = value; }
        }

        private string mResponseCodeISO
            = "";
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"ResponseCodeISO", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResponseCodeISO
        {
        get { return mResponseCodeISO; }
        set { mResponseCodeISO = value; }
        }

        private string mResponseTransactionNumber
            = "";
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"ResponseTransactionNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResponseTransactionNumber
        {
        get { return mResponseTransactionNumber; }
        set { mResponseTransactionNumber = value; }
        }

        private string mAuthorizationCode
            = "";
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"AuthorizationCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AuthorizationCode
        {
        get { return mAuthorizationCode; }
        set { mAuthorizationCode = value; }
        }

        private double mHostProcessingDateTime
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"HostProcessingDateTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double HostProcessingDateTime
        {
        get { return mHostProcessingDateTime; }
        set { mHostProcessingDateTime = value; }
        }

        private bool mHostProcessingDateTimeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"HostProcessingDateTimeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HostProcessingDateTimeSpecified
        {
        get { return mHostProcessingDateTimeSpecified; }
        set { mHostProcessingDateTimeSpecified = value; }
        }

        private bool mIsElectronicResponse
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"IsElectronicResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsElectronicResponse
        {
        get { return mIsElectronicResponse; }
        set { mIsElectronicResponse = value; }
        }

        private double mDateResponseImported
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"DateResponseImported", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateResponseImported
        {
        get { return mDateResponseImported; }
        set { mDateResponseImported = value; }
        }

        private int mResponseImportedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"ResponseImportedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ResponseImportedByUserId
        {
        get { return mResponseImportedByUserId; }
        set { mResponseImportedByUserId = value; }
        }

        private bool mResponseImportedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"ResponseImportedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ResponseImportedByUserIdSpecified
        {
        get { return mResponseImportedByUserIdSpecified; }
        set { mResponseImportedByUserIdSpecified = value; }
        }

        private string mResponseImportedByUserInit
            = "";
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"ResponseImportedByUserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResponseImportedByUserInit
        {
        get { return mResponseImportedByUserInit; }
        set { mResponseImportedByUserInit = value; }
        }

        private double mDateReconciled
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"DateReconciled", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"DateReconciledSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"ReconciledByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"ReconciledByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"ReconciledByUserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReconciledByUserInit
        {
        get { return mReconciledByUserInit; }
        set { mReconciledByUserInit = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARPayment> mPayments = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARPayment>();
        [global::ProtoBuf.ProtoMember(35, Name=@"Payments", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARPayment> Payments
        {
        get { return mPayments; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        