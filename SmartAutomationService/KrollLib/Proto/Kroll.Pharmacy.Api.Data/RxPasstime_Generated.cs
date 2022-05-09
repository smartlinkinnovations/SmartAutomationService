
        // Generated from: RxPasstime.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxPasstime")]
        public partial class RxPasstime : global::ProtoBuf.IExtensible
        {
        public RxPasstime() {}
        

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

        private int mSeq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Seq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Seq
        {
        get { return mSeq; }
        set { mSeq = value; }
        }

        private string mPassTime
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"PassTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PassTime
        {
        get { return mPassTime; }
        set { mPassTime = value; }
        }

        private string mUnitDose
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"UnitDose", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UnitDose
        {
        get { return mUnitDose; }
        set { mUnitDose = value; }
        }

        private string mNote
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Note", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Note
        {
        get { return mNote; }
        set { mNote = value; }
        }
        private readonly global::System.Collections.Generic.List<string> mAdminFlags = new global::System.Collections.Generic.List<string>();
        [global::ProtoBuf.ProtoMember(7, Name=@"AdminFlags", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<string> AdminFlags
        {
        get { return mAdminFlags; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        