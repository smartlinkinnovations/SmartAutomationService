
        // Generated from: CFPackager.proto
        // Note: requires additional types generated from: PackagerType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CFPackager")]
        public partial class CFPackager : global::ProtoBuf.IExtensible
        {
        public CFPackager() {}
        

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

        private int mCFHostId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"CFHostId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CFHostId
        {
        get { return mCFHostId; }
        set { mCFHostId = value; }
        }

        private bool mCFHostIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"CFHostIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CFHostIdSpecified
        {
        get { return mCFHostIdSpecified; }
        set { mCFHostIdSpecified = value; }
        }

        private string mHostPackagerId
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"HostPackagerId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string HostPackagerId
        {
        get { return mHostPackagerId; }
        set { mHostPackagerId = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private Kroll.Pharmacy.Api.Data.PackagerType mPackagerType
            = Kroll.Pharmacy.Api.Data.PackagerType.PackagerType_Unknown;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PackagerType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PackagerType.PackagerType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PackagerType PackagerType
        {
        get { return mPackagerType; }
        set { mPackagerType = value; }
        }

        private bool mUseShippingSchedule
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"UseShippingSchedule", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseShippingSchedule
        {
        get { return mUseShippingSchedule; }
        set { mUseShippingSchedule = value; }
        }

        private bool mPrintLabels
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"PrintLabels", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintLabels
        {
        get { return mPrintLabels; }
        set { mPrintLabels = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        