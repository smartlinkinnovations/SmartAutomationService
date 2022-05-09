
        // Generated from: Mail.proto
        // Note: requires additional types generated from: MailMessageType_Enum.proto
        // Note: requires additional types generated from: MailAttachment.proto
        // Note: requires additional types generated from: MailRecipient.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Mail")]
        public partial class Mail : global::ProtoBuf.IExtensible
        {
        public Mail() {}
        

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

        private Kroll.Pharmacy.Api.Data.MailMessageType mMessageType
            = Kroll.Pharmacy.Api.Data.MailMessageType.MailMessageType_Unknown;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"MessageType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MailMessageType.MailMessageType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.MailMessageType MessageType
        {
        get { return mMessageType; }
        set { mMessageType = value; }
        }

        private string mMessageId
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"MessageId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MessageId
        {
        get { return mMessageId; }
        set { mMessageId = value; }
        }

        private string mInReplyToMessageId
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"InReplyToMessageId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string InReplyToMessageId
        {
        get { return mInReplyToMessageId; }
        set { mInReplyToMessageId = value; }
        }

        private string mMailFrom
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"MailFrom", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MailFrom
        {
        get { return mMailFrom; }
        set { mMailFrom = value; }
        }

        private int mMailFromUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"MailFromUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MailFromUserId
        {
        get { return mMailFromUserId; }
        set { mMailFromUserId = value; }
        }

        private bool mMailFromUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"MailFromUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MailFromUserIdSpecified
        {
        get { return mMailFromUserIdSpecified; }
        set { mMailFromUserIdSpecified = value; }
        }

        private string mSubject
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Subject", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Subject
        {
        get { return mSubject; }
        set { mSubject = value; }
        }

        private string mContent
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Content", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Content
        {
        get { return mContent; }
        set { mContent = value; }
        }

        private string mContentEncoding
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ContentEncoding", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ContentEncoding
        {
        get { return mContentEncoding; }
        set { mContentEncoding = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private double mShowAfterDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ShowAfterDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ShowAfterDate
        {
        get { return mShowAfterDate; }
        set { mShowAfterDate = value; }
        }

        private bool mShowAfterDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ShowAfterDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ShowAfterDateSpecified
        {
        get { return mShowAfterDateSpecified; }
        set { mShowAfterDateSpecified = value; }
        }

        private double mExpireAfterDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"ExpireAfterDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ExpireAfterDate
        {
        get { return mExpireAfterDate; }
        set { mExpireAfterDate = value; }
        }

        private bool mExpireAfterDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"ExpireAfterDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExpireAfterDateSpecified
        {
        get { return mExpireAfterDateSpecified; }
        set { mExpireAfterDateSpecified = value; }
        }

        private double mSenderDateDeleted
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"SenderDateDeleted", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SenderDateDeleted
        {
        get { return mSenderDateDeleted; }
        set { mSenderDateDeleted = value; }
        }

        private bool mSenderDateDeletedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"SenderDateDeletedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SenderDateDeletedSpecified
        {
        get { return mSenderDateDeletedSpecified; }
        set { mSenderDateDeletedSpecified = value; }
        }

        private int mSenderFolderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"SenderFolderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SenderFolderId
        {
        get { return mSenderFolderId; }
        set { mSenderFolderId = value; }
        }

        private bool mSenderFolderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"SenderFolderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SenderFolderIdSpecified
        {
        get { return mSenderFolderIdSpecified; }
        set { mSenderFolderIdSpecified = value; }
        }

        private int mPriority
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"Priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Priority
        {
        get { return mPriority; }
        set { mPriority = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"DocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocIdSpecified
        {
        get { return mDocIdSpecified; }
        set { mDocIdSpecified = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxNumSpecified
        {
        get { return mRxNumSpecified; }
        set { mRxNumSpecified = value; }
        }

        private int mVendorId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"VendorId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int VendorId
        {
        get { return mVendorId; }
        set { mVendorId = value; }
        }

        private bool mVendorIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"VendorIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool VendorIdSpecified
        {
        get { return mVendorIdSpecified; }
        set { mVendorIdSpecified = value; }
        }

        private int mNHId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"NHId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"NHIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"NHWardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"NHWardIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHWardIdSpecified
        {
        get { return mNHWardIdSpecified; }
        set { mNHWardIdSpecified = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"StoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StoreIdSpecified
        {
        get { return mStoreIdSpecified; }
        set { mStoreIdSpecified = value; }
        }

        private int mNHCycleId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"NHCycleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"NHCycleIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHCycleIdSpecified
        {
        get { return mNHCycleIdSpecified; }
        set { mNHCycleIdSpecified = value; }
        }

        private int mNHBatchId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"NHBatchId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHBatchId
        {
        get { return mNHBatchId; }
        set { mNHBatchId = value; }
        }

        private bool mNHBatchIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"NHBatchIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHBatchIdSpecified
        {
        get { return mNHBatchIdSpecified; }
        set { mNHBatchIdSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MailAttachment> mMailAttachments = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MailAttachment>();
        [global::ProtoBuf.ProtoMember(44, Name=@"MailAttachments", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MailAttachment> MailAttachments
        {
        get { return mMailAttachments; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MailRecipient> mMailRecipients = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MailRecipient>();
        [global::ProtoBuf.ProtoMember(45, Name=@"MailRecipients", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MailRecipient> MailRecipients
        {
        get { return mMailRecipients; }
        }
    

        private int mPatMedReviewId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"PatMedReviewId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatMedReviewId
        {
        get { return mPatMedReviewId; }
        set { mPatMedReviewId = value; }
        }

        private bool mPatMedReviewIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"PatMedReviewIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatMedReviewIdSpecified
        {
        get { return mPatMedReviewIdSpecified; }
        set { mPatMedReviewIdSpecified = value; }
        }

        private int mMedReviewDocLetterId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"MedReviewDocLetterId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MedReviewDocLetterId
        {
        get { return mMedReviewDocLetterId; }
        set { mMedReviewDocLetterId = value; }
        }

        private bool mMedReviewDocLetterIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"MedReviewDocLetterIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MedReviewDocLetterIdSpecified
        {
        get { return mMedReviewDocLetterIdSpecified; }
        set { mMedReviewDocLetterIdSpecified = value; }
        }

        private string mExternalPatReference
            = "";
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"ExternalPatReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalPatReference
        {
        get { return mExternalPatReference; }
        set { mExternalPatReference = value; }
        }

        private bool mExternalPatReferenceSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"ExternalPatReferenceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExternalPatReferenceSpecified
        {
        get { return mExternalPatReferenceSpecified; }
        set { mExternalPatReferenceSpecified = value; }
        }

        private string mExternalDocReference
            = "";
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"ExternalDocReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalDocReference
        {
        get { return mExternalDocReference; }
        set { mExternalDocReference = value; }
        }

        private bool mExternalDocReferenceSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"ExternalDocReferenceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExternalDocReferenceSpecified
        {
        get { return mExternalDocReferenceSpecified; }
        set { mExternalDocReferenceSpecified = value; }
        }

        private string mExternalDocAddReference
            = "";
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"ExternalDocAddReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalDocAddReference
        {
        get { return mExternalDocAddReference; }
        set { mExternalDocAddReference = value; }
        }

        private bool mExternalDocAddReferenceSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"ExternalDocAddReferenceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExternalDocAddReferenceSpecified
        {
        get { return mExternalDocAddReferenceSpecified; }
        set { mExternalDocAddReferenceSpecified = value; }
        }

        private string mExternalRxReference
            = "";
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"ExternalRxReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalRxReference
        {
        get { return mExternalRxReference; }
        set { mExternalRxReference = value; }
        }

        private bool mExternalRxReferenceSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"ExternalRxReferenceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExternalRxReferenceSpecified
        {
        get { return mExternalRxReferenceSpecified; }
        set { mExternalRxReferenceSpecified = value; }
        }

        private int mMessageGroupId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"MessageGroupId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MessageGroupId
        {
        get { return mMessageGroupId; }
        set { mMessageGroupId = value; }
        }

        private bool mMessageGroupIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"MessageGroupIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MessageGroupIdSpecified
        {
        get { return mMessageGroupIdSpecified; }
        set { mMessageGroupIdSpecified = value; }
        }

        private int mWorkOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"WorkOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"WorkOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WorkOrderIdSpecified
        {
        get { return mWorkOrderIdSpecified; }
        set { mWorkOrderIdSpecified = value; }
        }

        private int mERxId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"ERxId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ERxId
        {
        get { return mERxId; }
        set { mERxId = value; }
        }

        private bool mERxIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"ERxIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ERxIdSpecified
        {
        get { return mERxIdSpecified; }
        set { mERxIdSpecified = value; }
        }

        private int mDocAddId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"DocAddId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DocAddId
        {
        get { return mDocAddId; }
        set { mDocAddId = value; }
        }

        private bool mDocAddIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"DocAddIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocAddIdSpecified
        {
        get { return mDocAddIdSpecified; }
        set { mDocAddIdSpecified = value; }
        }

        private int mMailReferenceId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"MailReferenceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MailReferenceId
        {
        get { return mMailReferenceId; }
        set { mMailReferenceId = value; }
        }

        private bool mMailReferenceIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"MailReferenceIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MailReferenceIdSpecified
        {
        get { return mMailReferenceIdSpecified; }
        set { mMailReferenceIdSpecified = value; }
        }

        private int mERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"ERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ERxOrderId
        {
        get { return mERxOrderId; }
        set { mERxOrderId = value; }
        }

        private bool mERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"ERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ERxOrderIdSpecified
        {
        get { return mERxOrderIdSpecified; }
        set { mERxOrderIdSpecified = value; }
        }

        private int mOrigRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"OrigRxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OrigRxNum
        {
        get { return mOrigRxNum; }
        set { mOrigRxNum = value; }
        }

        private bool mOrigRxNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"OrigRxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OrigRxNumSpecified
        {
        get { return mOrigRxNumSpecified; }
        set { mOrigRxNumSpecified = value; }
        }

        private int mReportingServiceQueueItemType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(72, IsRequired = false, Name=@"ReportingServiceQueueItemType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ReportingServiceQueueItemType
        {
        get { return mReportingServiceQueueItemType; }
        set { mReportingServiceQueueItemType = value; }
        }

        private bool mReportingServiceQueueItemTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(73, IsRequired = false, Name=@"ReportingServiceQueueItemTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ReportingServiceQueueItemTypeSpecified
        {
        get { return mReportingServiceQueueItemTypeSpecified; }
        set { mReportingServiceQueueItemTypeSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        