
        // Generated from: Pln.proto
        // Note: requires additional types generated from: AdjHostId_Enum.proto
        // Note: requires additional types generated from: DinTypeForMixtureAdjudication_Enum.proto
        // Note: requires additional types generated from: PlnSub.proto
        // Note: requires additional types generated from: PlnPhone.proto
        // Note: requires additional types generated from: PlnStoreLink.proto
        // Note: requires additional types generated from: PlnPreferredProvider.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Pln")]
        public partial class Pln : global::ProtoBuf.IExtensible
        {
        public Pln() {}
        

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

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private string mAddress1
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Address1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address1
        {
        get { return mAddress1; }
        set { mAddress1 = value; }
        }

        private string mAddress2
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Address2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address2
        {
        get { return mAddress2; }
        set { mAddress2 = value; }
        }

        private string mCity
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"City", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string City
        {
        get { return mCity; }
        set { mCity = value; }
        }

        private string mProvince
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Province", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Province
        {
        get { return mProvince; }
        set { mProvince = value; }
        }

        private string mPostalCode
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PostalCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PostalCode
        {
        get { return mPostalCode; }
        set { mPostalCode = value; }
        }

        private string mCountry
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Country", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Country
        {
        get { return mCountry; }
        set { mCountry = value; }
        }

        private string mContact
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Contact", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Contact
        {
        get { return mContact; }
        set { mContact = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdjHostId mAdjHostId
            = Kroll.Pharmacy.Api.Data.AdjHostId.AdjHostId_None;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"AdjHostId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdjHostId.AdjHostId_None)]
        
        public Kroll.Pharmacy.Api.Data.AdjHostId AdjHostId
        {
        get { return mAdjHostId; }
        set { mAdjHostId = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdjHostId mClinicalAdjHostId
            = Kroll.Pharmacy.Api.Data.AdjHostId.AdjHostId_None;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"ClinicalAdjHostId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdjHostId.AdjHostId_None)]
        
        public Kroll.Pharmacy.Api.Data.AdjHostId ClinicalAdjHostId
        {
        get { return mClinicalAdjHostId; }
        set { mClinicalAdjHostId = value; }
        }

        private int mCancelDays
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"CancelDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CancelDays
        {
        get { return mCancelDays; }
        set { mCancelDays = value; }
        }

        private bool mCancelDaysSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"CancelDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CancelDaysSpecified
        {
        get { return mCancelDaysSpecified; }
        set { mCancelDaysSpecified = value; }
        }

        private bool mTrialRx
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"TrialRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TrialRx
        {
        get { return mTrialRx; }
        set { mTrialRx = value; }
        }

        private bool mTriplicate
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"Triplicate", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Triplicate
        {
        get { return mTriplicate; }
        set { mTriplicate = value; }
        }

        private bool mPayPatient
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"PayPatient", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PayPatient
        {
        get { return mPayPatient; }
        set { mPayPatient = value; }
        }

        private bool mAlternatePayee
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"AlternatePayee", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AlternatePayee
        {
        get { return mAlternatePayee; }
        set { mAlternatePayee = value; }
        }

        private bool mDailyDetailSupported
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DailyDetailSupported", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DailyDetailSupported
        {
        get { return mDailyDetailSupported; }
        set { mDailyDetailSupported = value; }
        }

        private bool mUseDefaultRelationships
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"UseDefaultRelationships", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseDefaultRelationships
        {
        get { return mUseDefaultRelationships; }
        set { mUseDefaultRelationships = value; }
        }

        private Kroll.Pharmacy.Api.Data.DinTypeForMixtureAdjudication mDinTypeForMixtureAdjudication
            = Kroll.Pharmacy.Api.Data.DinTypeForMixtureAdjudication.DinTypeForMixtureAdjudication_BillingIngredient;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"DinTypeForMixtureAdjudication", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DinTypeForMixtureAdjudication.DinTypeForMixtureAdjudication_BillingIngredient)]
        
        public Kroll.Pharmacy.Api.Data.DinTypeForMixtureAdjudication DinTypeForMixtureAdjudication
        {
        get { return mDinTypeForMixtureAdjudication; }
        set { mDinTypeForMixtureAdjudication = value; }
        }

        private string mMixtureDin
            = "";
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"MixtureDin", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MixtureDin
        {
        get { return mMixtureDin; }
        set { mMixtureDin = value; }
        }

        private bool mCheckCoverage
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"CheckCoverage", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CheckCoverage
        {
        get { return mCheckCoverage; }
        set { mCheckCoverage = value; }
        }

        private bool mUseGlobalMixtureParameters
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"UseGlobalMixtureParameters", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseGlobalMixtureParameters
        {
        get { return mUseGlobalMixtureParameters; }
        set { mUseGlobalMixtureParameters = value; }
        }

        private int mMixtureFeePerMinute
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"MixtureFeePerMinute", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MixtureFeePerMinute
        {
        get { return mMixtureFeePerMinute; }
        set { mMixtureFeePerMinute = value; }
        }

        private bool mMixtureFeePerMinuteSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"MixtureFeePerMinuteSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MixtureFeePerMinuteSpecified
        {
        get { return mMixtureFeePerMinuteSpecified; }
        set { mMixtureFeePerMinuteSpecified = value; }
        }

        private int mDontChargeMixtureTimeBelow
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"DontChargeMixtureTimeBelow", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DontChargeMixtureTimeBelow
        {
        get { return mDontChargeMixtureTimeBelow; }
        set { mDontChargeMixtureTimeBelow = value; }
        }

        private bool mDontChargeMixtureTimeBelowSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"DontChargeMixtureTimeBelowSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DontChargeMixtureTimeBelowSpecified
        {
        get { return mDontChargeMixtureTimeBelowSpecified; }
        set { mDontChargeMixtureTimeBelowSpecified = value; }
        }

        private int mUpchargeOnMixtureFeePercent
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"UpchargeOnMixtureFeePercent", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UpchargeOnMixtureFeePercent
        {
        get { return mUpchargeOnMixtureFeePercent; }
        set { mUpchargeOnMixtureFeePercent = value; }
        }

        private bool mUpchargeOnMixtureFeePercentSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"UpchargeOnMixtureFeePercentSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UpchargeOnMixtureFeePercentSpecified
        {
        get { return mUpchargeOnMixtureFeePercentSpecified; }
        set { mUpchargeOnMixtureFeePercentSpecified = value; }
        }

        private bool mCheckMixtureCoverage
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"CheckMixtureCoverage", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CheckMixtureCoverage
        {
        get { return mCheckMixtureCoverage; }
        set { mCheckMixtureCoverage = value; }
        }

        private bool mIsProvincialPlan
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"IsProvincialPlan", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsProvincialPlan
        {
        get { return mIsProvincialPlan; }
        set { mIsProvincialPlan = value; }
        }

        private bool mIsRealTime
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"IsRealTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsRealTime
        {
        get { return mIsRealTime; }
        set { mIsRealTime = value; }
        }

        private bool mUseAlternateDoctorLicenseNumber
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"UseAlternateDoctorLicenseNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseAlternateDoctorLicenseNumber
        {
        get { return mUseAlternateDoctorLicenseNumber; }
        set { mUseAlternateDoctorLicenseNumber = value; }
        }

        private bool mUseAlternatePharmacistId
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"UseAlternatePharmacistId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseAlternatePharmacistId
        {
        get { return mUseAlternatePharmacistId; }
        set { mUseAlternatePharmacistId = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink CentralMaintLink
        {
        get { return mCentralMaintLink; }
        set { mCentralMaintLink = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PlnSub> mSubPlans = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PlnSub>();
        [global::ProtoBuf.ProtoMember(41, Name=@"SubPlans", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PlnSub> SubPlans
        {
        get { return mSubPlans; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PlnPhone> mPhone = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PlnPhone>();
        [global::ProtoBuf.ProtoMember(42, Name=@"Phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PlnPhone> Phone
        {
        get { return mPhone; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PlnStoreLink> mPlanStoreLinks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PlnStoreLink>();
        [global::ProtoBuf.ProtoMember(43, Name=@"PlanStoreLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PlnStoreLink> PlanStoreLinks
        {
        get { return mPlanStoreLinks; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PlnPreferredProvider> mPreferredProviders = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PlnPreferredProvider>();
        [global::ProtoBuf.ProtoMember(44, Name=@"PreferredProviders", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PlnPreferredProvider> PreferredProviders
        {
        get { return mPreferredProviders; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        