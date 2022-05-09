
        // Generated from: WorkflowSelectionMatrixSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorkflowSelectionMatrixSearchOptions")]
        public partial class WorkflowSelectionMatrixSearchOptions : global::ProtoBuf.IExtensible
        {
        public WorkflowSelectionMatrixSearchOptions() {}
        

        private bool mIncludeEntries
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludeEntries", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeEntries
        {
        get { return mIncludeEntries; }
        set { mIncludeEntries = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        