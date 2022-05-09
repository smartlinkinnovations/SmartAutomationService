
        // Generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CentralMaintLink")]
        public partial class CentralMaintLink : global::ProtoBuf.IExtensible
        {
        public CentralMaintLink() {}
        
        private int mCentralMaintId;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CentralMaintId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int CentralMaintId
        {
        get { return mCentralMaintId; }
        set { mCentralMaintId = value; }
        }
        private int mCentralMaintHostDBId;
        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"CentralMaintHostDBId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int CentralMaintHostDBId
        {
        get { return mCentralMaintHostDBId; }
        set { mCentralMaintHostDBId = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        