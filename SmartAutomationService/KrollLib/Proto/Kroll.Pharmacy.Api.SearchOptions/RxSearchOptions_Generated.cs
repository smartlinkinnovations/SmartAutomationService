
        // Generated from: RxSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxSearchOptions")]
        public partial class RxSearchOptions : global::ProtoBuf.IExtensible
        {
        public RxSearchOptions() {}
        

        private bool mIncludeCentralFill
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludeCentralFill", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeCentralFill
        {
        get { return mIncludeCentralFill; }
        set { mIncludeCentralFill = value; }
        }

        private bool mIncludeComments
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IncludeComments", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeComments
        {
        get { return mIncludeComments; }
        set { mIncludeComments = value; }
        }

        private bool mIncludeIndications
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IncludeIndications", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeIndications
        {
        get { return mIncludeIndications; }
        set { mIncludeIndications = value; }
        }

        private bool mIncludeLotNumbers
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"IncludeLotNumbers", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeLotNumbers
        {
        get { return mIncludeLotNumbers; }
        set { mIncludeLotNumbers = value; }
        }

        private bool mIncludeMixtureComponents
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"IncludeMixtureComponents", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeMixtureComponents
        {
        get { return mIncludeMixtureComponents; }
        set { mIncludeMixtureComponents = value; }
        }

        private bool mIncludePacks
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"IncludePacks", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePacks
        {
        get { return mIncludePacks; }
        set { mIncludePacks = value; }
        }

        private bool mIncludePasstimes
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"IncludePasstimes", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePasstimes
        {
        get { return mIncludePasstimes; }
        set { mIncludePasstimes = value; }
        }

        private bool mIncludePlans
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"IncludePlans", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePlans
        {
        get { return mIncludePlans; }
        set { mIncludePlans = value; }
        }

        private bool mIncludePlanAdjudicationDetails
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"IncludePlanAdjudicationDetails", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePlanAdjudicationDetails
        {
        get { return mIncludePlanAdjudicationDetails; }
        set { mIncludePlanAdjudicationDetails = value; }
        }

        private bool mIncludeRxTracking
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"IncludeRxTracking", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeRxTracking
        {
        get { return mIncludeRxTracking; }
        set { mIncludeRxTracking = value; }
        }

        private bool mIncludeRxTransfer
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"IncludeRxTransfer", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeRxTransfer
        {
        get { return mIncludeRxTransfer; }
        set { mIncludeRxTransfer = value; }
        }

        private bool mIncludeExternalLinks
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"IncludeExternalLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeExternalLinks
        {
        get { return mIncludeExternalLinks; }
        set { mIncludeExternalLinks = value; }
        }

        private bool mIncludeSigExpansion
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"IncludeSigExpansion", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeSigExpansion
        {
        get { return mIncludeSigExpansion; }
        set { mIncludeSigExpansion = value; }
        }

        private bool mIncludePlanAdjudicationRequestResponseDetails
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"IncludePlanAdjudicationRequestResponseDetails", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePlanAdjudicationRequestResponseDetails
        {
        get { return mIncludePlanAdjudicationRequestResponseDetails; }
        set { mIncludePlanAdjudicationRequestResponseDetails = value; }
        }

        private bool mIncludeRxSuspend
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"IncludeRxSuspend", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeRxSuspend
        {
        get { return mIncludeRxSuspend; }
        set { mIncludeRxSuspend = value; }
        }

        private bool mIncludeRxWorkflow
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"IncludeRxWorkflow", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeRxWorkflow
        {
        get { return mIncludeRxWorkflow; }
        set { mIncludeRxWorkflow = value; }
        }

        private bool mIncludeRxWorkflowComments
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"IncludeRxWorkflowComments", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeRxWorkflowComments
        {
        get { return mIncludeRxWorkflowComments; }
        set { mIncludeRxWorkflowComments = value; }
        }

        private bool mIncludeRxWorkflowDetails
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"IncludeRxWorkflowDetails", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeRxWorkflowDetails
        {
        get { return mIncludeRxWorkflowDetails; }
        set { mIncludeRxWorkflowDetails = value; }
        }

        private bool mIncludeRxWorkflowPacks
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"IncludeRxWorkflowPacks", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeRxWorkflowPacks
        {
        get { return mIncludeRxWorkflowPacks; }
        set { mIncludeRxWorkflowPacks = value; }
        }

        private bool mIncludeRxWorkflowPackDetails
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"IncludeRxWorkflowPackDetails", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeRxWorkflowPackDetails
        {
        get { return mIncludeRxWorkflowPackDetails; }
        set { mIncludeRxWorkflowPackDetails = value; }
        }

        private bool mIncludeScriptImageLinks
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"IncludeScriptImageLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeScriptImageLinks
        {
        get { return mIncludeScriptImageLinks; }
        set { mIncludeScriptImageLinks = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        