
        // Generated from: RxIndications.proto
        // Note: requires additional types generated from: MedicalConditionCodeType_Enum.proto
        // Note: requires additional types generated from: ConditionSource_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxIndications")]
        public partial class RxIndications : global::ProtoBuf.IExtensible
        {
        public RxIndications() {}
        

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

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private Kroll.Pharmacy.Api.Data.MedicalConditionCodeType mCodeType
            = Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_FdbdxCode;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"CodeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_FdbdxCode)]
        
        public Kroll.Pharmacy.Api.Data.MedicalConditionCodeType CodeType
        {
        get { return mCodeType; }
        set { mCodeType = value; }
        }

        private string mCode
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Code", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Code
        {
        get { return mCode; }
        set { mCode = value; }
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

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        