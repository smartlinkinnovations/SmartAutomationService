
        // Generated from: DocSearchCriteria.proto
        // Note: requires additional types generated from: StringComparisonOperator_Enum.proto
        // Note: requires additional types generated from: Designation_Enum.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DocSearchCriteria")]
        public partial class DocSearchCriteria : global::ProtoBuf.IExtensible
        {
        public DocSearchCriteria() {}
        

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

        private bool mIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IdSpecified
        {
        get { return mIdSpecified; }
        set { mIdSpecified = value; }
        }

        private string mCode
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Code", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Code
        {
        get { return mCode; }
        set { mCode = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mCodeComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"CodeComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator CodeComparisonOperator
        {
        get { return mCodeComparisonOperator; }
        set { mCodeComparisonOperator = value; }
        }

        private string mLastName
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"LastName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LastName
        {
        get { return mLastName; }
        set { mLastName = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mLastNameComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"LastNameComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator LastNameComparisonOperator
        {
        get { return mLastNameComparisonOperator; }
        set { mLastNameComparisonOperator = value; }
        }

        private string mFirstName
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"FirstName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FirstName
        {
        get { return mFirstName; }
        set { mFirstName = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mFirstNameComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"FirstNameComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator FirstNameComparisonOperator
        {
        get { return mFirstNameComparisonOperator; }
        set { mFirstNameComparisonOperator = value; }
        }

        private Kroll.Pharmacy.Api.Data.Designation mDesignation
            = Kroll.Pharmacy.Api.Data.Designation.Designation_Unknown;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"Designation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.Designation.Designation_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.Designation Designation
        {
        get { return mDesignation; }
        set { mDesignation = value; }
        }

        private bool mDesignationSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"DesignationSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DesignationSpecified
        {
        get { return mDesignationSpecified; }
        set { mDesignationSpecified = value; }
        }

        private string mLicense1Prov
            = "";
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"License1Prov", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string License1Prov
        {
        get { return mLicense1Prov; }
        set { mLicense1Prov = value; }
        }

        private bool mLicense1ProvSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"License1ProvSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool License1ProvSpecified
        {
        get { return mLicense1ProvSpecified; }
        set { mLicense1ProvSpecified = value; }
        }

        private string mLicense1ReferenceId
            = "";
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"License1ReferenceId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string License1ReferenceId
        {
        get { return mLicense1ReferenceId; }
        set { mLicense1ReferenceId = value; }
        }

        private bool mLicense1ReferenceIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"License1ReferenceIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool License1ReferenceIdSpecified
        {
        get { return mLicense1ReferenceIdSpecified; }
        set { mLicense1ReferenceIdSpecified = value; }
        }

        private string mLicense1
            = "";
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"License1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string License1
        {
        get { return mLicense1; }
        set { mLicense1 = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mLicense1Specified
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"License1Specified", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator License1Specified
        {
        get { return mLicense1Specified; }
        set { mLicense1Specified = value; }
        }

        private string mLicense2Prov
            = "";
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"License2Prov", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string License2Prov
        {
        get { return mLicense2Prov; }
        set { mLicense2Prov = value; }
        }

        private bool mLicense2ProvSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"License2ProvSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool License2ProvSpecified
        {
        get { return mLicense2ProvSpecified; }
        set { mLicense2ProvSpecified = value; }
        }

        private string mLicense2ReferenceId
            = "";
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"License2ReferenceId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string License2ReferenceId
        {
        get { return mLicense2ReferenceId; }
        set { mLicense2ReferenceId = value; }
        }

        private bool mLicense2ReferenceIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"License2ReferenceIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool License2ReferenceIdSpecified
        {
        get { return mLicense2ReferenceIdSpecified; }
        set { mLicense2ReferenceIdSpecified = value; }
        }

        private string mLicense2
            = "";
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"License2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string License2
        {
        get { return mLicense2; }
        set { mLicense2 = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mLicense2Specified
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"License2Specified", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator License2Specified
        {
        get { return mLicense2Specified; }
        set { mLicense2Specified = value; }
        }

        private string mEmail
            = "";
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"Email", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Email
        {
        get { return mEmail; }
        set { mEmail = value; }
        }

        private bool mEmailSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"EmailSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EmailSpecified
        {
        get { return mEmailSpecified; }
        set { mEmailSpecified = value; }
        }

        private bool mNoFaxRefills
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"NoFaxRefills", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoFaxRefills
        {
        get { return mNoFaxRefills; }
        set { mNoFaxRefills = value; }
        }

        private bool mNoFaxRefillsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"NoFaxRefillsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoFaxRefillsSpecified
        {
        get { return mNoFaxRefillsSpecified; }
        set { mNoFaxRefillsSpecified = value; }
        }

        private string mLanguage
            = "";
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"Language", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Language
        {
        get { return mLanguage; }
        set { mLanguage = value; }
        }

        private bool mLanguageSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"LanguageSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LanguageSpecified
        {
        get { return mLanguageSpecified; }
        set { mLanguageSpecified = value; }
        }

        private bool mNoPhoneRefills
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"NoPhoneRefills", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoPhoneRefills
        {
        get { return mNoPhoneRefills; }
        set { mNoPhoneRefills = value; }
        }

        private bool mNoPhoneRefillsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"NoPhoneRefillsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoPhoneRefillsSpecified
        {
        get { return mNoPhoneRefillsSpecified; }
        set { mNoPhoneRefillsSpecified = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private bool mActiveSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"ActiveSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ActiveSpecified
        {
        get { return mActiveSpecified; }
        set { mActiveSpecified = value; }
        }

        private string mExternalDocReference
            = "";
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"ExternalDocReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"ExternalDocReferenceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExternalDocReferenceSpecified
        {
        get { return mExternalDocReferenceSpecified; }
        set { mExternalDocReferenceSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        