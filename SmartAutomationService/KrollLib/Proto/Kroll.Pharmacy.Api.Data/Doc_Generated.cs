
        // Generated from: Doc.proto
        // Note: requires additional types generated from: Designation_Enum.proto
        // Note: requires additional types generated from: DispensingRights_Enum.proto
        // Note: requires additional types generated from: DocAdd.proto
        // Note: requires additional types generated from: DocCom.proto
        // Note: requires additional types generated from: DocGrp.proto
        // Note: requires additional types generated from: DocOCM.proto
        // Note: requires additional types generated from: DocPhone.proto
        // Note: requires additional types generated from: ExternalDocLink.proto
        // Note: requires additional types generated from: DocSignatureImage.proto
        // Note: requires additional types generated from: DocLicence.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Doc")]
        public partial class Doc : global::ProtoBuf.IExtensible
        {
        public Doc() {}
        

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

        private string mCode
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Code", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Code
        {
        get { return mCode; }
        set { mCode = value; }
        }

        private string mLastName
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"LastName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LastName
        {
        get { return mLastName; }
        set { mLastName = value; }
        }

        private string mFirstName
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"FirstName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FirstName
        {
        get { return mFirstName; }
        set { mFirstName = value; }
        }

        private string mSalutation
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Salutation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Salutation
        {
        get { return mSalutation; }
        set { mSalutation = value; }
        }

        private Kroll.Pharmacy.Api.Data.Designation mDesignation
            = Kroll.Pharmacy.Api.Data.Designation.Designation_Unknown;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Designation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.Designation.Designation_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.Designation Designation
        {
        get { return mDesignation; }
        set { mDesignation = value; }
        }

        private string mSpecialty
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Specialty", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Specialty
        {
        get { return mSpecialty; }
        set { mSpecialty = value; }
        }

        private string mLicense1Prov
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"License1Prov", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string License1Prov
        {
        get { return mLicense1Prov; }
        set { mLicense1Prov = value; }
        }

        private string mLicense1ReferenceId
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"License1ReferenceId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string License1ReferenceId
        {
        get { return mLicense1ReferenceId; }
        set { mLicense1ReferenceId = value; }
        }

        private bool mLicense1ReferenceIdOverride
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"License1ReferenceIdOverride", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool License1ReferenceIdOverride
        {
        get { return mLicense1ReferenceIdOverride; }
        set { mLicense1ReferenceIdOverride = value; }
        }

        private string mLicense1
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"License1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string License1
        {
        get { return mLicense1; }
        set { mLicense1 = value; }
        }

        private string mLicense2Prov
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"License2Prov", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string License2Prov
        {
        get { return mLicense2Prov; }
        set { mLicense2Prov = value; }
        }

        private string mLicense2ReferenceId
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"License2ReferenceId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string License2ReferenceId
        {
        get { return mLicense2ReferenceId; }
        set { mLicense2ReferenceId = value; }
        }

        private bool mLicense2ReferenceIdOverride
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"License2ReferenceIdOverride", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool License2ReferenceIdOverride
        {
        get { return mLicense2ReferenceIdOverride; }
        set { mLicense2ReferenceIdOverride = value; }
        }

        private string mLicense2
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"License2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string License2
        {
        get { return mLicense2; }
        set { mLicense2 = value; }
        }

        private string mEmail
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"Email", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Email
        {
        get { return mEmail; }
        set { mEmail = value; }
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

        private bool mDateCreatedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private double mLastUsedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"LastUsedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastUsedDate
        {
        get { return mLastUsedDate; }
        set { mLastUsedDate = value; }
        }

        private bool mLastUsedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"LastUsedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastUsedDateSpecified
        {
        get { return mLastUsedDateSpecified; }
        set { mLastUsedDateSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.DispensingRights mDispensingRights
            = Kroll.Pharmacy.Api.Data.DispensingRights.DispensingRights_Unknown;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"DispensingRights", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DispensingRights.DispensingRights_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.DispensingRights DispensingRights
        {
        get { return mDispensingRights; }
        set { mDispensingRights = value; }
        }

        private bool mNoKrollCare
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"NoKrollCare", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoKrollCare
        {
        get { return mNoKrollCare; }
        set { mNoKrollCare = value; }
        }

        private bool mNoFaxRefills
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"NoFaxRefills", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoFaxRefills
        {
        get { return mNoFaxRefills; }
        set { mNoFaxRefills = value; }
        }

        private string mLanguage
            = "";
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"Language", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Language
        {
        get { return mLanguage; }
        set { mLanguage = value; }
        }

        private bool mNoPhoneRefills
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"NoPhoneRefills", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoPhoneRefills
        {
        get { return mNoPhoneRefills; }
        set { mNoPhoneRefills = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocAdd> mAddress = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocAdd>();
        [global::ProtoBuf.ProtoMember(31, Name=@"Address", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocAdd> Address
        {
        get { return mAddress; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocCom> mComments = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocCom>();
        [global::ProtoBuf.ProtoMember(32, Name=@"Comments", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocCom> Comments
        {
        get { return mComments; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocGrp> mGroups = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocGrp>();
        [global::ProtoBuf.ProtoMember(33, Name=@"Groups", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocGrp> Groups
        {
        get { return mGroups; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocOCM> mOutboundCommunications = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocOCM>();
        [global::ProtoBuf.ProtoMember(34, Name=@"OutboundCommunications", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocOCM> OutboundCommunications
        {
        get { return mOutboundCommunications; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocPhone> mPhone = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocPhone>();
        [global::ProtoBuf.ProtoMember(35, Name=@"Phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocPhone> Phone
        {
        get { return mPhone; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalDocLink> mExternalLinks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalDocLink>();
        [global::ProtoBuf.ProtoMember(36, Name=@"ExternalLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalDocLink> ExternalLinks
        {
        get { return mExternalLinks; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocSignatureImage> mSignatureImages = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocSignatureImage>();
        [global::ProtoBuf.ProtoMember(37, Name=@"SignatureImages", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocSignatureImage> SignatureImages
        {
        get { return mSignatureImages; }
        }
    

        private int mMergedToId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"MergedToId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MergedToId
        {
        get { return mMergedToId; }
        set { mMergedToId = value; }
        }

        private bool mMergedToIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"MergedToIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MergedToIdSpecified
        {
        get { return mMergedToIdSpecified; }
        set { mMergedToIdSpecified = value; }
        }

        private string mLanguageSpoken
            = "";
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"LanguageSpoken", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LanguageSpoken
        {
        get { return mLanguageSpoken; }
        set { mLanguageSpoken = value; }
        }

        private bool mNoMedReviewLetter
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"NoMedReviewLetter", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoMedReviewLetter
        {
        get { return mNoMedReviewLetter; }
        set { mNoMedReviewLetter = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocLicence> mLicences = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocLicence>();
        [global::ProtoBuf.ProtoMember(42, Name=@"Licences", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DocLicence> Licences
        {
        get { return mLicences; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        