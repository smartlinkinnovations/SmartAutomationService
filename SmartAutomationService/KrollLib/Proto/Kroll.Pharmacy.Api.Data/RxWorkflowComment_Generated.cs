
        // Generated from: RxWorkflowComment.proto
        // Note: requires additional types generated from: RxWorkflowCommentType_Enum.proto
        // Note: requires additional types generated from: RxWorkflowTroubleType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxWorkflowComment")]
        public partial class RxWorkflowComment : global::ProtoBuf.IExtensible
        {
        public RxWorkflowComment() {}
        

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

        private Kroll.Pharmacy.Api.Data.RxWorkflowCommentType mCommentType
            = Kroll.Pharmacy.Api.Data.RxWorkflowCommentType.RxWorkflowCommentType_General;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"CommentType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxWorkflowCommentType.RxWorkflowCommentType_General)]
        
        public Kroll.Pharmacy.Api.Data.RxWorkflowCommentType CommentType
        {
        get { return mCommentType; }
        set { mCommentType = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxWorkflowTroubleType mTroubleType
            = Kroll.Pharmacy.Api.Data.RxWorkflowTroubleType.RxWorkflowTroubleType_None;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"TroubleType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxWorkflowTroubleType.RxWorkflowTroubleType_None)]
        
        public Kroll.Pharmacy.Api.Data.RxWorkflowTroubleType TroubleType
        {
        get { return mTroubleType; }
        set { mTroubleType = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private string mCreatedByInit
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"CreatedByInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CreatedByInit
        {
        get { return mCreatedByInit; }
        set { mCreatedByInit = value; }
        }

        private int mCreatedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"CreatedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"CreatedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CreatedByUserIdSpecified
        {
        get { return mCreatedByUserIdSpecified; }
        set { mCreatedByUserIdSpecified = value; }
        }

        private double mCreatedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CreatedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CreatedDate
        {
        get { return mCreatedDate; }
        set { mCreatedDate = value; }
        }

        private string mResolvedComment
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ResolvedComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResolvedComment
        {
        get { return mResolvedComment; }
        set { mResolvedComment = value; }
        }

        private string mResolvedByInit
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"ResolvedByInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResolvedByInit
        {
        get { return mResolvedByInit; }
        set { mResolvedByInit = value; }
        }

        private int mResolvedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"ResolvedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"ResolvedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ResolvedByUserIdSpecified
        {
        get { return mResolvedByUserIdSpecified; }
        set { mResolvedByUserIdSpecified = value; }
        }

        private double mResolvedDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"ResolvedDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ResolvedDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ResolvedDateSpecified
        {
        get { return mResolvedDateSpecified; }
        set { mResolvedDateSpecified = value; }
        }

        private int mClonedFromId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ClonedFromId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"ClonedFromIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ClonedFromIdSpecified
        {
        get { return mClonedFromIdSpecified; }
        set { mClonedFromIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        