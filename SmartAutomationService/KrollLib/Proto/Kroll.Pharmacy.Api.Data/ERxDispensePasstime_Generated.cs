
        // Generated from: ERxDispensePasstime.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ERxDispensePasstime")]
        public partial class ERxDispensePasstime : global::ProtoBuf.IExtensible
        {
        public ERxDispensePasstime() {}
        

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

        private int mERxDispenseId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ERxDispenseId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ERxDispenseId
        {
        get { return mERxDispenseId; }
        set { mERxDispenseId = value; }
        }

        private double mDoseDateTime
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DoseDateTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DoseDateTime
        {
        get { return mDoseDateTime; }
        set { mDoseDateTime = value; }
        }

        private bool mDoseDateTimeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DoseDateTimeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoseDateTimeSpecified
        {
        get { return mDoseDateTimeSpecified; }
        set { mDoseDateTimeSpecified = value; }
        }

        private double mDoseQuantity
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DoseQuantity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DoseQuantity
        {
        get { return mDoseQuantity; }
        set { mDoseQuantity = value; }
        }

        private bool mDoseQuantitySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DoseQuantitySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoseQuantitySpecified
        {
        get { return mDoseQuantitySpecified; }
        set { mDoseQuantitySpecified = value; }
        }

        private int mBagNumber
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"BagNumber", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int BagNumber
        {
        get { return mBagNumber; }
        set { mBagNumber = value; }
        }

        private bool mBagNumberSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"BagNumberSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BagNumberSpecified
        {
        get { return mBagNumberSpecified; }
        set { mBagNumberSpecified = value; }
        }

        private string mBarcode
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Barcode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Barcode
        {
        get { return mBarcode; }
        set { mBarcode = value; }
        }

        private string mFreeFormPassTime
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"FreeFormPassTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FreeFormPassTime
        {
        get { return mFreeFormPassTime; }
        set { mFreeFormPassTime = value; }
        }

        private string mPassTimeNote
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"PassTimeNote", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PassTimeNote
        {
        get { return mPassTimeNote; }
        set { mPassTimeNote = value; }
        }

        private int mSeq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Seq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Seq
        {
        get { return mSeq; }
        set { mSeq = value; }
        }

        private string mUnitDose
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"UnitDose", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UnitDose
        {
        get { return mUnitDose; }
        set { mUnitDose = value; }
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
        private readonly global::System.Collections.Generic.List<string> mAdminFlags = new global::System.Collections.Generic.List<string>();
        [global::ProtoBuf.ProtoMember(18, Name=@"AdminFlags", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<string> AdminFlags
        {
        get { return mAdminFlags; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        