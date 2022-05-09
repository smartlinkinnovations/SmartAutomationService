
        // Generated from: OCMQueue.proto
        // Note: requires additional types generated from: OCMQueueStatus_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCMQueue")]
        public partial class OCMQueue : global::ProtoBuf.IExtensible
        {
        public OCMQueue() {}
        

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

        private bool mPatIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatIdSpecified
        {
        get { return mPatIdSpecified; }
        set { mPatIdSpecified = value; }
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

        private int mOrigRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"OrigRxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"OrigRxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OrigRxNumSpecified
        {
        get { return mOrigRxNumSpecified; }
        set { mOrigRxNumSpecified = value; }
        }

        private int mMessageTypeId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"MessageTypeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MessageTypeId
        {
        get { return mMessageTypeId; }
        set { mMessageTypeId = value; }
        }

        private int mMessageSubTypeId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"MessageSubTypeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MessageSubTypeId
        {
        get { return mMessageSubTypeId; }
        set { mMessageSubTypeId = value; }
        }

        private bool mMessageSubTypeIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"MessageSubTypeIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MessageSubTypeIdSpecified
        {
        get { return mMessageSubTypeIdSpecified; }
        set { mMessageSubTypeIdSpecified = value; }
        }

        private int mCommTypeId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"CommTypeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CommTypeId
        {
        get { return mCommTypeId; }
        set { mCommTypeId = value; }
        }

        private int mEscalationLevel
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"EscalationLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int EscalationLevel
        {
        get { return mEscalationLevel; }
        set { mEscalationLevel = value; }
        }

        private double mTakeActionOnDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"TakeActionOnDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TakeActionOnDate
        {
        get { return mTakeActionOnDate; }
        set { mTakeActionOnDate = value; }
        }

        private double mActionTakenOnDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ActionTakenOnDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ActionTakenOnDate
        {
        get { return mActionTakenOnDate; }
        set { mActionTakenOnDate = value; }
        }

        private bool mActionTakenOnDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"ActionTakenOnDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ActionTakenOnDateSpecified
        {
        get { return mActionTakenOnDateSpecified; }
        set { mActionTakenOnDateSpecified = value; }
        }

        private bool mIsCancelRequest
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"IsCancelRequest", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsCancelRequest
        {
        get { return mIsCancelRequest; }
        set { mIsCancelRequest = value; }
        }

        private Kroll.Pharmacy.Api.Data.OCMQueueStatus mStatus
            = Kroll.Pharmacy.Api.Data.OCMQueueStatus.OCMQueueStatus_Unknown;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.OCMQueueStatus.OCMQueueStatus_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.OCMQueueStatus Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private string mMessages
            = "";
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"Messages", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Messages
        {
        get { return mMessages; }
        set { mMessages = value; }
        }

        private double mLastOutboundAttemptDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"LastOutboundAttemptDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastOutboundAttemptDate
        {
        get { return mLastOutboundAttemptDate; }
        set { mLastOutboundAttemptDate = value; }
        }

        private bool mLastOutboundAttemptDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"LastOutboundAttemptDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastOutboundAttemptDateSpecified
        {
        get { return mLastOutboundAttemptDateSpecified; }
        set { mLastOutboundAttemptDateSpecified = value; }
        }

        private string mReferenceNumber
            = "";
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ReferenceNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReferenceNumber
        {
        get { return mReferenceNumber; }
        set { mReferenceNumber = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private string mContactNumber
            = "";
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"ContactNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ContactNumber
        {
        get { return mContactNumber; }
        set { mContactNumber = value; }
        }

        private int mOcmQueueIdToCancel
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"OcmQueueIdToCancel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OcmQueueIdToCancel
        {
        get { return mOcmQueueIdToCancel; }
        set { mOcmQueueIdToCancel = value; }
        }

        private bool mOcmQueueIdToCancelSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"OcmQueueIdToCancelSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OcmQueueIdToCancelSpecified
        {
        get { return mOcmQueueIdToCancelSpecified; }
        set { mOcmQueueIdToCancelSpecified = value; }
        }

        private int mCancelledByOcmQueueId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"CancelledByOcmQueueId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CancelledByOcmQueueId
        {
        get { return mCancelledByOcmQueueId; }
        set { mCancelledByOcmQueueId = value; }
        }

        private bool mCancelledByOcmQueueIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"CancelledByOcmQueueIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CancelledByOcmQueueIdSpecified
        {
        get { return mCancelledByOcmQueueIdSpecified; }
        set { mCancelledByOcmQueueIdSpecified = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private double mCompletedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"CompletedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"CompletedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CompletedDateSpecified
        {
        get { return mCompletedDateSpecified; }
        set { mCompletedDateSpecified = value; }
        }

        private bool mRequestSentToThirdParty
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"RequestSentToThirdParty", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RequestSentToThirdParty
        {
        get { return mRequestSentToThirdParty; }
        set { mRequestSentToThirdParty = value; }
        }

        private int mPatOCMId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"PatOCMId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatOCMId
        {
        get { return mPatOCMId; }
        set { mPatOCMId = value; }
        }

        private bool mPatOCMIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"PatOCMIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatOCMIdSpecified
        {
        get { return mPatOCMIdSpecified; }
        set { mPatOCMIdSpecified = value; }
        }

        private int mDocOCMId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"DocOCMId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DocOCMId
        {
        get { return mDocOCMId; }
        set { mDocOCMId = value; }
        }

        private bool mDocOCMIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"DocOCMIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocOCMIdSpecified
        {
        get { return mDocOCMIdSpecified; }
        set { mDocOCMIdSpecified = value; }
        }

        private int mRxWorkflowId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"RxWorkflowId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"RxWorkflowIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxWorkflowIdSpecified
        {
        get { return mRxWorkflowIdSpecified; }
        set { mRxWorkflowIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        