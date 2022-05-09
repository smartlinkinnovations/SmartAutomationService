
        // Generated from: PatPln.proto
        // Note: requires additional types generated from: Relationship_Enum.proto
        // Note: requires additional types generated from: DeductType_Enum.proto
        // Note: requires additional types generated from: Sex_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatPln")]
        public partial class PatPln : global::ProtoBuf.IExtensible
        {
        public PatPln() {}
        

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

        private int mSeq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Seq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Seq
        {
        get { return mSeq; }
        set { mSeq = value; }
        }

        private int mSubPlanId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"SubPlanId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SubPlanId
        {
        get { return mSubPlanId; }
        set { mSubPlanId = value; }
        }

        private string mCardholder
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Cardholder", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Cardholder
        {
        get { return mCardholder; }
        set { mCardholder = value; }
        }

        private string mCarrierId
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"CarrierId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CarrierId
        {
        get { return mCarrierId; }
        set { mCarrierId = value; }
        }

        private string mGroupId
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"GroupId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string GroupId
        {
        get { return mGroupId; }
        set { mGroupId = value; }
        }

        private string mClientId
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"ClientId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ClientId
        {
        get { return mClientId; }
        set { mClientId = value; }
        }

        private string mCphaPatCode
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CphaPatCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CphaPatCode
        {
        get { return mCphaPatCode; }
        set { mCphaPatCode = value; }
        }

        private double mExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"ExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExpiryDateSpecified
        {
        get { return mExpiryDateSpecified; }
        set { mExpiryDateSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.Relationship mRelationship
            = Kroll.Pharmacy.Api.Data.Relationship.Relationship_Cardholder;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Relationship", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.Relationship.Relationship_Cardholder)]
        
        public Kroll.Pharmacy.Api.Data.Relationship Relationship
        {
        get { return mRelationship; }
        set { mRelationship = value; }
        }

        private Kroll.Pharmacy.Api.Data.DeductType mDeductType
            = Kroll.Pharmacy.Api.Data.DeductType.DeductType_Unknown;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DeductType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DeductType.DeductType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.DeductType DeductType
        {
        get { return mDeductType; }
        set { mDeductType = value; }
        }

        private string mDeductValue
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DeductValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DeductValue
        {
        get { return mDeductValue; }
        set { mDeductValue = value; }
        }

        private string mCommentPlaintext
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"CommentPlaintext", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CommentPlaintext
        {
        get { return mCommentPlaintext; }
        set { mCommentPlaintext = value; }
        }

        private int mLinkedPlanId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"LinkedPlanId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int LinkedPlanId
        {
        get { return mLinkedPlanId; }
        set { mLinkedPlanId = value; }
        }

        private bool mLinkedPlanIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"LinkedPlanIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LinkedPlanIdSpecified
        {
        get { return mLinkedPlanIdSpecified; }
        set { mLinkedPlanIdSpecified = value; }
        }

        private bool mAlwaysUseInRx
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"AlwaysUseInRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AlwaysUseInRx
        {
        get { return mAlwaysUseInRx; }
        set { mAlwaysUseInRx = value; }
        }

        private string mFirstName
            = "";
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"FirstName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FirstName
        {
        get { return mFirstName; }
        set { mFirstName = value; }
        }

        private double mInactivatedOn
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"InactivatedOn", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"InactivatedOnSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InactivatedOnSpecified
        {
        get { return mInactivatedOnSpecified; }
        set { mInactivatedOnSpecified = value; }
        }

        private double mBirthday
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"Birthday", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"BirthdaySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BirthdaySpecified
        {
        get { return mBirthdaySpecified; }
        set { mBirthdaySpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.Sex mPatSex
            = Kroll.Pharmacy.Api.Data.Sex.Sex_Unknown;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"PatSex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.Sex.Sex_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.Sex PatSex
        {
        get { return mPatSex; }
        set { mPatSex = value; }
        }

        private string mLastName
            = "";
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"LastName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LastName
        {
        get { return mLastName; }
        set { mLastName = value; }
        }

        private bool mDeleted
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"Deleted", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Deleted
        {
        get { return mDeleted; }
        set { mDeleted = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        