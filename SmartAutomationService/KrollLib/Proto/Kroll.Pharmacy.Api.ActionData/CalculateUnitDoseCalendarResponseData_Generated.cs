
        // Generated from: CalculateUnitDoseCalendarResponseData.proto
        // Note: requires additional types generated from: CalculateUnitDoseCalendarAdminDose.proto
        // Note: requires additional types generated from: CalculateUnitDoseCalendarResponseType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CalculateUnitDoseCalendarResponseData")]
        public partial class CalculateUnitDoseCalendarResponseData : global::ProtoBuf.IExtensible
        {
        public CalculateUnitDoseCalendarResponseData() {}
        

        private bool mIsSuccessful
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IsSuccessful", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsSuccessful
        {
        get { return mIsSuccessful; }
        set { mIsSuccessful = value; }
        }

        private Kroll.Pharmacy.Api.ActionData.CalculateUnitDoseCalendarResponseType mResponseType
            = Kroll.Pharmacy.Api.ActionData.CalculateUnitDoseCalendarResponseType.CalculateUnitDoseCalendarResponseType_Successful;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ResponseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.CalculateUnitDoseCalendarResponseType.CalculateUnitDoseCalendarResponseType_Successful)]
        
        public Kroll.Pharmacy.Api.ActionData.CalculateUnitDoseCalendarResponseType ResponseType
        {
        get { return mResponseType; }
        set { mResponseType = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.ActionData.CalculateUnitDoseCalendarAdminDose> mAdminDoses = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.ActionData.CalculateUnitDoseCalendarAdminDose>();
        [global::ProtoBuf.ProtoMember(3, Name=@"AdminDoses", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.ActionData.CalculateUnitDoseCalendarAdminDose> AdminDoses
        {
        get { return mAdminDoses; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        