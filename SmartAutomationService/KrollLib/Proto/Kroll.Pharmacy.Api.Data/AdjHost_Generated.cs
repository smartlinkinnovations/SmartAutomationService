
        // Generated from: AdjHost.proto
        // Note: requires additional types generated from: AdjHostId_Enum.proto
        // Note: requires additional types generated from: AdjClaimFormat_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AdjHost")]
        public partial class AdjHost : global::ProtoBuf.IExtensible
        {
        public AdjHost() {}
        

        private Kroll.Pharmacy.Api.Data.AdjHostId mAdjHostId
            = Kroll.Pharmacy.Api.Data.AdjHostId.AdjHostId_None;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"AdjHostId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdjHostId.AdjHostId_None)]
        
        public Kroll.Pharmacy.Api.Data.AdjHostId AdjHostId
        {
        get { return mAdjHostId; }
        set { mAdjHostId = value; }
        }

        private string mBin
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Bin", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Bin
        {
        get { return mBin; }
        set { mBin = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdjClaimFormat mDataFormat
            = Kroll.Pharmacy.Api.Data.AdjClaimFormat.AdjClaimFormat_Unknown;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DataFormat", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdjClaimFormat.AdjClaimFormat_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.AdjClaimFormat DataFormat
        {
        get { return mDataFormat; }
        set { mDataFormat = value; }
        }

        private int mPrimaryRouteId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"PrimaryRouteId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PrimaryRouteId
        {
        get { return mPrimaryRouteId; }
        set { mPrimaryRouteId = value; }
        }

        private bool mPrimaryRouteIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PrimaryRouteIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrimaryRouteIdSpecified
        {
        get { return mPrimaryRouteIdSpecified; }
        set { mPrimaryRouteIdSpecified = value; }
        }

        private int mSecondaryRouteId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"SecondaryRouteId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SecondaryRouteId
        {
        get { return mSecondaryRouteId; }
        set { mSecondaryRouteId = value; }
        }

        private bool mSecondaryRouteIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"SecondaryRouteIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SecondaryRouteIdSpecified
        {
        get { return mSecondaryRouteIdSpecified; }
        set { mSecondaryRouteIdSpecified = value; }
        }

        private string mDna
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Dna", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Dna
        {
        get { return mDna; }
        set { mDna = value; }
        }

        private string mIPAddress
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"IPAddress", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"PortNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"PortNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PortNumSpecified
        {
        get { return mPortNumSpecified; }
        set { mPortNumSpecified = value; }
        }

        private int mTransmitTimeout
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"TransmitTimeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int TransmitTimeout
        {
        get { return mTransmitTimeout; }
        set { mTransmitTimeout = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        