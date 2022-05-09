
        // Generated from: NHSort.proto
        // Note: requires additional types generated from: NHMedTypeSort.proto
        // Note: requires additional types generated from: NHReportType_Enum.proto
        // Note: requires additional types generated from: NHReportSortOptions_Enum.proto
        // Note: requires additional types generated from: NHReportSortDirection_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NHSort")]
        public partial class NHSort : global::ProtoBuf.IExtensible
        {
        public NHSort() {}
        

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

        private int mNHId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"NHId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHId
        {
        get { return mNHId; }
        set { mNHId = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHReportType mReportType
            = Kroll.Pharmacy.Api.Data.NHReportType.NHReportType_Unknown;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ReportType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHReportType.NHReportType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.NHReportType ReportType
        {
        get { return mReportType; }
        set { mReportType = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHReportSortOptions mSort1
            = Kroll.Pharmacy.Api.Data.NHReportSortOptions.NHReportSortOptions_None;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Sort1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHReportSortOptions.NHReportSortOptions_None)]
        
        public Kroll.Pharmacy.Api.Data.NHReportSortOptions Sort1
        {
        get { return mSort1; }
        set { mSort1 = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHReportSortDirection mSort1Direction
            = Kroll.Pharmacy.Api.Data.NHReportSortDirection.NHReportSortDirection_Ascending;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Sort1Direction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHReportSortDirection.NHReportSortDirection_Ascending)]
        
        public Kroll.Pharmacy.Api.Data.NHReportSortDirection Sort1Direction
        {
        get { return mSort1Direction; }
        set { mSort1Direction = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHReportSortOptions mSort2
            = Kroll.Pharmacy.Api.Data.NHReportSortOptions.NHReportSortOptions_None;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Sort2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHReportSortOptions.NHReportSortOptions_None)]
        
        public Kroll.Pharmacy.Api.Data.NHReportSortOptions Sort2
        {
        get { return mSort2; }
        set { mSort2 = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHReportSortDirection mSort2Direction
            = Kroll.Pharmacy.Api.Data.NHReportSortDirection.NHReportSortDirection_Ascending;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Sort2Direction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHReportSortDirection.NHReportSortDirection_Ascending)]
        
        public Kroll.Pharmacy.Api.Data.NHReportSortDirection Sort2Direction
        {
        get { return mSort2Direction; }
        set { mSort2Direction = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHReportSortOptions mSort3
            = Kroll.Pharmacy.Api.Data.NHReportSortOptions.NHReportSortOptions_None;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Sort3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHReportSortOptions.NHReportSortOptions_None)]
        
        public Kroll.Pharmacy.Api.Data.NHReportSortOptions Sort3
        {
        get { return mSort3; }
        set { mSort3 = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHReportSortDirection mSort3Direction
            = Kroll.Pharmacy.Api.Data.NHReportSortDirection.NHReportSortDirection_Ascending;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"Sort3Direction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHReportSortDirection.NHReportSortDirection_Ascending)]
        
        public Kroll.Pharmacy.Api.Data.NHReportSortDirection Sort3Direction
        {
        get { return mSort3Direction; }
        set { mSort3Direction = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHReportSortOptions mSort4
            = Kroll.Pharmacy.Api.Data.NHReportSortOptions.NHReportSortOptions_None;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"Sort4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHReportSortOptions.NHReportSortOptions_None)]
        
        public Kroll.Pharmacy.Api.Data.NHReportSortOptions Sort4
        {
        get { return mSort4; }
        set { mSort4 = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHReportSortDirection mSort4Direction
            = Kroll.Pharmacy.Api.Data.NHReportSortDirection.NHReportSortDirection_Ascending;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"Sort4Direction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHReportSortDirection.NHReportSortDirection_Ascending)]
        
        public Kroll.Pharmacy.Api.Data.NHReportSortDirection Sort4Direction
        {
        get { return mSort4Direction; }
        set { mSort4Direction = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHMedTypeSort> mNHMedTypeSort = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHMedTypeSort>();
        [global::ProtoBuf.ProtoMember(17, Name=@"NHMedTypeSort", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHMedTypeSort> NHMedTypeSort
        {
        get { return mNHMedTypeSort; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        