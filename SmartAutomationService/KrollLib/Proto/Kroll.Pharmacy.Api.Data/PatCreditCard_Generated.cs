
        // Generated from: PatCreditCard.proto
        // Note: requires additional types generated from: PaymentCardType_Enum.proto
        // Note: requires additional types generated from: PatCreditCardEncryptionAlgorithm_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatCreditCard")]
        public partial class PatCreditCard : global::ProtoBuf.IExtensible
        {
        public PatCreditCard() {}
        

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

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private Kroll.Pharmacy.Api.Data.PaymentCardType mPaymentCardType
            = Kroll.Pharmacy.Api.Data.PaymentCardType.PaymentCardType_CreditCard;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"PaymentCardType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PaymentCardType.PaymentCardType_CreditCard)]
        
        public Kroll.Pharmacy.Api.Data.PaymentCardType PaymentCardType
        {
        get { return mPaymentCardType; }
        set { mPaymentCardType = value; }
        }

        private string mCreditCardType
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"CreditCardType", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CreditCardType
        {
        get { return mCreditCardType; }
        set { mCreditCardType = value; }
        }

        private string mCreditCardNumber
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"CreditCardNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CreditCardNumber
        {
        get { return mCreditCardNumber; }
        set { mCreditCardNumber = value; }
        }

        private byte[] mEncryptedCreditCardNumber
            = null;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"EncryptedCreditCardNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] EncryptedCreditCardNumber
        {
        get { return mEncryptedCreditCardNumber; }
        set { mEncryptedCreditCardNumber = value; }
        }

        private double mCardExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"CardExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double CardExpiryDate
        {
        get { return mCardExpiryDate; }
        set { mCardExpiryDate = value; }
        }

        private bool mCardExpiryDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"CardExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CardExpiryDateSpecified
        {
        get { return mCardExpiryDateSpecified; }
        set { mCardExpiryDateSpecified = value; }
        }

        private string mCardHolderName
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CardHolderName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CardHolderName
        {
        get { return mCardHolderName; }
        set { mCardHolderName = value; }
        }

        private string mCardAddressLink
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"CardAddressLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CardAddressLink
        {
        get { return mCardAddressLink; }
        set { mCardAddressLink = value; }
        }

        private string mDebitBankNumber
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DebitBankNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DebitBankNumber
        {
        get { return mDebitBankNumber; }
        set { mDebitBankNumber = value; }
        }

        private string mDebitTransitNumber
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DebitTransitNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DebitTransitNumber
        {
        get { return mDebitTransitNumber; }
        set { mDebitTransitNumber = value; }
        }

        private string mDebitAccountNumber
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DebitAccountNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DebitAccountNumber
        {
        get { return mDebitAccountNumber; }
        set { mDebitAccountNumber = value; }
        }

        private byte[] mEncryptedDebitAccountNumber
            = null;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"EncryptedDebitAccountNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] EncryptedDebitAccountNumber
        {
        get { return mEncryptedDebitAccountNumber; }
        set { mEncryptedDebitAccountNumber = value; }
        }

        private string mMaskedCardNumber
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"MaskedCardNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MaskedCardNumber
        {
        get { return mMaskedCardNumber; }
        set { mMaskedCardNumber = value; }
        }

        private string mUserKeyToken
            = "";
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"UserKeyToken", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserKeyToken
        {
        get { return mUserKeyToken; }
        set { mUserKeyToken = value; }
        }

        private bool mIsEncrypted
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"IsEncrypted", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsEncrypted
        {
        get { return mIsEncrypted; }
        set { mIsEncrypted = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        