
        // Generated from: PatLoa.proto
        // Note: requires additional types generated from: PatLoaType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatLoa")]
        public partial class PatLoa : global::ProtoBuf.IExtensible
        {
        public PatLoa() {}
        

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

        private Kroll.Pharmacy.Api.Data.PatLoaType mLoaType
            = Kroll.Pharmacy.Api.Data.PatLoaType.PatLoaType_None;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"LoaType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatLoaType.PatLoaType_None)]
        
        public Kroll.Pharmacy.Api.Data.PatLoaType LoaType
        {
        get { return mLoaType; }
        set { mLoaType = value; }
        }

        private double mLoaStartDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"LoaStartDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LoaStartDate
        {
        get { return mLoaStartDate; }
        set { mLoaStartDate = value; }
        }

        private double mLoaEndDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"LoaEndDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LoaEndDate
        {
        get { return mLoaEndDate; }
        set { mLoaEndDate = value; }
        }

        private bool mLoaEndDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"LoaEndDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LoaEndDateSpecified
        {
        get { return mLoaEndDateSpecified; }
        set { mLoaEndDateSpecified = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private bool mSentToThirdParty
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"SentToThirdParty", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SentToThirdParty
        {
        get { return mSentToThirdParty; }
        set { mSentToThirdParty = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateCreated
        {
        get { return mDateCreated; }
        set { mDateCreated = value; }
        }

        private bool mDateCreatedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateCreatedSpecified
        {
        get { return mDateCreatedSpecified; }
        set { mDateCreatedSpecified = value; }
        }

        private double mDateChanged
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateChanged
        {
        get { return mDateChanged; }
        set { mDateChanged = value; }
        }

        private bool mDateChangedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        