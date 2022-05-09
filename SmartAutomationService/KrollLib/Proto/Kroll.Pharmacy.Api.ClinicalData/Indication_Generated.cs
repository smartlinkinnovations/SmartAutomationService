
        // Generated from: Indication.proto
        // Note: requires additional types generated from: IndicationLabeledCode_Enum.proto
        // Note: requires additional types generated from: MedicalConditionCodeType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Indication")]
        public partial class Indication : global::ProtoBuf.IExtensible
        {
        public Indication() {}
        

        private Kroll.Pharmacy.Api.Data.MedicalConditionCodeType mMedicalConditionCodeType
            = Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_Unknown;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"MedicalConditionCodeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MedicalConditionCodeType.MedicalConditionCodeType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.MedicalConditionCodeType MedicalConditionCodeType
        {
        get { return mMedicalConditionCodeType; }
        set { mMedicalConditionCodeType = value; }
        }

        private string mMedicalConditionCode
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"MedicalConditionCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MedicalConditionCode
        {
        get { return mMedicalConditionCode; }
        set { mMedicalConditionCode = value; }
        }

        private string mMedicalConditionDescription
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"MedicalConditionDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MedicalConditionDescription
        {
        get { return mMedicalConditionDescription; }
        set { mMedicalConditionDescription = value; }
        }

        private Kroll.Pharmacy.Api.Data.IndicationLabeledCode mIndicationLabeledCode
            = Kroll.Pharmacy.Api.Data.IndicationLabeledCode.IndicationLabeledCode_Unknown;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"IndicationLabeledCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.IndicationLabeledCode.IndicationLabeledCode_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.IndicationLabeledCode IndicationLabeledCode
        {
        get { return mIndicationLabeledCode; }
        set { mIndicationLabeledCode = value; }
        }

        private int mSequence
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Sequence", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Sequence
        {
        get { return mSequence; }
        set { mSequence = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        