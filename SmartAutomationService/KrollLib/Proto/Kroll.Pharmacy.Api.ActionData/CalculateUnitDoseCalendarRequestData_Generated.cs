
        // Generated from: CalculateUnitDoseCalendarRequestData.proto
        // Note: requires additional types generated from: NHUnitDoseType_Enum.proto
        // Note: requires additional types generated from: RxPasstime.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CalculateUnitDoseCalendarRequestData")]
        public partial class CalculateUnitDoseCalendarRequestData : global::ProtoBuf.IExtensible
        {
        public CalculateUnitDoseCalendarRequestData() {}
        

        private double mRxStartDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RxStartDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RxStartDate
        {
        get { return mRxStartDate; }
        set { mRxStartDate = value; }
        }

        private double mRxStopDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RxStopDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RxStopDate
        {
        get { return mRxStopDate; }
        set { mRxStopDate = value; }
        }

        private bool mRxStopDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"RxStopDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxStopDateSpecified
        {
        get { return mRxStopDateSpecified; }
        set { mRxStopDateSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHUnitDoseType mNHUnitDoseType
            = Kroll.Pharmacy.Api.Data.NHUnitDoseType.NHUnitDoseType_Unknown;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"NHUnitDoseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHUnitDoseType.NHUnitDoseType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.NHUnitDoseType NHUnitDoseType
        {
        get { return mNHUnitDoseType; }
        set { mNHUnitDoseType = value; }
        }

        private int mNHUnitDoseFreq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"NHUnitDoseFreq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHUnitDoseFreq
        {
        get { return mNHUnitDoseFreq; }
        set { mNHUnitDoseFreq = value; }
        }

        private bool mNHUnitDoseFreqSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"NHUnitDoseFreqSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHUnitDoseFreqSpecified
        {
        get { return mNHUnitDoseFreqSpecified; }
        set { mNHUnitDoseFreqSpecified = value; }
        }

        private double mNHUnitDoseAnchorDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"NHUnitDoseAnchorDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHUnitDoseAnchorDate
        {
        get { return mNHUnitDoseAnchorDate; }
        set { mNHUnitDoseAnchorDate = value; }
        }

        private bool mNHUnitDoseAnchorDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"NHUnitDoseAnchorDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHUnitDoseAnchorDateSpecified
        {
        get { return mNHUnitDoseAnchorDateSpecified; }
        set { mNHUnitDoseAnchorDateSpecified = value; }
        }

        private double mUnitDoseCalendarStartDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"UnitDoseCalendarStartDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double UnitDoseCalendarStartDate
        {
        get { return mUnitDoseCalendarStartDate; }
        set { mUnitDoseCalendarStartDate = value; }
        }

        private double mUnitDoseCalendarEndDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"UnitDoseCalendarEndDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double UnitDoseCalendarEndDate
        {
        get { return mUnitDoseCalendarEndDate; }
        set { mUnitDoseCalendarEndDate = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPasstime> mRxPasstimeList = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPasstime>();
        [global::ProtoBuf.ProtoMember(13, Name=@"RxPasstimeList", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxPasstime> RxPasstimeList
        {
        get { return mRxPasstimeList; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        