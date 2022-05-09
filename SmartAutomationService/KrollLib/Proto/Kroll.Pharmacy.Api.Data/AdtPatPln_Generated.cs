
        // Generated from: AdtPatPln.proto
        // Note: requires additional types generated from: AdtPatPlnType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AdtPatPln")]
        public partial class AdtPatPln : global::ProtoBuf.IExtensible
        {
        public AdtPatPln() {}
        

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

        private Kroll.Pharmacy.Api.Data.AdtPatPlnType mAdtPatPlnType
            = Kroll.Pharmacy.Api.Data.AdtPatPlnType.AdtPatPlnType_Insert;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"AdtPatPlnType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdtPatPlnType.AdtPatPlnType_Insert)]
        
        public Kroll.Pharmacy.Api.Data.AdtPatPlnType AdtPatPlnType
        {
        get { return mAdtPatPlnType; }
        set { mAdtPatPlnType = value; }
        }

        private string mExternalReference
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ExternalReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalReference
        {
        get { return mExternalReference; }
        set { mExternalReference = value; }
        }

        private int mPatPlnId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"PatPlnId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatPlnId
        {
        get { return mPatPlnId; }
        set { mPatPlnId = value; }
        }

        private bool mPatPlnIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PatPlnIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatPlnIdSpecified
        {
        get { return mPatPlnIdSpecified; }
        set { mPatPlnIdSpecified = value; }
        }

        private int mSubPlanId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"SubPlanId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SubPlanId
        {
        get { return mSubPlanId; }
        set { mSubPlanId = value; }
        }

        private bool mSubPlanIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"SubPlanIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SubPlanIdSpecified
        {
        get { return mSubPlanIdSpecified; }
        set { mSubPlanIdSpecified = value; }
        }

        private string mPlanDescription
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"PlanDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PlanDescription
        {
        get { return mPlanDescription; }
        set { mPlanDescription = value; }
        }

        private bool mPlanDescriptionSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"PlanDescriptionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PlanDescriptionSpecified
        {
        get { return mPlanDescriptionSpecified; }
        set { mPlanDescriptionSpecified = value; }
        }

        private string mSubPlanCode
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"SubPlanCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SubPlanCode
        {
        get { return mSubPlanCode; }
        set { mSubPlanCode = value; }
        }

        private bool mSubPlanCodeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"SubPlanCodeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SubPlanCodeSpecified
        {
        get { return mSubPlanCodeSpecified; }
        set { mSubPlanCodeSpecified = value; }
        }

        private bool mIsProvincialPlan
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"IsProvincialPlan", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsProvincialPlan
        {
        get { return mIsProvincialPlan; }
        set { mIsProvincialPlan = value; }
        }

        private string mCarrierId
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"CarrierId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CarrierId
        {
        get { return mCarrierId; }
        set { mCarrierId = value; }
        }

        private bool mCarrierIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"CarrierIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CarrierIdSpecified
        {
        get { return mCarrierIdSpecified; }
        set { mCarrierIdSpecified = value; }
        }

        private string mGroupId
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"GroupId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string GroupId
        {
        get { return mGroupId; }
        set { mGroupId = value; }
        }

        private bool mGroupIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"GroupIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool GroupIdSpecified
        {
        get { return mGroupIdSpecified; }
        set { mGroupIdSpecified = value; }
        }

        private string mClientId
            = "";
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"ClientId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ClientId
        {
        get { return mClientId; }
        set { mClientId = value; }
        }

        private bool mClientIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"ClientIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ClientIdSpecified
        {
        get { return mClientIdSpecified; }
        set { mClientIdSpecified = value; }
        }

        private string mCPHAPatCode
            = "";
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"CPHAPatCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CPHAPatCode
        {
        get { return mCPHAPatCode; }
        set { mCPHAPatCode = value; }
        }

        private bool mCPHAPatCodeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"CPHAPatCodeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CPHAPatCodeSpecified
        {
        get { return mCPHAPatCodeSpecified; }
        set { mCPHAPatCodeSpecified = value; }
        }

        private double mExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"ExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExpiryDateSpecified
        {
        get { return mExpiryDateSpecified; }
        set { mExpiryDateSpecified = value; }
        }

        private string mRel
            = "";
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"Rel", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Rel
        {
        get { return mRel; }
        set { mRel = value; }
        }

        private bool mRelSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"RelSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RelSpecified
        {
        get { return mRelSpecified; }
        set { mRelSpecified = value; }
        }

        private int mDeductType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"DeductType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeductType
        {
        get { return mDeductType; }
        set { mDeductType = value; }
        }

        private bool mDeductTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"DeductTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeductTypeSpecified
        {
        get { return mDeductTypeSpecified; }
        set { mDeductTypeSpecified = value; }
        }

        private string mDeductValue
            = "";
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"DeductValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DeductValue
        {
        get { return mDeductValue; }
        set { mDeductValue = value; }
        }

        private bool mDeductValueSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"DeductValueSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeductValueSpecified
        {
        get { return mDeductValueSpecified; }
        set { mDeductValueSpecified = value; }
        }

        private string mCardholderLastName
            = "";
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"CardholderLastName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CardholderLastName
        {
        get { return mCardholderLastName; }
        set { mCardholderLastName = value; }
        }

        private bool mCardholderLastNameSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"CardholderLastNameSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CardholderLastNameSpecified
        {
        get { return mCardholderLastNameSpecified; }
        set { mCardholderLastNameSpecified = value; }
        }

        private string mCardholderFirstName
            = "";
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"CardholderFirstName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CardholderFirstName
        {
        get { return mCardholderFirstName; }
        set { mCardholderFirstName = value; }
        }

        private bool mCardholderFirstNameSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"CardholderFirstNameSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CardholderFirstNameSpecified
        {
        get { return mCardholderFirstNameSpecified; }
        set { mCardholderFirstNameSpecified = value; }
        }

        private bool mAlwaysUseInRx
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"AlwaysUseInRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AlwaysUseInRx
        {
        get { return mAlwaysUseInRx; }
        set { mAlwaysUseInRx = value; }
        }

        private bool mAlwaysUseInRxSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"AlwaysUseInRxSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AlwaysUseInRxSpecified
        {
        get { return mAlwaysUseInRxSpecified; }
        set { mAlwaysUseInRxSpecified = value; }
        }

        private double mInactivatedOn
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"InactivatedOn", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double InactivatedOn
        {
        get { return mInactivatedOn; }
        set { mInactivatedOn = value; }
        }

        private bool mInactivatedOnSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"InactivatedOnSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InactivatedOnSpecified
        {
        get { return mInactivatedOnSpecified; }
        set { mInactivatedOnSpecified = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private bool mCommentSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"CommentSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CommentSpecified
        {
        get { return mCommentSpecified; }
        set { mCommentSpecified = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        