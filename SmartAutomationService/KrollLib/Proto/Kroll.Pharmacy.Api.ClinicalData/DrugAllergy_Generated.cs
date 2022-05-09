
        // Generated from: DrugAllergy.proto
        // Note: requires additional types generated from: AllergyCodeType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrugAllergy")]
        public partial class DrugAllergy : global::ProtoBuf.IExtensible
        {
        public DrugAllergy() {}
        

        private Kroll.Pharmacy.Api.Data.AllergyCodeType mAllergyCodeType
            = Kroll.Pharmacy.Api.Data.AllergyCodeType.AllergyCodeType_Unknown;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"AllergyCodeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AllergyCodeType.AllergyCodeType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.AllergyCodeType AllergyCodeType
        {
        get { return mAllergyCodeType; }
        set { mAllergyCodeType = value; }
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

        private bool mIsRelatedIngredient
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"IsRelatedIngredient", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsRelatedIngredient
        {
        get { return mIsRelatedIngredient; }
        set { mIsRelatedIngredient = value; }
        }

        private bool mIsCrossSensitivity
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"IsCrossSensitivity", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsCrossSensitivity
        {
        get { return mIsCrossSensitivity; }
        set { mIsCrossSensitivity = value; }
        }

        private string mCrossSensitivityGroupDescription
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"CrossSensitivityGroupDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CrossSensitivityGroupDescription
        {
        get { return mCrossSensitivityGroupDescription; }
        set { mCrossSensitivityGroupDescription = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        