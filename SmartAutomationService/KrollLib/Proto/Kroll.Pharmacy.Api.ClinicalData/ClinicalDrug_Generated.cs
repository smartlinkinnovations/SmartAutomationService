
        // Generated from: ClinicalDrug.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ClinicalDrug")]
        public partial class ClinicalDrug : global::ProtoBuf.IExtensible
        {
        public ClinicalDrug() {}
        

        private string mDin
            = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Din", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Din
        {
        get { return mDin; }
        set { mDin = value; }
        }

        private string mBrandName
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"BrandName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string BrandName
        {
        get { return mBrandName; }
        set { mBrandName = value; }
        }

        private string mGenericName
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"GenericName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string GenericName
        {
        get { return mGenericName; }
        set { mGenericName = value; }
        }

        private string mStrength
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Strength", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Strength
        {
        get { return mStrength; }
        set { mStrength = value; }
        }

        private string mManufacturer
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Manufacturer", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Manufacturer
        {
        get { return mManufacturer; }
        set { mManufacturer = value; }
        }

        private string mDosageFormCode
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DosageFormCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DosageFormCode
        {
        get { return mDosageFormCode; }
        set { mDosageFormCode = value; }
        }

        private string mDosageFormDescription
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"DosageFormDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DosageFormDescription
        {
        get { return mDosageFormDescription; }
        set { mDosageFormDescription = value; }
        }

        private string mRouteCode
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"RouteCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RouteCode
        {
        get { return mRouteCode; }
        set { mRouteCode = value; }
        }

        private string mRouteDescription
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"RouteDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RouteDescription
        {
        get { return mRouteDescription; }
        set { mRouteDescription = value; }
        }

        private string mHic3
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Hic3", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Hic3
        {
        get { return mHic3; }
        set { mHic3 = value; }
        }

        private int mAhfsCode
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"AhfsCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AhfsCode
        {
        get { return mAhfsCode; }
        set { mAhfsCode = value; }
        }

        private string mAhfsDescription
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"AhfsDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AhfsDescription
        {
        get { return mAhfsDescription; }
        set { mAhfsDescription = value; }
        }

        private int mGcn
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"Gcn", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Gcn
        {
        get { return mGcn; }
        set { mGcn = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        