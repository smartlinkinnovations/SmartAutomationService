
        // Generated from: RxWorkflowPackDetail.proto
        // Note: requires additional types generated from: DoubleCountType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxWorkflowPackDetail")]
        public partial class RxWorkflowPackDetail : global::ProtoBuf.IExtensible
        {
        public RxWorkflowPackDetail() {}
        

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

        private int mRxWorkflowPackId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RxWorkflowPackId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxWorkflowPackId
        {
        get { return mRxWorkflowPackId; }
        set { mRxWorkflowPackId = value; }
        }

        private string mUpc
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Upc", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Upc
        {
        get { return mUpc; }
        set { mUpc = value; }
        }

        private bool mUpcWasScanned
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"UpcWasScanned", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UpcWasScanned
        {
        get { return mUpcWasScanned; }
        set { mUpcWasScanned = value; }
        }

        private string mUpcScanExceptionReason
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"UpcScanExceptionReason", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UpcScanExceptionReason
        {
        get { return mUpcScanExceptionReason; }
        set { mUpcScanExceptionReason = value; }
        }

        private string mLotNum
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"LotNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string LotNum
        {
        get { return mLotNum; }
        set { mLotNum = value; }
        }

        private double mExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ExpiryDate
        {
        get { return mExpiryDate; }
        set { mExpiryDate = value; }
        }

        private bool mExpiryDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"ExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExpiryDateSpecified
        {
        get { return mExpiryDateSpecified; }
        set { mExpiryDateSpecified = value; }
        }

        private double mQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Qty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Qty
        {
        get { return mQty; }
        set { mQty = value; }
        }

        private bool mQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"QtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool QtySpecified
        {
        get { return mQtySpecified; }
        set { mQtySpecified = value; }
        }

        private string mCompletedByInit
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"CompletedByInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CompletedByInit
        {
        get { return mCompletedByInit; }
        set { mCompletedByInit = value; }
        }

        private int mCompletedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"CompletedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CompletedByUserId
        {
        get { return mCompletedByUserId; }
        set { mCompletedByUserId = value; }
        }

        private bool mCompletedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"CompletedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CompletedByUserIdSpecified
        {
        get { return mCompletedByUserIdSpecified; }
        set { mCompletedByUserIdSpecified = value; }
        }

        private string mCompletedByAssociatedPharmacistInit
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"CompletedByAssociatedPharmacistInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CompletedByAssociatedPharmacistInit
        {
        get { return mCompletedByAssociatedPharmacistInit; }
        set { mCompletedByAssociatedPharmacistInit = value; }
        }

        private int mCompletedByAssociatedPharmacistUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"CompletedByAssociatedPharmacistUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CompletedByAssociatedPharmacistUserId
        {
        get { return mCompletedByAssociatedPharmacistUserId; }
        set { mCompletedByAssociatedPharmacistUserId = value; }
        }

        private bool mCompletedByAssociatedPharmacistUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"CompletedByAssociatedPharmacistUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CompletedByAssociatedPharmacistUserIdSpecified
        {
        get { return mCompletedByAssociatedPharmacistUserIdSpecified; }
        set { mCompletedByAssociatedPharmacistUserIdSpecified = value; }
        }

        private int mClonedFromId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"ClonedFromId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ClonedFromId
        {
        get { return mClonedFromId; }
        set { mClonedFromId = value; }
        }

        private bool mClonedFromIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"ClonedFromIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ClonedFromIdSpecified
        {
        get { return mClonedFromIdSpecified; }
        set { mClonedFromIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.DoubleCountType mDoubleCountType
            = Kroll.Pharmacy.Api.Data.DoubleCountType.DoubleCountType_None;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DoubleCountType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DoubleCountType.DoubleCountType_None)]
        
        public Kroll.Pharmacy.Api.Data.DoubleCountType DoubleCountType
        {
        get { return mDoubleCountType; }
        set { mDoubleCountType = value; }
        }

        private string mDoubleCountUserInit
            = "";
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DoubleCountUserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DoubleCountUserInit
        {
        get { return mDoubleCountUserInit; }
        set { mDoubleCountUserInit = value; }
        }

        private int mDoubleCountUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"DoubleCountUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DoubleCountUserId
        {
        get { return mDoubleCountUserId; }
        set { mDoubleCountUserId = value; }
        }

        private bool mDoubleCountUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"DoubleCountUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoubleCountUserIdSpecified
        {
        get { return mDoubleCountUserIdSpecified; }
        set { mDoubleCountUserIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        