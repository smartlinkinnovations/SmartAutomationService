
        // Generated from: HoursOfOperation.proto
        // Note: requires additional types generated from: OperatingDayType_Enum.proto
        // Note: requires additional types generated from: OperatingHoursType_Enum.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HoursOfOperation")]
        public partial class HoursOfOperation : global::ProtoBuf.IExtensible
        {
        public HoursOfOperation() {}
        

        private int mId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Id
        {
        get { return mId; }
        set { mId = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private Kroll.Pharmacy.Api.Data.OperatingDayType mOperatingDayType
            = Kroll.Pharmacy.Api.Data.OperatingDayType.OperatingDayType_Unknown;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"OperatingDayType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.OperatingDayType.OperatingDayType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.OperatingDayType OperatingDayType
        {
        get { return mOperatingDayType; }
        set { mOperatingDayType = value; }
        }

        private double mOperatingDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"OperatingDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double OperatingDate
        {
        get { return mOperatingDate; }
        set { mOperatingDate = value; }
        }

        private bool mOperatingDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"OperatingDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OperatingDateSpecified
        {
        get { return mOperatingDateSpecified; }
        set { mOperatingDateSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.OperatingHoursType mOperatingHoursType
            = Kroll.Pharmacy.Api.Data.OperatingHoursType.OperatingHoursType_Closed;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"OperatingHoursType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.OperatingHoursType.OperatingHoursType_Closed)]
        
        public Kroll.Pharmacy.Api.Data.OperatingHoursType OperatingHoursType
        {
        get { return mOperatingHoursType; }
        set { mOperatingHoursType = value; }
        }

        private double mOpeningTime
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"OpeningTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double OpeningTime
        {
        get { return mOpeningTime; }
        set { mOpeningTime = value; }
        }

        private bool mOpeningTimeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"OpeningTimeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OpeningTimeSpecified
        {
        get { return mOpeningTimeSpecified; }
        set { mOpeningTimeSpecified = value; }
        }

        private double mClosingTime
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"ClosingTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ClosingTime
        {
        get { return mClosingTime; }
        set { mClosingTime = value; }
        }

        private bool mClosingTimeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ClosingTimeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ClosingTimeSpecified
        {
        get { return mClosingTimeSpecified; }
        set { mClosingTimeSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink CentralMaintLink
        {
        get { return mCentralMaintLink; }
        set { mCentralMaintLink = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateCreated
        {
        get { return mDateCreated; }
        set { mDateCreated = value; }
        }

        private bool mDateCreatedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateCreatedSpecified
        {
        get { return mDateCreatedSpecified; }
        set { mDateCreatedSpecified = value; }
        }

        private double mDateChanged
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateChanged
        {
        get { return mDateChanged; }
        set { mDateChanged = value; }
        }

        private bool mDateChangedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        