
        // Generated from: UpdateDrugPackInventoryRequestData.proto
        // Note: requires additional types generated from: UpdateDrugPackInventoryChangeValueType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateDrugPackInventoryRequestData")]
        public partial class UpdateDrugPackInventoryRequestData : global::ProtoBuf.IExtensible
        {
        public UpdateDrugPackInventoryRequestData() {}
        

        private int mDrugPackId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DrugPackId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrugPackId
        {
        get { return mDrugPackId; }
        set { mDrugPackId = value; }
        }

        private Kroll.Pharmacy.Api.ActionData.UpdateDrugPackInventoryChangeValueType mChangeValueType
            = Kroll.Pharmacy.Api.ActionData.UpdateDrugPackInventoryChangeValueType.UpdateDrugPackInventoryChangeValueType_None;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ChangeValueType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.UpdateDrugPackInventoryChangeValueType.UpdateDrugPackInventoryChangeValueType_None)]
        
        public Kroll.Pharmacy.Api.ActionData.UpdateDrugPackInventoryChangeValueType ChangeValueType
        {
        get { return mChangeValueType; }
        set { mChangeValueType = value; }
        }

        private double mChangeValue
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ChangeValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChangeValue
        {
        get { return mChangeValue; }
        set { mChangeValue = value; }
        }

        private string mReason
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Reason", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Reason
        {
        get { return mReason; }
        set { mReason = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        