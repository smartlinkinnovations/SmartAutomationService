
        // Generated from: ARInvoice.proto
        // Note: requires additional types generated from: ARDetail.proto
        // Note: requires additional types generated from: ARPaymentDetail.proto
        // Note: requires additional types generated from: ARInvoiceType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ARInvoice")]
        public partial class ARInvoice : global::ProtoBuf.IExtensible
        {
        public ARInvoice() {}
        

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

        private int mInvoiceNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"InvoiceNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int InvoiceNum
        {
        get { return mInvoiceNum; }
        set { mInvoiceNum = value; }
        }

        private int mARId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ARId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ARId
        {
        get { return mARId; }
        set { mARId = value; }
        }

        private double mInvoiceDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"InvoiceDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double InvoiceDate
        {
        get { return mInvoiceDate; }
        set { mInvoiceDate = value; }
        }

        private int mStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private double mSubTotal
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"SubTotal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SubTotal
        {
        get { return mSubTotal; }
        set { mSubTotal = value; }
        }

        private bool mSubTotalSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"SubTotalSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SubTotalSpecified
        {
        get { return mSubTotalSpecified; }
        set { mSubTotalSpecified = value; }
        }

        private double mTax1
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Tax1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Tax1
        {
        get { return mTax1; }
        set { mTax1 = value; }
        }

        private bool mTax1Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Tax1Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Tax1Specified
        {
        get { return mTax1Specified; }
        set { mTax1Specified = value; }
        }

        private double mTax2
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Tax2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Tax2
        {
        get { return mTax2; }
        set { mTax2 = value; }
        }

        private bool mTax2Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Tax2Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Tax2Specified
        {
        get { return mTax2Specified; }
        set { mTax2Specified = value; }
        }

        private double mPaid
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Paid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Paid
        {
        get { return mPaid; }
        set { mPaid = value; }
        }

        private bool mPaidSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"PaidSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PaidSpecified
        {
        get { return mPaidSpecified; }
        set { mPaidSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARDetail> mDetails = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARDetail>();
        [global::ProtoBuf.ProtoMember(14, Name=@"Details", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARDetail> Details
        {
        get { return mDetails; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARPaymentDetail> mPaymentDetails = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARPaymentDetail>();
        [global::ProtoBuf.ProtoMember(15, Name=@"PaymentDetails", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARPaymentDetail> PaymentDetails
        {
        get { return mPaymentDetails; }
        }
    

        private Kroll.Pharmacy.Api.Data.ARInvoiceType mInvoiceType
            = Kroll.Pharmacy.Api.Data.ARInvoiceType.ARInvoiceType_Invoice;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"InvoiceType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ARInvoiceType.ARInvoiceType_Invoice)]
        
        public Kroll.Pharmacy.Api.Data.ARInvoiceType InvoiceType
        {
        get { return mInvoiceType; }
        set { mInvoiceType = value; }
        }

        private int mARExportId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"ARExportId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"ARExportIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        