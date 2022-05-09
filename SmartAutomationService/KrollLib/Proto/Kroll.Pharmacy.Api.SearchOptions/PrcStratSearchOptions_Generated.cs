
        // Generated from: PrcStratSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PrcStratSearchOptions")]
        public partial class PrcStratSearchOptions : global::ProtoBuf.IExtensible
        {
        public PrcStratSearchOptions() {}
        

        private bool mIncludeMarkupItems
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludeMarkupItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeMarkupItems
        {
        get { return mIncludeMarkupItems; }
        set { mIncludeMarkupItems = value; }
        }

        private bool mIncludeMarkupItemLines
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IncludeMarkupItemLines", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeMarkupItemLines
        {
        get { return mIncludeMarkupItemLines; }
        set { mIncludeMarkupItemLines = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        