
        // Generated from: PatSearchCriteria.proto
        // Note: requires additional types generated from: StringComparisonOperator_Enum.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatSearchCriteria")]
        public partial class PatSearchCriteria : global::ProtoBuf.IExtensible
        {
        public PatSearchCriteria() {}
        

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

        private string mAddress1
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Address1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address1
        {
        get { return mAddress1; }
        set { mAddress1 = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mAddress1ComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Address1ComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator Address1ComparisonOperator
        {
        get { return mAddress1ComparisonOperator; }
        set { mAddress1ComparisonOperator = value; }
        }

        private string mAddress2
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Address2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address2
        {
        get { return mAddress2; }
        set { mAddress2 = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mAddress2ComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Address2ComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator Address2ComparisonOperator
        {
        get { return mAddress2ComparisonOperator; }
        set { mAddress2ComparisonOperator = value; }
        }

        private string mCity
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"City", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string City
        {
        get { return mCity; }
        set { mCity = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mCityComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"CityComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator CityComparisonOperator
        {
        get { return mCityComparisonOperator; }
        set { mCityComparisonOperator = value; }
        }

        private string mProv
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"Prov", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Prov
        {
        get { return mProv; }
        set { mProv = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mProvComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ProvComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator ProvComparisonOperator
        {
        get { return mProvComparisonOperator; }
        set { mProvComparisonOperator = value; }
        }

        private string mPostalCode
            = "";
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"PostalCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PostalCode
        {
        get { return mPostalCode; }
        set { mPostalCode = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mPostalCodeComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"PostalCodeComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator PostalCodeComparisonOperator
        {
        get { return mPostalCodeComparisonOperator; }
        set { mPostalCodeComparisonOperator = value; }
        }

        private string mCountry
            = "";
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"Country", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Country
        {
        get { return mCountry; }
        set { mCountry = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mCountryComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"CountryComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator CountryComparisonOperator
        {
        get { return mCountryComparisonOperator; }
        set { mCountryComparisonOperator = value; }
        }

        private double mBirthday
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"Birthday", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"BirthdaySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BirthdaySpecified
        {
        get { return mBirthdaySpecified; }
        set { mBirthdaySpecified = value; }
        }

        private string mEmail
            = "";
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"Email", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Email
        {
        get { return mEmail; }
        set { mEmail = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mEmailComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"EmailComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator EmailComparisonOperator
        {
        get { return mEmailComparisonOperator; }
        set { mEmailComparisonOperator = value; }
        }

        private int mNHId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"NHId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"NHIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"NHWardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"NHWardIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHWardIdSpecified
        {
        get { return mNHWardIdSpecified; }
        set { mNHWardIdSpecified = value; }
        }

        private string mNHRoom
            = "";
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"NHRoom", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHRoom
        {
        get { return mNHRoom; }
        set { mNHRoom = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mNHRoomComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"NHRoomComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator NHRoomComparisonOperator
        {
        get { return mNHRoomComparisonOperator; }
        set { mNHRoomComparisonOperator = value; }
        }

        private string mNHBed
            = "";
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"NHBed", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHBed
        {
        get { return mNHBed; }
        set { mNHBed = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mNHBedComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"NHBedComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator NHBedComparisonOperator
        {
        get { return mNHBedComparisonOperator; }
        set { mNHBedComparisonOperator = value; }
        }

        private int mDefaultNHCycleId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"DefaultNHCycleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DefaultNHCycleId
        {
        get { return mDefaultNHCycleId; }
        set { mDefaultNHCycleId = value; }
        }

        private bool mDefaultNHCycleIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"DefaultNHCycleIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DefaultNHCycleIdSpecified
        {
        get { return mDefaultNHCycleIdSpecified; }
        set { mDefaultNHCycleIdSpecified = value; }
        }

        private bool mNHInactive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"NHInactive", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"NHInactiveSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHInactiveSpecified
        {
        get { return mNHInactiveSpecified; }
        set { mNHInactiveSpecified = value; }
        }

        private int mDocId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"DocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocIdSpecified
        {
        get { return mDocIdSpecified; }
        set { mDocIdSpecified = value; }
        }

        private int mPriceGroupId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"PriceGroupId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PriceGroupId
        {
        get { return mPriceGroupId; }
        set { mPriceGroupId = value; }
        }

        private bool mPriceGroupIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"PriceGroupIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PriceGroupIdSpecified
        {
        get { return mPriceGroupIdSpecified; }
        set { mPriceGroupIdSpecified = value; }
        }

        private int mARId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"ARId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ARId
        {
        get { return mARId; }
        set { mARId = value; }
        }

        private bool mARIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"ARIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ARIdSpecified
        {
        get { return mARIdSpecified; }
        set { mARIdSpecified = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"StoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StoreIdSpecified
        {
        get { return mStoreIdSpecified; }
        set { mStoreIdSpecified = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"ActiveSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ActiveSpecified
        {
        get { return mActiveSpecified; }
        set { mActiveSpecified = value; }
        }

        private int mUnitDosePriceGroupId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"UnitDosePriceGroupId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UnitDosePriceGroupId
        {
        get { return mUnitDosePriceGroupId; }
        set { mUnitDosePriceGroupId = value; }
        }

        private bool mUnitDosePriceGroupIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"UnitDosePriceGroupIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UnitDosePriceGroupIdSpecified
        {
        get { return mUnitDosePriceGroupIdSpecified; }
        set { mUnitDosePriceGroupIdSpecified = value; }
        }

        private bool mIsDischarged
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"IsDischarged", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsDischarged
        {
        get { return mIsDischarged; }
        set { mIsDischarged = value; }
        }

        private bool mIsDischargedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"IsDischargedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsDischargedSpecified
        {
        get { return mIsDischargedSpecified; }
        set { mIsDischargedSpecified = value; }
        }

        private bool mIsDeceased
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"IsDeceased", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsDeceased
        {
        get { return mIsDeceased; }
        set { mIsDeceased = value; }
        }

        private bool mIsDeceasedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"IsDeceasedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsDeceasedSpecified
        {
        get { return mIsDeceasedSpecified; }
        set { mIsDeceasedSpecified = value; }
        }

        private double mNHAdmitDateStartRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"NHAdmitDateStartRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHAdmitDateStartRange
        {
        get { return mNHAdmitDateStartRange; }
        set { mNHAdmitDateStartRange = value; }
        }

        private bool mNHAdmitDateStartRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"NHAdmitDateStartRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHAdmitDateStartRangeSpecified
        {
        get { return mNHAdmitDateStartRangeSpecified; }
        set { mNHAdmitDateStartRangeSpecified = value; }
        }

        private double mNHAdmitDateEndRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"NHAdmitDateEndRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHAdmitDateEndRange
        {
        get { return mNHAdmitDateEndRange; }
        set { mNHAdmitDateEndRange = value; }
        }

        private bool mNHAdmitDateEndRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"NHAdmitDateEndRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHAdmitDateEndRangeSpecified
        {
        get { return mNHAdmitDateEndRangeSpecified; }
        set { mNHAdmitDateEndRangeSpecified = value; }
        }

        private double mNHDischargeDateStartRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"NHDischargeDateStartRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHDischargeDateStartRange
        {
        get { return mNHDischargeDateStartRange; }
        set { mNHDischargeDateStartRange = value; }
        }

        private bool mNHDischargeDateStartRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"NHDischargeDateStartRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHDischargeDateStartRangeSpecified
        {
        get { return mNHDischargeDateStartRangeSpecified; }
        set { mNHDischargeDateStartRangeSpecified = value; }
        }

        private double mNHDischargeDateEndRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"NHDischargeDateEndRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHDischargeDateEndRange
        {
        get { return mNHDischargeDateEndRange; }
        set { mNHDischargeDateEndRange = value; }
        }

        private bool mNHDischargeDateEndRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"NHDischargeDateEndRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHDischargeDateEndRangeSpecified
        {
        get { return mNHDischargeDateEndRangeSpecified; }
        set { mNHDischargeDateEndRangeSpecified = value; }
        }

        private double mNHDeceasedDateStartRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"NHDeceasedDateStartRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHDeceasedDateStartRange
        {
        get { return mNHDeceasedDateStartRange; }
        set { mNHDeceasedDateStartRange = value; }
        }

        private bool mNHDeceasedDateStartRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"NHDeceasedDateStartRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHDeceasedDateStartRangeSpecified
        {
        get { return mNHDeceasedDateStartRangeSpecified; }
        set { mNHDeceasedDateStartRangeSpecified = value; }
        }

        private double mNHDeceasedDateEndRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"NHDeceasedDateEndRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHDeceasedDateEndRange
        {
        get { return mNHDeceasedDateEndRange; }
        set { mNHDeceasedDateEndRange = value; }
        }

        private bool mNHDeceasedDateEndRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"NHDeceasedDateEndRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHDeceasedDateEndRangeSpecified
        {
        get { return mNHDeceasedDateEndRangeSpecified; }
        set { mNHDeceasedDateEndRangeSpecified = value; }
        }

        private string mExternalPatReference
            = "";
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"ExternalPatReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(72, IsRequired = false, Name=@"ExternalPatReferenceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExternalPatReferenceSpecified
        {
        get { return mExternalPatReferenceSpecified; }
        set { mExternalPatReferenceSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        