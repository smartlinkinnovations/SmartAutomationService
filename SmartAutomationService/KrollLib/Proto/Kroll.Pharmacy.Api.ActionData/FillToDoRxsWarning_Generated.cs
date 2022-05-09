
        // Generated from: FillToDoRxsWarning.proto
        // Note: requires additional types generated from: FillToDoRxsWarningType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FillToDoRxsWarning")]
        public partial class FillToDoRxsWarning : global::ProtoBuf.IExtensible
        {
        public FillToDoRxsWarning() {}
        

        private Kroll.Pharmacy.Api.ActionData.FillToDoRxsWarningType mWarningType
            = Kroll.Pharmacy.Api.ActionData.FillToDoRxsWarningType.FillToDoRxsWarningType_Error;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"WarningType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.FillToDoRxsWarningType.FillToDoRxsWarningType_Error)]
        
        public Kroll.Pharmacy.Api.ActionData.FillToDoRxsWarningType WarningType
        {
        get { return mWarningType; }
        set { mWarningType = value; }
        }

        private int mWarningId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"WarningId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int WarningId
        {
        get { return mWarningId; }
        set { mWarningId = value; }
        }

        private string mWarning
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Warning", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Warning
        {
        get { return mWarning; }
        set { mWarning = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        