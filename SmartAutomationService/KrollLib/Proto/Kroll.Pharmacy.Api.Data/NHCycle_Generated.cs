
        // Generated from: NHCycle.proto
        // Note: requires additional types generated from: NHCycleType_Enum.proto
        // Note: requires additional types generated from: NHBatchProcessingOrder_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NHCycle")]
        public partial class NHCycle : global::ProtoBuf.IExtensible
        {
        public NHCycle() {}
        

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

        private int mNHId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"NHId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHId
        {
        get { return mNHId; }
        set { mNHId = value; }
        }

        private string mName
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Name
        {
        get { return mName; }
        set { mName = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHCycleType mCycleType
            = Kroll.Pharmacy.Api.Data.NHCycleType.NHCycleType_Monthly;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"CycleType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHCycleType.NHCycleType_Monthly)]
        
        public Kroll.Pharmacy.Api.Data.NHCycleType CycleType
        {
        get { return mCycleType; }
        set { mCycleType = value; }
        }

        private int mCycleDays
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"CycleDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CycleDays
        {
        get { return mCycleDays; }
        set { mCycleDays = value; }
        }

        private bool mCycleDaysSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"CycleDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CycleDaysSpecified
        {
        get { return mCycleDaysSpecified; }
        set { mCycleDaysSpecified = value; }
        }

        private double mLastCycleDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"LastCycleDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastCycleDate
        {
        get { return mLastCycleDate; }
        set { mLastCycleDate = value; }
        }

        private bool mLastCycleDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"LastCycleDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastCycleDateSpecified
        {
        get { return mLastCycleDateSpecified; }
        set { mLastCycleDateSpecified = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private double mNextCycleDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"NextCycleDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NextCycleDate
        {
        get { return mNextCycleDate; }
        set { mNextCycleDate = value; }
        }

        private bool mNextCycleDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"NextCycleDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NextCycleDateSpecified
        {
        get { return mNextCycleDateSpecified; }
        set { mNextCycleDateSpecified = value; }
        }

        private double mLastRunDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"LastRunDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastRunDate
        {
        get { return mLastRunDate; }
        set { mLastRunDate = value; }
        }

        private bool mLastRunDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"LastRunDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastRunDateSpecified
        {
        get { return mLastRunDateSpecified; }
        set { mLastRunDateSpecified = value; }
        }

        private double mNextRunDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"NextRunDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NextRunDate
        {
        get { return mNextRunDate; }
        set { mNextRunDate = value; }
        }

        private bool mNextRunDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"NextRunDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NextRunDateSpecified
        {
        get { return mNextRunDateSpecified; }
        set { mNextRunDateSpecified = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private int mPriority
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"Priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Priority
        {
        get { return mPriority; }
        set { mPriority = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHBatchProcessingOrder mBatchProcessingOrder
            = Kroll.Pharmacy.Api.Data.NHBatchProcessingOrder.NHBatchProcessingOrder_Unknown;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"BatchProcessingOrder", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHBatchProcessingOrder.NHBatchProcessingOrder_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.NHBatchProcessingOrder BatchProcessingOrder
        {
        get { return mBatchProcessingOrder; }
        set { mBatchProcessingOrder = value; }
        }

        private bool mIsScheduled
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"IsScheduled", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsScheduled
        {
        get { return mIsScheduled; }
        set { mIsScheduled = value; }
        }

        private double mScheduledTime
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"ScheduledTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ScheduledTime
        {
        get { return mScheduledTime; }
        set { mScheduledTime = value; }
        }

        private bool mScheduledTimeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"ScheduledTimeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScheduledTimeSpecified
        {
        get { return mScheduledTimeSpecified; }
        set { mScheduledTimeSpecified = value; }
        }

        private string mScheduledInit
            = "";
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"ScheduledInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ScheduledInit
        {
        get { return mScheduledInit; }
        set { mScheduledInit = value; }
        }

        private bool mInitiateAdjudication
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"InitiateAdjudication", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InitiateAdjudication
        {
        get { return mInitiateAdjudication; }
        set { mInitiateAdjudication = value; }
        }

        private bool mPrintNHLabels
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"PrintNHLabels", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintNHLabels
        {
        get { return mPrintNHLabels; }
        set { mPrintNHLabels = value; }
        }

        private bool mPrintRegLabels
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"PrintRegLabels", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintRegLabels
        {
        get { return mPrintRegLabels; }
        set { mPrintRegLabels = value; }
        }

        private int mAddRegularRepeats
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"AddRegularRepeats", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AddRegularRepeats
        {
        get { return mAddRegularRepeats; }
        set { mAddRegularRepeats = value; }
        }

        private bool mCopyRegularRxsNeedingRepeatsToNew
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"CopyRegularRxsNeedingRepeatsToNew", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CopyRegularRxsNeedingRepeatsToNew
        {
        get { return mCopyRegularRxsNeedingRepeatsToNew; }
        set { mCopyRegularRxsNeedingRepeatsToNew = value; }
        }

        private int mAddNarcoticRepeats
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"AddNarcoticRepeats", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AddNarcoticRepeats
        {
        get { return mAddNarcoticRepeats; }
        set { mAddNarcoticRepeats = value; }
        }

        private bool mCopyNarcoticRxsNeedingRepeatsToNew
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"CopyNarcoticRxsNeedingRepeatsToNew", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CopyNarcoticRxsNeedingRepeatsToNew
        {
        get { return mCopyNarcoticRxsNeedingRepeatsToNew; }
        set { mCopyNarcoticRxsNeedingRepeatsToNew = value; }
        }

        private double mLastScheduledQueueDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"LastScheduledQueueDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastScheduledQueueDate
        {
        get { return mLastScheduledQueueDate; }
        set { mLastScheduledQueueDate = value; }
        }

        private bool mLastScheduledQueueDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"LastScheduledQueueDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastScheduledQueueDateSpecified
        {
        get { return mLastScheduledQueueDateSpecified; }
        set { mLastScheduledQueueDateSpecified = value; }
        }

        private int mMailDistributionListId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"MailDistributionListId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MailDistributionListId
        {
        get { return mMailDistributionListId; }
        set { mMailDistributionListId = value; }
        }

        private bool mMailDistributionListIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"MailDistributionListIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MailDistributionListIdSpecified
        {
        get { return mMailDistributionListIdSpecified; }
        set { mMailDistributionListIdSpecified = value; }
        }

        private int mScheduledUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"ScheduledUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ScheduledUserId
        {
        get { return mScheduledUserId; }
        set { mScheduledUserId = value; }
        }

        private bool mScheduledUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"ScheduledUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScheduledUserIdSpecified
        {
        get { return mScheduledUserIdSpecified; }
        set { mScheduledUserIdSpecified = value; }
        }

        private int mDefaultDueDateCategoryId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"DefaultDueDateCategoryId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DefaultDueDateCategoryId
        {
        get { return mDefaultDueDateCategoryId; }
        set { mDefaultDueDateCategoryId = value; }
        }

        private bool mDefaultDueDateCategoryIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"DefaultDueDateCategoryIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DefaultDueDateCategoryIdSpecified
        {
        get { return mDefaultDueDateCategoryIdSpecified; }
        set { mDefaultDueDateCategoryIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        