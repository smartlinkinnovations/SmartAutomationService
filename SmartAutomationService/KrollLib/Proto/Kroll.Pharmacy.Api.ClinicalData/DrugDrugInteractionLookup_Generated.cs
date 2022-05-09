
        // Generated from: DrugDrugInteractionLookup.proto
        // Note: requires additional types generated from: DrugDrugInteractionSeverity_Enum.proto
        // Note: requires additional types generated from: DrugDrugInteractionMonograph.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrugDrugInteractionLookup")]
        public partial class DrugDrugInteractionLookup : global::ProtoBuf.IExtensible
        {
        public DrugDrugInteractionLookup() {}
        

        private Kroll.Pharmacy.Api.Data.DrugDrugInteractionSeverity mSeverity
            = Kroll.Pharmacy.Api.Data.DrugDrugInteractionSeverity.DrugDrugInteractionSeverity_Unknown;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Severity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrugDrugInteractionSeverity.DrugDrugInteractionSeverity_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.DrugDrugInteractionSeverity Severity
        {
        get { return mSeverity; }
        set { mSeverity = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private string mClinicalEffectCode
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ClinicalEffectCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ClinicalEffectCode
        {
        get { return mClinicalEffectCode; }
        set { mClinicalEffectCode = value; }
        }

        private string mClinicalEffect
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ClinicalEffect", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ClinicalEffect
        {
        get { return mClinicalEffect; }
        set { mClinicalEffect = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrugDrugInteractionMonograph mMonograph
            = null;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Monograph", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.DrugDrugInteractionMonograph Monograph
        {
        get { return mMonograph; }
        set { mMonograph = value; }
        }

        private string mAnalyzedDrugAgentCategory
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"AnalyzedDrugAgentCategory", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AnalyzedDrugAgentCategory
        {
        get { return mAnalyzedDrugAgentCategory; }
        set { mAnalyzedDrugAgentCategory = value; }
        }
        private readonly global::System.Collections.Generic.List<string> mAnalyzedDrugAgents = new global::System.Collections.Generic.List<string>();
        [global::ProtoBuf.ProtoMember(7, Name=@"AnalyzedDrugAgents", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<string> AnalyzedDrugAgents
        {
        get { return mAnalyzedDrugAgents; }
        }
    

        private string mInteractingDrugAgentCategory
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"InteractingDrugAgentCategory", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string InteractingDrugAgentCategory
        {
        get { return mInteractingDrugAgentCategory; }
        set { mInteractingDrugAgentCategory = value; }
        }
        private readonly global::System.Collections.Generic.List<string> mInteractingDrugAgents = new global::System.Collections.Generic.List<string>();
        [global::ProtoBuf.ProtoMember(9, Name=@"InteractingDrugAgents", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<string> InteractingDrugAgents
        {
        get { return mInteractingDrugAgents; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        