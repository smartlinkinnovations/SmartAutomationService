
        // Generated from: RxProfileSearchCriteria.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxProfileSearchCriteria")]
        public partial class RxProfileSearchCriteria : global::ProtoBuf.IExtensible
        {
        public RxProfileSearchCriteria() {}
        

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.RxProfileType mRxProfileType
            = Kroll.Pharmacy.Api.SearchCriteria.RxProfileType.RxProfileType_All;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RxProfileType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.RxProfileType.RxProfileType_All)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.RxProfileType RxProfileType
        {
        get { return mRxProfileType; }
        set { mRxProfileType = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
        public enum RxProfileType
        {
        RxProfileType_All = 0
            ,
        RxProfileType_ActiveRxs = 1
            ,
        RxProfileType_Refillable = 2
            ,
        RxProfileType_Otc = 3
            ,
        RxProfileType_FilledInError = 4
        }
    
            }
        