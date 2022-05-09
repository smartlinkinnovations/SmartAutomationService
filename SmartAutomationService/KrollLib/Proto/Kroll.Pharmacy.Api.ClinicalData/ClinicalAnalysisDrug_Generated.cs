
        // Generated from: ClinicalAnalysisDrug.proto
        // Note: requires additional types generated from: ClinicalDrug.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ClinicalAnalysisDrug")]
        public partial class ClinicalAnalysisDrug : global::ProtoBuf.IExtensible
        {
        public ClinicalAnalysisDrug() {}
        

        private string mDin
            = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Din", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Din
        {
        get { return mDin; }
        set { mDin = value; }
        }

        private string mAlternateDin
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"AlternateDin", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AlternateDin
        {
        get { return mAlternateDin; }
        set { mAlternateDin = value; }
        }

        private Kroll.Pharmacy.Api.Data.ClinicalDrug mClinicalDrug
            = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ClinicalDrug", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.ClinicalDrug ClinicalDrug
        {
        get { return mClinicalDrug; }
        set { mClinicalDrug = value; }
        }

        private byte[] mContextInfo
            = null;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ContextInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] ContextInfo
        {
        get { return mContextInfo; }
        set { mContextInfo = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        