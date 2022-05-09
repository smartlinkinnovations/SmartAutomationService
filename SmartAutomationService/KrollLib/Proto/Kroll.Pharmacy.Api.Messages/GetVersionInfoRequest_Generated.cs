
        // Generated from: GetVersionInfoRequest.proto
        // Note: requires additional types generated from: GetVersionInfoRequestData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetVersionInfoRequest")]
        public partial class GetVersionInfoRequest : global::ProtoBuf.IExtensible
        {
        public GetVersionInfoRequest() {}
        

        private Kroll.Pharmacy.Api.ActionData.GetVersionInfoRequestData mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.GetVersionInfoRequestData RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        