
        // Generated from: PerformClinicalDrugAnalysisRequest.proto
        // Note: requires additional types generated from: PerformClinicalDrugAnalysisRequestData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PerformClinicalDrugAnalysisRequest")]
        public partial class PerformClinicalDrugAnalysisRequest : global::ProtoBuf.IExtensible
        {
        public PerformClinicalDrugAnalysisRequest() {}
        

        private Kroll.Pharmacy.Api.ActionData.PerformClinicalDrugAnalysisRequestData mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.PerformClinicalDrugAnalysisRequestData RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        