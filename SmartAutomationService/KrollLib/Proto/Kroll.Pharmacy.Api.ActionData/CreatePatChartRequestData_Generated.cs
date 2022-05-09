
        // Generated from: CreatePatChartRequestData.proto
        // Note: requires additional types generated from: PatChartSource_Enum.proto
        // Note: requires additional types generated from: PatChartType_Enum.proto
        // Note: requires additional types generated from: PatChartSpecimenType_Enum.proto
        // Note: requires additional types generated from: PatChartDetail.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreatePatChartRequestData")]
        public partial class CreatePatChartRequestData : global::ProtoBuf.IExtensible
        {
        public CreatePatChartRequestData() {}
        

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private Kroll.Pharmacy.Api.Data.PatChartType mChartType
            = Kroll.Pharmacy.Api.Data.PatChartType.PatChartType_Unknown;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ChartType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatChartType.PatChartType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PatChartType ChartType
        {
        get { return mChartType; }
        set { mChartType = value; }
        }

        private double mDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Date", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Date
        {
        get { return mDate; }
        set { mDate = value; }
        }

        private double mValue1
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Value1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Value1
        {
        get { return mValue1; }
        set { mValue1 = value; }
        }

        private bool mValue1Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Value1Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Value1Specified
        {
        get { return mValue1Specified; }
        set { mValue1Specified = value; }
        }

        private double mValue2
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Value2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Value2
        {
        get { return mValue2; }
        set { mValue2 = value; }
        }

        private bool mValue2Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Value2Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Value2Specified
        {
        get { return mValue2Specified; }
        set { mValue2Specified = value; }
        }

        private double mValue3
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Value3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Value3
        {
        get { return mValue3; }
        set { mValue3 = value; }
        }

        private bool mValue3Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Value3Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Value3Specified
        {
        get { return mValue3Specified; }
        set { mValue3Specified = value; }
        }

        private double mValue4
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"Value4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Value4
        {
        get { return mValue4; }
        set { mValue4 = value; }
        }

        private bool mValue4Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"Value4Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Value4Specified
        {
        get { return mValue4Specified; }
        set { mValue4Specified = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private int mUpdateChartId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"UpdateChartId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UpdateChartId
        {
        get { return mUpdateChartId; }
        set { mUpdateChartId = value; }
        }

        private bool mUpdateChartIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"UpdateChartIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UpdateChartIdSpecified
        {
        get { return mUpdateChartIdSpecified; }
        set { mUpdateChartIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.PatChartSource mChartSource
            = Kroll.Pharmacy.Api.Data.PatChartSource.PatChartSource_NotSpecified;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"ChartSource", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatChartSource.PatChartSource_NotSpecified)]
        
        public Kroll.Pharmacy.Api.Data.PatChartSource ChartSource
        {
        get { return mChartSource; }
        set { mChartSource = value; }
        }

        private string mExternalPatReference
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ExternalPatReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalPatReference
        {
        get { return mExternalPatReference; }
        set { mExternalPatReference = value; }
        }

        private Kroll.Pharmacy.Api.Data.PatChartSpecimenType mSpecimenType
            = Kroll.Pharmacy.Api.Data.PatChartSpecimenType.SpecimenType_Unknown;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"SpecimenType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatChartSpecimenType.SpecimenType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PatChartSpecimenType SpecimenType
        {
        get { return mSpecimenType; }
        set { mSpecimenType = value; }
        }

        private bool mSpecimenTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"SpecimenTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SpecimenTypeSpecified
        {
        get { return mSpecimenTypeSpecified; }
        set { mSpecimenTypeSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatChartDetail> mPatChartDetails = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatChartDetail>();
        [global::ProtoBuf.ProtoMember(20, Name=@"PatChartDetails", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PatChartDetail> PatChartDetails
        {
        get { return mPatChartDetails; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        