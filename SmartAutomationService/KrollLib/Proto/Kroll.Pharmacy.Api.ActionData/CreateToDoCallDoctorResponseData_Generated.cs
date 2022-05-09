
        // Generated from: CreateToDoCallDoctorResponseData.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
        // Note: requires additional types generated from: CreateToDoCallDoctorResponseType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateToDoCallDoctorResponseData")]
        public partial class CreateToDoCallDoctorResponseData : global::ProtoBuf.IExtensible
        {
        public CreateToDoCallDoctorResponseData() {}
        

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

        private Kroll.Pharmacy.Api.ActionData.CreateToDoCallDoctorResponseType mResponseType
            = Kroll.Pharmacy.Api.ActionData.CreateToDoCallDoctorResponseType.CreateToDoCallDoctorResponseType_Accepted;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ResponseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.CreateToDoCallDoctorResponseType.CreateToDoCallDoctorResponseType_Accepted)]
        
        public Kroll.Pharmacy.Api.ActionData.CreateToDoCallDoctorResponseType ResponseType
        {
        get { return mResponseType; }
        set { mResponseType = value; }
        }

        private int mToDoId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ToDoId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ToDoId
        {
        get { return mToDoId; }
        set { mToDoId = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        