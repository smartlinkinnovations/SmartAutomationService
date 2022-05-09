
        // Generated from: Catalog.proto
        // Note: requires additional types generated from: DrgCatPackLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Catalog")]
        public partial class Catalog : global::ProtoBuf.IExtensible
        {
        public Catalog() {}
        

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

        private int mVendorId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"VendorId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int VendorId
        {
        get { return mVendorId; }
        set { mVendorId = value; }
        }

        private string mItemNum
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ItemNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ItemNum
        {
        get { return mItemNum; }
        set { mItemNum = value; }
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

        private string mDIN
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DIN", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DIN
        {
        get { return mDIN; }
        set { mDIN = value; }
        }

        private double mPackSize
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PackSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double PackSize
        {
        get { return mPackSize; }
        set { mPackSize = value; }
        }

        private bool mPackSizeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PackSizeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PackSizeSpecified
        {
        get { return mPackSizeSpecified; }
        set { mPackSizeSpecified = value; }
        }

        private string mUPC
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"UPC", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UPC
        {
        get { return mUPC; }
        set { mUPC = value; }
        }

        private double mPrice
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Price", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Price
        {
        get { return mPrice; }
        set { mPrice = value; }
        }

        private bool mPriceSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"PriceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PriceSpecified
        {
        get { return mPriceSpecified; }
        set { mPriceSpecified = value; }
        }

        private string mManufDesc
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"ManufDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ManufDesc
        {
        get { return mManufDesc; }
        set { mManufDesc = value; }
        }

        private int mCaseQty
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"CaseQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CaseQty
        {
        get { return mCaseQty; }
        set { mCaseQty = value; }
        }

        private double mLastPriceUpdate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"LastPriceUpdate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastPriceUpdate
        {
        get { return mLastPriceUpdate; }
        set { mLastPriceUpdate = value; }
        }

        private bool mLastPriceUpdateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"LastPriceUpdateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastPriceUpdateSpecified
        {
        get { return mLastPriceUpdateSpecified; }
        set { mLastPriceUpdateSpecified = value; }
        }

        private bool mGST
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"GST", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool GST
        {
        get { return mGST; }
        set { mGST = value; }
        }

        private bool mPST
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"PST", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PST
        {
        get { return mPST; }
        set { mPST = value; }
        }

        private int mDrgPackTierId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"DrgPackTierId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgPackTierId
        {
        get { return mDrgPackTierId; }
        set { mDrgPackTierId = value; }
        }

        private string mPriceTier
            = "";
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"PriceTier", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PriceTier
        {
        get { return mPriceTier; }
        set { mPriceTier = value; }
        }

        private string mSpecialHandling
            = "";
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"SpecialHandling", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SpecialHandling
        {
        get { return mSpecialHandling; }
        set { mSpecialHandling = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private double mDateDeleted
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"DateDeleted", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateDeleted
        {
        get { return mDateDeleted; }
        set { mDateDeleted = value; }
        }

        private bool mDateDeletedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"DateDeletedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateDeletedSpecified
        {
        get { return mDateDeletedSpecified; }
        set { mDateDeletedSpecified = value; }
        }

        private bool mDoNotTryToLinkToDrgPack
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"DoNotTryToLinkToDrgPack", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoNotTryToLinkToDrgPack
        {
        get { return mDoNotTryToLinkToDrgPack; }
        set { mDoNotTryToLinkToDrgPack = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgCatPackLink> mCatalogLinks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgCatPackLink>();
        [global::ProtoBuf.ProtoMember(24, Name=@"CatalogLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgCatPackLink> CatalogLinks
        {
        get { return mCatalogLinks; }
        }
    

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        