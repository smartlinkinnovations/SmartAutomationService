
        // Generated from: ExternalInterfaceUser.proto
        // Note: requires additional types generated from: ExternalInterfacePermission.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ExternalInterfaceUser")]
        public partial class ExternalInterfaceUser : global::ProtoBuf.IExtensible
        {
        public ExternalInterfaceUser() {}
        

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

        private string mUserName
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"UserName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserName
        {
        get { return mUserName; }
        set { mUserName = value; }
        }

        private byte[] mPassword
            = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Password", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] Password
        {
        get { return mPassword; }
        set { mPassword = value; }
        }

        private bool mEnabled
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Enabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Enabled
        {
        get { return mEnabled; }
        set { mEnabled = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalInterfacePermission> mPermissions = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalInterfacePermission>();
        [global::ProtoBuf.ProtoMember(5, Name=@"Permissions", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ExternalInterfacePermission> Permissions
        {
        get { return mPermissions; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        