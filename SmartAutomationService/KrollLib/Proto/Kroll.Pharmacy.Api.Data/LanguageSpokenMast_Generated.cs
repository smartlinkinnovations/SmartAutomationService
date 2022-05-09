
        // Generated from: LanguageSpokenMast.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LanguageSpokenMast")]
        public partial class LanguageSpokenMast : global::ProtoBuf.IExtensible
        {
        public LanguageSpokenMast() {}
        

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

        private string mLanguageCode
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"LanguageCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LanguageCode
        {
        get { return mLanguageCode; }
        set { mLanguageCode = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private string mMacroLanguageCode
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"MacroLanguageCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MacroLanguageCode
        {
        get { return mMacroLanguageCode; }
        set { mMacroLanguageCode = value; }
        }

        private string mMacroLanguageDescription
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"MacroLanguageDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MacroLanguageDescription
        {
        get { return mMacroLanguageDescription; }
        set { mMacroLanguageDescription = value; }
        }

        private bool mIsMacroLanguage
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"IsMacroLanguage", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsMacroLanguage
        {
        get { return mIsMacroLanguage; }
        set { mIsMacroLanguage = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        