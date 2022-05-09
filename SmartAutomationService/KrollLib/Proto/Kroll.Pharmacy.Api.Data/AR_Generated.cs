
        // Generated from: AR.proto
        // Note: requires additional types generated from: ARComment.proto
        // Note: requires additional types generated from: ARDetail.proto
        // Note: requires additional types generated from: ARInvoice.proto
        // Note: requires additional types generated from: ARPayment.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AR")]
        public partial class AR : global::ProtoBuf.IExtensible
        {
        public AR() {}
        

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

        private string mAccountNum
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"AccountNum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AccountNum
        {
        get { return mAccountNum; }
        set { mAccountNum = value; }
        }

        private double mCreditLimit
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"CreditLimit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CreditLimit
        {
        get { return mCreditLimit; }
        set { mCreditLimit = value; }
        }

        private bool mCreditLimitSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"CreditLimitSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CreditLimitSpecified
        {
        get { return mCreditLimitSpecified; }
        set { mCreditLimitSpecified = value; }
        }

        private int mBillToPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"BillToPatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int BillToPatId
        {
        get { return mBillToPatId; }
        set { mBillToPatId = value; }
        }

        private bool mInactive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Inactive", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Inactive
        {
        get { return mInactive; }
        set { mInactive = value; }
        }

        private bool mWaiveFinanceCharges
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"WaiveFinanceCharges", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool WaiveFinanceCharges
        {
        get { return mWaiveFinanceCharges; }
        set { mWaiveFinanceCharges = value; }
        }

        private bool mDuplicateStatement
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DuplicateStatement", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DuplicateStatement
        {
        get { return mDuplicateStatement; }
        set { mDuplicateStatement = value; }
        }

        private double mLastStatementDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"LastStatementDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double LastStatementDate
        {
        get { return mLastStatementDate; }
        set { mLastStatementDate = value; }
        }

        private bool mLastStatementDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"LastStatementDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LastStatementDateSpecified
        {
        get { return mLastStatementDateSpecified; }
        set { mLastStatementDateSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARComment> mComments = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARComment>();
        [global::ProtoBuf.ProtoMember(11, Name=@"Comments", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARComment> Comments
        {
        get { return mComments; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARDetail> mInvoiceDetails = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARDetail>();
        [global::ProtoBuf.ProtoMember(12, Name=@"InvoiceDetails", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARDetail> InvoiceDetails
        {
        get { return mInvoiceDetails; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARInvoice> mInvoices = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARInvoice>();
        [global::ProtoBuf.ProtoMember(13, Name=@"Invoices", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARInvoice> Invoices
        {
        get { return mInvoices; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARPayment> mPayments = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARPayment>();
        [global::ProtoBuf.ProtoMember(14, Name=@"Payments", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ARPayment> Payments
        {
        get { return mPayments; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        