
        // Generated from: ToDo.proto
        // Note: requires additional types generated from: ToDoType_Enum.proto
        // Note: requires additional types generated from: PendingNewRx.proto
        // Note: requires additional types generated from: ToDoResolvedType_Enum.proto
        // Note: requires additional types generated from: ToDoOrigin_Enum.proto
        // Note: requires additional types generated from: DeliveryRouteType_Enum.proto
        // Note: requires additional types generated from: RxWorkflowTroubleType_Enum.proto
        // Note: requires additional types generated from: ToDoOCM.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ToDo")]
        public partial class ToDo : global::ProtoBuf.IExtensible
        {
        public ToDo() {}
        

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

        private Kroll.Pharmacy.Api.Data.ToDoType mType
            = Kroll.Pharmacy.Api.Data.ToDoType.ToDoType_Unknown;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ToDoType.ToDoType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ToDoType Type
        {
        get { return mType; }
        set { mType = value; }
        }

        private double mEnteredDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"EnteredDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double EnteredDate
        {
        get { return mEnteredDate; }
        set { mEnteredDate = value; }
        }

        private bool mEnteredDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"EnteredDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EnteredDateSpecified
        {
        get { return mEnteredDateSpecified; }
        set { mEnteredDateSpecified = value; }
        }

        private string mEnteredBy
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"EnteredBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string EnteredBy
        {
        get { return mEnteredBy; }
        set { mEnteredBy = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private double mDueDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"DueDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DueDate
        {
        get { return mDueDate; }
        set { mDueDate = value; }
        }

        private bool mDueDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DueDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DueDateSpecified
        {
        get { return mDueDateSpecified; }
        set { mDueDateSpecified = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"OrigRxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"OrigRxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OrigRxNumSpecified
        {
        get { return mOrigRxNumSpecified; }
        set { mOrigRxNumSpecified = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"DocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocIdSpecified
        {
        get { return mDocIdSpecified; }
        set { mDocIdSpecified = value; }
        }

        private int mInterventionId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"InterventionId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int InterventionId
        {
        get { return mInterventionId; }
        set { mInterventionId = value; }
        }

        private bool mInterventionIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"InterventionIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InterventionIdSpecified
        {
        get { return mInterventionIdSpecified; }
        set { mInterventionIdSpecified = value; }
        }

        private bool mInUse
            = 
                default(bool)
            ;
        [global::System.Obsolete, global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"InUse", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InUse
        {
        get { return mInUse; }
        set { mInUse = value; }
        }

        private string mInUseByUser
            = "";
        [global::System.Obsolete, global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"InUseByUser", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string InUseByUser
        {
        get { return mInUseByUser; }
        set { mInUseByUser = value; }
        }

        private string mInUseByStation
            = "";
        [global::System.Obsolete, global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"InUseByStation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string InUseByStation
        {
        get { return mInUseByStation; }
        set { mInUseByStation = value; }
        }

        private bool mResolved
            = 
                default(bool)
            ;
        [global::System.Obsolete, global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"Resolved", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Resolved
        {
        get { return mResolved; }
        set { mResolved = value; }
        }

        private double mResolvedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ResolvedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ResolvedDate
        {
        get { return mResolvedDate; }
        set { mResolvedDate = value; }
        }

        private bool mResolvedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"ResolvedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ResolvedDateSpecified
        {
        get { return mResolvedDateSpecified; }
        set { mResolvedDateSpecified = value; }
        }

        private string mResolvedBy
            = "";
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"ResolvedBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResolvedBy
        {
        get { return mResolvedBy; }
        set { mResolvedBy = value; }
        }

        private string mResolvedComment
            = "";
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"ResolvedComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResolvedComment
        {
        get { return mResolvedComment; }
        set { mResolvedComment = value; }
        }

        private int mRecurrenceInterval
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"RecurrenceInterval", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RecurrenceInterval
        {
        get { return mRecurrenceInterval; }
        set { mRecurrenceInterval = value; }
        }

        private bool mRecurrenceIntervalSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"RecurrenceIntervalSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RecurrenceIntervalSpecified
        {
        get { return mRecurrenceIntervalSpecified; }
        set { mRecurrenceIntervalSpecified = value; }
        }

        private int mStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private int mWorkOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"WorkOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"WorkOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WorkOrderIdSpecified
        {
        get { return mWorkOrderIdSpecified; }
        set { mWorkOrderIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.PendingNewRx mPendingNewRx
            = null;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"PendingNewRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.PendingNewRx PendingNewRx
        {
        get { return mPendingNewRx; }
        set { mPendingNewRx = value; }
        }

        private string mExternalDocReference
            = "";
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"ExternalDocReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalDocReference
        {
        get { return mExternalDocReference; }
        set { mExternalDocReference = value; }
        }

        private string mExternalPatReference
            = "";
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"ExternalPatReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalPatReference
        {
        get { return mExternalPatReference; }
        set { mExternalPatReference = value; }
        }

        private string mExternalRxReference
            = "";
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"ExternalRxReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalRxReference
        {
        get { return mExternalRxReference; }
        set { mExternalRxReference = value; }
        }

        private string mExternalToDoReference
            = "";
        [global::ProtoBuf.ProtoMember(72, IsRequired = false, Name=@"ExternalToDoReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalToDoReference
        {
        get { return mExternalToDoReference; }
        set { mExternalToDoReference = value; }
        }

        private Kroll.Pharmacy.Api.Data.ToDoResolvedType mResolvedType
            = Kroll.Pharmacy.Api.Data.ToDoResolvedType.ToDoResolvedType_NotResolved;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"ResolvedType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ToDoResolvedType.ToDoResolvedType_NotResolved)]
        
        public Kroll.Pharmacy.Api.Data.ToDoResolvedType ResolvedType
        {
        get { return mResolvedType; }
        set { mResolvedType = value; }
        }

        private int mERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"ERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"ERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ERxOrderIdSpecified
        {
        get { return mERxOrderIdSpecified; }
        set { mERxOrderIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.ToDoOrigin mOrigin
            = Kroll.Pharmacy.Api.Data.ToDoOrigin.ToDoOrigin_Unknown;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"Origin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ToDoOrigin.ToDoOrigin_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ToDoOrigin Origin
        {
        get { return mOrigin; }
        set { mOrigin = value; }
        }

        private string mOriginContext
            = "";
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"OriginContext", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OriginContext
        {
        get { return mOriginContext; }
        set { mOriginContext = value; }
        }

        private Kroll.Pharmacy.Api.Data.DeliveryRouteType mDeliveryRouteType
            = Kroll.Pharmacy.Api.Data.DeliveryRouteType.DeliveryRouteType_Default;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"DeliveryRouteType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DeliveryRouteType.DeliveryRouteType_Default)]
        
        public Kroll.Pharmacy.Api.Data.DeliveryRouteType DeliveryRouteType
        {
        get { return mDeliveryRouteType; }
        set { mDeliveryRouteType = value; }
        }

        private int mDueDateCategoryId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"DueDateCategoryId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DueDateCategoryId
        {
        get { return mDueDateCategoryId; }
        set { mDueDateCategoryId = value; }
        }

        private bool mDueDateCategoryIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"DueDateCategoryIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DueDateCategoryIdSpecified
        {
        get { return mDueDateCategoryIdSpecified; }
        set { mDueDateCategoryIdSpecified = value; }
        }

        private double mTroubleUntilDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"TroubleUntilDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TroubleUntilDate
        {
        get { return mTroubleUntilDate; }
        set { mTroubleUntilDate = value; }
        }

        private bool mTroubleUntilDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"TroubleUntilDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TroubleUntilDateSpecified
        {
        get { return mTroubleUntilDateSpecified; }
        set { mTroubleUntilDateSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxWorkflowTroubleType mTroubleType
            = Kroll.Pharmacy.Api.Data.RxWorkflowTroubleType.RxWorkflowTroubleType_None;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"TroubleType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxWorkflowTroubleType.RxWorkflowTroubleType_None)]
        
        public Kroll.Pharmacy.Api.Data.RxWorkflowTroubleType TroubleType
        {
        get { return mTroubleType; }
        set { mTroubleType = value; }
        }

        private string mTroubleComment
            = "";
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"TroubleComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string TroubleComment
        {
        get { return mTroubleComment; }
        set { mTroubleComment = value; }
        }

        private int mActionToDoId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"ActionToDoId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ActionToDoId
        {
        get { return mActionToDoId; }
        set { mActionToDoId = value; }
        }

        private bool mActionToDoIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"ActionToDoIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ActionToDoIdSpecified
        {
        get { return mActionToDoIdSpecified; }
        set { mActionToDoIdSpecified = value; }
        }

        private string mToteNumber
            = "";
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"ToteNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ToteNumber
        {
        get { return mToteNumber; }
        set { mToteNumber = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ToDoOCM> mToDoOCM = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ToDoOCM>();
        [global::ProtoBuf.ProtoMember(57, Name=@"ToDoOCM", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ToDoOCM> ToDoOCM
        {
        get { return mToDoOCM; }
        }
    

        private int mEnteredByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"EnteredByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int EnteredByUserId
        {
        get { return mEnteredByUserId; }
        set { mEnteredByUserId = value; }
        }

        private bool mEnteredByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"EnteredByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EnteredByUserIdSpecified
        {
        get { return mEnteredByUserIdSpecified; }
        set { mEnteredByUserIdSpecified = value; }
        }

        private int mInUseByUserId
            = 
                default(int)
            ;
        [global::System.Obsolete, global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"InUseByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int InUseByUserId
        {
        get { return mInUseByUserId; }
        set { mInUseByUserId = value; }
        }

        private bool mInUseByUserIdSpecified
            = 
                default(bool)
            ;
        [global::System.Obsolete, global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"InUseByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InUseByUserIdSpecified
        {
        get { return mInUseByUserIdSpecified; }
        set { mInUseByUserIdSpecified = value; }
        }

        private int mResolvedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"ResolvedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"ResolvedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ResolvedByUserIdSpecified
        {
        get { return mResolvedByUserIdSpecified; }
        set { mResolvedByUserIdSpecified = value; }
        }

        private int mPendingNewRxId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"PendingNewRxId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PendingNewRxId
        {
        get { return mPendingNewRxId; }
        set { mPendingNewRxId = value; }
        }

        private bool mPendingNewRxIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"PendingNewRxIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PendingNewRxIdSpecified
        {
        get { return mPendingNewRxIdSpecified; }
        set { mPendingNewRxIdSpecified = value; }
        }

        private int mPatMedReviewId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"PatMedReviewId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatMedReviewId
        {
        get { return mPatMedReviewId; }
        set { mPatMedReviewId = value; }
        }

        private bool mPatMedReviewIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"PatMedReviewIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatMedReviewIdSpecified
        {
        get { return mPatMedReviewIdSpecified; }
        set { mPatMedReviewIdSpecified = value; }
        }

        private int mSubType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"SubType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SubType
        {
        get { return mSubType; }
        set { mSubType = value; }
        }

        private bool mSubTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"SubTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SubTypeSpecified
        {
        get { return mSubTypeSpecified; }
        set { mSubTypeSpecified = value; }
        }

        private int mPatImmunizationId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"PatImmunizationId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatImmunizationId
        {
        get { return mPatImmunizationId; }
        set { mPatImmunizationId = value; }
        }

        private bool mPatImmunizationIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"PatImmunizationIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatImmunizationIdSpecified
        {
        get { return mPatImmunizationIdSpecified; }
        set { mPatImmunizationIdSpecified = value; }
        }

        private int mDocAddId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(73, IsRequired = false, Name=@"DocAddId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DocAddId
        {
        get { return mDocAddId; }
        set { mDocAddId = value; }
        }

        private bool mDocAddIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(74, IsRequired = false, Name=@"DocAddIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocAddIdSpecified
        {
        get { return mDocAddIdSpecified; }
        set { mDocAddIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        