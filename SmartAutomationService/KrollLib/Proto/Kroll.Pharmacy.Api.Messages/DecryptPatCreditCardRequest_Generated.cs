
        // Generated from: DecryptPatCreditCardRequest.proto
        // Note: requires additional types generated from: DecryptPatCreditCardRequestData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DecryptPatCreditCardRequest")]
        public partial class DecryptPatCreditCardRequest : global::ProtoBuf.IExtensible
        {
        public DecryptPatCreditCardRequest() {}
        

        private Kroll.Pharmacy.Api.ActionData.DecryptPatCreditCardRequestData mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.DecryptPatCreditCardRequestData RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        