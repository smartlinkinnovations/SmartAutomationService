
        // Generated from: SigSearchCriteria.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SigSearchCriteria")]
        public partial class SigSearchCriteria : global::ProtoBuf.IExtensible
        {
        public SigSearchCriteria() {}
        

        private string mToken
            = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Token", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Token
        {
        get { return mToken; }
        set { mToken = value; }
        }

        private bool mTokenSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"TokenSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TokenSpecified
        {
        get { return mTokenSpecified; }
        set { mTokenSpecified = value; }
        }

        private string mLanguage
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Language", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Language
        {
        get { return mLanguage; }
        set { mLanguage = value; }
        }

        private bool mLanguageSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"LanguageSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LanguageSpecified
        {
        get { return mLanguageSpecified; }
        set { mLanguageSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        