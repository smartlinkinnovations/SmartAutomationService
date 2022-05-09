
        // Generated from: WorkflowCommentAlert.proto
        // Note: requires additional types generated from: CommentAlertType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorkflowCommentAlert")]
        public partial class WorkflowCommentAlert : global::ProtoBuf.IExtensible
        {
        public WorkflowCommentAlert() {}
        

        private int mWorkflowActionType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"WorkflowActionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int WorkflowActionType
        {
        get { return mWorkflowActionType; }
        set { mWorkflowActionType = value; }
        }

        private Kroll.Pharmacy.Api.Data.CommentAlertType mCommentAlertType
            = Kroll.Pharmacy.Api.Data.CommentAlertType.CommentAlertType_Unknown;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"CommentAlertType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CommentAlertType.CommentAlertType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.CommentAlertType CommentAlertType
        {
        get { return mCommentAlertType; }
        set { mCommentAlertType = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        