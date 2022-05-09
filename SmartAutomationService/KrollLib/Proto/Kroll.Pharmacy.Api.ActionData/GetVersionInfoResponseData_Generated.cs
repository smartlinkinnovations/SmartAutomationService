
        // Generated from: GetVersionInfoResponseData.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetVersionInfoResponseData")]
        public partial class GetVersionInfoResponseData : global::ProtoBuf.IExtensible
        {
        public GetVersionInfoResponseData() {}
        

        private int mDatabaseVersion
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DatabaseVersion", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DatabaseVersion
        {
        get { return mDatabaseVersion; }
        set { mDatabaseVersion = value; }
        }

        private string mServiceVersion
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ServiceVersion", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ServiceVersion
        {
        get { return mServiceVersion; }
        set { mServiceVersion = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        