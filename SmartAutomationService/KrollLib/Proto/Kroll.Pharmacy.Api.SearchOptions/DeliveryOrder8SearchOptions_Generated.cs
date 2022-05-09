
        // Generated from: DeliveryOrder8SearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeliveryOrder8SearchOptions")]
        public partial class DeliveryOrder8SearchOptions : global::ProtoBuf.IExtensible
        {
        public DeliveryOrder8SearchOptions() {}
        

        private bool mIncludeItems
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludeItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeItems
        {
        get { return mIncludeItems; }
        set { mIncludeItems = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        