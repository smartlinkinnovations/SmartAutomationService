
        // Generated from: RxTransfer.proto
        // Note: requires additional types generated from: RxTransferDirection_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxTransfer")]
        public partial class RxTransfer : global::ProtoBuf.IExtensible
        {
        public RxTransfer() {}
        

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

        private int mOrigRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"OrigRxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OrigRxNum
        {
        get { return mOrigRxNum; }
        set { mOrigRxNum = value; }
        }

        private bool mOrigRxNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"OrigRxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OrigRxNumSpecified
        {
        get { return mOrigRxNumSpecified; }
        set { mOrigRxNumSpecified = value; }
        }

        private int mRxTransferStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"RxTransferStoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxTransferStoreId
        {
        get { return mRxTransferStoreId; }
        set { mRxTransferStoreId = value; }
        }

        private double mTransferDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"TransferDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TransferDate
        {
        get { return mTransferDate; }
        set { mTransferDate = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxTransferDirection mDirection
            = Kroll.Pharmacy.Api.Data.RxTransferDirection.RxTransferDirection_TransferOut;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Direction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxTransferDirection.RxTransferDirection_TransferOut)]
        
        public Kroll.Pharmacy.Api.Data.RxTransferDirection Direction
        {
        get { return mDirection; }
        set { mDirection = value; }
        }

        private string mOtherStorePharmacist
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"OtherStorePharmacist", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OtherStorePharmacist
        {
        get { return mOtherStorePharmacist; }
        set { mOtherStorePharmacist = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private double mOtherStoreFirstFillDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"OtherStoreFirstFillDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double OtherStoreFirstFillDate
        {
        get { return mOtherStoreFirstFillDate; }
        set { mOtherStoreFirstFillDate = value; }
        }

        private bool mOtherStoreFirstFillDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"OtherStoreFirstFillDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OtherStoreFirstFillDateSpecified
        {
        get { return mOtherStoreFirstFillDateSpecified; }
        set { mOtherStoreFirstFillDateSpecified = value; }
        }

        private double mOtherStoreLastFillDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"OtherStoreLastFillDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double OtherStoreLastFillDate
        {
        get { return mOtherStoreLastFillDate; }
        set { mOtherStoreLastFillDate = value; }
        }

        private bool mOtherStoreLastFillDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"OtherStoreLastFillDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OtherStoreLastFillDateSpecified
        {
        get { return mOtherStoreLastFillDateSpecified; }
        set { mOtherStoreLastFillDateSpecified = value; }
        }

        private string mOtherStoreRxNum
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"OtherStoreRxNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OtherStoreRxNum
        {
        get { return mOtherStoreRxNum; }
        set { mOtherStoreRxNum = value; }
        }

        private int mOtherStoreOriginalFills
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"OtherStoreOriginalFills", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OtherStoreOriginalFills
        {
        get { return mOtherStoreOriginalFills; }
        set { mOtherStoreOriginalFills = value; }
        }

        private bool mOtherStoreOriginalFillsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"OtherStoreOriginalFillsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool OtherStoreOriginalFillsSpecified
        {
        get { return mOtherStoreOriginalFillsSpecified; }
        set { mOtherStoreOriginalFillsSpecified = value; }
        }

        private string mInit
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"Init", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Init
        {
        get { return mInit; }
        set { mInit = value; }
        }

        private string mUserInit
            = "";
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"UserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserInit
        {
        get { return mUserInit; }
        set { mUserInit = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private int mUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"UserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UserId
        {
        get { return mUserId; }
        set { mUserId = value; }
        }

        private bool mUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"UserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserIdSpecified
        {
        get { return mUserIdSpecified; }
        set { mUserIdSpecified = value; }
        }

        private int mUserUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"UserUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UserUserId
        {
        get { return mUserUserId; }
        set { mUserUserId = value; }
        }

        private bool mUserUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"UserUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UserUserIdSpecified
        {
        get { return mUserUserIdSpecified; }
        set { mUserUserIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        