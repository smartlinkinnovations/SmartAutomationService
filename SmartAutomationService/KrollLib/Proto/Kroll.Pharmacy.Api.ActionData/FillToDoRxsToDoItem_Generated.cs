
        // Generated from: FillToDoRxsToDoItem.proto
        // Note: requires additional types generated from: FillToDoRxsWarning.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FillToDoRxsToDoItem")]
        public partial class FillToDoRxsToDoItem : global::ProtoBuf.IExtensible
        {
        public FillToDoRxsToDoItem() {}
        

        private int mToDoId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ToDoId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ToDoId
        {
        get { return mToDoId; }
        set { mToDoId = value; }
        }

        private bool mSuccessful
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Successful", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Successful
        {
        get { return mSuccessful; }
        set { mSuccessful = value; }
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

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"OrigRxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"OrigRxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OrigRxNumSpecified
        {
        get { return mOrigRxNumSpecified; }
        set { mOrigRxNumSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.ActionData.FillToDoRxsWarning> mWarnings = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.ActionData.FillToDoRxsWarning>();
        [global::ProtoBuf.ProtoMember(8, Name=@"Warnings", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.ActionData.FillToDoRxsWarning> Warnings
        {
        get { return mWarnings; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        