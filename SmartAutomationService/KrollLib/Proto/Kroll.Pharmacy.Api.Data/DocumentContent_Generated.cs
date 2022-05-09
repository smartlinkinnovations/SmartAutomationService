
        // Generated from: DocumentContent.proto
        // Note: requires additional types generated from: DocumentFormat_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DocumentContent")]
        public partial class DocumentContent : global::ProtoBuf.IExtensible
        {
        public DocumentContent() {}
        

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

        private Kroll.Pharmacy.Api.Data.DocumentFormat mDocumentFormat
            = Kroll.Pharmacy.Api.Data.DocumentFormat.DocumentFormat_Unknown;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DocumentFormat", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DocumentFormat.DocumentFormat_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.DocumentFormat DocumentFormat
        {
        get { return mDocumentFormat; }
        set { mDocumentFormat = value; }
        }

        private bool mDocumentFormatSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"DocumentFormatSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocumentFormatSpecified
        {
        get { return mDocumentFormatSpecified; }
        set { mDocumentFormatSpecified = value; }
        }

        private byte[] mData
            = null;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Data", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] Data
        {
        get { return mData; }
        set { mData = value; }
        }

        private string mContentMimeType
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ContentMimeType", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ContentMimeType
        {
        get { return mContentMimeType; }
        set { mContentMimeType = value; }
        }

        private byte[] mSHA256
            = null;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"SHA256", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] SHA256
        {
        get { return mSHA256; }
        set { mSHA256 = value; }
        }

        private int mCentralMaintId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CentralMaintId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintId
        {
        get { return mCentralMaintId; }
        set { mCentralMaintId = value; }
        }

        private bool mCentralMaintIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"CentralMaintIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CentralMaintIdSpecified
        {
        get { return mCentralMaintIdSpecified; }
        set { mCentralMaintIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        