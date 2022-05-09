
        // Generated from: CalculateUnitDoseCalendarAdminDose.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CalculateUnitDoseCalendarAdminDose")]
        public partial class CalculateUnitDoseCalendarAdminDose : global::ProtoBuf.IExtensible
        {
        public CalculateUnitDoseCalendarAdminDose() {}
        

        private double mAdminDateTime
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"AdminDateTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AdminDateTime
        {
        get { return mAdminDateTime; }
        set { mAdminDateTime = value; }
        }

        private double mQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Qty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double Qty
        {
        get { return mQty; }
        set { mQty = value; }
        }

        private string mNote
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Note", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Note
        {
        get { return mNote; }
        set { mNote = value; }
        }

        private int mSeq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Seq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Seq
        {
        get { return mSeq; }
        set { mSeq = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        