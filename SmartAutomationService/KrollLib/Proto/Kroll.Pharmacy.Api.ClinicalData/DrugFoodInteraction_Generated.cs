
        // Generated from: DrugFoodInteraction.proto
        // Note: requires additional types generated from: DrugFoodInteractionSeverity_Enum.proto
        // Note: requires additional types generated from: DrugFoodInteractionMonograph.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrugFoodInteraction")]
        public partial class DrugFoodInteraction : global::ProtoBuf.IExtensible
        {
        public DrugFoodInteraction() {}
        

        private Kroll.Pharmacy.Api.Data.DrugFoodInteractionSeverity mSeverity
            = Kroll.Pharmacy.Api.Data.DrugFoodInteractionSeverity.DrugFoodInteractionSeverity_MostSignificant;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Severity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrugFoodInteractionSeverity.DrugFoodInteractionSeverity_MostSignificant)]
        
        public Kroll.Pharmacy.Api.Data.DrugFoodInteractionSeverity Severity
        {
        get { return mSeverity; }
        set { mSeverity = value; }
        }

        private string mInteractionResult
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"InteractionResult", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string InteractionResult
        {
        get { return mInteractionResult; }
        set { mInteractionResult = value; }
        }

        private string mInteractionMessage
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"InteractionMessage", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string InteractionMessage
        {
        get { return mInteractionMessage; }
        set { mInteractionMessage = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrugFoodInteractionMonograph mMonograph
            = null;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Monograph", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.DrugFoodInteractionMonograph Monograph
        {
        get { return mMonograph; }
        set { mMonograph = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        