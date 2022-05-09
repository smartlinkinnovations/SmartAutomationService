
        // Generated from: PatSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatSearchOptions")]
        public partial class PatSearchOptions : global::ProtoBuf.IExtensible
        {
        public PatSearchOptions() {}
        

        private bool mIncludeAddress
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludeAddress", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeAddress
        {
        get { return mIncludeAddress; }
        set { mIncludeAddress = value; }
        }

        private bool mIncludeAllergies
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IncludeAllergies", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeAllergies
        {
        get { return mIncludeAllergies; }
        set { mIncludeAllergies = value; }
        }

        private bool mIncludeCharts
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IncludeCharts", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeCharts
        {
        get { return mIncludeCharts; }
        set { mIncludeCharts = value; }
        }

        private bool mIncludeCreditCards
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"IncludeCreditCards", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeCreditCards
        {
        get { return mIncludeCreditCards; }
        set { mIncludeCreditCards = value; }
        }

        private bool mIncludeConditions
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"IncludeConditions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeConditions
        {
        get { return mIncludeConditions; }
        set { mIncludeConditions = value; }
        }

        private bool mIncludeComments
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"IncludeComments", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeComments
        {
        get { return mIncludeComments; }
        set { mIncludeComments = value; }
        }

        private bool mIncludeDocuments
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"IncludeDocuments", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeDocuments
        {
        get { return mIncludeDocuments; }
        set { mIncludeDocuments = value; }
        }

        private bool mIncludeExternalLinks
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"IncludeExternalLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeExternalLinks
        {
        get { return mIncludeExternalLinks; }
        set { mIncludeExternalLinks = value; }
        }

        private bool mIncludeGroups
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"IncludeGroups", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeGroups
        {
        get { return mIncludeGroups; }
        set { mIncludeGroups = value; }
        }

        private bool mIncludeInterventions
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"IncludeInterventions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeInterventions
        {
        get { return mIncludeInterventions; }
        set { mIncludeInterventions = value; }
        }

        private bool mIncludeLimitedUse
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"IncludeLimitedUse", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeLimitedUse
        {
        get { return mIncludeLimitedUse; }
        set { mIncludeLimitedUse = value; }
        }

        private bool mIncludeNHOrders
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"IncludeNHOrders", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeNHOrders
        {
        get { return mIncludeNHOrders; }
        set { mIncludeNHOrders = value; }
        }

        private bool mIncludeOutboundCommunications
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"IncludeOutboundCommunications", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeOutboundCommunications
        {
        get { return mIncludeOutboundCommunications; }
        set { mIncludeOutboundCommunications = value; }
        }

        private bool mIncludePlans
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"IncludePlans", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePlans
        {
        get { return mIncludePlans; }
        set { mIncludePlans = value; }
        }

        private bool mIncludePhone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"IncludePhone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePhone
        {
        get { return mIncludePhone; }
        set { mIncludePhone = value; }
        }

        private bool mIncludeInterventionDetails
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"IncludeInterventionDetails", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeInterventionDetails
        {
        get { return mIncludeInterventionDetails; }
        set { mIncludeInterventionDetails = value; }
        }

        private bool mIncludeDocumentComments
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"IncludeDocumentComments", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeDocumentComments
        {
        get { return mIncludeDocumentComments; }
        set { mIncludeDocumentComments = value; }
        }

        private bool mIncludeDrgAlertLinks
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"IncludeDrgAlertLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeDrgAlertLinks
        {
        get { return mIncludeDrgAlertLinks; }
        set { mIncludeDrgAlertLinks = value; }
        }

        private bool mIncludeLeaveOfAbsence
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"IncludeLeaveOfAbsence", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeLeaveOfAbsence
        {
        get { return mIncludeLeaveOfAbsence; }
        set { mIncludeLeaveOfAbsence = value; }
        }

        private bool mIncludeRelationships
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"IncludeRelationships", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeRelationships
        {
        get { return mIncludeRelationships; }
        set { mIncludeRelationships = value; }
        }

        private bool mIncludeConsent
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"IncludeConsent", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeConsent
        {
        get { return mIncludeConsent; }
        set { mIncludeConsent = value; }
        }

        private bool mIncludeMedReviews
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"IncludeMedReviews", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeMedReviews
        {
        get { return mIncludeMedReviews; }
        set { mIncludeMedReviews = value; }
        }

        private bool mIncludeDeletedPlans
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"IncludeDeletedPlans", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeDeletedPlans
        {
        get { return mIncludeDeletedPlans; }
        set { mIncludeDeletedPlans = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        