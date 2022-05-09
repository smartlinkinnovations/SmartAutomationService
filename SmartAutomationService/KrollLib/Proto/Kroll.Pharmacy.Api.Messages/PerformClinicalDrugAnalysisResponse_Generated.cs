
        // Generated from: PerformClinicalDrugAnalysisResponse.proto
        // Note: requires additional types generated from: PerformClinicalDrugAnalysisResponseData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PerformClinicalDrugAnalysisResponse")]
        public partial class PerformClinicalDrugAnalysisResponse : global::ProtoBuf.IExtensible
        {
        public PerformClinicalDrugAnalysisResponse() {}
        

        private Kroll.Pharmacy.Api.ActionData.PerformClinicalDrugAnalysisResponseData mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.PerformClinicalDrugAnalysisResponseData ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        