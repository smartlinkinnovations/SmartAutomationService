
        // Generated from: CreateScriptImageResponseData.proto
        // Note: requires additional types generated from: CreateScriptImageResponseType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateScriptImageResponseData")]
        public partial class CreateScriptImageResponseData : global::ProtoBuf.IExtensible
        {
        public CreateScriptImageResponseData() {}
        

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

        private Kroll.Pharmacy.Api.ActionData.CreateScriptImageResponseType mResponseType
            = Kroll.Pharmacy.Api.ActionData.CreateScriptImageResponseType.CreateScriptImageResponseType_Accepted;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ResponseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.CreateScriptImageResponseType.CreateScriptImageResponseType_Accepted)]
        
        public Kroll.Pharmacy.Api.ActionData.CreateScriptImageResponseType ResponseType
        {
        get { return mResponseType; }
        set { mResponseType = value; }
        }

        private int mScriptImageId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ScriptImageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ScriptImageId
        {
        get { return mScriptImageId; }
        set { mScriptImageId = value; }
        }

        private bool mScriptImageIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ScriptImageIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScriptImageIdSpecified
        {
        get { return mScriptImageIdSpecified; }
        set { mScriptImageIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        