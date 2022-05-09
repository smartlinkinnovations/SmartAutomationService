
        // Generated from: WorkflowQueue.proto
        // Note: requires additional types generated from: WorkflowQueueMode_Enum.proto
        // Note: requires additional types generated from: PharmacyLinkQueueType_Enum.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorkflowQueue")]
        public partial class WorkflowQueue : global::ProtoBuf.IExtensible
        {
        public WorkflowQueue() {}
        

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

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private int mSortOrder
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SortOrder", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SortOrder
        {
        get { return mSortOrder; }
        set { mSortOrder = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink CentralMaintLink
        {
        get { return mCentralMaintLink; }
        set { mCentralMaintLink = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private bool mEnabledForBatch
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"EnabledForBatch", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EnabledForBatch
        {
        get { return mEnabledForBatch; }
        set { mEnabledForBatch = value; }
        }

        private bool mEnabledForHandheld
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"EnabledForHandheld", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EnabledForHandheld
        {
        get { return mEnabledForHandheld; }
        set { mEnabledForHandheld = value; }
        }

        private int mImageIndex
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"ImageIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ImageIndex
        {
        get { return mImageIndex; }
        set { mImageIndex = value; }
        }

        private bool mImageIndexSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ImageIndexSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ImageIndexSpecified
        {
        get { return mImageIndexSpecified; }
        set { mImageIndexSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkflowQueueMode mWorkflowMode
            = Kroll.Pharmacy.Api.Data.WorkflowQueueMode.WorkflowQueueMode_Pull;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"WorkflowMode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkflowQueueMode.WorkflowQueueMode_Pull)]
        
        public Kroll.Pharmacy.Api.Data.WorkflowQueueMode WorkflowMode
        {
        get { return mWorkflowMode; }
        set { mWorkflowMode = value; }
        }

        private bool mIncludeToDo
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"IncludeToDo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeToDo
        {
        get { return mIncludeToDo; }
        set { mIncludeToDo = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private bool mEnabledForBatchReview
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"EnabledForBatchReview", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EnabledForBatchReview
        {
        get { return mEnabledForBatchReview; }
        set { mEnabledForBatchReview = value; }
        }

        private bool mDisabled
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"Disabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Disabled
        {
        get { return mDisabled; }
        set { mDisabled = value; }
        }

        private Kroll.Pharmacy.Api.Data.PharmacyLinkQueueType mPharmacyLinkQueueType
            = Kroll.Pharmacy.Api.Data.PharmacyLinkQueueType.PharmacyLinkQueueType_NotSpecified;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"PharmacyLinkQueueType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PharmacyLinkQueueType.PharmacyLinkQueueType_NotSpecified)]
        
        public Kroll.Pharmacy.Api.Data.PharmacyLinkQueueType PharmacyLinkQueueType
        {
        get { return mPharmacyLinkQueueType; }
        set { mPharmacyLinkQueueType = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        