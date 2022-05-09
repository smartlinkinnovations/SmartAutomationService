
        // Generated from: AdtSearchCriteria.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AdtSearchCriteria")]
        public partial class AdtSearchCriteria : global::ProtoBuf.IExtensible
        {
        public AdtSearchCriteria() {}
        

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

        private bool mIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IdSpecified
        {
        get { return mIdSpecified; }
        set { mIdSpecified = value; }
        }

        private string mExternalMessageId
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ExternalMessageId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalMessageId
        {
        get { return mExternalMessageId; }
        set { mExternalMessageId = value; }
        }

        private string mExternalAdtReference
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ExternalAdtReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalAdtReference
        {
        get { return mExternalAdtReference; }
        set { mExternalAdtReference = value; }
        }

        private string mExternalPatReference
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ExternalPatReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalPatReference
        {
        get { return mExternalPatReference; }
        set { mExternalPatReference = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        