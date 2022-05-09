
        // Generated from: PatCnd.proto
        // Note: requires additional types generated from: ConditionSource_Enum.proto
        // Note: requires additional types generated from: MedicalConditionCodeType_Enum.proto
        // Note: requires additional types generated from: ExternalPatCndLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatCnd")]
        public partial class PatCnd : global::ProtoBuf.IExtensible
        {
        public PatCnd() {}
        

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

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private string mCode
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Code", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Code
        {
        get { return mCode; }
        set { mCode = value; }
        }

        private int mSeq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Seq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Seq
        {
        get { return mSeq; }
        set { mSeq = value; }
        }

        private Kroll.Pharmacy.Api.Data.ConditionSource mSource
            = Kroll.Pharmacy.Api.Data.ConditionSource.ConditionSource_Pharmacist;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Source", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ConditionSource.ConditionSource_Pharmacist)]
        
        public Kroll.Pharmacy.Api.Data.ConditionSource Source
        {
        get { return mSource; }
        set { mSource = value; }
        }

        private double mDateAdded
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DateAdded", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateAdded
        {
        get { return mDateAdded; }
        set { mDateAdded = value; }
        }

        private bool mDateAddedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"DateAddedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateAddedSpecified
        {
        get { return mDateAddedSpecified; }
        set { mDateAddedSpecified = value; }
        }

        private string mSeverity
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Severity", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Severity
        {
        get { return mSeverity; }
        set { mSeverity = value; }
        }

        private Kroll.Pharmacy.Api.Data.MedicalConditionCodeType mCodeType
            = Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_FdbdxCode;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CodeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_FdbdxCode)]
        
        public Kroll.Pharmacy.Api.Data.MedicalConditionCodeType CodeType
        {
        get { return mCodeType; }
        set { mCodeType = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalPatCndLink> mExternalLinks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalPatCndLink>();
        [global::ProtoBuf.ProtoMember(10, Name=@"ExternalLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalPatCndLink> ExternalLinks
        {
        get { return mExternalLinks; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        