
        // Generated from: AllergyPickListItem.proto
        // Note: requires additional types generated from: AllergyCodeType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AllergyPickListItem")]
        public partial class AllergyPickListItem : global::ProtoBuf.IExtensible
        {
        public AllergyPickListItem() {}
        

        private Kroll.Pharmacy.Api.Data.AllergyCodeType mCodeType
            = Kroll.Pharmacy.Api.Data.AllergyCodeType.AllergyCodeType_Unknown;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"CodeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AllergyCodeType.AllergyCodeType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.AllergyCodeType CodeType
        {
        get { return mCodeType; }
        set { mCodeType = value; }
        }

        private string mCode
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Code", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Code
        {
        get { return mCode; }
        set { mCode = value; }
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

        private bool mIsScreened
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"IsScreened", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsScreened
        {
        get { return mIsScreened; }
        set { mIsScreened = value; }
        }

        private bool mReverseLookupOnly
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ReverseLookupOnly", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ReverseLookupOnly
        {
        get { return mReverseLookupOnly; }
        set { mReverseLookupOnly = value; }
        }

        private string mLanguageCode
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"LanguageCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LanguageCode
        {
        get { return mLanguageCode; }
        set { mLanguageCode = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        