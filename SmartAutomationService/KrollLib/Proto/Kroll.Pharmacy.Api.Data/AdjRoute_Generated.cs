
        // Generated from: AdjRoute.proto
        // Note: requires additional types generated from: AdjNodeType_Enum.proto
        // Note: requires additional types generated from: Parity_Enum.proto
        // Note: requires additional types generated from: AdjTransmissionProtocol_Enum.proto
        // Note: requires additional types generated from: AdjRouteType_Enum.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AdjRoute")]
        public partial class AdjRoute : global::ProtoBuf.IExtensible
        {
        public AdjRoute() {}
        

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

        private string mName
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Name
        {
        get { return mName; }
        set { mName = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdjNodeType mNodeType
            = Kroll.Pharmacy.Api.Data.AdjNodeType.AdjNodeType_NotSet;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"NodeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdjNodeType.AdjNodeType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.AdjNodeType NodeType
        {
        get { return mNodeType; }
        set { mNodeType = value; }
        }

        private string mModemInit
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ModemInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ModemInit
        {
        get { return mModemInit; }
        set { mModemInit = value; }
        }

        private int mBaud
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Baud", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Baud
        {
        get { return mBaud; }
        set { mBaud = value; }
        }

        private bool mBaudSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"BaudSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BaudSpecified
        {
        get { return mBaudSpecified; }
        set { mBaudSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.Parity mParity
            = Kroll.Pharmacy.Api.Data.Parity.Parity_None;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Parity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.Parity.Parity_None)]
        
        public Kroll.Pharmacy.Api.Data.Parity Parity
        {
        get { return mParity; }
        set { mParity = value; }
        }

        private int mDataBits
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DataBits", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DataBits
        {
        get { return mDataBits; }
        set { mDataBits = value; }
        }

        private bool mDataBitsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DataBitsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DataBitsSpecified
        {
        get { return mDataBitsSpecified; }
        set { mDataBitsSpecified = value; }
        }

        private int mStopBits
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"StopBits", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StopBits
        {
        get { return mStopBits; }
        set { mStopBits = value; }
        }

        private bool mStopBitsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"StopBitsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StopBitsSpecified
        {
        get { return mStopBitsSpecified; }
        set { mStopBitsSpecified = value; }
        }

        private string mPhone
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Phone
        {
        get { return mPhone; }
        set { mPhone = value; }
        }

        private byte[] mLoginString
            = null;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"LoginString", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] LoginString
        {
        get { return mLoginString; }
        set { mLoginString = value; }
        }

        private int mDialTimeout
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DialTimeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DialTimeout
        {
        get { return mDialTimeout; }
        set { mDialTimeout = value; }
        }

        private string mIPAddress
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"IPAddress", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string IPAddress
        {
        get { return mIPAddress; }
        set { mIPAddress = value; }
        }

        private int mPortNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"PortNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PortNum
        {
        get { return mPortNum; }
        set { mPortNum = value; }
        }

        private bool mPortNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"PortNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PortNumSpecified
        {
        get { return mPortNumSpecified; }
        set { mPortNumSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdjTransmissionProtocol mProtocol
            = Kroll.Pharmacy.Api.Data.AdjTransmissionProtocol.AdjTransmissionProtocol_Default;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"Protocol", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdjTransmissionProtocol.AdjTransmissionProtocol_Default)]
        
        public Kroll.Pharmacy.Api.Data.AdjTransmissionProtocol Protocol
        {
        get { return mProtocol; }
        set { mProtocol = value; }
        }

        private bool mIsDown
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"IsDown", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsDown
        {
        get { return mIsDown; }
        set { mIsDown = value; }
        }

        private int mDefaultRetryMinutes
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DefaultRetryMinutes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DefaultRetryMinutes
        {
        get { return mDefaultRetryMinutes; }
        set { mDefaultRetryMinutes = value; }
        }

        private bool mDefaultRetryMinutesSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"DefaultRetryMinutesSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DefaultRetryMinutesSpecified
        {
        get { return mDefaultRetryMinutesSpecified; }
        set { mDefaultRetryMinutesSpecified = value; }
        }

        private double mRetryAt
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"RetryAt", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RetryAt
        {
        get { return mRetryAt; }
        set { mRetryAt = value; }
        }

        private bool mRetryAtSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"RetryAtSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RetryAtSpecified
        {
        get { return mRetryAtSpecified; }
        set { mRetryAtSpecified = value; }
        }

        private string mVPNConnection
            = "";
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"VPNConnection", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string VPNConnection
        {
        get { return mVPNConnection; }
        set { mVPNConnection = value; }
        }

        private bool mNoHangup
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"NoHangup", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoHangup
        {
        get { return mNoHangup; }
        set { mNoHangup = value; }
        }

        private int mNoHangupTimeout
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"NoHangupTimeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NoHangupTimeout
        {
        get { return mNoHangupTimeout; }
        set { mNoHangupTimeout = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink CentralMaintLink
        {
        get { return mCentralMaintLink; }
        set { mCentralMaintLink = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private string mCertificateFileName
            = "";
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"CertificateFileName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CertificateFileName
        {
        get { return mCertificateFileName; }
        set { mCertificateFileName = value; }
        }

        private int mMaxThreads
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"MaxThreads", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MaxThreads
        {
        get { return mMaxThreads; }
        set { mMaxThreads = value; }
        }

        private bool mMaxThreadsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"MaxThreadsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MaxThreadsSpecified
        {
        get { return mMaxThreadsSpecified; }
        set { mMaxThreadsSpecified = value; }
        }

        private string mRemoteCertificateName
            = "";
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"RemoteCertificateName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RemoteCertificateName
        {
        get { return mRemoteCertificateName; }
        set { mRemoteCertificateName = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdjRouteType mRouteType
            = Kroll.Pharmacy.Api.Data.AdjRouteType.AdjRouteType_Production;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"RouteType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdjRouteType.AdjRouteType_Production)]
        
        public Kroll.Pharmacy.Api.Data.AdjRouteType RouteType
        {
        get { return mRouteType; }
        set { mRouteType = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        