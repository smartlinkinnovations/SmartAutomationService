
        // Generated from: ExternalInterfacePermission.proto
        // Note: requires additional types generated from: ExternalInterfacePermissionType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ExternalInterfacePermission")]
        public partial class ExternalInterfacePermission : global::ProtoBuf.IExtensible
        {
        public ExternalInterfacePermission() {}
        

        private int mId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Id
        {
        get { return mId; }
        set { mId = value; }
        }

        private int mExternalInterfaceUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ExternalInterfaceUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ExternalInterfaceUserId
        {
        get { return mExternalInterfaceUserId; }
        set { mExternalInterfaceUserId = value; }
        }

        private Kroll.Pharmacy.Api.Data.ExternalInterfacePermissionType mPermissionType
            = Kroll.Pharmacy.Api.Data.ExternalInterfacePermissionType.ExternalInterfacePermissionType_Unknown;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"PermissionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ExternalInterfacePermissionType.ExternalInterfacePermissionType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ExternalInterfacePermissionType PermissionType
        {
        get { return mPermissionType; }
        set { mPermissionType = value; }
        }

        private string mValue
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Value", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Value
        {
        get { return mValue; }
        set { mValue = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        