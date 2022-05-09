
        // Generated from: FillToDoRxsRequestData.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FillToDoRxsRequestData")]
        public partial class FillToDoRxsRequestData : global::ProtoBuf.IExtensible
        {
        public FillToDoRxsRequestData() {}
        
        private readonly global::System.Collections.Generic.List<int> mToDoIds = new global::System.Collections.Generic.List<int>();
        [global::ProtoBuf.ProtoMember(1, Name=@"ToDoIds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public global::System.Collections.Generic.List<int> ToDoIds
        {
        get { return mToDoIds; }
        }
    

        private int mSharedDBStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SharedDBStoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SharedDBStoreId
        {
        get { return mSharedDBStoreId; }
        set { mSharedDBStoreId = value; }
        }

        private string mUserInit
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"UserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserInit
        {
        get { return mUserInit; }
        set { mUserInit = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        