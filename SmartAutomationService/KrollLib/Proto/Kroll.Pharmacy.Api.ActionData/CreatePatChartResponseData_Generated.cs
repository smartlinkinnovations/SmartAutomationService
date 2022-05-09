
        // Generated from: CreatePatChartResponseData.proto
        // Note: requires additional types generated from: CreatePatChartResponseType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreatePatChartResponseData")]
        public partial class CreatePatChartResponseData : global::ProtoBuf.IExtensible
        {
        public CreatePatChartResponseData() {}
        

        private bool mIsAccepted
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IsAccepted", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsAccepted
        {
        get { return mIsAccepted; }
        set { mIsAccepted = value; }
        }

        private Kroll.Pharmacy.Api.ActionData.CreatePatChartResponseType mResponseType
            = Kroll.Pharmacy.Api.ActionData.CreatePatChartResponseType.CreatePatChartResponseType_Accepted;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ResponseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.CreatePatChartResponseType.CreatePatChartResponseType_Accepted)]
        
        public Kroll.Pharmacy.Api.ActionData.CreatePatChartResponseType ResponseType
        {
        get { return mResponseType; }
        set { mResponseType = value; }
        }

        private int mPatChartId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"PatChartId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatChartId
        {
        get { return mPatChartId; }
        set { mPatChartId = value; }
        }

        private bool mPatChartIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"PatChartIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatChartIdSpecified
        {
        get { return mPatChartIdSpecified; }
        set { mPatChartIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        