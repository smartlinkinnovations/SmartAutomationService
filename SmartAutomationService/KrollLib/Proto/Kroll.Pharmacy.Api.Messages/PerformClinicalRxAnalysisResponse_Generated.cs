
        // Generated from: PerformClinicalRxAnalysisResponse.proto
        // Note: requires additional types generated from: PerformClinicalRxAnalysisResponseData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PerformClinicalRxAnalysisResponse")]
        public partial class PerformClinicalRxAnalysisResponse : global::ProtoBuf.IExtensible
        {
        public PerformClinicalRxAnalysisResponse() {}
        

        private Kroll.Pharmacy.Api.ActionData.PerformClinicalRxAnalysisResponseData mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.PerformClinicalRxAnalysisResponseData ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        