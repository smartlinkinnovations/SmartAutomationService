
        // Generated from: UpdateLog.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateLog")]
        public partial class UpdateLog : global::ProtoBuf.IExtensible
        {
        public UpdateLog() {}
        

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

        private int mUpdateClass
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"UpdateClass", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UpdateClass
        {
        get { return mUpdateClass; }
        set { mUpdateClass = value; }
        }

        private int mUpdateType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"UpdateType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UpdateType
        {
        get { return mUpdateType; }
        set { mUpdateType = value; }
        }

        private string mVersion
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Version", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Version
        {
        get { return mVersion; }
        set { mVersion = value; }
        }

        private int mStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private double mInstallDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"InstallDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double InstallDate
        {
        get { return mInstallDate; }
        set { mInstallDate = value; }
        }

        private bool mInstallDirection
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"InstallDirection", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InstallDirection
        {
        get { return mInstallDirection; }
        set { mInstallDirection = value; }
        }

        private string mLog
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Log", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Log
        {
        get { return mLog; }
        set { mLog = value; }
        }

        private string mConfigFile
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"ConfigFile", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ConfigFile
        {
        get { return mConfigFile; }
        set { mConfigFile = value; }
        }

        private string mUpdateFilename
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"UpdateFilename", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UpdateFilename
        {
        get { return mUpdateFilename; }
        set { mUpdateFilename = value; }
        }

        private string mCommandHistory
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"CommandHistory", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CommandHistory
        {
        get { return mCommandHistory; }
        set { mCommandHistory = value; }
        }

        private int mUpdateComponentId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"UpdateComponentId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UpdateComponentId
        {
        get { return mUpdateComponentId; }
        set { mUpdateComponentId = value; }
        }

        private bool mUpdateComponentIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"UpdateComponentIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UpdateComponentIdSpecified
        {
        get { return mUpdateComponentIdSpecified; }
        set { mUpdateComponentIdSpecified = value; }
        }

        private int mUpdatePackageId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"UpdatePackageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UpdatePackageId
        {
        get { return mUpdatePackageId; }
        set { mUpdatePackageId = value; }
        }

        private bool mUpdatePackageIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"UpdatePackageIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UpdatePackageIdSpecified
        {
        get { return mUpdatePackageIdSpecified; }
        set { mUpdatePackageIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        