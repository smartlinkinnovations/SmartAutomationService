
        // Generated from: VendorStoreLink.proto
        // Note: requires additional types generated from: VendorRemoteServerType_Enum.proto
        // Note: requires additional types generated from: VendorExternalConnectionType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"VendorStoreLink")]
        public partial class VendorStoreLink : global::ProtoBuf.IExtensible
        {
        public VendorStoreLink() {}
        

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

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private int mVendorId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"VendorId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int VendorId
        {
        get { return mVendorId; }
        set { mVendorId = value; }
        }

        private string mCustomerNumber1
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"CustomerNumber1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CustomerNumber1
        {
        get { return mCustomerNumber1; }
        set { mCustomerNumber1 = value; }
        }

        private string mCustomerNumber2
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"CustomerNumber2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CustomerNumber2
        {
        get { return mCustomerNumber2; }
        set { mCustomerNumber2 = value; }
        }

        private byte[] mParams
            = null;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Params", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] Params
        {
        get { return mParams; }
        set { mParams = value; }
        }

        private string mLocalTempFolder
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"LocalTempFolder", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LocalTempFolder
        {
        get { return mLocalTempFolder; }
        set { mLocalTempFolder = value; }
        }

        private Kroll.Pharmacy.Api.Data.VendorRemoteServerType mRemoteServerType
            = Kroll.Pharmacy.Api.Data.VendorRemoteServerType.VendorRemoteServerType_Ftp;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"RemoteServerType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.VendorRemoteServerType.VendorRemoteServerType_Ftp)]
        
        public Kroll.Pharmacy.Api.Data.VendorRemoteServerType RemoteServerType
        {
        get { return mRemoteServerType; }
        set { mRemoteServerType = value; }
        }

        private string mRemoteServer
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"RemoteServer", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RemoteServer
        {
        get { return mRemoteServer; }
        set { mRemoteServer = value; }
        }

        private string mRemoteUserName
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"RemoteUserName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RemoteUserName
        {
        get { return mRemoteUserName; }
        set { mRemoteUserName = value; }
        }

        private string mRemotePassword
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"RemotePassword", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RemotePassword
        {
        get { return mRemotePassword; }
        set { mRemotePassword = value; }
        }

        private string mRemoteOrderPath
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"RemoteOrderPath", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RemoteOrderPath
        {
        get { return mRemoteOrderPath; }
        set { mRemoteOrderPath = value; }
        }

        private string mRemoteOrderBackupPath
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"RemoteOrderBackupPath", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RemoteOrderBackupPath
        {
        get { return mRemoteOrderBackupPath; }
        set { mRemoteOrderBackupPath = value; }
        }

        private string mRemoteCatalogPath
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"RemoteCatalogPath", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RemoteCatalogPath
        {
        get { return mRemoteCatalogPath; }
        set { mRemoteCatalogPath = value; }
        }

        private string mRemoteInvoicePath
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"RemoteInvoicePath", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RemoteInvoicePath
        {
        get { return mRemoteInvoicePath; }
        set { mRemoteInvoicePath = value; }
        }

        private string mRemoteInvoiceBackupPath
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"RemoteInvoiceBackupPath", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RemoteInvoiceBackupPath
        {
        get { return mRemoteInvoiceBackupPath; }
        set { mRemoteInvoiceBackupPath = value; }
        }

        private Kroll.Pharmacy.Api.Data.VendorExternalConnectionType mExternalConnectionType
            = Kroll.Pharmacy.Api.Data.VendorExternalConnectionType.VendorExternalConnectionType_None;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"ExternalConnectionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.VendorExternalConnectionType.VendorExternalConnectionType_None)]
        
        public Kroll.Pharmacy.Api.Data.VendorExternalConnectionType ExternalConnectionType
        {
        get { return mExternalConnectionType; }
        set { mExternalConnectionType = value; }
        }

        private string mExternalConnectionUserName
            = "";
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"ExternalConnectionUserName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalConnectionUserName
        {
        get { return mExternalConnectionUserName; }
        set { mExternalConnectionUserName = value; }
        }

        private string mExternalConnectionPassword
            = "";
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"ExternalConnectionPassword", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalConnectionPassword
        {
        get { return mExternalConnectionPassword; }
        set { mExternalConnectionPassword = value; }
        }

        private string mExternalConnectionProfileName
            = "";
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"ExternalConnectionProfileName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalConnectionProfileName
        {
        get { return mExternalConnectionProfileName; }
        set { mExternalConnectionProfileName = value; }
        }

        private string mExternalConnectionClientPath
            = "";
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"ExternalConnectionClientPath", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalConnectionClientPath
        {
        get { return mExternalConnectionClientPath; }
        set { mExternalConnectionClientPath = value; }
        }

        private int mRemoteServerPort
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"RemoteServerPort", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RemoteServerPort
        {
        get { return mRemoteServerPort; }
        set { mRemoteServerPort = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        