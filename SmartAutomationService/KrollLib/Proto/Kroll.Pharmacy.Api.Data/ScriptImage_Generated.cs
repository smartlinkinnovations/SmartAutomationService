
        // Generated from: ScriptImage.proto
        // Note: requires additional types generated from: ScriptImageType_Enum.proto
        // Note: requires additional types generated from: GenericLabelItem_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ScriptImage")]
        public partial class ScriptImage : global::ProtoBuf.IExtensible
        {
        public ScriptImage() {}
        

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

        private double mScanDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ScanDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ScanDate
        {
        get { return mScanDate; }
        set { mScanDate = value; }
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

        private byte[] mScriptImageData
            = null;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ScriptImageData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ScriptImageData
        {
        get { return mScriptImageData; }
        set { mScriptImageData = value; }
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

        private bool mLinkedInWorkflow
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"LinkedInWorkflow", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LinkedInWorkflow
        {
        get { return mLinkedInWorkflow; }
        set { mLinkedInWorkflow = value; }
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

        private string mScriptCountByPage
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"ScriptCountByPage", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ScriptCountByPage
        {
        get { return mScriptCountByPage; }
        set { mScriptCountByPage = value; }
        }

        private string mContentMimeType
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ContentMimeType", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ContentMimeType
        {
        get { return mContentMimeType; }
        set { mContentMimeType = value; }
        }

        private Kroll.Pharmacy.Api.Data.ScriptImageType mScriptImageType
            = Kroll.Pharmacy.Api.Data.ScriptImageType.ScriptImageType_Unknown;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ScriptImageType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ScriptImageType.ScriptImageType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ScriptImageType ScriptImageType
        {
        get { return mScriptImageType; }
        set { mScriptImageType = value; }
        }

        private Kroll.Pharmacy.Api.Data.GenericLabelItem mGenericLabelItem
            = Kroll.Pharmacy.Api.Data.GenericLabelItem.GenericLabelItem_None;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"GenericLabelItem", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.GenericLabelItem.GenericLabelItem_None)]
        
        public Kroll.Pharmacy.Api.Data.GenericLabelItem GenericLabelItem
        {
        get { return mGenericLabelItem; }
        set { mGenericLabelItem = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private byte[] mAnnotations
            = null;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"Annotations", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] Annotations
        {
        get { return mAnnotations; }
        set { mAnnotations = value; }
        }

        private string mScannedByInit
            = "";
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"ScannedByInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ScannedByInit
        {
        get { return mScannedByInit; }
        set { mScannedByInit = value; }
        }

        private int mScannedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ScannedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ScannedByUserId
        {
        get { return mScannedByUserId; }
        set { mScannedByUserId = value; }
        }

        private bool mScannedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"ScannedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScannedByUserIdSpecified
        {
        get { return mScannedByUserIdSpecified; }
        set { mScannedByUserIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        