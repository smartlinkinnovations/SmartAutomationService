
        // Generated from: NHPhone.proto
        // Note: requires additional types generated from: PhoneType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NHPhone")]
        public partial class NHPhone : global::ProtoBuf.IExtensible
        {
        public NHPhone() {}
        

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

        private int mNHId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"NHId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHId
        {
        get { return mNHId; }
        set { mNHId = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private string mPhone
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Phone
        {
        get { return mPhone; }
        set { mPhone = value; }
        }

        private string mExtension
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Extension", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Extension
        {
        get { return mExtension; }
        set { mExtension = value; }
        }

        private Kroll.Pharmacy.Api.Data.PhoneType mPhoneType
            = Kroll.Pharmacy.Api.Data.PhoneType.PhoneType_Unknown;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PhoneType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PhoneType.PhoneType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PhoneType PhoneType
        {
        get { return mPhoneType; }
        set { mPhoneType = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        