
        // Generated from: DecompressDataRequest.proto
        // Note: requires additional types generated from: DecompressDataRequestData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DecompressDataRequest")]
        public partial class DecompressDataRequest : global::ProtoBuf.IExtensible
        {
        public DecompressDataRequest() {}
        

        private Kroll.Pharmacy.Api.ActionData.DecompressDataRequestData mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.DecompressDataRequestData RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        