
        // Generated from: Lists.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Lists")]
        public partial class Lists : global::ProtoBuf.IExtensible
        {
        public Lists() {}
        

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

        private string mListName
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ListName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ListName
        {
        get { return mListName; }
        set { mListName = value; }
        }

        private string mDisplayValue
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DisplayValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DisplayValue
        {
        get { return mDisplayValue; }
        set { mDisplayValue = value; }
        }

        private string mStoredValue
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"StoredValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string StoredValue
        {
        get { return mStoredValue; }
        set { mStoredValue = value; }
        }

        private int mSeq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Seq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Seq
        {
        get { return mSeq; }
        set { mSeq = value; }
        }

        private bool mSeqSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"SeqSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SeqSpecified
        {
        get { return mSeqSpecified; }
        set { mSeqSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink CentralMaintLink
        {
        get { return mCentralMaintLink; }
        set { mCentralMaintLink = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        