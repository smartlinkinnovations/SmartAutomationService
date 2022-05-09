
        // Generated from: ReportingServiceHost.proto
        // Note: requires additional types generated from: ReportingServiceType_Enum.proto
        // Note: requires additional types generated from: ReportingServiceHostStatus_Enum.proto
        // Note: requires additional types generated from: ReportingServiceNH.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReportingServiceHost")]
        public partial class ReportingServiceHost : global::ProtoBuf.IExtensible
        {
        public ReportingServiceHost() {}
        

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

        private Kroll.Pharmacy.Api.Data.ReportingServiceType mServiceType
            = Kroll.Pharmacy.Api.Data.ReportingServiceType.ReportingServiceType_Unknown;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ServiceType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ReportingServiceType.ReportingServiceType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ReportingServiceType ServiceType
        {
        get { return mServiceType; }
        set { mServiceType = value; }
        }

        private string mWsURL
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"WsURL", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string WsURL
        {
        get { return mWsURL; }
        set { mWsURL = value; }
        }

        private string mPharmacyId
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"PharmacyId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PharmacyId
        {
        get { return mPharmacyId; }
        set { mPharmacyId = value; }
        }

        private string mUserName
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"UserName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserName
        {
        get { return mUserName; }
        set { mUserName = value; }
        }

        private string mHttpUsername
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"HttpUsername", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string HttpUsername
        {
        get { return mHttpUsername; }
        set { mHttpUsername = value; }
        }

        private string mIncomingClientId
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"IncomingClientId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string IncomingClientId
        {
        get { return mIncomingClientId; }
        set { mIncomingClientId = value; }
        }

        private string mIncomingUsername
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"IncomingUsername", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string IncomingUsername
        {
        get { return mIncomingUsername; }
        set { mIncomingUsername = value; }
        }

        private string mCertificateFilename
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"CertificateFilename", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CertificateFilename
        {
        get { return mCertificateFilename; }
        set { mCertificateFilename = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private Kroll.Pharmacy.Api.Data.ReportingServiceHostStatus mHostStatus
            = Kroll.Pharmacy.Api.Data.ReportingServiceHostStatus.ReportingServiceHostStatus_Unknown;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"HostStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ReportingServiceHostStatus.ReportingServiceHostStatus_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ReportingServiceHostStatus HostStatus
        {
        get { return mHostStatus; }
        set { mHostStatus = value; }
        }

        private double mLastActivity
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"LastActivity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastActivity
        {
        get { return mLastActivity; }
        set { mLastActivity = value; }
        }

        private bool mLastActivitySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"LastActivitySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastActivitySpecified
        {
        get { return mLastActivitySpecified; }
        set { mLastActivitySpecified = value; }
        }

        private int mExternalInterfaceId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"ExternalInterfaceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ExternalInterfaceId
        {
        get { return mExternalInterfaceId; }
        set { mExternalInterfaceId = value; }
        }

        private int mExternalInterfaceIdSpecified
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"ExternalInterfaceIdSpecified", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ExternalInterfaceIdSpecified
        {
        get { return mExternalInterfaceIdSpecified; }
        set { mExternalInterfaceIdSpecified = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private int mStoreIdSpecified
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"StoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreIdSpecified
        {
        get { return mStoreIdSpecified; }
        set { mStoreIdSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ReportingServiceNH> mValidNursingHomes = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ReportingServiceNH>();
        [global::ProtoBuf.ProtoMember(20, Name=@"ValidNursingHomes", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ReportingServiceNH> ValidNursingHomes
        {
        get { return mValidNursingHomes; }
        }
    

        private byte[] mContextInfo
            = null;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ContextInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ContextInfo
        {
        get { return mContextInfo; }
        set { mContextInfo = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private string mOrganizationId
            = "";
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"OrganizationId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OrganizationId
        {
        get { return mOrganizationId; }
        set { mOrganizationId = value; }
        }

        private int mMailDistributionListId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"MailDistributionListId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MailDistributionListId
        {
        get { return mMailDistributionListId; }
        set { mMailDistributionListId = value; }
        }

        private bool mMailDistributionListIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"MailDistributionListIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MailDistributionListIdSpecified
        {
        get { return mMailDistributionListIdSpecified; }
        set { mMailDistributionListIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        