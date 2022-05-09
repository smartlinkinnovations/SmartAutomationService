
        // Generated from: SideEffect.proto
        // Note: requires additional types generated from: MedicalConditionCodeType_Enum.proto
        // Note: requires additional types generated from: SideEffectFrequency_Enum.proto
        // Note: requires additional types generated from: SideEffectSeverity_Enum.proto
        // Note: requires additional types generated from: SideEffectVisibility_Enum.proto
        // Note: requires additional types generated from: SideEffectLabTest_Enum.proto
        // Note: requires additional types generated from: SideEffectPhysicianContact_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SideEffect")]
        public partial class SideEffect : global::ProtoBuf.IExtensible
        {
        public SideEffect() {}
        

        private int mSequence
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Sequence", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Sequence
        {
        get { return mSequence; }
        set { mSequence = value; }
        }

        private int mSideEffectCode
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SideEffectCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SideEffectCode
        {
        get { return mSideEffectCode; }
        set { mSideEffectCode = value; }
        }

        private string mSideEffectDescription
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SideEffectDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SideEffectDescription
        {
        get { return mSideEffectDescription; }
        set { mSideEffectDescription = value; }
        }

        private Kroll.Pharmacy.Api.Data.MedicalConditionCodeType mMedicalConditionCodeType
            = Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_Unknown;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"MedicalConditionCodeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.MedicalConditionCodeType MedicalConditionCodeType
        {
        get { return mMedicalConditionCodeType; }
        set { mMedicalConditionCodeType = value; }
        }

        private string mMedicalConditionCode
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"MedicalConditionCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MedicalConditionCode
        {
        get { return mMedicalConditionCode; }
        set { mMedicalConditionCode = value; }
        }

        private Kroll.Pharmacy.Api.Data.SideEffectFrequency mFrequency
            = Kroll.Pharmacy.Api.Data.SideEffectFrequency.SideEffectFrequency_MoreFrequent;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Frequency", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.SideEffectFrequency.SideEffectFrequency_MoreFrequent)]
        
        public Kroll.Pharmacy.Api.Data.SideEffectFrequency Frequency
        {
        get { return mFrequency; }
        set { mFrequency = value; }
        }

        private Kroll.Pharmacy.Api.Data.SideEffectSeverity mSeverity
            = Kroll.Pharmacy.Api.Data.SideEffectSeverity.SideEffectSeverity_LessSevere;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Severity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.SideEffectSeverity.SideEffectSeverity_LessSevere)]
        
        public Kroll.Pharmacy.Api.Data.SideEffectSeverity Severity
        {
        get { return mSeverity; }
        set { mSeverity = value; }
        }

        private Kroll.Pharmacy.Api.Data.SideEffectVisibility mVisibility
            = Kroll.Pharmacy.Api.Data.SideEffectVisibility.SideEffectVisibility_Visible;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Visibility", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.SideEffectVisibility.SideEffectVisibility_Visible)]
        
        public Kroll.Pharmacy.Api.Data.SideEffectVisibility Visibility
        {
        get { return mVisibility; }
        set { mVisibility = value; }
        }

        private Kroll.Pharmacy.Api.Data.SideEffectLabTest mLabTest
            = Kroll.Pharmacy.Api.Data.SideEffectLabTest.SideEffectLabTest_NoLabOrDiagnosticTestRecommended;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"LabTest", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.SideEffectLabTest.SideEffectLabTest_NoLabOrDiagnosticTestRecommended)]
        
        public Kroll.Pharmacy.Api.Data.SideEffectLabTest LabTest
        {
        get { return mLabTest; }
        set { mLabTest = value; }
        }

        private Kroll.Pharmacy.Api.Data.SideEffectPhysicianContact mPhysicianContact
            = Kroll.Pharmacy.Api.Data.SideEffectPhysicianContact.SideEffectPhysicianContact_ContactPhysicianOnlyIfBecomesBothersome;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"PhysicianContact", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.SideEffectPhysicianContact.SideEffectPhysicianContact_ContactPhysicianOnlyIfBecomesBothersome)]
        
        public Kroll.Pharmacy.Api.Data.SideEffectPhysicianContact PhysicianContact
        {
        get { return mPhysicianContact; }
        set { mPhysicianContact = value; }
        }

        private bool mHypersensitivity
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Hypersensitivity", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Hypersensitivity
        {
        get { return mHypersensitivity; }
        set { mHypersensitivity = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        