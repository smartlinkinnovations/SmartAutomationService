
        // Generated from: CreateToDoDiscontinueRxRequestData.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateToDoDiscontinueRxRequestData")]
        public partial class CreateToDoDiscontinueRxRequestData : global::ProtoBuf.IExtensible
        {
        public CreateToDoDiscontinueRxRequestData() {}
        

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private double mDueDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DueDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DueDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DueDateSpecified
        {
        get { return mDueDateSpecified; }
        set { mDueDateSpecified = value; }
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

        private string mEnteredBy
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"EnteredBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string EnteredBy
        {
        get { return mEnteredBy; }
        set { mEnteredBy = value; }
        }

        private int mWorkOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"WorkOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"WorkOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WorkOrderIdSpecified
        {
        get { return mWorkOrderIdSpecified; }
        set { mWorkOrderIdSpecified = value; }
        }

        private int mSharedDBStoreId
            = 
                (int)1;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"SharedDBStoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                (int)1)]
        
        public int SharedDBStoreId
        {
        get { return mSharedDBStoreId; }
        set { mSharedDBStoreId = value; }
        }

        private bool mSharedDBStoreIdSpecified
            = 
                (bool)true;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"SharedDBStoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                (bool)true)]
        
        public bool SharedDBStoreIdSpecified
        {
        get { return mSharedDBStoreIdSpecified; }
        set { mSharedDBStoreIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mSharedDBStoreCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"SharedDBStoreCentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink SharedDBStoreCentralMaintLink
        {
        get { return mSharedDBStoreCentralMaintLink; }
        set { mSharedDBStoreCentralMaintLink = value; }
        }

        private bool mSharedDBStoreCentralMaintLinkSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"SharedDBStoreCentralMaintLinkSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SharedDBStoreCentralMaintLinkSpecified
        {
        get { return mSharedDBStoreCentralMaintLinkSpecified; }
        set { mSharedDBStoreCentralMaintLinkSpecified = value; }
        }

        private int mScriptImageId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"ScriptImageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"ScriptImageIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScriptImageIdSpecified
        {
        get { return mScriptImageIdSpecified; }
        set { mScriptImageIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        