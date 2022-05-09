
        // Generated from: RxWorkflowDetail.proto
        // Note: requires additional types generated from: RxWorkflowDetailStatus_Enum.proto
        // Note: requires additional types generated from: CompressionType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxWorkflowDetail")]
        public partial class RxWorkflowDetail : global::ProtoBuf.IExtensible
        {
        public RxWorkflowDetail() {}
        

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

        private int mRxWorkflowId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RxWorkflowId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxWorkflowId
        {
        get { return mRxWorkflowId; }
        set { mRxWorkflowId = value; }
        }

        private int mWorkflowActionType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"WorkflowActionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int WorkflowActionType
        {
        get { return mWorkflowActionType; }
        set { mWorkflowActionType = value; }
        }

        private int mIterationNumber
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"IterationNumber", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int IterationNumber
        {
        get { return mIterationNumber; }
        set { mIterationNumber = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxWorkflowDetailStatus mStatus
            = Kroll.Pharmacy.Api.Data.RxWorkflowDetailStatus.RxWorkflowDetailStatus_NotCompleted;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxWorkflowDetailStatus.RxWorkflowDetailStatus_NotCompleted)]
        
        public Kroll.Pharmacy.Api.Data.RxWorkflowDetailStatus Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private double mCompletedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"CompletedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CompletedDate
        {
        get { return mCompletedDate; }
        set { mCompletedDate = value; }
        }

        private bool mCompletedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"CompletedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CompletedDateSpecified
        {
        get { return mCompletedDateSpecified; }
        set { mCompletedDateSpecified = value; }
        }

        private string mCompletedByInit
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"CompletedByInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CompletedByInit
        {
        get { return mCompletedByInit; }
        set { mCompletedByInit = value; }
        }

        private int mCompletedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CompletedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CompletedByUserId
        {
        get { return mCompletedByUserId; }
        set { mCompletedByUserId = value; }
        }

        private bool mCompletedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"CompletedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CompletedByUserIdSpecified
        {
        get { return mCompletedByUserIdSpecified; }
        set { mCompletedByUserIdSpecified = value; }
        }

        private string mCompletedByAssociatedPharmacistInit
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"CompletedByAssociatedPharmacistInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CompletedByAssociatedPharmacistInit
        {
        get { return mCompletedByAssociatedPharmacistInit; }
        set { mCompletedByAssociatedPharmacistInit = value; }
        }

        private int mCompletedByAssociatedPharmacistUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"CompletedByAssociatedPharmacistUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CompletedByAssociatedPharmacistUserId
        {
        get { return mCompletedByAssociatedPharmacistUserId; }
        set { mCompletedByAssociatedPharmacistUserId = value; }
        }

        private bool mCompletedByAssociatedPharmacistUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"CompletedByAssociatedPharmacistUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CompletedByAssociatedPharmacistUserIdSpecified
        {
        get { return mCompletedByAssociatedPharmacistUserIdSpecified; }
        set { mCompletedByAssociatedPharmacistUserIdSpecified = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private byte[] mContextInfo
            = null;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ContextInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ContextInfo
        {
        get { return mContextInfo; }
        set { mContextInfo = value; }
        }

        private Kroll.Pharmacy.Api.Data.CompressionType mContextInfoCompressionType
            = Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ContextInfoCompressionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.CompressionType ContextInfoCompressionType
        {
        get { return mContextInfoCompressionType; }
        set { mContextInfoCompressionType = value; }
        }

        private double mRejectedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"RejectedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RejectedDate
        {
        get { return mRejectedDate; }
        set { mRejectedDate = value; }
        }

        private bool mRejectedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"RejectedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RejectedDateSpecified
        {
        get { return mRejectedDateSpecified; }
        set { mRejectedDateSpecified = value; }
        }

        private string mRejectedByInit
            = "";
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"RejectedByInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RejectedByInit
        {
        get { return mRejectedByInit; }
        set { mRejectedByInit = value; }
        }

        private int mRejectedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"RejectedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RejectedByUserId
        {
        get { return mRejectedByUserId; }
        set { mRejectedByUserId = value; }
        }

        private bool mRejectedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"RejectedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RejectedByUserIdSpecified
        {
        get { return mRejectedByUserIdSpecified; }
        set { mRejectedByUserIdSpecified = value; }
        }

        private string mRejectedComment
            = "";
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"RejectedComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RejectedComment
        {
        get { return mRejectedComment; }
        set { mRejectedComment = value; }
        }

        private int mTimeToPerformSeconds
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"TimeToPerformSeconds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int TimeToPerformSeconds
        {
        get { return mTimeToPerformSeconds; }
        set { mTimeToPerformSeconds = value; }
        }

        private bool mTimeToPerformSecondsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"TimeToPerformSecondsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TimeToPerformSecondsSpecified
        {
        get { return mTimeToPerformSecondsSpecified; }
        set { mTimeToPerformSecondsSpecified = value; }
        }

        private int mClonedFromId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"ClonedFromId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ClonedFromId
        {
        get { return mClonedFromId; }
        set { mClonedFromId = value; }
        }

        private bool mClonedFromIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"ClonedFromIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ClonedFromIdSpecified
        {
        get { return mClonedFromIdSpecified; }
        set { mClonedFromIdSpecified = value; }
        }

        private bool mPerformedAutomatically
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"PerformedAutomatically", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PerformedAutomatically
        {
        get { return mPerformedAutomatically; }
        set { mPerformedAutomatically = value; }
        }

        private int mElectronicSignatureId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"ElectronicSignatureId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ElectronicSignatureId
        {
        get { return mElectronicSignatureId; }
        set { mElectronicSignatureId = value; }
        }

        private bool mElectronicSignatureIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"ElectronicSignatureIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ElectronicSignatureIdSpecified
        {
        get { return mElectronicSignatureIdSpecified; }
        set { mElectronicSignatureIdSpecified = value; }
        }

        private int mPatElectronicSignatureId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"PatElectronicSignatureId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatElectronicSignatureId
        {
        get { return mPatElectronicSignatureId; }
        set { mPatElectronicSignatureId = value; }
        }

        private bool mPatElectronicSignatureIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"PatElectronicSignatureIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatElectronicSignatureIdSpecified
        {
        get { return mPatElectronicSignatureIdSpecified; }
        set { mPatElectronicSignatureIdSpecified = value; }
        }

        private int mWorkflowQueueId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"WorkflowQueueId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int WorkflowQueueId
        {
        get { return mWorkflowQueueId; }
        set { mWorkflowQueueId = value; }
        }

        private bool mWorkflowQueueIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"WorkflowQueueIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WorkflowQueueIdSpecified
        {
        get { return mWorkflowQueueIdSpecified; }
        set { mWorkflowQueueIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        