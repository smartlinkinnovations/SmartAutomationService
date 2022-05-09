
        // Generated from: CreateToDoDiscontinueRxResponseData.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
        // Note: requires additional types generated from: CreateToDoDiscontinueRxResponseType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateToDoDiscontinueRxResponseData")]
        public partial class CreateToDoDiscontinueRxResponseData : global::ProtoBuf.IExtensible
        {
        public CreateToDoDiscontinueRxResponseData() {}
        

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

        private int mOrigRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"OrigRxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OrigRxNum
        {
        get { return mOrigRxNum; }
        set { mOrigRxNum = value; }
        }

        private bool mIsAccepted
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IsAccepted", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsAccepted
        {
        get { return mIsAccepted; }
        set { mIsAccepted = value; }
        }

        private double mDueDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DueDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DueDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DueDateSpecified
        {
        get { return mDueDateSpecified; }
        set { mDueDateSpecified = value; }
        }

        private int mToDoId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ToDoId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ToDoIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ToDoIdSpecified
        {
        get { return mToDoIdSpecified; }
        set { mToDoIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.ActionData.CreateToDoDiscontinueRxResponseType mResponseType
            = Kroll.Pharmacy.Api.ActionData.CreateToDoDiscontinueRxResponseType.CreateToDoDiscontinueRxResponseType_Accepted;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"ResponseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.CreateToDoDiscontinueRxResponseType.CreateToDoDiscontinueRxResponseType_Accepted)]
        
        public Kroll.Pharmacy.Api.ActionData.CreateToDoDiscontinueRxResponseType ResponseType
        {
        get { return mResponseType; }
        set { mResponseType = value; }
        }

        private int mSharedDBStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"SharedDBStoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SharedDBStoreId
        {
        get { return mSharedDBStoreId; }
        set { mSharedDBStoreId = value; }
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
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        