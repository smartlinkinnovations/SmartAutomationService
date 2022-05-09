
        // Generated from: PatConsent.proto
        // Note: requires additional types generated from: PatConsentType_Enum.proto
        // Note: requires additional types generated from: PatConsentGivenByType_Enum.proto
        // Note: requires additional types generated from: CompressionType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatConsent")]
        public partial class PatConsent : global::ProtoBuf.IExtensible
        {
        public PatConsent() {}
        

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

        private Kroll.Pharmacy.Api.Data.PatConsentType mConsentType
            = Kroll.Pharmacy.Api.Data.PatConsentType.PatConsentType_Unknown;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ConsentType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatConsentType.PatConsentType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PatConsentType ConsentType
        {
        get { return mConsentType; }
        set { mConsentType = value; }
        }

        private int mConsentValue
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ConsentValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ConsentValue
        {
        get { return mConsentValue; }
        set { mConsentValue = value; }
        }

        private double mConsentDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ConsentDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ConsentDate
        {
        get { return mConsentDate; }
        set { mConsentDate = value; }
        }

        private bool mConsentDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ConsentDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ConsentDateSpecified
        {
        get { return mConsentDateSpecified; }
        set { mConsentDateSpecified = value; }
        }

        private string mProgramName
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ProgramName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ProgramName
        {
        get { return mProgramName; }
        set { mProgramName = value; }
        }

        private Kroll.Pharmacy.Api.Data.PatConsentGivenByType mConsentGivenByType
            = Kroll.Pharmacy.Api.Data.PatConsentGivenByType.PatConsentGivenByType_Unknown;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"ConsentGivenByType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatConsentGivenByType.PatConsentGivenByType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PatConsentGivenByType ConsentGivenByType
        {
        get { return mConsentGivenByType; }
        set { mConsentGivenByType = value; }
        }

        private int mConsentGivenByPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"ConsentGivenByPatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ConsentGivenByPatId
        {
        get { return mConsentGivenByPatId; }
        set { mConsentGivenByPatId = value; }
        }

        private bool mConsentGivenByPatIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ConsentGivenByPatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ConsentGivenByPatIdSpecified
        {
        get { return mConsentGivenByPatIdSpecified; }
        set { mConsentGivenByPatIdSpecified = value; }
        }

        private int mRecordedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"RecordedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RecordedByUserId
        {
        get { return mRecordedByUserId; }
        set { mRecordedByUserId = value; }
        }

        private bool mRecordedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"RecordedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RecordedByUserIdSpecified
        {
        get { return mRecordedByUserIdSpecified; }
        set { mRecordedByUserIdSpecified = value; }
        }

        private string mRecordedByUserInit
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"RecordedByUserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RecordedByUserInit
        {
        get { return mRecordedByUserInit; }
        set { mRecordedByUserInit = value; }
        }

        private string mDin
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"Din", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Din
        {
        get { return mDin; }
        set { mDin = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private byte[] mContextInfo
            = null;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ContextInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ContextInfo
        {
        get { return mContextInfo; }
        set { mContextInfo = value; }
        }

        private Kroll.Pharmacy.Api.Data.CompressionType mContextInfoCompressionType
            = Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"ContextInfoCompressionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.CompressionType ContextInfoCompressionType
        {
        get { return mContextInfoCompressionType; }
        set { mContextInfoCompressionType = value; }
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
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        