
        // Generated from: PatDocument.proto
        // Note: requires additional types generated from: PatDocumentComment.proto
        // Note: requires additional types generated from: PatDocumentRetentionType_Enum.proto
        // Note: requires additional types generated from: DocumentFormat_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatDocument")]
        public partial class PatDocument : global::ProtoBuf.IExtensible
        {
        public PatDocument() {}
        

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
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private int mDocId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DocId
        {
        get { return mDocId; }
        set { mDocId = value; }
        }

        private int mDocumentContentId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DocumentContentId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DocumentContentId
        {
        get { return mDocumentContentId; }
        set { mDocumentContentId = value; }
        }

        private string mTitle
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Title", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Title
        {
        get { return mTitle; }
        set { mTitle = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private int mDocumentType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DocumentType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DocumentType
        {
        get { return mDocumentType; }
        set { mDocumentType = value; }
        }

        private bool mDocumentTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"DocumentTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocumentTypeSpecified
        {
        get { return mDocumentTypeSpecified; }
        set { mDocumentTypeSpecified = value; }
        }

        private int mReportNumber
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"ReportNumber", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ReportNumber
        {
        get { return mReportNumber; }
        set { mReportNumber = value; }
        }

        private bool mReportNumberSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"ReportNumberSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ReportNumberSpecified
        {
        get { return mReportNumberSpecified; }
        set { mReportNumberSpecified = value; }
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

        private bool mUserEditable
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"UserEditable", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserEditable
        {
        get { return mUserEditable; }
        set { mUserEditable = value; }
        }

        private bool mIsRequiredRetention
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"IsRequiredRetention", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsRequiredRetention
        {
        get { return mIsRequiredRetention; }
        set { mIsRequiredRetention = value; }
        }

        private bool mIsManualRetention
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"IsManualRetention", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsManualRetention
        {
        get { return mIsManualRetention; }
        set { mIsManualRetention = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateCreated
        {
        get { return mDateCreated; }
        set { mDateCreated = value; }
        }

        private double mDateChanged
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateChanged
        {
        get { return mDateChanged; }
        set { mDateChanged = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatDocumentComment> mComments = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatDocumentComment>();
        [global::ProtoBuf.ProtoMember(19, Name=@"Comments", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatDocumentComment> Comments
        {
        get { return mComments; }
        }
    

        private Kroll.Pharmacy.Api.Data.PatDocumentRetentionType mRetentionType
            = Kroll.Pharmacy.Api.Data.PatDocumentRetentionType.PatDocumentRetentionType_Unknown;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"RetentionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatDocumentRetentionType.PatDocumentRetentionType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PatDocumentRetentionType RetentionType
        {
        get { return mRetentionType; }
        set { mRetentionType = value; }
        }

        private int mRetentionMonths
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"RetentionMonths", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RetentionMonths
        {
        get { return mRetentionMonths; }
        set { mRetentionMonths = value; }
        }

        private bool mRetentionMonthsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"RetentionMonthsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RetentionMonthsSpecified
        {
        get { return mRetentionMonthsSpecified; }
        set { mRetentionMonthsSpecified = value; }
        }

        private int mUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"UserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"UserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserIdSpecified
        {
        get { return mUserIdSpecified; }
        set { mUserIdSpecified = value; }
        }

        private int mPatMedReviewId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"PatMedReviewId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"PatMedReviewIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatMedReviewIdSpecified
        {
        get { return mPatMedReviewIdSpecified; }
        set { mPatMedReviewIdSpecified = value; }
        }

        private int mDeliveryOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"DeliveryOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryOrderId
        {
        get { return mDeliveryOrderId; }
        set { mDeliveryOrderId = value; }
        }

        private bool mDeliveryOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"DeliveryOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryOrderIdSpecified
        {
        get { return mDeliveryOrderIdSpecified; }
        set { mDeliveryOrderIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.DocumentFormat mDocumentFormat
            = Kroll.Pharmacy.Api.Data.DocumentFormat.DocumentFormat_Unknown;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"DocumentFormat", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DocumentFormat.DocumentFormat_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.DocumentFormat DocumentFormat
        {
        get { return mDocumentFormat; }
        set { mDocumentFormat = value; }
        }

        private bool mDocumentFormatSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"DocumentFormatSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocumentFormatSpecified
        {
        get { return mDocumentFormatSpecified; }
        set { mDocumentFormatSpecified = value; }
        }

        private int mPatImmunizationId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"PatImmunizationId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatImmunizationId
        {
        get { return mPatImmunizationId; }
        set { mPatImmunizationId = value; }
        }

        private bool mPatImmunizationIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"PatImmunizationIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatImmunizationIdSpecified
        {
        get { return mPatImmunizationIdSpecified; }
        set { mPatImmunizationIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        