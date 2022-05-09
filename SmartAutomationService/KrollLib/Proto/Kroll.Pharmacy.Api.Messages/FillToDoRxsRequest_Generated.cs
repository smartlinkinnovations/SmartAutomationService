
        // Generated from: FillToDoRxsRequest.proto
        // Note: requires additional types generated from: FillToDoRxsRequestData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FillToDoRxsRequest")]
        public partial class FillToDoRxsRequest : global::ProtoBuf.IExtensible
        {
        public FillToDoRxsRequest() {}
        

        private Kroll.Pharmacy.Api.ActionData.FillToDoRxsRequestData mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.FillToDoRxsRequestData RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        