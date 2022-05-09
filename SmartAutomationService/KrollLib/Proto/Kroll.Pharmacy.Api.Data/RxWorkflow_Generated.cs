
        // Generated from: RxWorkflow.proto
        // Note: requires additional types generated from: RxWorkflowType_Enum.proto
        // Note: requires additional types generated from: RxWorkflowCompletedType_Enum.proto
        // Note: requires additional types generated from: WorkflowType_Enum.proto
        // Note: requires additional types generated from: DeliveryRouteType_Enum.proto
        // Note: requires additional types generated from: RxWorkflowTroubleType_Enum.proto
        // Note: requires additional types generated from: RoboticInterfaceType_Enum.proto
        // Note: requires additional types generated from: RoboticPending_Enum.proto
        // Note: requires additional types generated from: CompressionType_Enum.proto
        // Note: requires additional types generated from: ToDoOrigin_Enum.proto
        // Note: requires additional types generated from: RxWorkflowComment.proto
        // Note: requires additional types generated from: RxWorkflowDetail.proto
        // Note: requires additional types generated from: RxWorkflowPack.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxWorkflow")]
        public partial class RxWorkflow : global::ProtoBuf.IExtensible
        {
        public RxWorkflow() {}
        

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

        private int mOrigRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"OrigRxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"OrigRxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OrigRxNumSpecified
        {
        get { return mOrigRxNumSpecified; }
        set { mOrigRxNumSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxWorkflowType mFillingRxWorkflowType
            = Kroll.Pharmacy.Api.Data.RxWorkflowType.RxWorkflowType_None;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"FillingRxWorkflowType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxWorkflowType.RxWorkflowType_None)]
        
        public Kroll.Pharmacy.Api.Data.RxWorkflowType FillingRxWorkflowType
        {
        get { return mFillingRxWorkflowType; }
        set { mFillingRxWorkflowType = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxWorkflowType mDeliveryRxWorkflowType
            = Kroll.Pharmacy.Api.Data.RxWorkflowType.RxWorkflowType_None;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"DeliveryRxWorkflowType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxWorkflowType.RxWorkflowType_None)]
        
        public Kroll.Pharmacy.Api.Data.RxWorkflowType DeliveryRxWorkflowType
        {
        get { return mDeliveryRxWorkflowType; }
        set { mDeliveryRxWorkflowType = value; }
        }

        private int mSeq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Seq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Seq
        {
        get { return mSeq; }
        set { mSeq = value; }
        }

        private int mFillingWorkflowId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"FillingWorkflowId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int FillingWorkflowId
        {
        get { return mFillingWorkflowId; }
        set { mFillingWorkflowId = value; }
        }

        private bool mFillingWorkflowIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"FillingWorkflowIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FillingWorkflowIdSpecified
        {
        get { return mFillingWorkflowIdSpecified; }
        set { mFillingWorkflowIdSpecified = value; }
        }

        private int mDeliveryWorkflowId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DeliveryWorkflowId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryWorkflowId
        {
        get { return mDeliveryWorkflowId; }
        set { mDeliveryWorkflowId = value; }
        }

        private bool mDeliveryWorkflowIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DeliveryWorkflowIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryWorkflowIdSpecified
        {
        get { return mDeliveryWorkflowIdSpecified; }
        set { mDeliveryWorkflowIdSpecified = value; }
        }

        private int mOriginalWorkOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"OriginalWorkOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OriginalWorkOrderId
        {
        get { return mOriginalWorkOrderId; }
        set { mOriginalWorkOrderId = value; }
        }

        private bool mOriginalWorkOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"OriginalWorkOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OriginalWorkOrderIdSpecified
        {
        get { return mOriginalWorkOrderIdSpecified; }
        set { mOriginalWorkOrderIdSpecified = value; }
        }

        private int mWorkOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"WorkOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"WorkOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WorkOrderIdSpecified
        {
        get { return mWorkOrderIdSpecified; }
        set { mWorkOrderIdSpecified = value; }
        }

        private double mDueDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"DueDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DueDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DueDateSpecified
        {
        get { return mDueDateSpecified; }
        set { mDueDateSpecified = value; }
        }

        private int mDueDateCategoryId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DueDateCategoryId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DueDateCategoryIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DueDateCategoryIdSpecified
        {
        get { return mDueDateCategoryIdSpecified; }
        set { mDueDateCategoryIdSpecified = value; }
        }

        private string mToteNumber
            = "";
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"ToteNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ToteNumber
        {
        get { return mToteNumber; }
        set { mToteNumber = value; }
        }

        private bool mCompleted
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"Completed", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Completed
        {
        get { return mCompleted; }
        set { mCompleted = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxWorkflowCompletedType mCompletedType
            = Kroll.Pharmacy.Api.Data.RxWorkflowCompletedType.RxWorkflowCompletedType_Workflow;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"CompletedType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxWorkflowCompletedType.RxWorkflowCompletedType_Workflow)]
        
        public Kroll.Pharmacy.Api.Data.RxWorkflowCompletedType CompletedType
        {
        get { return mCompletedType; }
        set { mCompletedType = value; }
        }

        private bool mFillingCompleted
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"FillingCompleted", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FillingCompleted
        {
        get { return mFillingCompleted; }
        set { mFillingCompleted = value; }
        }

        private bool mDeliveryCompleted
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"DeliveryCompleted", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryCompleted
        {
        get { return mDeliveryCompleted; }
        set { mDeliveryCompleted = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowType mNextWorkflowType
            = Kroll.Pharmacy.Api.Data.WorkflowType.WorkflowType_None;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"NextWorkflowType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowType.WorkflowType_None)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowType NextWorkflowType
        {
        get { return mNextWorkflowType; }
        set { mNextWorkflowType = value; }
        }

        private int mNextWorkflowActionType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"NextWorkflowActionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NextWorkflowActionType
        {
        get { return mNextWorkflowActionType; }
        set { mNextWorkflowActionType = value; }
        }

        private bool mNextWorkflowActionTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"NextWorkflowActionTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NextWorkflowActionTypeSpecified
        {
        get { return mNextWorkflowActionTypeSpecified; }
        set { mNextWorkflowActionTypeSpecified = value; }
        }

        private int mLastWorkflowActionType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"LastWorkflowActionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int LastWorkflowActionType
        {
        get { return mLastWorkflowActionType; }
        set { mLastWorkflowActionType = value; }
        }

        private bool mLastWorkflowActionTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"LastWorkflowActionTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastWorkflowActionTypeSpecified
        {
        get { return mLastWorkflowActionTypeSpecified; }
        set { mLastWorkflowActionTypeSpecified = value; }
        }

        private double mLastWorkflowActionCompletedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"LastWorkflowActionCompletedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastWorkflowActionCompletedDate
        {
        get { return mLastWorkflowActionCompletedDate; }
        set { mLastWorkflowActionCompletedDate = value; }
        }

        private bool mLastWorkflowActionCompletedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"LastWorkflowActionCompletedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastWorkflowActionCompletedDateSpecified
        {
        get { return mLastWorkflowActionCompletedDateSpecified; }
        set { mLastWorkflowActionCompletedDateSpecified = value; }
        }

        private double mLastWorkflowActionPerformedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"LastWorkflowActionPerformedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastWorkflowActionPerformedDate
        {
        get { return mLastWorkflowActionPerformedDate; }
        set { mLastWorkflowActionPerformedDate = value; }
        }

        private bool mLastWorkflowActionPerformedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"LastWorkflowActionPerformedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastWorkflowActionPerformedDateSpecified
        {
        get { return mLastWorkflowActionPerformedDateSpecified; }
        set { mLastWorkflowActionPerformedDateSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.DeliveryRouteType mDeliveryRouteType
            = Kroll.Pharmacy.Api.Data.DeliveryRouteType.DeliveryRouteType_Default;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"DeliveryRouteType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DeliveryRouteType.DeliveryRouteType_Default)]
        
        public Kroll.Pharmacy.Api.Data.DeliveryRouteType DeliveryRouteType
        {
        get { return mDeliveryRouteType; }
        set { mDeliveryRouteType = value; }
        }

        private double mTroubleUntilDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"TroubleUntilDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"TroubleUntilDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"TroubleType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxWorkflowTroubleType.RxWorkflowTroubleType_None)]
        
        public Kroll.Pharmacy.Api.Data.RxWorkflowTroubleType TroubleType
        {
        get { return mTroubleType; }
        set { mTroubleType = value; }
        }

        private string mTroubleComment
            = "";
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"TroubleComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string TroubleComment
        {
        get { return mTroubleComment; }
        set { mTroubleComment = value; }
        }

        private double mQtyToPackage
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"QtyToPackage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double QtyToPackage
        {
        get { return mQtyToPackage; }
        set { mQtyToPackage = value; }
        }

        private bool mQtyToPackageSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"QtyToPackageSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool QtyToPackageSpecified
        {
        get { return mQtyToPackageSpecified; }
        set { mQtyToPackageSpecified = value; }
        }

        private double mQtyPackaged
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"QtyPackaged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double QtyPackaged
        {
        get { return mQtyPackaged; }
        set { mQtyPackaged = value; }
        }

        private bool mQtyPackagedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"QtyPackagedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool QtyPackagedSpecified
        {
        get { return mQtyPackagedSpecified; }
        set { mQtyPackagedSpecified = value; }
        }

        private bool mUseWorkflowLabels
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"UseWorkflowLabels", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseWorkflowLabels
        {
        get { return mUseWorkflowLabels; }
        set { mUseWorkflowLabels = value; }
        }

        private int mLabels
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"Labels", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Labels
        {
        get { return mLabels; }
        set { mLabels = value; }
        }

        private bool mLabelsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"LabelsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LabelsSpecified
        {
        get { return mLabelsSpecified; }
        set { mLabelsSpecified = value; }
        }

        private bool mLabelSplitQty
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"LabelSplitQty", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LabelSplitQty
        {
        get { return mLabelSplitQty; }
        set { mLabelSplitQty = value; }
        }

        private bool mLabelSplitEvenly
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"LabelSplitEvenly", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LabelSplitEvenly
        {
        get { return mLabelSplitEvenly; }
        set { mLabelSplitEvenly = value; }
        }

        private string mLabelQtySplit
            = "";
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"LabelQtySplit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LabelQtySplit
        {
        get { return mLabelQtySplit; }
        set { mLabelQtySplit = value; }
        }

        private int mNHLabels
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"NHLabels", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHLabels
        {
        get { return mNHLabels; }
        set { mNHLabels = value; }
        }

        private bool mNHLabelsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"NHLabelsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHLabelsSpecified
        {
        get { return mNHLabelsSpecified; }
        set { mNHLabelsSpecified = value; }
        }

        private bool mNHLabelSplitQty
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"NHLabelSplitQty", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHLabelSplitQty
        {
        get { return mNHLabelSplitQty; }
        set { mNHLabelSplitQty = value; }
        }

        private bool mNHLabelSplitEvenly
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"NHLabelSplitEvenly", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHLabelSplitEvenly
        {
        get { return mNHLabelSplitEvenly; }
        set { mNHLabelSplitEvenly = value; }
        }

        private string mNHLabelQtySplit
            = "";
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"NHLabelQtySplit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHLabelQtySplit
        {
        get { return mNHLabelQtySplit; }
        set { mNHLabelQtySplit = value; }
        }

        private int mOwedToRxWorkflowId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"OwedToRxWorkflowId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OwedToRxWorkflowId
        {
        get { return mOwedToRxWorkflowId; }
        set { mOwedToRxWorkflowId = value; }
        }

        private bool mOwedToRxWorkflowIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"OwedToRxWorkflowIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OwedToRxWorkflowIdSpecified
        {
        get { return mOwedToRxWorkflowIdSpecified; }
        set { mOwedToRxWorkflowIdSpecified = value; }
        }

        private bool mHasPostponedRxWorkflowDetail
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"HasPostponedRxWorkflowDetail", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HasPostponedRxWorkflowDetail
        {
        get { return mHasPostponedRxWorkflowDetail; }
        set { mHasPostponedRxWorkflowDetail = value; }
        }

        private bool mRxRequiresDataVerification
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"RxRequiresDataVerification", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxRequiresDataVerification
        {
        get { return mRxRequiresDataVerification; }
        set { mRxRequiresDataVerification = value; }
        }

        private int mUserRestrictions
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"UserRestrictions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UserRestrictions
        {
        get { return mUserRestrictions; }
        set { mUserRestrictions = value; }
        }

        private bool mRxHadTrouble
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"RxHadTrouble", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxHadTrouble
        {
        get { return mRxHadTrouble; }
        set { mRxHadTrouble = value; }
        }

        private int mOppositeRxWorkflowId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"OppositeRxWorkflowId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OppositeRxWorkflowId
        {
        get { return mOppositeRxWorkflowId; }
        set { mOppositeRxWorkflowId = value; }
        }

        private bool mOppositeRxWorkflowIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"OppositeRxWorkflowIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OppositeRxWorkflowIdSpecified
        {
        get { return mOppositeRxWorkflowIdSpecified; }
        set { mOppositeRxWorkflowIdSpecified = value; }
        }

        private string mMixtureLotNum
            = "";
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"MixtureLotNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MixtureLotNum
        {
        get { return mMixtureLotNum; }
        set { mMixtureLotNum = value; }
        }

        private double mMixtureExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"MixtureExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MixtureExpiryDate
        {
        get { return mMixtureExpiryDate; }
        set { mMixtureExpiryDate = value; }
        }

        private bool mMixtureExpiryDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"MixtureExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MixtureExpiryDateSpecified
        {
        get { return mMixtureExpiryDateSpecified; }
        set { mMixtureExpiryDateSpecified = value; }
        }

        private bool mWorkflowValuesCopiedForward
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"WorkflowValuesCopiedForward", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WorkflowValuesCopiedForward
        {
        get { return mWorkflowValuesCopiedForward; }
        set { mWorkflowValuesCopiedForward = value; }
        }

        private int mClonedFromId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"ClonedFromId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"ClonedFromIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ClonedFromIdSpecified
        {
        get { return mClonedFromIdSpecified; }
        set { mClonedFromIdSpecified = value; }
        }

        private bool mReprintLabelSetRequested
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"ReprintLabelSetRequested", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ReprintLabelSetRequested
        {
        get { return mReprintLabelSetRequested; }
        set { mReprintLabelSetRequested = value; }
        }

        private Kroll.Pharmacy.Api.Data.RoboticInterfaceType mRoboticInterfaceType
            = Kroll.Pharmacy.Api.Data.RoboticInterfaceType.RoboticInterfaceType_None;
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"RoboticInterfaceType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RoboticInterfaceType.RoboticInterfaceType_None)]
        
        public Kroll.Pharmacy.Api.Data.RoboticInterfaceType RoboticInterfaceType
        {
        get { return mRoboticInterfaceType; }
        set { mRoboticInterfaceType = value; }
        }

        private double mQtyOwed
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"QtyOwed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double QtyOwed
        {
        get { return mQtyOwed; }
        set { mQtyOwed = value; }
        }

        private bool mQtyOwedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(72, IsRequired = false, Name=@"QtyOwedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool QtyOwedSpecified
        {
        get { return mQtyOwedSpecified; }
        set { mQtyOwedSpecified = value; }
        }

        private bool mIsPackaged
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(73, IsRequired = false, Name=@"IsPackaged", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsPackaged
        {
        get { return mIsPackaged; }
        set { mIsPackaged = value; }
        }

        private double mFillingStartedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(74, IsRequired = false, Name=@"FillingStartedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double FillingStartedDate
        {
        get { return mFillingStartedDate; }
        set { mFillingStartedDate = value; }
        }

        private bool mFillingStartedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(75, IsRequired = false, Name=@"FillingStartedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FillingStartedDateSpecified
        {
        get { return mFillingStartedDateSpecified; }
        set { mFillingStartedDateSpecified = value; }
        }

        private double mFillingCompletedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(76, IsRequired = false, Name=@"FillingCompletedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double FillingCompletedDate
        {
        get { return mFillingCompletedDate; }
        set { mFillingCompletedDate = value; }
        }

        private bool mFillingCompletedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(77, IsRequired = false, Name=@"FillingCompletedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FillingCompletedDateSpecified
        {
        get { return mFillingCompletedDateSpecified; }
        set { mFillingCompletedDateSpecified = value; }
        }

        private double mDeliveryStartedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(78, IsRequired = false, Name=@"DeliveryStartedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DeliveryStartedDate
        {
        get { return mDeliveryStartedDate; }
        set { mDeliveryStartedDate = value; }
        }

        private bool mDeliveryStartedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(79, IsRequired = false, Name=@"DeliveryStartedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryStartedDateSpecified
        {
        get { return mDeliveryStartedDateSpecified; }
        set { mDeliveryStartedDateSpecified = value; }
        }

        private double mDeliveryCompletedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(80, IsRequired = false, Name=@"DeliveryCompletedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DeliveryCompletedDate
        {
        get { return mDeliveryCompletedDate; }
        set { mDeliveryCompletedDate = value; }
        }

        private bool mDeliveryCompletedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(81, IsRequired = false, Name=@"DeliveryCompletedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryCompletedDateSpecified
        {
        get { return mDeliveryCompletedDateSpecified; }
        set { mDeliveryCompletedDateSpecified = value; }
        }

        private double mRxReadyForDeliveryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(82, IsRequired = false, Name=@"RxReadyForDeliveryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RxReadyForDeliveryDate
        {
        get { return mRxReadyForDeliveryDate; }
        set { mRxReadyForDeliveryDate = value; }
        }

        private bool mRxReadyForDeliveryDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(83, IsRequired = false, Name=@"RxReadyForDeliveryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxReadyForDeliveryDateSpecified
        {
        get { return mRxReadyForDeliveryDateSpecified; }
        set { mRxReadyForDeliveryDateSpecified = value; }
        }

        private double mRxLeftTheStoreOnDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(84, IsRequired = false, Name=@"RxLeftTheStoreOnDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RxLeftTheStoreOnDate
        {
        get { return mRxLeftTheStoreOnDate; }
        set { mRxLeftTheStoreOnDate = value; }
        }

        private bool mRxLeftTheStoreOnDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(85, IsRequired = false, Name=@"RxLeftTheStoreOnDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxLeftTheStoreOnDateSpecified
        {
        get { return mRxLeftTheStoreOnDateSpecified; }
        set { mRxLeftTheStoreOnDateSpecified = value; }
        }

        private double mDeliveredToPatientDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(86, IsRequired = false, Name=@"DeliveredToPatientDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DeliveredToPatientDate
        {
        get { return mDeliveredToPatientDate; }
        set { mDeliveredToPatientDate = value; }
        }

        private bool mDeliveredToPatientDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(87, IsRequired = false, Name=@"DeliveredToPatientDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveredToPatientDateSpecified
        {
        get { return mDeliveredToPatientDateSpecified; }
        set { mDeliveredToPatientDateSpecified = value; }
        }

        private bool mCanPlaceRxInPickupBin
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(88, IsRequired = false, Name=@"CanPlaceRxInPickupBin", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CanPlaceRxInPickupBin
        {
        get { return mCanPlaceRxInPickupBin; }
        set { mCanPlaceRxInPickupBin = value; }
        }

        private bool mCanPickupRx
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(89, IsRequired = false, Name=@"CanPickupRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CanPickupRx
        {
        get { return mCanPickupRx; }
        set { mCanPickupRx = value; }
        }

        private int mDeliveryOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(90, IsRequired = false, Name=@"DeliveryOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryOrderId
        {
        get { return mDeliveryOrderId; }
        set { mDeliveryOrderId = value; }
        }

        private bool mDeliveryOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(91, IsRequired = false, Name=@"DeliveryOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryOrderIdSpecified
        {
        get { return mDeliveryOrderIdSpecified; }
        set { mDeliveryOrderIdSpecified = value; }
        }

        private int mDeliveryOrderPackageId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(92, IsRequired = false, Name=@"DeliveryOrderPackageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryOrderPackageId
        {
        get { return mDeliveryOrderPackageId; }
        set { mDeliveryOrderPackageId = value; }
        }

        private bool mDeliveryOrderPackageIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(93, IsRequired = false, Name=@"DeliveryOrderPackageIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryOrderPackageIdSpecified
        {
        get { return mDeliveryOrderPackageIdSpecified; }
        set { mDeliveryOrderPackageIdSpecified = value; }
        }

        private int mDeliveryOrderPackageDetailId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(94, IsRequired = false, Name=@"DeliveryOrderPackageDetailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryOrderPackageDetailId
        {
        get { return mDeliveryOrderPackageDetailId; }
        set { mDeliveryOrderPackageDetailId = value; }
        }

        private bool mDeliveryOrderPackageDetailIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(95, IsRequired = false, Name=@"DeliveryOrderPackageDetailIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryOrderPackageDetailIdSpecified
        {
        get { return mDeliveryOrderPackageDetailIdSpecified; }
        set { mDeliveryOrderPackageDetailIdSpecified = value; }
        }

        private int mVialCount
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(96, IsRequired = false, Name=@"VialCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int VialCount
        {
        get { return mVialCount; }
        set { mVialCount = value; }
        }

        private byte[] mContextInfo
            = null;
        [global::ProtoBuf.ProtoMember(97, IsRequired = false, Name=@"ContextInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ContextInfo
        {
        get { return mContextInfo; }
        set { mContextInfo = value; }
        }

        private Kroll.Pharmacy.Api.Data.CompressionType mContextInfoCompressionType
            = Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet;
        [global::ProtoBuf.ProtoMember(98, IsRequired = false, Name=@"ContextInfoCompressionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.CompressionType ContextInfoCompressionType
        {
        get { return mContextInfoCompressionType; }
        set { mContextInfoCompressionType = value; }
        }

        private int mToDoId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(99, IsRequired = false, Name=@"ToDoId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(100, IsRequired = false, Name=@"ToDoIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ToDoIdSpecified
        {
        get { return mToDoIdSpecified; }
        set { mToDoIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.ToDoOrigin mToDoOrigin
            = Kroll.Pharmacy.Api.Data.ToDoOrigin.ToDoOrigin_Unknown;
        [global::ProtoBuf.ProtoMember(101, IsRequired = false, Name=@"ToDoOrigin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ToDoOrigin.ToDoOrigin_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ToDoOrigin ToDoOrigin
        {
        get { return mToDoOrigin; }
        set { mToDoOrigin = value; }
        }

        private bool mDoInventoryAdjustments
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(102, IsRequired = false, Name=@"DoInventoryAdjustments", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoInventoryAdjustments
        {
        get { return mDoInventoryAdjustments; }
        set { mDoInventoryAdjustments = value; }
        }

        private int mRxSuspendId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(103, IsRequired = false, Name=@"RxSuspendId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(104, IsRequired = false, Name=@"RxSuspendIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxSuspendIdSpecified
        {
        get { return mRxSuspendIdSpecified; }
        set { mRxSuspendIdSpecified = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(105, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(106, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(107, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(108, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflowComment> mComments = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflowComment>();
        [global::ProtoBuf.ProtoMember(109, Name=@"Comments", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflowComment> Comments
        {
        get { return mComments; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflowDetail> mDetails = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflowDetail>();
        [global::ProtoBuf.ProtoMember(110, Name=@"Details", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflowDetail> Details
        {
        get { return mDetails; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflowPack> mPacks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflowPack>();
        [global::ProtoBuf.ProtoMember(111, Name=@"Packs", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflowPack> Packs
        {
        get { return mPacks; }
        }
    

        private bool mRevertWorkflow
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(121, IsRequired = false, Name=@"RevertWorkflow", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RevertWorkflow
        {
        get { return mRevertWorkflow; }
        set { mRevertWorkflow = value; }
        }

        private int mRevertToAction
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(122, IsRequired = false, Name=@"RevertToAction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RevertToAction
        {
        get { return mRevertToAction; }
        set { mRevertToAction = value; }
        }

        private bool mRevertToActionSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(123, IsRequired = false, Name=@"RevertToActionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RevertToActionSpecified
        {
        get { return mRevertToActionSpecified; }
        set { mRevertToActionSpecified = value; }
        }

        private double mWorkflowStartedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(124, IsRequired = false, Name=@"WorkflowStartedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double WorkflowStartedDate
        {
        get { return mWorkflowStartedDate; }
        set { mWorkflowStartedDate = value; }
        }

        private bool mWorkflowStartedDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(125, IsRequired = false, Name=@"WorkflowStartedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WorkflowStartedDateSpecified
        {
        get { return mWorkflowStartedDateSpecified; }
        set { mWorkflowStartedDateSpecified = value; }
        }

        private int mScriptImageId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(126, IsRequired = false, Name=@"ScriptImageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ScriptImageId
        {
        get { return mScriptImageId; }
        set { mScriptImageId = value; }
        }

        private bool mScriptImageIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(127, IsRequired = false, Name=@"ScriptImageIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScriptImageIdSpecified
        {
        get { return mScriptImageIdSpecified; }
        set { mScriptImageIdSpecified = value; }
        }

        private int mScriptImagePosition
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(128, IsRequired = false, Name=@"ScriptImagePosition", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ScriptImagePosition
        {
        get { return mScriptImagePosition; }
        set { mScriptImagePosition = value; }
        }

        private bool mScriptImagePositionSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(129, IsRequired = false, Name=@"ScriptImagePositionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScriptImagePositionSpecified
        {
        get { return mScriptImagePositionSpecified; }
        set { mScriptImagePositionSpecified = value; }
        }

        private int mScriptImagePage
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(130, IsRequired = false, Name=@"ScriptImagePage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ScriptImagePage
        {
        get { return mScriptImagePage; }
        set { mScriptImagePage = value; }
        }

        private bool mScriptImagePageSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(131, IsRequired = false, Name=@"ScriptImagePageSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScriptImagePageSpecified
        {
        get { return mScriptImagePageSpecified; }
        set { mScriptImagePageSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.RoboticPending mRoboticPending
            = Kroll.Pharmacy.Api.Data.RoboticPending.RoboticPending_Unknown;
        [global::ProtoBuf.ProtoMember(132, IsRequired = false, Name=@"RoboticPending", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RoboticPending.RoboticPending_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.RoboticPending RoboticPending
        {
        get { return mRoboticPending; }
        set { mRoboticPending = value; }
        }

        private int mAuthoritativeERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(133, IsRequired = false, Name=@"AuthoritativeERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AuthoritativeERxOrderId
        {
        get { return mAuthoritativeERxOrderId; }
        set { mAuthoritativeERxOrderId = value; }
        }

        private bool mAuthoritativeERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(134, IsRequired = false, Name=@"AuthoritativeERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AuthoritativeERxOrderIdSpecified
        {
        get { return mAuthoritativeERxOrderIdSpecified; }
        set { mAuthoritativeERxOrderIdSpecified = value; }
        }

        private int mRxTransferId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(135, IsRequired = false, Name=@"RxTransferId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxTransferId
        {
        get { return mRxTransferId; }
        set { mRxTransferId = value; }
        }

        private bool mRxTransferIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(136, IsRequired = false, Name=@"RxTransferIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxTransferIdSpecified
        {
        get { return mRxTransferIdSpecified; }
        set { mRxTransferIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        