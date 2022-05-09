
        // Generated from: CalculateUnitDoseCalendarResponse.proto
        // Note: requires additional types generated from: CalculateUnitDoseCalendarResponseData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CalculateUnitDoseCalendarResponse")]
        public partial class CalculateUnitDoseCalendarResponse : global::ProtoBuf.IExtensible
        {
        public CalculateUnitDoseCalendarResponse() {}
        

        private Kroll.Pharmacy.Api.ActionData.CalculateUnitDoseCalendarResponseData mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.CalculateUnitDoseCalendarResponseData ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        