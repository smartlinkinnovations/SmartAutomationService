
        // Generated from: RxCom.proto
        // Note: requires additional types generated from: RxCommentType_Enum.proto
        // Note: requires additional types generated from: WorkflowCommentAlert.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxCom")]
        public partial class RxCom : global::ProtoBuf.IExtensible
        {
        public RxCom() {}
        

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

        private string mTopic
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Topic", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Topic
        {
        get { return mTopic; }
        set { mTopic = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private bool mShowOnRx
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ShowOnRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ShowOnRx
        {
        get { return mShowOnRx; }
        set { mShowOnRx = value; }
        }

        private bool mPrintOnHardcopy
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PrintOnHardcopy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintOnHardcopy
        {
        get { return mPrintOnHardcopy; }
        set { mPrintOnHardcopy = value; }
        }

        private bool mConspicuous
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Conspicuous", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Conspicuous
        {
        get { return mConspicuous; }
        set { mConspicuous = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxCommentType mCommentType
            = Kroll.Pharmacy.Api.Data.RxCommentType.RxCommentType_None;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"CommentType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxCommentType.RxCommentType_None)]
        
        public Kroll.Pharmacy.Api.Data.RxCommentType CommentType
        {
        get { return mCommentType; }
        set { mCommentType = value; }
        }

        private bool mKeepForRefills
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"KeepForRefills", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool KeepForRefills
        {
        get { return mKeepForRefills; }
        set { mKeepForRefills = value; }
        }

        private bool mKeepForCopiedRxs
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"KeepForCopiedRxs", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool KeepForCopiedRxs
        {
        get { return mKeepForCopiedRxs; }
        set { mKeepForCopiedRxs = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private string mInit
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"Init", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Init
        {
        get { return mInit; }
        set { mInit = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkflowCommentAlert> mWorkflowAlerts = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkflowCommentAlert>();
        [global::ProtoBuf.ProtoMember(16, Name=@"WorkflowAlerts", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.WorkflowCommentAlert> WorkflowAlerts
        {
        get { return mWorkflowAlerts; }
        }
    

        private int mUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"UserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"UserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        