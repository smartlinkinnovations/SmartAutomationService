
        // Generated from: ARPayment.proto
        // Note: requires additional types generated from: ARPaymentDetail.proto
        // Note: requires additional types generated from: ARGLCategory.proto
        // Note: requires additional types generated from: ARPaymentType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ARPayment")]
        public partial class ARPayment : global::ProtoBuf.IExtensible
        {
        public ARPayment() {}
        

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

        private int mARId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ARId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ARId
        {
        get { return mARId; }
        set { mARId = value; }
        }

        private int mStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private int mType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Type
        {
        get { return mType; }
        set { mType = value; }
        }

        private double mDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Date", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Date
        {
        get { return mDate; }
        set { mDate = value; }
        }

        private double mAmount
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Amount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Amount
        {
        get { return mAmount; }
        set { mAmount = value; }
        }

        private bool mAmountSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"AmountSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AmountSpecified
        {
        get { return mAmountSpecified; }
        set { mAmountSpecified = value; }
        }

        private double mAmountUsed
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"AmountUsed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AmountUsed
        {
        get { return mAmountUsed; }
        set { mAmountUsed = value; }
        }

        private bool mAmountUsedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"AmountUsedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AmountUsedSpecified
        {
        get { return mAmountUsedSpecified; }
        set { mAmountUsedSpecified = value; }
        }

        private int mPaymentMethod
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"PaymentMethod", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PaymentMethod
        {
        get { return mPaymentMethod; }
        set { mPaymentMethod = value; }
        }

        private bool mPaymentMethodSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"PaymentMethodSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PaymentMethodSpecified
        {
        get { return mPaymentMethodSpecified; }
        set { mPaymentMethodSpecified = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private double mSubTotal
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"SubTotal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SubTotal
        {
        get { return mSubTotal; }
        set { mSubTotal = value; }
        }

        private int mTaxType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"TaxType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int TaxType
        {
        get { return mTaxType; }
        set { mTaxType = value; }
        }

        private double mTax1
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"Tax1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Tax1
        {
        get { return mTax1; }
        set { mTax1 = value; }
        }

        private double mTax2
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"Tax2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Tax2
        {
        get { return mTax2; }
        set { mTax2 = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARPaymentDetail> mPaymentDetails = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARPaymentDetail>();
        [global::ProtoBuf.ProtoMember(17, Name=@"PaymentDetails", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARPaymentDetail> PaymentDetails
        {
        get { return mPaymentDetails; }
        }
    

        private int mARGLCategoryId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"ARGLCategoryId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ARGLCategoryId
        {
        get { return mARGLCategoryId; }
        set { mARGLCategoryId = value; }
        }

        private bool mARGLCategoryIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"ARGLCategoryIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ARGLCategoryIdSpecified
        {
        get { return mARGLCategoryIdSpecified; }
        set { mARGLCategoryIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.ARGLCategory mARGLCategory
            = null;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"ARGLCategory", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.ARGLCategory ARGLCategory
        {
        get { return mARGLCategory; }
        set { mARGLCategory = value; }
        }

        private Kroll.Pharmacy.Api.Data.ARPaymentType mPaymentType
            = Kroll.Pharmacy.Api.Data.ARPaymentType.ARPaymentType_Payment;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"PaymentType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ARPaymentType.ARPaymentType_Payment)]
        
        public Kroll.Pharmacy.Api.Data.ARPaymentType PaymentType
        {
        get { return mPaymentType; }
        set { mPaymentType = value; }
        }

        private int mARExportId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"ARExportId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ARExportId
        {
        get { return mARExportId; }
        set { mARExportId = value; }
        }

        private bool mARExportIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ARExportIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ARExportIdSpecified
        {
        get { return mARExportIdSpecified; }
        set { mARExportIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        