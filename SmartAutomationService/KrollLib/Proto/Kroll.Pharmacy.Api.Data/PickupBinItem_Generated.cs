
        // Generated from: PickupBinItem.proto
        // Note: requires additional types generated from: IdentificationRequiredOnDelivery_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PickupBinItem")]
        public partial class PickupBinItem : global::ProtoBuf.IExtensible
        {
        public PickupBinItem() {}
        

        private int mId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Id
        {
        get { return mId; }
        set { mId = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private double mDeliveredToPatientDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DeliveredToPatientDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DeliveredToPatientDate
        {
        get { return mDeliveredToPatientDate; }
        set { mDeliveredToPatientDate = value; }
        }

        private bool mDeliveredToPatientDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DeliveredToPatientDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveredToPatientDateSpecified
        {
        get { return mDeliveredToPatientDateSpecified; }
        set { mDeliveredToPatientDateSpecified = value; }
        }

        private int mDeliveryOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"DeliveryOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryOrderId
        {
        get { return mDeliveryOrderId; }
        set { mDeliveryOrderId = value; }
        }

        private bool mDeliveryOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DeliveryOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryOrderIdSpecified
        {
        get { return mDeliveryOrderIdSpecified; }
        set { mDeliveryOrderIdSpecified = value; }
        }

        private int mDeliveryOrderPackageId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DeliveryOrderPackageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryOrderPackageId
        {
        get { return mDeliveryOrderPackageId; }
        set { mDeliveryOrderPackageId = value; }
        }

        private bool mDeliveryOrderPackageIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"DeliveryOrderPackageIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryOrderPackageIdSpecified
        {
        get { return mDeliveryOrderPackageIdSpecified; }
        set { mDeliveryOrderPackageIdSpecified = value; }
        }

        private int mDeliveryOrderPackageDetailId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DeliveryOrderPackageDetailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryOrderPackageDetailId
        {
        get { return mDeliveryOrderPackageDetailId; }
        set { mDeliveryOrderPackageDetailId = value; }
        }

        private bool mDeliveryOrderPackageDetailIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DeliveryOrderPackageDetailIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryOrderPackageDetailIdSpecified
        {
        get { return mDeliveryOrderPackageDetailIdSpecified; }
        set { mDeliveryOrderPackageDetailIdSpecified = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateCreated
        {
        get { return mDateCreated; }
        set { mDateCreated = value; }
        }

        private bool mDateCreatedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateCreatedSpecified
        {
        get { return mDateCreatedSpecified; }
        set { mDateCreatedSpecified = value; }
        }

        private double mDateChanged
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateChanged
        {
        get { return mDateChanged; }
        set { mDateChanged = value; }
        }

        private bool mDateChangedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.IdentificationRequiredOnDelivery mIdentificationRequiredOnDelivery
            = Kroll.Pharmacy.Api.Data.IdentificationRequiredOnDelivery.IdentificationRequiredOnDelivery_None;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"IdentificationRequiredOnDelivery", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.IdentificationRequiredOnDelivery.IdentificationRequiredOnDelivery_None)]
        
        public Kroll.Pharmacy.Api.Data.IdentificationRequiredOnDelivery IdentificationRequiredOnDelivery
        {
        get { return mIdentificationRequiredOnDelivery; }
        set { mIdentificationRequiredOnDelivery = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        