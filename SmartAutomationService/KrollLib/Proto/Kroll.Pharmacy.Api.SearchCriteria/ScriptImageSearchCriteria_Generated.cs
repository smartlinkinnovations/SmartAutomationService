
        // Generated from: ScriptImageSearchCriteria.proto
        // Note: requires additional types generated from: StringComparisonOperator_Enum.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ScriptImageSearchCriteria")]
        public partial class ScriptImageSearchCriteria : global::ProtoBuf.IExtensible
        {
        public ScriptImageSearchCriteria() {}
        

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

        private double mScanDateStartRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ScanDateStartRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ScanDateStartRange
        {
        get { return mScanDateStartRange; }
        set { mScanDateStartRange = value; }
        }

        private bool mScanDateStartRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"ScanDateStartRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScanDateStartRangeSpecified
        {
        get { return mScanDateStartRangeSpecified; }
        set { mScanDateStartRangeSpecified = value; }
        }

        private double mScanDateEndRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"ScanDateEndRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ScanDateEndRange
        {
        get { return mScanDateEndRange; }
        set { mScanDateEndRange = value; }
        }

        private bool mScanDateEndRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ScanDateEndRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScanDateEndRangeSpecified
        {
        get { return mScanDateEndRangeSpecified; }
        set { mScanDateEndRangeSpecified = value; }
        }

        private string mReferenceNumber
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"ReferenceNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReferenceNumber
        {
        get { return mReferenceNumber; }
        set { mReferenceNumber = value; }
        }

        private bool mReferenceNumberSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"ReferenceNumberSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ReferenceNumberSpecified
        {
        get { return mReferenceNumberSpecified; }
        set { mReferenceNumberSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        