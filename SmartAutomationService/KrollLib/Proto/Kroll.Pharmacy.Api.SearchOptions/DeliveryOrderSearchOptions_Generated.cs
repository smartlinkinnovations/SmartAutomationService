
        // Generated from: DeliveryOrderSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeliveryOrderSearchOptions")]
        public partial class DeliveryOrderSearchOptions : global::ProtoBuf.IExtensible
        {
        public DeliveryOrderSearchOptions() {}
        

        private bool mIncludePackages
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludePackages", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePackages
        {
        get { return mIncludePackages; }
        set { mIncludePackages = value; }
        }

        private bool mIncludePackageDetails
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IncludePackageDetails", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePackageDetails
        {
        get { return mIncludePackageDetails; }
        set { mIncludePackageDetails = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        