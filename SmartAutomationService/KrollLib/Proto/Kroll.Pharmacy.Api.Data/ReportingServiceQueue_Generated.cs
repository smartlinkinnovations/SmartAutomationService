
        // Generated from: ReportingServiceQueue.proto
        // Note: requires additional types generated from: ReportingServiceQueueItemType_Enum.proto
        // Note: requires additional types generated from: ReportingServiceQueueDeferReason_Enum.proto
        // Note: requires additional types generated from: HistoricFlag_Enum.proto
        // Note: requires additional types generated from: RxStatus_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReportingServiceQueue")]
        public partial class ReportingServiceQueue : global::ProtoBuf.IExtensible
        {
        public ReportingServiceQueue() {}
        

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

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxNumSpecified
        {
        get { return mRxNumSpecified; }
        set { mRxNumSpecified = value; }
        }

        private int mDocId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocIdSpecified
        {
        get { return mDocIdSpecified; }
        set { mDocIdSpecified = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private bool mPatIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatIdSpecified
        {
        get { return mPatIdSpecified; }
        set { mPatIdSpecified = value; }
        }

        private int mDrgId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DrgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgId
        {
        get { return mDrgId; }
        set { mDrgId = value; }
        }

        private bool mDrgIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DrgIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrgIdSpecified
        {
        get { return mDrgIdSpecified; }
        set { mDrgIdSpecified = value; }
        }

        private int mMixId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"MixId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MixId
        {
        get { return mMixId; }
        set { mMixId = value; }
        }

        private bool mMixIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"MixIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MixIdSpecified
        {
        get { return mMixIdSpecified; }
        set { mMixIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.ReportingServiceQueueItemType mQueueItemType
            = Kroll.Pharmacy.Api.Data.ReportingServiceQueueItemType.ReportingServiceQueueItemType_FillCancelRx;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"QueueItemType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ReportingServiceQueueItemType.ReportingServiceQueueItemType_FillCancelRx)]
        
        public Kroll.Pharmacy.Api.Data.ReportingServiceQueueItemType QueueItemType
        {
        get { return mQueueItemType; }
        set { mQueueItemType = value; }
        }

        private Kroll.Pharmacy.Api.Data.HistoricFlag mHistoricFlag
            = Kroll.Pharmacy.Api.Data.HistoricFlag.HistoricFlag_Regular;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"HistoricFlag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.HistoricFlag.HistoricFlag_Regular)]
        
        public Kroll.Pharmacy.Api.Data.HistoricFlag HistoricFlag
        {
        get { return mHistoricFlag; }
        set { mHistoricFlag = value; }
        }

        private double mDateAdded
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DateAdded", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateAdded
        {
        get { return mDateAdded; }
        set { mDateAdded = value; }
        }

        private bool mDateAddedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"DateAddedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateAddedSpecified
        {
        get { return mDateAddedSpecified; }
        set { mDateAddedSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxStatus mStatus
            = Kroll.Pharmacy.Api.Data.RxStatus.RxStatus_Unknown;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxStatus.RxStatus_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.RxStatus Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private bool mIsModify
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"IsModify", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsModify
        {
        get { return mIsModify; }
        set { mIsModify = value; }
        }

        private int mPriority
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"Priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Priority
        {
        get { return mPriority; }
        set { mPriority = value; }
        }

        private int mReportingServiceHostId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"ReportingServiceHostId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ReportingServiceHostId
        {
        get { return mReportingServiceHostId; }
        set { mReportingServiceHostId = value; }
        }

        private double mDeferUntil
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DeferUntil", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DeferUntil
        {
        get { return mDeferUntil; }
        set { mDeferUntil = value; }
        }

        private bool mDeferUntilSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"DeferUntilSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeferUntilSpecified
        {
        get { return mDeferUntilSpecified; }
        set { mDeferUntilSpecified = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private bool mStoreIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"StoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StoreIdSpecified
        {
        get { return mStoreIdSpecified; }
        set { mStoreIdSpecified = value; }
        }

        private int mPackagerBatchId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"PackagerBatchId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PackagerBatchId
        {
        get { return mPackagerBatchId; }
        set { mPackagerBatchId = value; }
        }

        private bool mPackagerBatchIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"PackagerBatchIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PackagerBatchIdSpecified
        {
        get { return mPackagerBatchIdSpecified; }
        set { mPackagerBatchIdSpecified = value; }
        }

        private int mERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"ERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ERxOrderId
        {
        get { return mERxOrderId; }
        set { mERxOrderId = value; }
        }

        private bool mERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"ERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ERxOrderIdSpecified
        {
        get { return mERxOrderIdSpecified; }
        set { mERxOrderIdSpecified = value; }
        }

        private int mToDoId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"ToDoId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ToDoId
        {
        get { return mToDoId; }
        set { mToDoId = value; }
        }

        private bool mToDoIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"ToDoIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ToDoIdSpecified
        {
        get { return mToDoIdSpecified; }
        set { mToDoIdSpecified = value; }
        }

        private int mDrgPackInvHistId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"DrgPackInvHistId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgPackInvHistId
        {
        get { return mDrgPackInvHistId; }
        set { mDrgPackInvHistId = value; }
        }

        private bool mDrgPackInvHistIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"DrgPackInvHistIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrgPackInvHistIdSpecified
        {
        get { return mDrgPackInvHistIdSpecified; }
        set { mDrgPackInvHistIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.ReportingServiceQueueDeferReason mDeferReason
            = Kroll.Pharmacy.Api.Data.ReportingServiceQueueDeferReason.ReportingServiceQueueDeferReason_None;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"DeferReason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ReportingServiceQueueDeferReason.ReportingServiceQueueDeferReason_None)]
        
        public Kroll.Pharmacy.Api.Data.ReportingServiceQueueDeferReason DeferReason
        {
        get { return mDeferReason; }
        set { mDeferReason = value; }
        }

        private int mRxSuspendId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"RxSuspendId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxSuspendId
        {
        get { return mRxSuspendId; }
        set { mRxSuspendId = value; }
        }

        private bool mRxSuspendIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"RxSuspendIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxSuspendIdSpecified
        {
        get { return mRxSuspendIdSpecified; }
        set { mRxSuspendIdSpecified = value; }
        }

        private int mMailId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"MailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MailId
        {
        get { return mMailId; }
        set { mMailId = value; }
        }

        private bool mMailIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"MailIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MailIdSpecified
        {
        get { return mMailIdSpecified; }
        set { mMailIdSpecified = value; }
        }

        private int mDrgProgramId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"DrgProgramId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgProgramId
        {
        get { return mDrgProgramId; }
        set { mDrgProgramId = value; }
        }

        private bool mDrgProgramIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"DrgProgramIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrgProgramIdSpecified
        {
        get { return mDrgProgramIdSpecified; }
        set { mDrgProgramIdSpecified = value; }
        }

        private int mRxTransferStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"RxTransferStoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxTransferStoreId
        {
        get { return mRxTransferStoreId; }
        set { mRxTransferStoreId = value; }
        }

        private bool mRxTransferStoreIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"RxTransferStoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxTransferStoreIdSpecified
        {
        get { return mRxTransferStoreIdSpecified; }
        set { mRxTransferStoreIdSpecified = value; }
        }

        private int mOrigRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"OrigRxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OrigRxNum
        {
        get { return mOrigRxNum; }
        set { mOrigRxNum = value; }
        }

        private bool mOrigRxNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"OrigRxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OrigRxNumSpecified
        {
        get { return mOrigRxNumSpecified; }
        set { mOrigRxNumSpecified = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private int mWorkOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"WorkOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int WorkOrderId
        {
        get { return mWorkOrderId; }
        set { mWorkOrderId = value; }
        }

        private bool mWorkOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"WorkOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WorkOrderIdSpecified
        {
        get { return mWorkOrderIdSpecified; }
        set { mWorkOrderIdSpecified = value; }
        }

        private int mERxTransmissionId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"ERxTransmissionId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ERxTransmissionId
        {
        get { return mERxTransmissionId; }
        set { mERxTransmissionId = value; }
        }

        private bool mERxTransmissionIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"ERxTransmissionIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ERxTransmissionIdSpecified
        {
        get { return mERxTransmissionIdSpecified; }
        set { mERxTransmissionIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        