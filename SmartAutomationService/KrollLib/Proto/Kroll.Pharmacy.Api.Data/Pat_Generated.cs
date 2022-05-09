
        // Generated from: Pat.proto
        // Note: requires additional types generated from: Sex_Enum.proto
        // Note: requires additional types generated from: DrugLabelName_Enum.proto
        // Note: requires additional types generated from: PatAutoRefillStatus_Enum.proto
        // Note: requires additional types generated from: PatAutoRefillNotification_Enum.proto
        // Note: requires additional types generated from: PatPickupNotificationEnrolment_Enum.proto
        // Note: requires additional types generated from: DeliveryRouteType_Enum.proto
        // Note: requires additional types generated from: RemQtyLabelType_Enum.proto
        // Note: requires additional types generated from: DoubleCount_Enum.proto
        // Note: requires additional types generated from: PatAdd.proto
        // Note: requires additional types generated from: PatAlg.proto
        // Note: requires additional types generated from: PatConsent.proto
        // Note: requires additional types generated from: PatCnd.proto
        // Note: requires additional types generated from: PatCom.proto
        // Note: requires additional types generated from: PatDocument.proto
        // Note: requires additional types generated from: PatGrp.proto
        // Note: requires additional types generated from: Intervention.proto
        // Note: requires additional types generated from: PatLimitedUse.proto
        // Note: requires additional types generated from: PatLoa.proto
        // Note: requires additional types generated from: PatMedReview.proto
        // Note: requires additional types generated from: PatNHOrders.proto
        // Note: requires additional types generated from: PatOCM.proto
        // Note: requires additional types generated from: PatPln.proto
        // Note: requires additional types generated from: PatRel.proto
        // Note: requires additional types generated from: PatPhone.proto
        // Note: requires additional types generated from: PatChart.proto
        // Note: requires additional types generated from: PatCreditCard.proto
        // Note: requires additional types generated from: ExternalPatLink.proto
        // Note: requires additional types generated from: DrgAlertLink.proto
        // Note: requires additional types generated from: PatType_Enum.proto
        // Note: requires additional types generated from: UnitDoseType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Pat")]
        public partial class Pat : global::ProtoBuf.IExtensible
        {
        public Pat() {}
        

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

        private string mAddress1
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Address1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address1
        {
        get { return mAddress1; }
        set { mAddress1 = value; }
        }

        private string mAddress2
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Address2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address2
        {
        get { return mAddress2; }
        set { mAddress2 = value; }
        }

        private string mCity
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"City", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string City
        {
        get { return mCity; }
        set { mCity = value; }
        }

        private string mProv
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Prov", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Prov
        {
        get { return mProv; }
        set { mProv = value; }
        }

        private string mPostalCode
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"PostalCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PostalCode
        {
        get { return mPostalCode; }
        set { mPostalCode = value; }
        }

        private string mCountry
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Country", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Country
        {
        get { return mCountry; }
        set { mCountry = value; }
        }

        private double mBirthday
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Birthday", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"BirthdaySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BirthdaySpecified
        {
        get { return mBirthdaySpecified; }
        set { mBirthdaySpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.Sex mSex
            = Kroll.Pharmacy.Api.Data.Sex.Sex_Unknown;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"Sex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.Sex.Sex_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.Sex Sex
        {
        get { return mSex; }
        set { mSex = value; }
        }

        private string mLanguage
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"Language", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Language
        {
        get { return mLanguage; }
        set { mLanguage = value; }
        }

        private double mRxTotalsResetDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"RxTotalsResetDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RxTotalsResetDate
        {
        get { return mRxTotalsResetDate; }
        set { mRxTotalsResetDate = value; }
        }

        private bool mRxTotalsResetDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"RxTotalsResetDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxTotalsResetDateSpecified
        {
        get { return mRxTotalsResetDateSpecified; }
        set { mRxTotalsResetDateSpecified = value; }
        }

        private double mTotalDollars
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"TotalDollars", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TotalDollars
        {
        get { return mTotalDollars; }
        set { mTotalDollars = value; }
        }

        private bool mTotalDollarsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"TotalDollarsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TotalDollarsSpecified
        {
        get { return mTotalDollarsSpecified; }
        set { mTotalDollarsSpecified = value; }
        }

        private int mTotalRx
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"TotalRx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int TotalRx
        {
        get { return mTotalRx; }
        set { mTotalRx = value; }
        }

        private bool mTotalRxSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"TotalRxSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TotalRxSpecified
        {
        get { return mTotalRxSpecified; }
        set { mTotalRxSpecified = value; }
        }

        private string mWeight
            = "";
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"Weight", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Weight
        {
        get { return mWeight; }
        set { mWeight = value; }
        }

        private string mHeight
            = "";
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"Height", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Height
        {
        get { return mHeight; }
        set { mHeight = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"LastUsedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"LastUsedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastUsedDateSpecified
        {
        get { return mLastUsedDateSpecified; }
        set { mLastUsedDateSpecified = value; }
        }

        private string mSalutation
            = "";
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"Salutation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Salutation
        {
        get { return mSalutation; }
        set { mSalutation = value; }
        }

        private bool mSnapRequested
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"SnapRequested", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SnapRequested
        {
        get { return mSnapRequested; }
        set { mSnapRequested = value; }
        }

        private bool mSnapDocumented
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"SnapDocumented", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SnapDocumented
        {
        get { return mSnapDocumented; }
        set { mSnapDocumented = value; }
        }

        private bool mLargeSig
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"LargeSig", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LargeSig
        {
        get { return mLargeSig; }
        set { mLargeSig = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrugLabelName mFirstDrugName
            = Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"FirstDrugName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default)]
        
        public Kroll.Pharmacy.Api.Data.DrugLabelName FirstDrugName
        {
        get { return mFirstDrugName; }
        set { mFirstDrugName = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrugLabelName mSecondDrugName
            = Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"SecondDrugName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default)]
        
        public Kroll.Pharmacy.Api.Data.DrugLabelName SecondDrugName
        {
        get { return mSecondDrugName; }
        set { mSecondDrugName = value; }
        }

        private string mDeliveryRoute
            = "";
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"DeliveryRoute", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DeliveryRoute
        {
        get { return mDeliveryRoute; }
        set { mDeliveryRoute = value; }
        }

        private string mEmail
            = "";
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"Email", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Email
        {
        get { return mEmail; }
        set { mEmail = value; }
        }

        private int mAddressLink
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"AddressLink", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AddressLink
        {
        get { return mAddressLink; }
        set { mAddressLink = value; }
        }

        private bool mAddressLinkSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"AddressLinkSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AddressLinkSpecified
        {
        get { return mAddressLinkSpecified; }
        set { mAddressLinkSpecified = value; }
        }

        private int mNHId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"NHId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"NHIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHIdSpecified
        {
        get { return mNHIdSpecified; }
        set { mNHIdSpecified = value; }
        }

        private bool mNoKrollCare
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"NoKrollCare", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoKrollCare
        {
        get { return mNoKrollCare; }
        set { mNoKrollCare = value; }
        }

        private Kroll.Pharmacy.Api.Data.UnitDoseType mUnitDoseType
            = Kroll.Pharmacy.Api.Data.UnitDoseType.UnitDoseType_NotSpecified;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"UnitDoseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UnitDoseType.UnitDoseType_NotSpecified)]
        
        public Kroll.Pharmacy.Api.Data.UnitDoseType UnitDoseType
        {
        get { return mUnitDoseType; }
        set { mUnitDoseType = value; }
        }

        private int mUnitDoseCycle
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"UnitDoseCycle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UnitDoseCycle
        {
        get { return mUnitDoseCycle; }
        set { mUnitDoseCycle = value; }
        }

        private int mDocId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"DocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"PriceGroupId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"PriceGroupIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PriceGroupIdSpecified
        {
        get { return mPriceGroupIdSpecified; }
        set { mPriceGroupIdSpecified = value; }
        }

        private bool mPrintCompliance
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"PrintCompliance", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintCompliance
        {
        get { return mPrintCompliance; }
        set { mPrintCompliance = value; }
        }

        private int mARId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"ARId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"ARIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ARIdSpecified
        {
        get { return mARIdSpecified; }
        set { mARIdSpecified = value; }
        }

        private int mNHWardId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"NHWardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"NHWardIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHWardIdSpecified
        {
        get { return mNHWardIdSpecified; }
        set { mNHWardIdSpecified = value; }
        }

        private double mNHAdmitDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"NHAdmitDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"NHAdmitDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"NHDischargeDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"NHDischargeDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"NHDeceasedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"NHDeceasedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHDeceasedDateSpecified
        {
        get { return mNHDeceasedDateSpecified; }
        set { mNHDeceasedDateSpecified = value; }
        }

        private string mNHRoom
            = "";
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"NHRoom", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHRoom
        {
        get { return mNHRoom; }
        set { mNHRoom = value; }
        }

        private string mNHBed
            = "";
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"NHBed", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHBed
        {
        get { return mNHBed; }
        set { mNHBed = value; }
        }

        private double mNHLastTmrDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"NHLastTmrDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHLastTmrDate
        {
        get { return mNHLastTmrDate; }
        set { mNHLastTmrDate = value; }
        }

        private bool mNHLastTmrDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"NHLastTmrDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHLastTmrDateSpecified
        {
        get { return mNHLastTmrDateSpecified; }
        set { mNHLastTmrDateSpecified = value; }
        }

        private bool mNHInactive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"NHInactive", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHInactive
        {
        get { return mNHInactive; }
        set { mNHInactive = value; }
        }

        private string mNHDiet
            = "";
        [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"NHDiet", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHDiet
        {
        get { return mNHDiet; }
        set { mNHDiet = value; }
        }

        private string mNHComment
            = "";
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"NHComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHComment
        {
        get { return mNHComment; }
        set { mNHComment = value; }
        }

        private Kroll.Pharmacy.Api.Data.PatAutoRefillStatus mAutoRefillStatus
            = Kroll.Pharmacy.Api.Data.PatAutoRefillStatus.PatAutoRefillStatus_Unknown;
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"AutoRefillStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatAutoRefillStatus.PatAutoRefillStatus_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PatAutoRefillStatus AutoRefillStatus
        {
        get { return mAutoRefillStatus; }
        set { mAutoRefillStatus = value; }
        }

        private Kroll.Pharmacy.Api.Data.PatAutoRefillNotification mAutoRefillNotification
            = Kroll.Pharmacy.Api.Data.PatAutoRefillNotification.PatAutoRefillNotification_Phone;
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"AutoRefillNotification", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatAutoRefillNotification.PatAutoRefillNotification_Phone)]
        
        public Kroll.Pharmacy.Api.Data.PatAutoRefillNotification AutoRefillNotification
        {
        get { return mAutoRefillNotification; }
        set { mAutoRefillNotification = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(84, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private bool mStoreLocal
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(85, IsRequired = false, Name=@"StoreLocal", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StoreLocal
        {
        get { return mStoreLocal; }
        set { mStoreLocal = value; }
        }

        private double mLastTMRPrintedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(86, IsRequired = false, Name=@"LastTMRPrintedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastTMRPrintedDate
        {
        get { return mLastTMRPrintedDate; }
        set { mLastTMRPrintedDate = value; }
        }

        private bool mLastTMRPrintedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(87, IsRequired = false, Name=@"LastTMRPrintedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastTMRPrintedDateSpecified
        {
        get { return mLastTMRPrintedDateSpecified; }
        set { mLastTMRPrintedDateSpecified = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(88, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private int mDefaultNHCycleId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(93, IsRequired = false, Name=@"DefaultNHCycleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(94, IsRequired = false, Name=@"DefaultNHCycleIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DefaultNHCycleIdSpecified
        {
        get { return mDefaultNHCycleIdSpecified; }
        set { mDefaultNHCycleIdSpecified = value; }
        }

        private string mOCMPin
            = "";
        [global::ProtoBuf.ProtoMember(95, IsRequired = false, Name=@"OCMPin", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OCMPin
        {
        get { return mOCMPin; }
        set { mOCMPin = value; }
        }

        private bool mIsAnimal
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(96, IsRequired = false, Name=@"IsAnimal", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsAnimal
        {
        get { return mIsAnimal; }
        set { mIsAnimal = value; }
        }

        private string mAnimalType
            = "";
        [global::ProtoBuf.ProtoMember(97, IsRequired = false, Name=@"AnimalType", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AnimalType
        {
        get { return mAnimalType; }
        set { mAnimalType = value; }
        }

        private string mNetworkId
            = "";
        [global::ProtoBuf.ProtoMember(98, IsRequired = false, Name=@"NetworkId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NetworkId
        {
        get { return mNetworkId; }
        set { mNetworkId = value; }
        }

        private int mAnimalOwnerPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(99, IsRequired = false, Name=@"AnimalOwnerPatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AnimalOwnerPatId
        {
        get { return mAnimalOwnerPatId; }
        set { mAnimalOwnerPatId = value; }
        }

        private bool mAnimalOwnerPatIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(100, IsRequired = false, Name=@"AnimalOwnerPatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AnimalOwnerPatIdSpecified
        {
        get { return mAnimalOwnerPatIdSpecified; }
        set { mAnimalOwnerPatIdSpecified = value; }
        }

        private int mUnitDosePriceGroupId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(101, IsRequired = false, Name=@"UnitDosePriceGroupId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(102, IsRequired = false, Name=@"UnitDosePriceGroupIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UnitDosePriceGroupIdSpecified
        {
        get { return mUnitDosePriceGroupIdSpecified; }
        set { mUnitDosePriceGroupIdSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatAdd> mAddress = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatAdd>();
        [global::ProtoBuf.ProtoMember(103, Name=@"Address", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatAdd> Address
        {
        get { return mAddress; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatAlg> mAllergies = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatAlg>();
        [global::ProtoBuf.ProtoMember(104, Name=@"Allergies", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatAlg> Allergies
        {
        get { return mAllergies; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatCnd> mConditions = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatCnd>();
        [global::ProtoBuf.ProtoMember(105, Name=@"Conditions", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatCnd> Conditions
        {
        get { return mConditions; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatCom> mComments = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatCom>();
        [global::ProtoBuf.ProtoMember(106, Name=@"Comments", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatCom> Comments
        {
        get { return mComments; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatDocument> mDocuments = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatDocument>();
        [global::ProtoBuf.ProtoMember(107, Name=@"Documents", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatDocument> Documents
        {
        get { return mDocuments; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatGrp> mGroups = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatGrp>();
        [global::ProtoBuf.ProtoMember(108, Name=@"Groups", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatGrp> Groups
        {
        get { return mGroups; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.Intervention> mInterventions = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.Intervention>();
        [global::ProtoBuf.ProtoMember(109, Name=@"Interventions", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.Intervention> Interventions
        {
        get { return mInterventions; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatLimitedUse> mLimitedUse = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatLimitedUse>();
        [global::ProtoBuf.ProtoMember(110, Name=@"LimitedUse", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatLimitedUse> LimitedUse
        {
        get { return mLimitedUse; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatNHOrders> mNHOrders = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatNHOrders>();
        [global::ProtoBuf.ProtoMember(111, Name=@"NHOrders", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatNHOrders> NHOrders
        {
        get { return mNHOrders; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatOCM> mOutboundCommunications = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatOCM>();
        [global::ProtoBuf.ProtoMember(112, Name=@"OutboundCommunications", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatOCM> OutboundCommunications
        {
        get { return mOutboundCommunications; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatPln> mPlans = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatPln>();
        [global::ProtoBuf.ProtoMember(113, Name=@"Plans", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatPln> Plans
        {
        get { return mPlans; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatPhone> mPhone = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatPhone>();
        [global::ProtoBuf.ProtoMember(114, Name=@"Phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatPhone> Phone
        {
        get { return mPhone; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatChart> mCharts = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatChart>();
        [global::ProtoBuf.ProtoMember(115, Name=@"Charts", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatChart> Charts
        {
        get { return mCharts; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatCreditCard> mCreditCards = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatCreditCard>();
        [global::ProtoBuf.ProtoMember(116, Name=@"CreditCards", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatCreditCard> CreditCards
        {
        get { return mCreditCards; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalPatLink> mExternalLinks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalPatLink>();
        [global::ProtoBuf.ProtoMember(117, Name=@"ExternalLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalPatLink> ExternalLinks
        {
        get { return mExternalLinks; }
        }
    

        private int mMergedToId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(118, IsRequired = false, Name=@"MergedToId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(119, IsRequired = false, Name=@"MergedToIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(120, IsRequired = false, Name=@"LanguageSpoken", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LanguageSpoken
        {
        get { return mLanguageSpoken; }
        set { mLanguageSpoken = value; }
        }

        private Kroll.Pharmacy.Api.Data.PatPickupNotificationEnrolment mPickupNotificationEnrolment
            = Kroll.Pharmacy.Api.Data.PatPickupNotificationEnrolment.PatPickupNotificationEnrolment_Unknown;
        [global::ProtoBuf.ProtoMember(121, IsRequired = false, Name=@"PickupNotificationEnrolment", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatPickupNotificationEnrolment.PatPickupNotificationEnrolment_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PatPickupNotificationEnrolment PickupNotificationEnrolment
        {
        get { return mPickupNotificationEnrolment; }
        set { mPickupNotificationEnrolment = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgAlertLink> mDrgAlertLinks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgAlertLink>();
        [global::ProtoBuf.ProtoMember(122, Name=@"DrgAlertLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgAlertLink> DrgAlertLinks
        {
        get { return mDrgAlertLinks; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatLoa> mLeaveOfAbsence = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatLoa>();
        [global::ProtoBuf.ProtoMember(123, Name=@"LeaveOfAbsence", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatLoa> LeaveOfAbsence
        {
        get { return mLeaveOfAbsence; }
        }
    

        private Kroll.Pharmacy.Api.Data.DeliveryRouteType mDeliveryRoutetype
            = Kroll.Pharmacy.Api.Data.DeliveryRouteType.DeliveryRouteType_Default;
        [global::ProtoBuf.ProtoMember(124, IsRequired = false, Name=@"DeliveryRoutetype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DeliveryRouteType.DeliveryRouteType_Default)]
        
        public Kroll.Pharmacy.Api.Data.DeliveryRouteType DeliveryRoutetype
        {
        get { return mDeliveryRoutetype; }
        set { mDeliveryRoutetype = value; }
        }

        private Kroll.Pharmacy.Api.Data.DoubleCount mDoubleCount
            = Kroll.Pharmacy.Api.Data.DoubleCount.DoubleCount_NotRequired;
        [global::ProtoBuf.ProtoMember(125, IsRequired = false, Name=@"DoubleCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DoubleCount.DoubleCount_NotRequired)]
        
        public Kroll.Pharmacy.Api.Data.DoubleCount DoubleCount
        {
        get { return mDoubleCount; }
        set { mDoubleCount = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatRel> mRelationships = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatRel>();
        [global::ProtoBuf.ProtoMember(126, Name=@"Relationships", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatRel> Relationships
        {
        get { return mRelationships; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatConsent> mConsent = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatConsent>();
        [global::ProtoBuf.ProtoMember(127, Name=@"Consent", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatConsent> Consent
        {
        get { return mConsent; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatMedReview> mMedReviews = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatMedReview>();
        [global::ProtoBuf.ProtoMember(128, Name=@"MedReviews", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatMedReview> MedReviews
        {
        get { return mMedReviews; }
        }
    

        private string mVialIdentifier
            = "";
        [global::ProtoBuf.ProtoMember(129, IsRequired = false, Name=@"VialIdentifier", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string VialIdentifier
        {
        get { return mVialIdentifier; }
        set { mVialIdentifier = value; }
        }

        private Kroll.Pharmacy.Api.Data.PatType mPatType
            = Kroll.Pharmacy.Api.Data.PatType.PatType_Unknown;
        [global::ProtoBuf.ProtoMember(130, IsRequired = false, Name=@"PatType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatType.PatType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PatType PatType
        {
        get { return mPatType; }
        set { mPatType = value; }
        }

        private string mAlternateLastName
            = "";
        [global::ProtoBuf.ProtoMember(131, IsRequired = false, Name=@"AlternateLastName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AlternateLastName
        {
        get { return mAlternateLastName; }
        set { mAlternateLastName = value; }
        }

        private bool mNoWalletCard
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(133, IsRequired = false, Name=@"NoWalletCard", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoWalletCard
        {
        get { return mNoWalletCard; }
        set { mNoWalletCard = value; }
        }

        private Kroll.Pharmacy.Api.Data.RemQtyLabelType mRemQtyLabelType
            = Kroll.Pharmacy.Api.Data.RemQtyLabelType.RemQtyLabelType_Default;
        [global::ProtoBuf.ProtoMember(134, IsRequired = false, Name=@"RemQtyLabelType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RemQtyLabelType.RemQtyLabelType_Default)]
        
        public Kroll.Pharmacy.Api.Data.RemQtyLabelType RemQtyLabelType
        {
        get { return mRemQtyLabelType; }
        set { mRemQtyLabelType = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        