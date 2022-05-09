
        // Generated from: DecryptPatCreditCardResponse.proto
        // Note: requires additional types generated from: DecryptPatCreditCardResponseData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DecryptPatCreditCardResponse")]
        public partial class DecryptPatCreditCardResponse : global::ProtoBuf.IExtensible
        {
        public DecryptPatCreditCardResponse() {}
        

        private Kroll.Pharmacy.Api.ActionData.DecryptPatCreditCardResponseData mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.DecryptPatCreditCardResponseData ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        