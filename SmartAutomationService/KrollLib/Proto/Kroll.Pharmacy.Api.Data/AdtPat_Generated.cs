
        // Generated from: AdtPat.proto
        // Note: requires additional types generated from: AdtPatType_Enum.proto
        // Note: requires additional types generated from: AdtPatAdd.proto
        // Note: requires additional types generated from: AdtPatAlg.proto
        // Note: requires additional types generated from: AdtPatCnd.proto
        // Note: requires additional types generated from: AdtPatPhone.proto
        // Note: requires additional types generated from: AdtPatPln.proto
        // Note: requires additional types generated from: AdtPatIdSpecifiedByType_Enum.proto
        // Note: requires additional types generated from: AdtPatHeightUnits_Enum.proto
        // Note: requires additional types generated from: AdtPatWeightUnits_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AdtPat")]
        public partial class AdtPat : global::ProtoBuf.IExtensible
        {
        public AdtPat() {}
        

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

        private int mAdtId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"AdtId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AdtId
        {
        get { return mAdtId; }
        set { mAdtId = value; }
        }

        private bool mAdtIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"AdtIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AdtIdSpecified
        {
        get { return mAdtIdSpecified; }
        set { mAdtIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdtPatType mAdtPatType
            = Kroll.Pharmacy.Api.Data.AdtPatType.AdtPatType_Unknown;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"AdtPatType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdtPatType.AdtPatType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.AdtPatType AdtPatType
        {
        get { return mAdtPatType; }
        set { mAdtPatType = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatIdSpecified
        {
        get { return mPatIdSpecified; }
        set { mPatIdSpecified = value; }
        }

        private string mExternalReference
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ExternalReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalReference
        {
        get { return mExternalReference; }
        set { mExternalReference = value; }
        }

        private int mNHId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"NHId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"NHIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"NHWardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"NHWardIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHWardIdSpecified
        {
        get { return mNHWardIdSpecified; }
        set { mNHWardIdSpecified = value; }
        }

        private string mProvincialPlanClientId
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"ProvincialPlanClientId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ProvincialPlanClientId
        {
        get { return mProvincialPlanClientId; }
        set { mProvincialPlanClientId = value; }
        }

        private bool mProvincialPlanClientIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"ProvincialPlanClientIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ProvincialPlanClientIdSpecified
        {
        get { return mProvincialPlanClientIdSpecified; }
        set { mProvincialPlanClientIdSpecified = value; }
        }

        private string mCode
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"Code", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Code
        {
        get { return mCode; }
        set { mCode = value; }
        }

        private bool mCodeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"CodeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CodeSpecified
        {
        get { return mCodeSpecified; }
        set { mCodeSpecified = value; }
        }

        private string mLastName
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"LastName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LastName
        {
        get { return mLastName; }
        set { mLastName = value; }
        }

        private bool mLastNameSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"LastNameSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastNameSpecified
        {
        get { return mLastNameSpecified; }
        set { mLastNameSpecified = value; }
        }

        private string mFirstName
            = "";
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"FirstName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FirstName
        {
        get { return mFirstName; }
        set { mFirstName = value; }
        }

        private bool mFirstNameSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"FirstNameSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FirstNameSpecified
        {
        get { return mFirstNameSpecified; }
        set { mFirstNameSpecified = value; }
        }

        private string mSalutation
            = "";
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"Salutation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Salutation
        {
        get { return mSalutation; }
        set { mSalutation = value; }
        }

        private bool mSalutationSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"SalutationSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SalutationSpecified
        {
        get { return mSalutationSpecified; }
        set { mSalutationSpecified = value; }
        }

        private string mAddress1
            = "";
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"Address1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address1
        {
        get { return mAddress1; }
        set { mAddress1 = value; }
        }

        private bool mAddress1Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"Address1Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Address1Specified
        {
        get { return mAddress1Specified; }
        set { mAddress1Specified = value; }
        }

        private string mAddress2
            = "";
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"Address2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address2
        {
        get { return mAddress2; }
        set { mAddress2 = value; }
        }

        private bool mAddress2Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"Address2Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Address2Specified
        {
        get { return mAddress2Specified; }
        set { mAddress2Specified = value; }
        }

        private string mCity
            = "";
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"City", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string City
        {
        get { return mCity; }
        set { mCity = value; }
        }

        private bool mCitySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"CitySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CitySpecified
        {
        get { return mCitySpecified; }
        set { mCitySpecified = value; }
        }

        private string mProv
            = "";
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"Prov", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Prov
        {
        get { return mProv; }
        set { mProv = value; }
        }

        private bool mProvSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"ProvSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ProvSpecified
        {
        get { return mProvSpecified; }
        set { mProvSpecified = value; }
        }

        private string mPostal
            = "";
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"Postal", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Postal
        {
        get { return mPostal; }
        set { mPostal = value; }
        }

        private bool mPostalSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"PostalSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PostalSpecified
        {
        get { return mPostalSpecified; }
        set { mPostalSpecified = value; }
        }

        private string mCountry
            = "";
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"Country", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Country
        {
        get { return mCountry; }
        set { mCountry = value; }
        }

        private bool mCountrySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"CountrySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CountrySpecified
        {
        get { return mCountrySpecified; }
        set { mCountrySpecified = value; }
        }

        private double mBirthday
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"Birthday", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Birthday
        {
        get { return mBirthday; }
        set { mBirthday = value; }
        }

        private bool mBirthdaySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"BirthdaySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BirthdaySpecified
        {
        get { return mBirthdaySpecified; }
        set { mBirthdaySpecified = value; }
        }

        private string mSex
            = "";
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"Sex", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Sex
        {
        get { return mSex; }
        set { mSex = value; }
        }

        private bool mSexSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"SexSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SexSpecified
        {
        get { return mSexSpecified; }
        set { mSexSpecified = value; }
        }

        private string mLanguage
            = "";
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"Language", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"LanguageSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LanguageSpecified
        {
        get { return mLanguageSpecified; }
        set { mLanguageSpecified = value; }
        }

        private string mWeight
            = "";
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"Weight", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Weight
        {
        get { return mWeight; }
        set { mWeight = value; }
        }

        private bool mWeightSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"WeightSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WeightSpecified
        {
        get { return mWeightSpecified; }
        set { mWeightSpecified = value; }
        }

        private string mHeight
            = "";
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"Height", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Height
        {
        get { return mHeight; }
        set { mHeight = value; }
        }

        private bool mHeightSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"HeightSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HeightSpecified
        {
        get { return mHeightSpecified; }
        set { mHeightSpecified = value; }
        }

        private bool mSnapRequested
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"SnapRequested", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SnapRequested
        {
        get { return mSnapRequested; }
        set { mSnapRequested = value; }
        }

        private bool mSnapRequestedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"SnapRequestedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SnapRequestedSpecified
        {
        get { return mSnapRequestedSpecified; }
        set { mSnapRequestedSpecified = value; }
        }

        private bool mSnapDocumented
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"SnapDocumented", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SnapDocumented
        {
        get { return mSnapDocumented; }
        set { mSnapDocumented = value; }
        }

        private bool mSnapDocumentedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"SnapDocumentedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SnapDocumentedSpecified
        {
        get { return mSnapDocumentedSpecified; }
        set { mSnapDocumentedSpecified = value; }
        }

        private string mEMail
            = "";
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"EMail", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string EMail
        {
        get { return mEMail; }
        set { mEMail = value; }
        }

        private bool mEMailSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"EMailSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EMailSpecified
        {
        get { return mEMailSpecified; }
        set { mEMailSpecified = value; }
        }

        private double mNHAdmitDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"NHAdmitDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHAdmitDate
        {
        get { return mNHAdmitDate; }
        set { mNHAdmitDate = value; }
        }

        private bool mNHAdmitDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"NHAdmitDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHAdmitDateSpecified
        {
        get { return mNHAdmitDateSpecified; }
        set { mNHAdmitDateSpecified = value; }
        }

        private double mNHDischargeDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"NHDischargeDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHDischargeDate
        {
        get { return mNHDischargeDate; }
        set { mNHDischargeDate = value; }
        }

        private bool mNHDischargeDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"NHDischargeDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHDischargeDateSpecified
        {
        get { return mNHDischargeDateSpecified; }
        set { mNHDischargeDateSpecified = value; }
        }

        private double mNHDeceasedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"NHDeceasedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHDeceasedDate
        {
        get { return mNHDeceasedDate; }
        set { mNHDeceasedDate = value; }
        }

        private bool mNHDeceasedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"NHDeceasedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHDeceasedDateSpecified
        {
        get { return mNHDeceasedDateSpecified; }
        set { mNHDeceasedDateSpecified = value; }
        }

        private string mNHBuilding
            = "";
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"NHBuilding", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHBuilding
        {
        get { return mNHBuilding; }
        set { mNHBuilding = value; }
        }

        private bool mNHBuildingSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"NHBuildingSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHBuildingSpecified
        {
        get { return mNHBuildingSpecified; }
        set { mNHBuildingSpecified = value; }
        }

        private string mNHFloor
            = "";
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"NHFloor", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHFloor
        {
        get { return mNHFloor; }
        set { mNHFloor = value; }
        }

        private bool mNHFloorSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"NHFloorSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHFloorSpecified
        {
        get { return mNHFloorSpecified; }
        set { mNHFloorSpecified = value; }
        }

        private string mNHRoom
            = "";
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"NHRoom", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHRoom
        {
        get { return mNHRoom; }
        set { mNHRoom = value; }
        }

        private bool mNHRoomSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"NHRoomSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHRoomSpecified
        {
        get { return mNHRoomSpecified; }
        set { mNHRoomSpecified = value; }
        }

        private string mNHBed
            = "";
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"NHBed", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHBed
        {
        get { return mNHBed; }
        set { mNHBed = value; }
        }

        private bool mNHBedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"NHBedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHBedSpecified
        {
        get { return mNHBedSpecified; }
        set { mNHBedSpecified = value; }
        }

        private bool mNHInactive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"NHInactive", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHInactive
        {
        get { return mNHInactive; }
        set { mNHInactive = value; }
        }

        private bool mNHInactiveSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"NHInactiveSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHInactiveSpecified
        {
        get { return mNHInactiveSpecified; }
        set { mNHInactiveSpecified = value; }
        }

        private string mNHDiet
            = "";
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"NHDiet", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHDiet
        {
        get { return mNHDiet; }
        set { mNHDiet = value; }
        }

        private bool mNHDietSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"NHDietSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHDietSpecified
        {
        get { return mNHDietSpecified; }
        set { mNHDietSpecified = value; }
        }

        private string mNHComment
            = "";
        [global::ProtoBuf.ProtoMember(72, IsRequired = false, Name=@"NHComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHComment
        {
        get { return mNHComment; }
        set { mNHComment = value; }
        }

        private bool mNHCommentSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(73, IsRequired = false, Name=@"NHCommentSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHCommentSpecified
        {
        get { return mNHCommentSpecified; }
        set { mNHCommentSpecified = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(74, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(75, IsRequired = false, Name=@"ActiveSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ActiveSpecified
        {
        get { return mActiveSpecified; }
        set { mActiveSpecified = value; }
        }

        private bool mIsAnimal
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(76, IsRequired = false, Name=@"IsAnimal", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsAnimal
        {
        get { return mIsAnimal; }
        set { mIsAnimal = value; }
        }

        private bool mIsAnimalSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(77, IsRequired = false, Name=@"IsAnimalSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsAnimalSpecified
        {
        get { return mIsAnimalSpecified; }
        set { mIsAnimalSpecified = value; }
        }

        private string mAnimalType
            = "";
        [global::ProtoBuf.ProtoMember(78, IsRequired = false, Name=@"AnimalType", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AnimalType
        {
        get { return mAnimalType; }
        set { mAnimalType = value; }
        }

        private bool mAnimalTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(79, IsRequired = false, Name=@"AnimalTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AnimalTypeSpecified
        {
        get { return mAnimalTypeSpecified; }
        set { mAnimalTypeSpecified = value; }
        }

        private int mDefaultDocId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(80, IsRequired = false, Name=@"DefaultDocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DefaultDocId
        {
        get { return mDefaultDocId; }
        set { mDefaultDocId = value; }
        }

        private bool mDefaultDocIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(81, IsRequired = false, Name=@"DefaultDocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DefaultDocIdSpecified
        {
        get { return mDefaultDocIdSpecified; }
        set { mDefaultDocIdSpecified = value; }
        }

        private string mDefaultDocExternalReference
            = "";
        [global::ProtoBuf.ProtoMember(82, IsRequired = false, Name=@"DefaultDocExternalReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DefaultDocExternalReference
        {
        get { return mDefaultDocExternalReference; }
        set { mDefaultDocExternalReference = value; }
        }

        private string mDefaultDocLastName
            = "";
        [global::ProtoBuf.ProtoMember(83, IsRequired = false, Name=@"DefaultDocLastName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DefaultDocLastName
        {
        get { return mDefaultDocLastName; }
        set { mDefaultDocLastName = value; }
        }

        private string mDefaultDocFirstName
            = "";
        [global::ProtoBuf.ProtoMember(84, IsRequired = false, Name=@"DefaultDocFirstName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DefaultDocFirstName
        {
        get { return mDefaultDocFirstName; }
        set { mDefaultDocFirstName = value; }
        }

        private string mDefaultDocLicense
            = "";
        [global::ProtoBuf.ProtoMember(85, IsRequired = false, Name=@"DefaultDocLicense", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DefaultDocLicense
        {
        get { return mDefaultDocLicense; }
        set { mDefaultDocLicense = value; }
        }

        private bool mDefaultDocSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(86, IsRequired = false, Name=@"DefaultDocSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DefaultDocSpecified
        {
        get { return mDefaultDocSpecified; }
        set { mDefaultDocSpecified = value; }
        }

        private double mNHLoaStartDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(87, IsRequired = false, Name=@"NHLoaStartDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHLoaStartDate
        {
        get { return mNHLoaStartDate; }
        set { mNHLoaStartDate = value; }
        }

        private bool mNHLoaStartDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(88, IsRequired = false, Name=@"NHLoaStartDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHLoaStartDateSpecified
        {
        get { return mNHLoaStartDateSpecified; }
        set { mNHLoaStartDateSpecified = value; }
        }

        private double mNHLoaEndDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(90, IsRequired = false, Name=@"NHLoaEndDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHLoaEndDate
        {
        get { return mNHLoaEndDate; }
        set { mNHLoaEndDate = value; }
        }

        private bool mNHLoaEndDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(91, IsRequired = false, Name=@"NHLoaEndDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHLoaEndDateSpecified
        {
        get { return mNHLoaEndDateSpecified; }
        set { mNHLoaEndDateSpecified = value; }
        }

        private int mNHLoaType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(93, IsRequired = false, Name=@"NHLoaType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHLoaType
        {
        get { return mNHLoaType; }
        set { mNHLoaType = value; }
        }

        private bool mNHLoaTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(94, IsRequired = false, Name=@"NHLoaTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHLoaTypeSpecified
        {
        get { return mNHLoaTypeSpecified; }
        set { mNHLoaTypeSpecified = value; }
        }

        private string mNHLoaComment
            = "";
        [global::ProtoBuf.ProtoMember(95, IsRequired = false, Name=@"NHLoaComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHLoaComment
        {
        get { return mNHLoaComment; }
        set { mNHLoaComment = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(96, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(97, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(98, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(99, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdtPatIdSpecifiedByType mPatIdSpecifiedBy
            = Kroll.Pharmacy.Api.Data.AdtPatIdSpecifiedByType.AdtPatIdSpecifiedByType_Unknown;
        [global::ProtoBuf.ProtoMember(105, IsRequired = false, Name=@"PatIdSpecifiedBy", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdtPatIdSpecifiedByType.AdtPatIdSpecifiedByType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.AdtPatIdSpecifiedByType PatIdSpecifiedBy
        {
        get { return mPatIdSpecifiedBy; }
        set { mPatIdSpecifiedBy = value; }
        }

        private double mHeightValue
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(106, IsRequired = false, Name=@"HeightValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double HeightValue
        {
        get { return mHeightValue; }
        set { mHeightValue = value; }
        }

        private bool mHeightValueSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(107, IsRequired = false, Name=@"HeightValueSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HeightValueSpecified
        {
        get { return mHeightValueSpecified; }
        set { mHeightValueSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdtPatHeightUnits mHeightUnits
            = Kroll.Pharmacy.Api.Data.AdtPatHeightUnits.AdtPatHeightUnits_Unknown;
        [global::ProtoBuf.ProtoMember(108, IsRequired = false, Name=@"HeightUnits", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdtPatHeightUnits.AdtPatHeightUnits_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.AdtPatHeightUnits HeightUnits
        {
        get { return mHeightUnits; }
        set { mHeightUnits = value; }
        }

        private bool mHeightUnitsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(109, IsRequired = false, Name=@"HeightUnitsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HeightUnitsSpecified
        {
        get { return mHeightUnitsSpecified; }
        set { mHeightUnitsSpecified = value; }
        }

        private double mWeightValue
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(110, IsRequired = false, Name=@"WeightValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double WeightValue
        {
        get { return mWeightValue; }
        set { mWeightValue = value; }
        }

        private bool mWeightValueSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(111, IsRequired = false, Name=@"WeightValueSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WeightValueSpecified
        {
        get { return mWeightValueSpecified; }
        set { mWeightValueSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdtPatWeightUnits mWeightUnits
            = Kroll.Pharmacy.Api.Data.AdtPatWeightUnits.AdtPatWeightUnits_Unknown;
        [global::ProtoBuf.ProtoMember(112, IsRequired = false, Name=@"WeightUnits", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdtPatWeightUnits.AdtPatWeightUnits_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.AdtPatWeightUnits WeightUnits
        {
        get { return mWeightUnits; }
        set { mWeightUnits = value; }
        }

        private bool mWeightUnitsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(113, IsRequired = false, Name=@"WeightUnitsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WeightUnitsSpecified
        {
        get { return mWeightUnitsSpecified; }
        set { mWeightUnitsSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatAdd> mAdtPatAdd = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatAdd>();
        [global::ProtoBuf.ProtoMember(100, Name=@"AdtPatAdd", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatAdd> AdtPatAdd
        {
        get { return mAdtPatAdd; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatAlg> mAdtPatAlg = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatAlg>();
        [global::ProtoBuf.ProtoMember(101, Name=@"AdtPatAlg", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatAlg> AdtPatAlg
        {
        get { return mAdtPatAlg; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatCnd> mAdtPatCnd = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatCnd>();
        [global::ProtoBuf.ProtoMember(102, Name=@"AdtPatCnd", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatCnd> AdtPatCnd
        {
        get { return mAdtPatCnd; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatPhone> mAdtPatPhone = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatPhone>();
        [global::ProtoBuf.ProtoMember(103, Name=@"AdtPatPhone", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatPhone> AdtPatPhone
        {
        get { return mAdtPatPhone; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatPln> mAdtPatPln = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatPln>();
        [global::ProtoBuf.ProtoMember(104, Name=@"AdtPatPln", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPatPln> AdtPatPln
        {
        get { return mAdtPatPln; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        