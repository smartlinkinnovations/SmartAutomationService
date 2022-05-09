
        // Generated from: SearchRouteOfAdministrationResponse.proto
        // Note: requires additional types generated from: RouteOfAdministration.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchRouteOfAdministrationResponse")]
        public partial class SearchRouteOfAdministrationResponse : global::ProtoBuf.IExtensible
        {
        public SearchRouteOfAdministrationResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RouteOfAdministration> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RouteOfAdministration>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RouteOfAdministration> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        