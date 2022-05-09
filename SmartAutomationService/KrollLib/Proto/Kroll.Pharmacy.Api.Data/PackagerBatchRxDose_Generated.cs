
        // Generated from: PackagerBatchRxDose.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PackagerBatchRxDose")]
        public partial class PackagerBatchRxDose : global::ProtoBuf.IExtensible
        {
        public PackagerBatchRxDose() {}
        

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

        private int mPackagerBatchRxId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PackagerBatchRxId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PackagerBatchRxId
        {
        get { return mPackagerBatchRxId; }
        set { mPackagerBatchRxId = value; }
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

        private double mDoseQuantity
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DoseQuantity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DoseQuantity
        {
        get { return mDoseQuantity; }
        set { mDoseQuantity = value; }
        }

        private int mBagNumber
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"BagNumber", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"BagNumberSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BagNumberSpecified
        {
        get { return mBagNumberSpecified; }
        set { mBagNumberSpecified = value; }
        }

        private string mBarCode
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"BarCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string BarCode
        {
        get { return mBarCode; }
        set { mBarCode = value; }
        }

        private string mFreeFormPassTime
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"FreeFormPassTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FreeFormPassTime
        {
        get { return mFreeFormPassTime; }
        set { mFreeFormPassTime = value; }
        }

        private string mPassTimeNote
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"PassTimeNote", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Seq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Seq
        {
        get { return mSeq; }
        set { mSeq = value; }
        }

        private bool mSeqSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"SeqSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SeqSpecified
        {
        get { return mSeqSpecified; }
        set { mSeqSpecified = value; }
        }

        private int mBagNumberForDose
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"BagNumberForDose", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int BagNumberForDose
        {
        get { return mBagNumberForDose; }
        set { mBagNumberForDose = value; }
        }

        private bool mBagNumberForDoseSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"BagNumberForDoseSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BagNumberForDoseSpecified
        {
        get { return mBagNumberForDoseSpecified; }
        set { mBagNumberForDoseSpecified = value; }
        }

        private int mTotalBagsForDose
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"TotalBagsForDose", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int TotalBagsForDose
        {
        get { return mTotalBagsForDose; }
        set { mTotalBagsForDose = value; }
        }

        private bool mTotalBagsForDoseSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"TotalBagsForDoseSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TotalBagsForDoseSpecified
        {
        get { return mTotalBagsForDoseSpecified; }
        set { mTotalBagsForDoseSpecified = value; }
        }

        private int mNHCardNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"NHCardNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHCardNum
        {
        get { return mNHCardNum; }
        set { mNHCardNum = value; }
        }

        private bool mNHCardNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"NHCardNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHCardNumSpecified
        {
        get { return mNHCardNumSpecified; }
        set { mNHCardNumSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        