
        // Generated from: Allergy.proto
        // Note: requires additional types generated from: AllergyCodeType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Allergy")]
        public partial class Allergy : global::ProtoBuf.IExtensible
        {
        public Allergy() {}
        

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
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        