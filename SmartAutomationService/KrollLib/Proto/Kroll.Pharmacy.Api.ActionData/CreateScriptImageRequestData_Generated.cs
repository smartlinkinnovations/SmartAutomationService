
        // Generated from: CreateScriptImageRequestData.proto
        // Note: requires additional types generated from: ScriptImageType_Enum.proto
        // Note: requires additional types generated from: GenericLabelItem_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateScriptImageRequestData")]
        public partial class CreateScriptImageRequestData : global::ProtoBuf.IExtensible
        {
        public CreateScriptImageRequestData() {}
        

        private double mScanDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ScanDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ScanDate
        {
        get { return mScanDate; }
        set { mScanDate = value; }
        }

        private bool mScanDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ScanDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScanDateSpecified
        {
        get { return mScanDateSpecified; }
        set { mScanDateSpecified = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private bool mPatIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatIdSpecified
        {
        get { return mPatIdSpecified; }
        set { mPatIdSpecified = value; }
        }

        private int mDocId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DocId
        {
        get { return mDocId; }
        set { mDocId = value; }
        }

        private bool mDocIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocIdSpecified
        {
        get { return mDocIdSpecified; }
        set { mDocIdSpecified = value; }
        }

        private byte[] mScriptImage
            = null;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ScriptImage", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ScriptImage
        {
        get { return mScriptImage; }
        set { mScriptImage = value; }
        }

        private string mReferenceNumber
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"ReferenceNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReferenceNumber
        {
        get { return mReferenceNumber; }
        set { mReferenceNumber = value; }
        }

        private int mScriptCount
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ScriptCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ScriptCount
        {
        get { return mScriptCount; }
        set { mScriptCount = value; }
        }

        private bool mScriptCountSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"ScriptCountSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScriptCountSpecified
        {
        get { return mScriptCountSpecified; }
        set { mScriptCountSpecified = value; }
        }

        private int mPageCount
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"PageCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PageCount
        {
        get { return mPageCount; }
        set { mPageCount = value; }
        }

        private bool mPageCountSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"PageCountSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PageCountSpecified
        {
        get { return mPageCountSpecified; }
        set { mPageCountSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<int> mScriptCountByPage = new global::System.Collections.Generic.List<int>();
        [global::ProtoBuf.ProtoMember(14, Name=@"ScriptCountByPage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public global::System.Collections.Generic.List<int> ScriptCountByPage
        {
        get { return mScriptCountByPage; }
        }
    

        private bool mScriptCountByPageSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ScriptCountByPageSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScriptCountByPageSpecified
        {
        get { return mScriptCountByPageSpecified; }
        set { mScriptCountByPageSpecified = value; }
        }

        private string mContentMimeType
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ContentMimeType", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ContentMimeType
        {
        get { return mContentMimeType; }
        set { mContentMimeType = value; }
        }

        private Kroll.Pharmacy.Api.Data.ScriptImageType mScriptImageType
            = Kroll.Pharmacy.Api.Data.ScriptImageType.ScriptImageType_Unknown;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"ScriptImageType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ScriptImageType.ScriptImageType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ScriptImageType ScriptImageType
        {
        get { return mScriptImageType; }
        set { mScriptImageType = value; }
        }

        private Kroll.Pharmacy.Api.Data.GenericLabelItem mGenericLabelItem
            = Kroll.Pharmacy.Api.Data.GenericLabelItem.GenericLabelItem_None;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"GenericLabelItem", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.GenericLabelItem.GenericLabelItem_None)]
        
        public Kroll.Pharmacy.Api.Data.GenericLabelItem GenericLabelItem
        {
        get { return mGenericLabelItem; }
        set { mGenericLabelItem = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        