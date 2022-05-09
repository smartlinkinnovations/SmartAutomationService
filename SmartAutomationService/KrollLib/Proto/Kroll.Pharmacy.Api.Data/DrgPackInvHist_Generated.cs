
        // Generated from: DrgPackInvHist.proto
        // Note: requires additional types generated from: DrgPackInvHistChangeType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrgPackInvHist")]
        public partial class DrgPackInvHist : global::ProtoBuf.IExtensible
        {
        public DrgPackInvHist() {}
        

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

        private int mDrgPackId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DrgPackId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgPackId
        {
        get { return mDrgPackId; }
        set { mDrgPackId = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrgPackInvHistChangeType mChangeType
            = Kroll.Pharmacy.Api.Data.DrgPackInvHistChangeType.DrgPackInvHistChangeType_Unknown;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ChangeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrgPackInvHistChangeType.DrgPackInvHistChangeType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.DrgPackInvHistChangeType ChangeType
        {
        get { return mChangeType; }
        set { mChangeType = value; }
        }

        private string mUser
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"User", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string User
        {
        get { return mUser; }
        set { mUser = value; }
        }

        private double mTimeStampDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"TimeStampDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TimeStampDate
        {
        get { return mTimeStampDate; }
        set { mTimeStampDate = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxNumSpecified
        {
        get { return mRxNumSpecified; }
        set { mRxNumSpecified = value; }
        }

        private string mPONum
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"PONum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PONum
        {
        get { return mPONum; }
        set { mPONum = value; }
        }

        private double mOldValue
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"OldValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double OldValue
        {
        get { return mOldValue; }
        set { mOldValue = value; }
        }

        private double mNewValue
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"NewValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NewValue
        {
        get { return mNewValue; }
        set { mNewValue = value; }
        }

        private string mReason
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Reason", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Reason
        {
        get { return mReason; }
        set { mReason = value; }
        }

        private int mRxWorkflowId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"RxWorkflowId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxWorkflowId
        {
        get { return mRxWorkflowId; }
        set { mRxWorkflowId = value; }
        }

        private bool mRxWorkflowIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"RxWorkflowIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxWorkflowIdSpecified
        {
        get { return mRxWorkflowIdSpecified; }
        set { mRxWorkflowIdSpecified = value; }
        }

        private int mRxWorkflowPackId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"RxWorkflowPackId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxWorkflowPackId
        {
        get { return mRxWorkflowPackId; }
        set { mRxWorkflowPackId = value; }
        }

        private bool mRxWorkflowPackIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"RxWorkflowPackIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxWorkflowPackIdSpecified
        {
        get { return mRxWorkflowPackIdSpecified; }
        set { mRxWorkflowPackIdSpecified = value; }
        }

        private int mVendorId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"VendorId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int VendorId
        {
        get { return mVendorId; }
        set { mVendorId = value; }
        }

        private bool mVendorIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"VendorIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool VendorIdSpecified
        {
        get { return mVendorIdSpecified; }
        set { mVendorIdSpecified = value; }
        }

        private double mDeltaAcqCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DeltaAcqCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DeltaAcqCost
        {
        get { return mDeltaAcqCost; }
        set { mDeltaAcqCost = value; }
        }

        private bool mDeltaAcqCostSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DeltaAcqCostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeltaAcqCostSpecified
        {
        get { return mDeltaAcqCostSpecified; }
        set { mDeltaAcqCostSpecified = value; }
        }

        private int mStoreId
            = 
                (int)1;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                (int)1)]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private bool mStoreIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"StoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StoreIdSpecified
        {
        get { return mStoreIdSpecified; }
        set { mStoreIdSpecified = value; }
        }

        private int mUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"UserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UserId
        {
        get { return mUserId; }
        set { mUserId = value; }
        }

        private bool mUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"UserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserIdSpecified
        {
        get { return mUserIdSpecified; }
        set { mUserIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        