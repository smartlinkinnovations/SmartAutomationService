
        // Generated from: WorkOrder.proto
        // Note: requires additional types generated from: Rx.proto
        // Note: requires additional types generated from: ToDo.proto
        // Note: requires additional types generated from: WorkOrderType_Enum.proto
        // Note: requires additional types generated from: CompressionType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorkOrder")]
        public partial class WorkOrder : global::ProtoBuf.IExtensible
        {
        public WorkOrder() {}
        

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
        [global::System.Obsolete, global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateCreatedSpecified
        {
        get { return mDateCreatedSpecified; }
        set { mDateCreatedSpecified = value; }
        }

        private string mCreatedBy
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"CreatedBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CreatedBy
        {
        get { return mCreatedBy; }
        set { mCreatedBy = value; }
        }

        private bool mCompleted
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Completed", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Completed
        {
        get { return mCompleted; }
        set { mCompleted = value; }
        }

        private string mDefaultToteNumber
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"DefaultToteNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DefaultToteNumber
        {
        get { return mDefaultToteNumber; }
        set { mDefaultToteNumber = value; }
        }

        private double mDefaultDueDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DefaultDueDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DefaultDueDate
        {
        get { return mDefaultDueDate; }
        set { mDefaultDueDate = value; }
        }

        private bool mDefaultDueDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DefaultDueDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DefaultDueDateSpecified
        {
        get { return mDefaultDueDateSpecified; }
        set { mDefaultDueDateSpecified = value; }
        }

        private int mDefaultDueDateCategoryId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"DefaultDueDateCategoryId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DefaultDueDateCategoryIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DefaultDueDateCategoryIdSpecified
        {
        get { return mDefaultDueDateCategoryIdSpecified; }
        set { mDefaultDueDateCategoryIdSpecified = value; }
        }

        private bool mAutomaticallyCreated
            = 
                (bool)true;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"AutomaticallyCreated", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                (bool)true)]
        
        public bool AutomaticallyCreated
        {
        get { return mAutomaticallyCreated; }
        set { mAutomaticallyCreated = value; }
        }

        private int mStoreId
            = 
                (int)1;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"StoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StoreIdSpecified
        {
        get { return mStoreIdSpecified; }
        set { mStoreIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkOrderType mWorkOrderType
            = Kroll.Pharmacy.Api.Data.WorkOrderType.WorkOrderType_None;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"WorkOrderType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkOrderType.WorkOrderType_None)]
        
        public Kroll.Pharmacy.Api.Data.WorkOrderType WorkOrderType
        {
        get { return mWorkOrderType; }
        set { mWorkOrderType = value; }
        }

        private byte[] mWorkflowContextInfo
            = null;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"WorkflowContextInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] WorkflowContextInfo
        {
        get { return mWorkflowContextInfo; }
        set { mWorkflowContextInfo = value; }
        }

        private Kroll.Pharmacy.Api.Data.CompressionType mWorkflowContextInfoCompressionType
            = Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_None;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"WorkflowContextInfoCompressionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_None)]
        
        public Kroll.Pharmacy.Api.Data.CompressionType WorkflowContextInfoCompressionType
        {
        get { return mWorkflowContextInfoCompressionType; }
        set { mWorkflowContextInfoCompressionType = value; }
        }

        private int mCreatedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"CreatedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"CreatedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CreatedByUserIdSpecified
        {
        get { return mCreatedByUserIdSpecified; }
        set { mCreatedByUserIdSpecified = value; }
        }

        private string mExternalReference
            = "";
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"ExternalReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalReference
        {
        get { return mExternalReference; }
        set { mExternalReference = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        