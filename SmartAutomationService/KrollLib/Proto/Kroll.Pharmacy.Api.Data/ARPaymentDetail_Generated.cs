
        // Generated from: ARPaymentDetail.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ARPaymentDetail")]
        public partial class ARPaymentDetail : global::ProtoBuf.IExtensible
        {
        public ARPaymentDetail() {}
        

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

        private int mPaymentId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PaymentId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PaymentId
        {
        get { return mPaymentId; }
        set { mPaymentId = value; }
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

        private double mAmount
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Amount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"AmountSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AmountSpecified
        {
        get { return mAmountSpecified; }
        set { mAmountSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        