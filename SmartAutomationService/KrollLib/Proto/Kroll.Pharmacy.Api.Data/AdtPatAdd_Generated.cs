
        // Generated from: AdtPatAdd.proto
        // Note: requires additional types generated from: AdtPatAddType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AdtPatAdd")]
        public partial class AdtPatAdd : global::ProtoBuf.IExtensible
        {
        public AdtPatAdd() {}
        

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

        private int mAdtPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"AdtPatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AdtPatId
        {
        get { return mAdtPatId; }
        set { mAdtPatId = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdtPatAddType mAdtPatAddType
            = Kroll.Pharmacy.Api.Data.AdtPatAddType.AdtPatAddType_Insert;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"AdtPatAddType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdtPatAddType.AdtPatAddType_Insert)]
        
        public Kroll.Pharmacy.Api.Data.AdtPatAddType AdtPatAddType
        {
        get { return mAdtPatAddType; }
        set { mAdtPatAddType = value; }
        }

        private int mPatAddId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"PatAddId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatAddId
        {
        get { return mPatAddId; }
        set { mPatAddId = value; }
        }

        private bool mPatAddIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"PatAddIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatAddIdSpecified
        {
        get { return mPatAddIdSpecified; }
        set { mPatAddIdSpecified = value; }
        }

        private string mExternalReference
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ExternalReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalReference
        {
        get { return mExternalReference; }
        set { mExternalReference = value; }
        }

        private string mLocation
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Location", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Location
        {
        get { return mLocation; }
        set { mLocation = value; }
        }

        private bool mLocationSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"LocationSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LocationSpecified
        {
        get { return mLocationSpecified; }
        set { mLocationSpecified = value; }
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

        private bool mAddress1Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Address1Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Address2", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Address2Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"City", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"CitySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"Prov", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ProvSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"Postal", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"PostalSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"Country", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"CountrySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CountrySpecified
        {
        get { return mCountrySpecified; }
        set { mCountrySpecified = value; }
        }

        private string mPhone
            = "";
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"Phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Phone
        {
        get { return mPhone; }
        set { mPhone = value; }
        }

        private bool mPhoneSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"PhoneSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PhoneSpecified
        {
        get { return mPhoneSpecified; }
        set { mPhoneSpecified = value; }
        }

        private string mPhoneExtension
            = "";
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"PhoneExtension", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PhoneExtension
        {
        get { return mPhoneExtension; }
        set { mPhoneExtension = value; }
        }

        private bool mPhoneExtensionSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"PhoneExtensionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PhoneExtensionSpecified
        {
        get { return mPhoneExtensionSpecified; }
        set { mPhoneExtensionSpecified = value; }
        }

        private string mFax
            = "";
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"Fax", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Fax
        {
        get { return mFax; }
        set { mFax = value; }
        }

        private bool mFaxSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"FaxSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FaxSpecified
        {
        get { return mFaxSpecified; }
        set { mFaxSpecified = value; }
        }

        private string mFaxExtension
            = "";
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"FaxExtension", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FaxExtension
        {
        get { return mFaxExtension; }
        set { mFaxExtension = value; }
        }

        private bool mFaxExtensionSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"FaxExtensionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FaxExtensionSpecified
        {
        get { return mFaxExtensionSpecified; }
        set { mFaxExtensionSpecified = value; }
        }

        private bool mUseForDelivery
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"UseForDelivery", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseForDelivery
        {
        get { return mUseForDelivery; }
        set { mUseForDelivery = value; }
        }

        private bool mUseForDeliverySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"UseForDeliverySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseForDeliverySpecified
        {
        get { return mUseForDeliverySpecified; }
        set { mUseForDeliverySpecified = value; }
        }

        private bool mUseForBilling
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"UseForBilling", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseForBilling
        {
        get { return mUseForBilling; }
        set { mUseForBilling = value; }
        }

        private bool mUseForBillingSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"UseForBillingSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseForBillingSpecified
        {
        get { return mUseForBillingSpecified; }
        set { mUseForBillingSpecified = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        