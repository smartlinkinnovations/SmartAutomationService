
        // Generated from: DecryptPatCreditCardRequestData.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DecryptPatCreditCardRequestData")]
        public partial class DecryptPatCreditCardRequestData : global::ProtoBuf.IExtensible
        {
        public DecryptPatCreditCardRequestData() {}
        

        private int mPatCreditCardId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"PatCreditCardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatCreditCardId
        {
        get { return mPatCreditCardId; }
        set { mPatCreditCardId = value; }
        }

        private string mUserKeyToken
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"UserKeyToken", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserKeyToken
        {
        get { return mUserKeyToken; }
        set { mUserKeyToken = value; }
        }

        private string mPassword
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Password", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Password
        {
        get { return mPassword; }
        set { mPassword = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        