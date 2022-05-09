
        // Generated from: MailRecipient.proto
        // Note: requires additional types generated from: MailRecipientType_Enum.proto
        // Note: requires additional types generated from: MailRecipientTransmissionStatus_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MailRecipient")]
        public partial class MailRecipient : global::ProtoBuf.IExtensible
        {
        public MailRecipient() {}
        

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

        private int mMailId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"MailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MailId
        {
        get { return mMailId; }
        set { mMailId = value; }
        }

        private int mFolderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"FolderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int FolderId
        {
        get { return mFolderId; }
        set { mFolderId = value; }
        }

        private Kroll.Pharmacy.Api.Data.MailRecipientType mMailRecipientType
            = Kroll.Pharmacy.Api.Data.MailRecipientType.MailRecipientType_Unknown;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"MailRecipientType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MailRecipientType.MailRecipientType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.MailRecipientType MailRecipientType
        {
        get { return mMailRecipientType; }
        set { mMailRecipientType = value; }
        }

        private string mMailTo
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"MailTo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MailTo
        {
        get { return mMailTo; }
        set { mMailTo = value; }
        }

        private int mMailToUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"MailToUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MailToUserId
        {
        get { return mMailToUserId; }
        set { mMailToUserId = value; }
        }

        private bool mMailToUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"MailToUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MailToUserIdSpecified
        {
        get { return mMailToUserIdSpecified; }
        set { mMailToUserIdSpecified = value; }
        }

        private double mDateRead
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DateRead", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateRead
        {
        get { return mDateRead; }
        set { mDateRead = value; }
        }

        private bool mDateReadSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DateReadSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateReadSpecified
        {
        get { return mDateReadSpecified; }
        set { mDateReadSpecified = value; }
        }

        private double mDateDeleted
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"DateDeleted", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateDeleted
        {
        get { return mDateDeleted; }
        set { mDateDeleted = value; }
        }

        private bool mDateDeletedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DateDeletedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateDeletedSpecified
        {
        get { return mDateDeletedSpecified; }
        set { mDateDeletedSpecified = value; }
        }

        private int mFlagged
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Flagged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Flagged
        {
        get { return mFlagged; }
        set { mFlagged = value; }
        }

        private double mDateSent
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DateSent", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateSent
        {
        get { return mDateSent; }
        set { mDateSent = value; }
        }

        private bool mDateSentSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DateSentSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateSentSpecified
        {
        get { return mDateSentSpecified; }
        set { mDateSentSpecified = value; }
        }

        private string mSendErrors
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"SendErrors", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SendErrors
        {
        get { return mSendErrors; }
        set { mSendErrors = value; }
        }

        private Kroll.Pharmacy.Api.Data.MailRecipientTransmissionStatus mTransmissionStatus
            = Kroll.Pharmacy.Api.Data.MailRecipientTransmissionStatus.MailRecipientTransmissionStatus_None;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"TransmissionStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MailRecipientTransmissionStatus.MailRecipientTransmissionStatus_None)]
        
        public Kroll.Pharmacy.Api.Data.MailRecipientTransmissionStatus TransmissionStatus
        {
        get { return mTransmissionStatus; }
        set { mTransmissionStatus = value; }
        }

        private bool mSentToThirdParty
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"SentToThirdParty", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SentToThirdParty
        {
        get { return mSentToThirdParty; }
        set { mSentToThirdParty = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private string mExternalConfirmationNumber
            = "";
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ExternalConfirmationNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalConfirmationNumber
        {
        get { return mExternalConfirmationNumber; }
        set { mExternalConfirmationNumber = value; }
        }

        private int mERxTransmissionId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"ERxTransmissionId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ERxTransmissionId
        {
        get { return mERxTransmissionId; }
        set { mERxTransmissionId = value; }
        }

        private bool mERxTransmissionIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"ERxTransmissionIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ERxTransmissionIdSpecified
        {
        get { return mERxTransmissionIdSpecified; }
        set { mERxTransmissionIdSpecified = value; }
        }

        private double mRetryUntil
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"RetryUntil", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RetryUntil
        {
        get { return mRetryUntil; }
        set { mRetryUntil = value; }
        }

        private bool mRetryUntilSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"RetryUntilSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RetryUntilSpecified
        {
        get { return mRetryUntilSpecified; }
        set { mRetryUntilSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        