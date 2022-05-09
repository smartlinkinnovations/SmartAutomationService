
        // Generated from: VendorSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"VendorSearchOptions")]
        public partial class VendorSearchOptions : global::ProtoBuf.IExtensible
        {
        public VendorSearchOptions() {}
        

        private bool mIncludeVendorStoreLink
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludeVendorStoreLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeVendorStoreLink
        {
        get { return mIncludeVendorStoreLink; }
        set { mIncludeVendorStoreLink = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        