
        // Generated from: CreatePatChartResponse.proto
        // Note: requires additional types generated from: CreatePatChartResponseData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreatePatChartResponse")]
        public partial class CreatePatChartResponse : global::ProtoBuf.IExtensible
        {
        public CreatePatChartResponse() {}
        

        private Kroll.Pharmacy.Api.ActionData.CreatePatChartResponseData mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.CreatePatChartResponseData ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        