
        // Generated from: CFHost.proto
        // Note: requires additional types generated from: CFHostType_Enum.proto
        // Note: requires additional types generated from: CFPackager.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CFHost")]
        public partial class CFHost : global::ProtoBuf.IExtensible
        {
        public CFHost() {}
        

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

        private Kroll.Pharmacy.Api.Data.CFHostType mCFType
            = Kroll.Pharmacy.Api.Data.CFHostType.CFHostType_Unknown;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"CFType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CFHostType.CFHostType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.CFHostType CFType
        {
        get { return mCFType; }
        set { mCFType = value; }
        }

        private string mCustId
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"CustId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CustId
        {
        get { return mCustId; }
        set { mCustId = value; }
        }

        private string mServer
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Server", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Server
        {
        get { return mServer; }
        set { mServer = value; }
        }

        private bool mTrackIfShipped
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"TrackIfShipped", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TrackIfShipped
        {
        get { return mTrackIfShipped; }
        set { mTrackIfShipped = value; }
        }

        private bool mTrackIfReceived
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"TrackIfReceived", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TrackIfReceived
        {
        get { return mTrackIfReceived; }
        set { mTrackIfReceived = value; }
        }

        private bool mUseBarCodesWhenReconciling
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"UseBarCodesWhenReconciling", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseBarCodesWhenReconciling
        {
        get { return mUseBarCodesWhenReconciling; }
        set { mUseBarCodesWhenReconciling = value; }
        }

        private string mPostal
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Postal", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Postal
        {
        get { return mPostal; }
        set { mPostal = value; }
        }

        private string mIMSClientId
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"IMSClientId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string IMSClientId
        {
        get { return mIMSClientId; }
        set { mIMSClientId = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.CFPackager> mCFPackager = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.CFPackager>();
        [global::ProtoBuf.ProtoMember(12, Name=@"CFPackager", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.CFPackager> CFPackager
        {
        get { return mCFPackager; }
        }
    

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        