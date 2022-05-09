
        // Generated from: CalculateUnitDoseCalendarRequest.proto
        // Note: requires additional types generated from: CalculateUnitDoseCalendarRequestData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CalculateUnitDoseCalendarRequest")]
        public partial class CalculateUnitDoseCalendarRequest : global::ProtoBuf.IExtensible
        {
        public CalculateUnitDoseCalendarRequest() {}
        

        private Kroll.Pharmacy.Api.ActionData.CalculateUnitDoseCalendarRequestData mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.CalculateUnitDoseCalendarRequestData RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        