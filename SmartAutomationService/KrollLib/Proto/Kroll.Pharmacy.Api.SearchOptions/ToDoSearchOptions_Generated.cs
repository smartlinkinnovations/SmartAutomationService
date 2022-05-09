
        // Generated from: ToDoSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ToDoSearchOptions")]
        public partial class ToDoSearchOptions : global::ProtoBuf.IExtensible
        {
        public ToDoSearchOptions() {}
        

        private bool mIncludePendingNewRx
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludePendingNewRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePendingNewRx
        {
        get { return mIncludePendingNewRx; }
        set { mIncludePendingNewRx = value; }
        }

        private bool mIncludeToDoOCM
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IncludeToDoOCM", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeToDoOCM
        {
        get { return mIncludeToDoOCM; }
        set { mIncludeToDoOCM = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        