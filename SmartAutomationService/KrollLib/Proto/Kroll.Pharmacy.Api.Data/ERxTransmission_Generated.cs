
        // Generated from: ERxTransmission.proto
        // Note: requires additional types generated from: ERxTransmissionMessageType_Enum.proto
        // Note: requires additional types generated from: ERxTransmissionOrigin_Enum.proto
        // Note: requires additional types generated from: ERxTransmissionStatus_Enum.proto
        // Note: requires additional types generated from: CompressionType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ERxTransmission")]
        public partial class ERxTransmission : global::ProtoBuf.IExtensible
        {
        public ERxTransmission() {}
        

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

        private int mERxId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ERxId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ERxId
        {
        get { return mERxId; }
        set { mERxId = value; }
        }

        private bool mERxIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ERxIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ERxIdSpecified
        {
        get { return mERxIdSpecified; }
        set { mERxIdSpecified = value; }
        }

        private int mExternalInterfaceId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ExternalInterfaceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ExternalInterfaceId
        {
        get { return mExternalInterfaceId; }
        set { mExternalInterfaceId = value; }
        }

        private string mExternalMessageId
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ExternalMessageId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalMessageId
        {
        get { return mExternalMessageId; }
        set { mExternalMessageId = value; }
        }

        private Kroll.Pharmacy.Api.Data.ERxTransmissionMessageType mMessageType
            = Kroll.Pharmacy.Api.Data.ERxTransmissionMessageType.ERxTransmissionMessageType_Unknown;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"MessageType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ERxTransmissionMessageType.ERxTransmissionMessageType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ERxTransmissionMessageType MessageType
        {
        get { return mMessageType; }
        set { mMessageType = value; }
        }

        private Kroll.Pharmacy.Api.Data.ERxTransmissionOrigin mOrigin
            = Kroll.Pharmacy.Api.Data.ERxTransmissionOrigin.ERxTransmissionOrigin_External;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Origin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ERxTransmissionOrigin.ERxTransmissionOrigin_External)]
        
        public Kroll.Pharmacy.Api.Data.ERxTransmissionOrigin Origin
        {
        get { return mOrigin; }
        set { mOrigin = value; }
        }

        private double mTransmissionDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"TransmissionDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TransmissionDate
        {
        get { return mTransmissionDate; }
        set { mTransmissionDate = value; }
        }

        private bool mTransmissionDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"TransmissionDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TransmissionDateSpecified
        {
        get { return mTransmissionDateSpecified; }
        set { mTransmissionDateSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.ERxTransmissionStatus mTransmissionStatus
            = Kroll.Pharmacy.Api.Data.ERxTransmissionStatus.ERxTransmissionStatus_NotSent;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"TransmissionStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ERxTransmissionStatus.ERxTransmissionStatus_NotSent)]
        
        public Kroll.Pharmacy.Api.Data.ERxTransmissionStatus TransmissionStatus
        {
        get { return mTransmissionStatus; }
        set { mTransmissionStatus = value; }
        }

        private string mTransmissionErrors
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"TransmissionErrors", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string TransmissionErrors
        {
        get { return mTransmissionErrors; }
        set { mTransmissionErrors = value; }
        }

        private byte[] mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }

        private Kroll.Pharmacy.Api.Data.CompressionType mRequestDataCompressionType
            = Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"RequestDataCompressionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.CompressionType RequestDataCompressionType
        {
        get { return mRequestDataCompressionType; }
        set { mRequestDataCompressionType = value; }
        }

        private byte[] mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }

        private Kroll.Pharmacy.Api.Data.CompressionType mResponseDataCompressionType
            = Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ResponseDataCompressionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.CompressionType ResponseDataCompressionType
        {
        get { return mResponseDataCompressionType; }
        set { mResponseDataCompressionType = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateCreated
        {
        get { return mDateCreated; }
        set { mDateCreated = value; }
        }

        private bool mDateCreatedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateCreatedSpecified
        {
        get { return mDateCreatedSpecified; }
        set { mDateCreatedSpecified = value; }
        }

        private double mDateChanged
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateChanged
        {
        get { return mDateChanged; }
        set { mDateChanged = value; }
        }

        private bool mDateChangedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private string mRequestDataEncoding
            = "";
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"RequestDataEncoding", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RequestDataEncoding
        {
        get { return mRequestDataEncoding; }
        set { mRequestDataEncoding = value; }
        }

        private string mResponseDataEncoding
            = "";
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"ResponseDataEncoding", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResponseDataEncoding
        {
        get { return mResponseDataEncoding; }
        set { mResponseDataEncoding = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        