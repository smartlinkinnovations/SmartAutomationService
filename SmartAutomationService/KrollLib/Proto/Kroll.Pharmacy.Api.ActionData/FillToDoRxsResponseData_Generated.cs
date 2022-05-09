
        // Generated from: FillToDoRxsResponseData.proto
        // Note: requires additional types generated from: FillToDoRxsResponseType_Enum.proto
        // Note: requires additional types generated from: FillToDoRxsToDoItem.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FillToDoRxsResponseData")]
        public partial class FillToDoRxsResponseData : global::ProtoBuf.IExtensible
        {
        public FillToDoRxsResponseData() {}
        

        private bool mIsSuccessful
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IsSuccessful", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsSuccessful
        {
        get { return mIsSuccessful; }
        set { mIsSuccessful = value; }
        }

        private Kroll.Pharmacy.Api.ActionData.FillToDoRxsResponseType mResponseType
            = Kroll.Pharmacy.Api.ActionData.FillToDoRxsResponseType.FillToDoRxsResponseType_Successful;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ResponseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.FillToDoRxsResponseType.FillToDoRxsResponseType_Successful)]
        
        public Kroll.Pharmacy.Api.ActionData.FillToDoRxsResponseType ResponseType
        {
        get { return mResponseType; }
        set { mResponseType = value; }
        }

        private string mErrorMessage
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ErrorMessage", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ErrorMessage
        {
        get { return mErrorMessage; }
        set { mErrorMessage = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.ActionData.FillToDoRxsToDoItem> mToDoItems = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.ActionData.FillToDoRxsToDoItem>();
        [global::ProtoBuf.ProtoMember(4, Name=@"ToDoItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.ActionData.FillToDoRxsToDoItem> ToDoItems
        {
        get { return mToDoItems; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        