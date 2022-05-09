
        // Generated from: Intervention.proto
        // Note: requires additional types generated from: InterventionType_Enum.proto
        // Note: requires additional types generated from: InterventionStatus_Enum.proto
        // Note: requires additional types generated from: PrivacyConsentChoice_Enum.proto
        // Note: requires additional types generated from: OptInOptOutChoice_Enum.proto
        // Note: requires additional types generated from: InterventionCounsellingType_Enum.proto
        // Note: requires additional types generated from: InterventionDetails.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Intervention")]
        public partial class Intervention : global::ProtoBuf.IExtensible
        {
        public Intervention() {}
        

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

        private Kroll.Pharmacy.Api.Data.InterventionType mType
            = Kroll.Pharmacy.Api.Data.InterventionType.InterventionType_Unknown;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.InterventionType.InterventionType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.InterventionType Type
        {
        get { return mType; }
        set { mType = value; }
        }

        private Kroll.Pharmacy.Api.Data.InterventionStatus mStatus
            = Kroll.Pharmacy.Api.Data.InterventionStatus.InterventionStatus_Open;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.InterventionStatus.InterventionStatus_Open)]
        
        public Kroll.Pharmacy.Api.Data.InterventionStatus Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private bool mRxNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxNumSpecified
        {
        get { return mRxNumSpecified; }
        set { mRxNumSpecified = value; }
        }

        private string mCreatedBy
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"CreatedBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CreatedBy
        {
        get { return mCreatedBy; }
        set { mCreatedBy = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateCreatedSpecified
        {
        get { return mDateCreatedSpecified; }
        set { mDateCreatedSpecified = value; }
        }

        private string mResolvedBy
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ResolvedBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResolvedBy
        {
        get { return mResolvedBy; }
        set { mResolvedBy = value; }
        }

        private double mDateResolved
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DateResolved", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateResolved
        {
        get { return mDateResolved; }
        set { mDateResolved = value; }
        }

        private bool mDateResolvedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DateResolvedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateResolvedSpecified
        {
        get { return mDateResolvedSpecified; }
        set { mDateResolvedSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.PrivacyConsentChoice mPrivacyConsentChoice
            = Kroll.Pharmacy.Api.Data.PrivacyConsentChoice.PrivacyConsentChoice_Unknown;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"PrivacyConsentChoice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PrivacyConsentChoice.PrivacyConsentChoice_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PrivacyConsentChoice PrivacyConsentChoice
        {
        get { return mPrivacyConsentChoice; }
        set { mPrivacyConsentChoice = value; }
        }

        private Kroll.Pharmacy.Api.Data.OptInOptOutChoice mOptInOptOutChoice
            = Kroll.Pharmacy.Api.Data.OptInOptOutChoice.OptInOptOutChoice_Undecided;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"OptInOptOutChoice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.OptInOptOutChoice.OptInOptOutChoice_Undecided)]
        
        public Kroll.Pharmacy.Api.Data.OptInOptOutChoice OptInOptOutChoice
        {
        get { return mOptInOptOutChoice; }
        set { mOptInOptOutChoice = value; }
        }

        private Kroll.Pharmacy.Api.Data.InterventionCounsellingType mCounsellingType
            = Kroll.Pharmacy.Api.Data.InterventionCounsellingType.InterventionCounsellingType_InPerson;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"CounsellingType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.InterventionCounsellingType.InterventionCounsellingType_InPerson)]
        
        public Kroll.Pharmacy.Api.Data.InterventionCounsellingType CounsellingType
        {
        get { return mCounsellingType; }
        set { mCounsellingType = value; }
        }

        private string mDin
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"Din", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Din
        {
        get { return mDin; }
        set { mDin = value; }
        }

        private int mValueInt1
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"ValueInt1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ValueInt1
        {
        get { return mValueInt1; }
        set { mValueInt1 = value; }
        }

        private bool mValueInt1Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"ValueInt1Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ValueInt1Specified
        {
        get { return mValueInt1Specified; }
        set { mValueInt1Specified = value; }
        }

        private string mValueStr1
            = "";
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"ValueStr1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ValueStr1
        {
        get { return mValueStr1; }
        set { mValueStr1 = value; }
        }

        private int mValueInt2
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"ValueInt2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ValueInt2
        {
        get { return mValueInt2; }
        set { mValueInt2 = value; }
        }

        private bool mValueInt2Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"ValueInt2Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ValueInt2Specified
        {
        get { return mValueInt2Specified; }
        set { mValueInt2Specified = value; }
        }

        private string mValueStr2
            = "";
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"ValueStr2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ValueStr2
        {
        get { return mValueStr2; }
        set { mValueStr2 = value; }
        }

        private int mValueInt3
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ValueInt3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ValueInt3
        {
        get { return mValueInt3; }
        set { mValueInt3 = value; }
        }

        private bool mValueInt3Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"ValueInt3Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ValueInt3Specified
        {
        get { return mValueInt3Specified; }
        set { mValueInt3Specified = value; }
        }

        private string mValueStr3
            = "";
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"ValueStr3", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ValueStr3
        {
        get { return mValueStr3; }
        set { mValueStr3 = value; }
        }

        private int mValueInt4
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"ValueInt4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ValueInt4
        {
        get { return mValueInt4; }
        set { mValueInt4 = value; }
        }

        private bool mValueInt4Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"ValueInt4Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ValueInt4Specified
        {
        get { return mValueInt4Specified; }
        set { mValueInt4Specified = value; }
        }

        private string mValueStr4
            = "";
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"ValueStr4", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ValueStr4
        {
        get { return mValueStr4; }
        set { mValueStr4 = value; }
        }

        private int mValueInt5
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"ValueInt5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ValueInt5
        {
        get { return mValueInt5; }
        set { mValueInt5 = value; }
        }

        private bool mValueInt5Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"ValueInt5Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ValueInt5Specified
        {
        get { return mValueInt5Specified; }
        set { mValueInt5Specified = value; }
        }

        private string mValueStr5
            = "";
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"ValueStr5", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ValueStr5
        {
        get { return mValueStr5; }
        set { mValueStr5 = value; }
        }

        private int mValueInt6
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"ValueInt6", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ValueInt6
        {
        get { return mValueInt6; }
        set { mValueInt6 = value; }
        }

        private bool mValueInt6Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"ValueInt6Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ValueInt6Specified
        {
        get { return mValueInt6Specified; }
        set { mValueInt6Specified = value; }
        }

        private string mValueStr6
            = "";
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"ValueStr6", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ValueStr6
        {
        get { return mValueStr6; }
        set { mValueStr6 = value; }
        }

        private byte[] mExtraInfo
            = null;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"ExtraInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ExtraInfo
        {
        get { return mExtraInfo; }
        set { mExtraInfo = value; }
        }

        private double mDateChanged
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.InterventionDetails> mDetails = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.InterventionDetails>();
        [global::ProtoBuf.ProtoMember(38, Name=@"Details", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.InterventionDetails> Details
        {
        get { return mDetails; }
        }
    

        private int mCreatedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"CreatedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CreatedByUserId
        {
        get { return mCreatedByUserId; }
        set { mCreatedByUserId = value; }
        }

        private bool mCreatedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"CreatedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CreatedByUserIdSpecified
        {
        get { return mCreatedByUserIdSpecified; }
        set { mCreatedByUserIdSpecified = value; }
        }

        private int mResolvedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"ResolvedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ResolvedByUserId
        {
        get { return mResolvedByUserId; }
        set { mResolvedByUserId = value; }
        }

        private bool mResolvedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"ResolvedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ResolvedByUserIdSpecified
        {
        get { return mResolvedByUserIdSpecified; }
        set { mResolvedByUserIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        