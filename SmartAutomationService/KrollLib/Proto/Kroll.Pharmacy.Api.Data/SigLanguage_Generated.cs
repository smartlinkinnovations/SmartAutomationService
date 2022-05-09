
        // Generated from: SigLanguage.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SigLanguage")]
        public partial class SigLanguage : global::ProtoBuf.IExtensible
        {
        public SigLanguage() {}
        

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

        private string mLanguage
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Language", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Language
        {
        get { return mLanguage; }
        set { mLanguage = value; }
        }

        private string mFontName
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"FontName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FontName
        {
        get { return mFontName; }
        set { mFontName = value; }
        }

        private int mFontSize
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"FontSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int FontSize
        {
        get { return mFontSize; }
        set { mFontSize = value; }
        }

        private string mCommonChars
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"CommonChars", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CommonChars
        {
        get { return mCommonChars; }
        set { mCommonChars = value; }
        }

        private int mDisplayFontSize
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DisplayFontSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DisplayFontSize
        {
        get { return mDisplayFontSize; }
        set { mDisplayFontSize = value; }
        }

        private bool mPrintAsBitmap
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PrintAsBitmap", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintAsBitmap
        {
        get { return mPrintAsBitmap; }
        set { mPrintAsBitmap = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        