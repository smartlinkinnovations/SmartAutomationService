
        // Generated from: PerformClinicalRxAnalysisRequest.proto
        // Note: requires additional types generated from: PerformClinicalRxAnalysisRequestData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PerformClinicalRxAnalysisRequest")]
        public partial class PerformClinicalRxAnalysisRequest : global::ProtoBuf.IExtensible
        {
        public PerformClinicalRxAnalysisRequest() {}
        

        private Kroll.Pharmacy.Api.ActionData.PerformClinicalRxAnalysisRequestData mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.PerformClinicalRxAnalysisRequestData RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        