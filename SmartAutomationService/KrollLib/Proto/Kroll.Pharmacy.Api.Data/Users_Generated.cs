
        // Generated from: Users.proto
        // Note: requires additional types generated from: UserGrp.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
        // Note: requires additional types generated from: UserClinicalProviderType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Users")]
        public partial class Users : global::ProtoBuf.IExtensible
        {
        public Users() {}
        

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

        private string mInit
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Init", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Init
        {
        get { return mInit; }
        set { mInit = value; }
        }

        private string mFullName
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"FullName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FullName
        {
        get { return mFullName; }
        set { mFullName = value; }
        }

        private double mLastPasswordChange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"LastPasswordChange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastPasswordChange
        {
        get { return mLastPasswordChange; }
        set { mLastPasswordChange = value; }
        }

        private bool mLastPasswordChangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"LastPasswordChangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastPasswordChangeSpecified
        {
        get { return mLastPasswordChangeSpecified; }
        set { mLastPasswordChangeSpecified = value; }
        }

        private string mLicenseNumber
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"LicenseNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LicenseNumber
        {
        get { return mLicenseNumber; }
        set { mLicenseNumber = value; }
        }

        private string mLicenseNumber2
            = "";
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"LicenseNumber2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LicenseNumber2
        {
        get { return mLicenseNumber2; }
        set { mLicenseNumber2 = value; }
        }

        private bool mDisabled
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Disabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Disabled
        {
        get { return mDisabled; }
        set { mDisabled = value; }
        }

        private double mLastClinicalActivity
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"LastClinicalActivity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastClinicalActivity
        {
        get { return mLastClinicalActivity; }
        set { mLastClinicalActivity = value; }
        }

        private bool mLastClinicalActivitySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"LastClinicalActivitySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastClinicalActivitySpecified
        {
        get { return mLastClinicalActivitySpecified; }
        set { mLastClinicalActivitySpecified = value; }
        }

        private bool mIsPharmacist
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"IsPharmacist", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsPharmacist
        {
        get { return mIsPharmacist; }
        set { mIsPharmacist = value; }
        }

        private Kroll.Pharmacy.Api.Data.UserClinicalProviderType mClinicalProviderType
            = Kroll.Pharmacy.Api.Data.UserClinicalProviderType.UserClinicalProviderType_Technician;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"ClinicalProviderType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UserClinicalProviderType.UserClinicalProviderType_Technician)]
        
        public Kroll.Pharmacy.Api.Data.UserClinicalProviderType ClinicalProviderType
        {
        get { return mClinicalProviderType; }
        set { mClinicalProviderType = value; }
        }

        private double mPharmacistUserExpires
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"PharmacistUserExpires", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double PharmacistUserExpires
        {
        get { return mPharmacistUserExpires; }
        set { mPharmacistUserExpires = value; }
        }

        private bool mPharmacistUserExpiresSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"PharmacistUserExpiresSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PharmacistUserExpiresSpecified
        {
        get { return mPharmacistUserExpiresSpecified; }
        set { mPharmacistUserExpiresSpecified = value; }
        }

        private string mPharmacistUserInit
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"PharmacistUserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PharmacistUserInit
        {
        get { return mPharmacistUserInit; }
        set { mPharmacistUserInit = value; }
        }

        private string mNetworkUsername
            = "";
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"NetworkUsername", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NetworkUsername
        {
        get { return mNetworkUsername; }
        set { mNetworkUsername = value; }
        }

        private string mNetworkUsername2
            = "";
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"NetworkUsername2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NetworkUsername2
        {
        get { return mNetworkUsername2; }
        set { mNetworkUsername2 = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink CentralMaintLink
        {
        get { return mCentralMaintLink; }
        set { mCentralMaintLink = value; }
        }

        private double mExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"ExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ExpiryDate
        {
        get { return mExpiryDate; }
        set { mExpiryDate = value; }
        }

        private bool mExpiryDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"ExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExpiryDateSpecified
        {
        get { return mExpiryDateSpecified; }
        set { mExpiryDateSpecified = value; }
        }

        private bool mPasswordNeverExpires
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"PasswordNeverExpires", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PasswordNeverExpires
        {
        get { return mPasswordNeverExpires; }
        set { mPasswordNeverExpires = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private double mLockedOutOnDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"LockedOutOnDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LockedOutOnDate
        {
        get { return mLockedOutOnDate; }
        set { mLockedOutOnDate = value; }
        }

        private bool mLockedOutOnDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"LockedOutOnDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LockedOutOnDateSpecified
        {
        get { return mLockedOutOnDateSpecified; }
        set { mLockedOutOnDateSpecified = value; }
        }

        private bool mForcePasswordChangeOnNextLogin
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"ForcePasswordChangeOnNextLogin", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ForcePasswordChangeOnNextLogin
        {
        get { return mForcePasswordChangeOnNextLogin; }
        set { mForcePasswordChangeOnNextLogin = value; }
        }

        private double mLastNetworkTermsOfUseDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"LastNetworkTermsOfUseDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastNetworkTermsOfUseDate
        {
        get { return mLastNetworkTermsOfUseDate; }
        set { mLastNetworkTermsOfUseDate = value; }
        }

        private bool mLastNetworkTermsOfUseDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"LastNetworkTermsOfUseDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastNetworkTermsOfUseDateSpecified
        {
        get { return mLastNetworkTermsOfUseDateSpecified; }
        set { mLastNetworkTermsOfUseDateSpecified = value; }
        }

        private int mDateDeleted
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"DateDeleted", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DateDeleted
        {
        get { return mDateDeleted; }
        set { mDateDeleted = value; }
        }

        private bool mDateDeletedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"DateDeletedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateDeletedSpecified
        {
        get { return mDateDeletedSpecified; }
        set { mDateDeletedSpecified = value; }
        }

        private int mPharmacistUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"PharmacistUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PharmacistUserId
        {
        get { return mPharmacistUserId; }
        set { mPharmacistUserId = value; }
        }

        private bool mPharmacistUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"PharmacistUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PharmacistUserIdSpecified
        {
        get { return mPharmacistUserIdSpecified; }
        set { mPharmacistUserIdSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.UserGrp> mGroups = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.UserGrp>();
        [global::ProtoBuf.ProtoMember(30, Name=@"Groups", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.UserGrp> Groups
        {
        get { return mGroups; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        