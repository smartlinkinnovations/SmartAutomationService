
        // Generated from: PatChartDetail.proto
        // Note: requires additional types generated from: PatChartDetailReadingType_Enum.proto
        // Note: requires additional types generated from: PatChartDetailReadingUnits_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatChartDetail")]
        public partial class PatChartDetail : global::ProtoBuf.IExtensible
        {
        public PatChartDetail() {}
        

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

        private int mPatChartId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PatChartId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatChartId
        {
        get { return mPatChartId; }
        set { mPatChartId = value; }
        }

        private Kroll.Pharmacy.Api.Data.PatChartDetailReadingType mReadingType
            = Kroll.Pharmacy.Api.Data.PatChartDetailReadingType.PatChartDetailReadingType_Unknown;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ReadingType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatChartDetailReadingType.PatChartDetailReadingType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PatChartDetailReadingType ReadingType
        {
        get { return mReadingType; }
        set { mReadingType = value; }
        }

        private double mValue
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Value
        {
        get { return mValue; }
        set { mValue = value; }
        }

        private bool mValueSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ValueSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ValueSpecified
        {
        get { return mValueSpecified; }
        set { mValueSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.PatChartDetailReadingUnit mUnits
            = Kroll.Pharmacy.Api.Data.PatChartDetailReadingUnit.PatChartDetailReadingUnit_Unknown;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Units", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatChartDetailReadingUnit.PatChartDetailReadingUnit_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PatChartDetailReadingUnit Units
        {
        get { return mUnits; }
        set { mUnits = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        