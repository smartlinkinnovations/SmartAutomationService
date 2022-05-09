
        // Generated from: ARDetail.proto
        // Note: requires additional types generated from: ARGLCategory.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ARDetail")]
        public partial class ARDetail : global::ProtoBuf.IExtensible
        {
        public ARDetail() {}
        

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

        private int mInvoiceNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"InvoiceNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int InvoiceNum
        {
        get { return mInvoiceNum; }
        set { mInvoiceNum = value; }
        }

        private bool mInvoiceNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"InvoiceNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InvoiceNumSpecified
        {
        get { return mInvoiceNumSpecified; }
        set { mInvoiceNumSpecified = value; }
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

        private bool mDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateSpecified
        {
        get { return mDateSpecified; }
        set { mDateSpecified = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private bool mRxNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxNumSpecified
        {
        get { return mRxNumSpecified; }
        set { mRxNumSpecified = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private bool mPatIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatIdSpecified
        {
        get { return mPatIdSpecified; }
        set { mPatIdSpecified = value; }
        }

        private double mAmount
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Amount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"AmountSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AmountSpecified
        {
        get { return mAmountSpecified; }
        set { mAmountSpecified = value; }
        }

        private int mTaxType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"TaxType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int TaxType
        {
        get { return mTaxType; }
        set { mTaxType = value; }
        }

        private bool mTaxTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"TaxTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TaxTypeSpecified
        {
        get { return mTaxTypeSpecified; }
        set { mTaxTypeSpecified = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private bool mFinanceCharge
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"FinanceCharge", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FinanceCharge
        {
        get { return mFinanceCharge; }
        set { mFinanceCharge = value; }
        }

        private int mDeliveryOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"DeliveryOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryOrderId
        {
        get { return mDeliveryOrderId; }
        set { mDeliveryOrderId = value; }
        }

        private bool mDeliveryOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DeliveryOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryOrderIdSpecified
        {
        get { return mDeliveryOrderIdSpecified; }
        set { mDeliveryOrderIdSpecified = value; }
        }

        private int mDeliveryOrderItemId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DeliveryOrderItemId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryOrderItemId
        {
        get { return mDeliveryOrderItemId; }
        set { mDeliveryOrderItemId = value; }
        }

        private bool mDeliveryOrderItemIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DeliveryOrderItemIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryOrderItemIdSpecified
        {
        get { return mDeliveryOrderItemIdSpecified; }
        set { mDeliveryOrderItemIdSpecified = value; }
        }

        private int mARGLCategoryId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"ARGLCategoryId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"ARGLCategoryIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ARGLCategory", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.ARGLCategory ARGLCategory
        {
        get { return mARGLCategory; }
        set { mARGLCategory = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        