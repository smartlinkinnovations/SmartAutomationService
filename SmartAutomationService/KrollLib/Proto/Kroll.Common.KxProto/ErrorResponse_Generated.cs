
        // Generated from: ErrorResponse.proto
            namespace Kroll.Common.KxProto.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ErrorResponse")]
        public partial class ErrorResponse : global::ProtoBuf.IExtensible
        {
        public ErrorResponse() {}
        

        private string mOriginalMessageName
            = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"OriginalMessageName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OriginalMessageName
        {
        get { return mOriginalMessageName; }
        set { mOriginalMessageName = value; }
        }

        private string mOriginalMessageVersion
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"OriginalMessageVersion", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OriginalMessageVersion
        {
        get { return mOriginalMessageVersion; }
        set { mOriginalMessageVersion = value; }
        }

        private int mErrorNumber
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ErrorNumber", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ErrorNumber
        {
        get { return mErrorNumber; }
        set { mErrorNumber = value; }
        }

        private string mErrorMessage
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ErrorMessage", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ErrorMessage
        {
        get { return mErrorMessage; }
        set { mErrorMessage = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        