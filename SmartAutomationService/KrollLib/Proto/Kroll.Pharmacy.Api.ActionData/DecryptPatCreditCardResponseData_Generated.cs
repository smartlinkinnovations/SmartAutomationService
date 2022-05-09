
        // Generated from: DecryptPatCreditCardResponseData.proto
        // Note: requires additional types generated from: PatCreditCard.proto
        // Note: requires additional types generated from: DecryptPatCreditCardResponseType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DecryptPatCreditCardResponseData")]
        public partial class DecryptPatCreditCardResponseData : global::ProtoBuf.IExtensible
        {
        public DecryptPatCreditCardResponseData() {}
        

        private bool mIsAccepted
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IsAccepted", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsAccepted
        {
        get { return mIsAccepted; }
        set { mIsAccepted = value; }
        }

        private Kroll.Pharmacy.Api.ActionData.DecryptPatCreditCardResponseType mResponseType
            = Kroll.Pharmacy.Api.ActionData.DecryptPatCreditCardResponseType.DecryptPatCreditCardResponseType_Accepted;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ResponseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.DecryptPatCreditCardResponseType.DecryptPatCreditCardResponseType_Accepted)]
        
        public Kroll.Pharmacy.Api.ActionData.DecryptPatCreditCardResponseType ResponseType
        {
        get { return mResponseType; }
        set { mResponseType = value; }
        }

        private Kroll.Pharmacy.Api.Data.PatCreditCard mPatCreditCard
            = null;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"PatCreditCard", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.PatCreditCard PatCreditCard
        {
        get { return mPatCreditCard; }
        set { mPatCreditCard = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        