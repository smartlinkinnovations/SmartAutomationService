
        // Generated from: DrugAllergyInteraction.proto
        // Note: requires additional types generated from: AllergyCodeType_Enum.proto
        // Note: requires additional types generated from: DrugAllergyInteractionType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrugAllergyInteraction")]
        public partial class DrugAllergyInteraction : global::ProtoBuf.IExtensible
        {
        public DrugAllergyInteraction() {}
        

        private Kroll.Pharmacy.Api.Data.DrugAllergyInteractionType mDrugAllergyInteractionType
            = Kroll.Pharmacy.Api.Data.DrugAllergyInteractionType.DrugAllergyInteractionType_RelatedIngredients;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DrugAllergyInteractionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrugAllergyInteractionType.DrugAllergyInteractionType_RelatedIngredients)]
        
        public Kroll.Pharmacy.Api.Data.DrugAllergyInteractionType DrugAllergyInteractionType
        {
        get { return mDrugAllergyInteractionType; }
        set { mDrugAllergyInteractionType = value; }
        }

        private Kroll.Pharmacy.Api.Data.AllergyCodeType mPatientAllergyCodeType
            = Kroll.Pharmacy.Api.Data.AllergyCodeType.AllergyCodeType_Unknown;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PatientAllergyCodeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AllergyCodeType.AllergyCodeType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.AllergyCodeType PatientAllergyCodeType
        {
        get { return mPatientAllergyCodeType; }
        set { mPatientAllergyCodeType = value; }
        }

        private string mPatientAllergyCode
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"PatientAllergyCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PatientAllergyCode
        {
        get { return mPatientAllergyCode; }
        set { mPatientAllergyCode = value; }
        }

        private string mPatientAllergyDescription
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"PatientAllergyDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PatientAllergyDescription
        {
        get { return mPatientAllergyDescription; }
        set { mPatientAllergyDescription = value; }
        }

        private string mDrugIngredientCode
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DrugIngredientCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrugIngredientCode
        {
        get { return mDrugIngredientCode; }
        set { mDrugIngredientCode = value; }
        }

        private string mDrugIngredientDescription
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DrugIngredientDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrugIngredientDescription
        {
        get { return mDrugIngredientDescription; }
        set { mDrugIngredientDescription = value; }
        }

        private bool mIsRelatedIngredient
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"IsRelatedIngredient", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsRelatedIngredient
        {
        get { return mIsRelatedIngredient; }
        set { mIsRelatedIngredient = value; }
        }

        private string mAllergenIngredientCode
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"AllergenIngredientCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AllergenIngredientCode
        {
        get { return mAllergenIngredientCode; }
        set { mAllergenIngredientCode = value; }
        }

        private string mAllergenIngredientDescription
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"AllergenIngredientDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AllergenIngredientDescription
        {
        get { return mAllergenIngredientDescription; }
        set { mAllergenIngredientDescription = value; }
        }

        private int mAllergenGroupCode
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"AllergenGroupCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AllergenGroupCode
        {
        get { return mAllergenGroupCode; }
        set { mAllergenGroupCode = value; }
        }

        private string mAllergenGroupDescription
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"AllergenGroupDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AllergenGroupDescription
        {
        get { return mAllergenGroupDescription; }
        set { mAllergenGroupDescription = value; }
        }

        private int mAllergenStatusCode
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"AllergenStatusCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AllergenStatusCode
        {
        get { return mAllergenStatusCode; }
        set { mAllergenStatusCode = value; }
        }

        private int mAllergenPotentiallyInactiveIndicator
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"AllergenPotentiallyInactiveIndicator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AllergenPotentiallyInactiveIndicator
        {
        get { return mAllergenPotentiallyInactiveIndicator; }
        set { mAllergenPotentiallyInactiveIndicator = value; }
        }

        private int mCrossSensitivityGroupCode
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"CrossSensitivityGroupCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CrossSensitivityGroupCode
        {
        get { return mCrossSensitivityGroupCode; }
        set { mCrossSensitivityGroupCode = value; }
        }

        private string mCrossSensitivityGroupDescription
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"CrossSensitivityGroupDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CrossSensitivityGroupDescription
        {
        get { return mCrossSensitivityGroupDescription; }
        set { mCrossSensitivityGroupDescription = value; }
        }

        private int mCrossSensitivityStatusCode
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"CrossSensitivityStatusCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CrossSensitivityStatusCode
        {
        get { return mCrossSensitivityStatusCode; }
        set { mCrossSensitivityStatusCode = value; }
        }

        private int mCrossSensitivityPotentiallyInactiveIndicator
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"CrossSensitivityPotentiallyInactiveIndicator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CrossSensitivityPotentiallyInactiveIndicator
        {
        get { return mCrossSensitivityPotentiallyInactiveIndicator; }
        set { mCrossSensitivityPotentiallyInactiveIndicator = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        