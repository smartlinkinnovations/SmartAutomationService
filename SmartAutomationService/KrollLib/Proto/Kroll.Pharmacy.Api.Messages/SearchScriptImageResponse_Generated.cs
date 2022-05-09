
        // Generated from: SearchScriptImageResponse.proto
        // Note: requires additional types generated from: ScriptImage.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchScriptImageResponse")]
        public partial class SearchScriptImageResponse : global::ProtoBuf.IExtensible
        {
        public SearchScriptImageResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ScriptImage> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ScriptImage>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ScriptImage> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        