
        // Generated from: ToDoSearchCriteria.proto
        // Note: requires additional types generated from: RxWorkflowTroubleType_Enum.proto
        // Note: requires additional types generated from: ToDoResolvedType_Enum.proto
        // Note: requires additional types generated from: ToDoOrigin_Enum.proto
        // Note: requires additional types generated from: ToDoType_Enum.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ToDoSearchCriteria")]
        public partial class ToDoSearchCriteria : global::ProtoBuf.IExtensible
        {
        public ToDoSearchCriteria() {}
        

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

        private bool mIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IdSpecified
        {
        get { return mIdSpecified; }
        set { mIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.ToDoType mToDoType
            = Kroll.Pharmacy.Api.Data.ToDoType.ToDoType_Unknown;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ToDoType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ToDoType.ToDoType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ToDoType ToDoType
        {
        get { return mToDoType; }
        set { mToDoType = value; }
        }

        private bool mToDoTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ToDoTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ToDoTypeSpecified
        {
        get { return mToDoTypeSpecified; }
        set { mToDoTypeSpecified = value; }
        }

        private double mEnteredDateStartRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"EnteredDateStartRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double EnteredDateStartRange
        {
        get { return mEnteredDateStartRange; }
        set { mEnteredDateStartRange = value; }
        }

        private bool mEnteredDateStartRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"EnteredDateStartRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EnteredDateStartRangeSpecified
        {
        get { return mEnteredDateStartRangeSpecified; }
        set { mEnteredDateStartRangeSpecified = value; }
        }

        private double mEnteredDateEndRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"EnteredDateEndRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double EnteredDateEndRange
        {
        get { return mEnteredDateEndRange; }
        set { mEnteredDateEndRange = value; }
        }

        private bool mEnteredDateEndRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"EnteredDateEndRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EnteredDateEndRangeSpecified
        {
        get { return mEnteredDateEndRangeSpecified; }
        set { mEnteredDateEndRangeSpecified = value; }
        }

        private string mEnteredBy
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"EnteredBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string EnteredBy
        {
        get { return mEnteredBy; }
        set { mEnteredBy = value; }
        }

        private bool mEnteredBySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"EnteredBySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EnteredBySpecified
        {
        get { return mEnteredBySpecified; }
        set { mEnteredBySpecified = value; }
        }

        private double mDueDateStartRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DueDateStartRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DueDateStartRange
        {
        get { return mDueDateStartRange; }
        set { mDueDateStartRange = value; }
        }

        private bool mDueDateStartRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DueDateStartRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DueDateStartRangeSpecified
        {
        get { return mDueDateStartRangeSpecified; }
        set { mDueDateStartRangeSpecified = value; }
        }

        private double mDueDateEndRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DueDateEndRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DueDateEndRange
        {
        get { return mDueDateEndRange; }
        set { mDueDateEndRange = value; }
        }

        private bool mDueDateEndRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DueDateEndRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DueDateEndRangeSpecified
        {
        get { return mDueDateEndRangeSpecified; }
        set { mDueDateEndRangeSpecified = value; }
        }

        private string mResolvedBy
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ResolvedBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResolvedBy
        {
        get { return mResolvedBy; }
        set { mResolvedBy = value; }
        }

        private bool mResolvedBySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ResolvedBySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ResolvedBySpecified
        {
        get { return mResolvedBySpecified; }
        set { mResolvedBySpecified = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"OrigRxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"OrigRxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"DocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"InterventionId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"InterventionIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InterventionIdSpecified
        {
        get { return mInterventionIdSpecified; }
        set { mInterventionIdSpecified = value; }
        }

        private int mStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private bool mStatusSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"StatusSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StatusSpecified
        {
        get { return mStatusSpecified; }
        set { mStatusSpecified = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"StoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StoreIdSpecified
        {
        get { return mStoreIdSpecified; }
        set { mStoreIdSpecified = value; }
        }

        private bool mIsResolved
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"IsResolved", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsResolved
        {
        get { return mIsResolved; }
        set { mIsResolved = value; }
        }

        private bool mIsResolvedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"IsResolvedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsResolvedSpecified
        {
        get { return mIsResolvedSpecified; }
        set { mIsResolvedSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.ToDoResolvedType mResolvedType
            = Kroll.Pharmacy.Api.Data.ToDoResolvedType.ToDoResolvedType_NotResolved;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"ResolvedType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ToDoResolvedType.ToDoResolvedType_NotResolved)]
        
        public Kroll.Pharmacy.Api.Data.ToDoResolvedType ResolvedType
        {
        get { return mResolvedType; }
        set { mResolvedType = value; }
        }

        private bool mResolvedTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"ResolvedTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ResolvedTypeSpecified
        {
        get { return mResolvedTypeSpecified; }
        set { mResolvedTypeSpecified = value; }
        }

        private int mActionToDoId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"ActionToDoId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"ActionToDoIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ActionToDoIdSpecified
        {
        get { return mActionToDoIdSpecified; }
        set { mActionToDoIdSpecified = value; }
        }

        private int mWorkOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"WorkOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"WorkOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WorkOrderIdSpecified
        {
        get { return mWorkOrderIdSpecified; }
        set { mWorkOrderIdSpecified = value; }
        }

        private int mDueDateCategoryId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"DueDateCategoryId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"DueDateCategoryIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DueDateCategoryIdSpecified
        {
        get { return mDueDateCategoryIdSpecified; }
        set { mDueDateCategoryIdSpecified = value; }
        }

        private bool mIsInTrouble
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"IsInTrouble", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsInTrouble
        {
        get { return mIsInTrouble; }
        set { mIsInTrouble = value; }
        }

        private bool mIsInTroubleSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"IsInTroubleSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsInTroubleSpecified
        {
        get { return mIsInTroubleSpecified; }
        set { mIsInTroubleSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxWorkflowTroubleType mTroubleType
            = Kroll.Pharmacy.Api.Data.RxWorkflowTroubleType.RxWorkflowTroubleType_None;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"TroubleType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxWorkflowTroubleType.RxWorkflowTroubleType_None)]
        
        public Kroll.Pharmacy.Api.Data.RxWorkflowTroubleType TroubleType
        {
        get { return mTroubleType; }
        set { mTroubleType = value; }
        }

        private bool mTroubleTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"TroubleTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TroubleTypeSpecified
        {
        get { return mTroubleTypeSpecified; }
        set { mTroubleTypeSpecified = value; }
        }

        private string mToteNumber
            = "";
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"ToteNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ToteNumber
        {
        get { return mToteNumber; }
        set { mToteNumber = value; }
        }

        private bool mToteNumberSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"ToteNumberSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ToteNumberSpecified
        {
        get { return mToteNumberSpecified; }
        set { mToteNumberSpecified = value; }
        }

        private string mExternalDocReference
            = "";
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"ExternalDocReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalDocReference
        {
        get { return mExternalDocReference; }
        set { mExternalDocReference = value; }
        }

        private bool mExternalDocReferenceSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"ExternalDocReferenceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExternalDocReferenceSpecified
        {
        get { return mExternalDocReferenceSpecified; }
        set { mExternalDocReferenceSpecified = value; }
        }

        private string mExternalPatReference
            = "";
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"ExternalPatReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalPatReference
        {
        get { return mExternalPatReference; }
        set { mExternalPatReference = value; }
        }

        private bool mExternalPatReferenceSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"ExternalPatReferenceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExternalPatReferenceSpecified
        {
        get { return mExternalPatReferenceSpecified; }
        set { mExternalPatReferenceSpecified = value; }
        }

        private string mExternalRxReference
            = "";
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"ExternalRxReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalRxReference
        {
        get { return mExternalRxReference; }
        set { mExternalRxReference = value; }
        }

        private bool mExternalRxReferenceSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"ExternalRxReferenceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExternalRxReferenceSpecified
        {
        get { return mExternalRxReferenceSpecified; }
        set { mExternalRxReferenceSpecified = value; }
        }

        private int mERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"ERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"ERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"Origin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ToDoOrigin.ToDoOrigin_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ToDoOrigin Origin
        {
        get { return mOrigin; }
        set { mOrigin = value; }
        }

        private bool mOriginSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"OriginSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OriginSpecified
        {
        get { return mOriginSpecified; }
        set { mOriginSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        