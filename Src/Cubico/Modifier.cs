using System;
using System.Runtime.Serialization;

namespace Cubico
{
#if (!PCL && !NETSTANDARD1_4)
    [Serializable]
#endif
    [DataContract(IsReference = true)]
	public partial class Modifier
	{
		#region "Contructors"
		public Modifier () : base()
		{
		}
		#endregion
		#region "Primitive Properties"
		[DataMember]
		public int ID { get; set; }

		[DataMember]
		public decimal Value { get; set; }

		[DataMember]
		public int Order { get; set; }

		[DataMember]
		public int UnitSourceID { get; set; }

		[DataMember]
		public int UnitTargetID { get; set; }

		[DataMember]
		public Nullable<int> Precision { get; set; }
		#endregion
		#region "ChangeTracking"
		bool _isDeserializing;

		protected bool IsDeserializing {
			get { return _isDeserializing; }
			set { _isDeserializing = value; }
		}

		[OnDeserializing]
		public void OnDeserializingMethod (StreamingContext context)
		{
			IsDeserializing = true;
		}

		[OnDeserialized]
		public void OnDeserializedMethod (StreamingContext context)
		{
			IsDeserializing = false;
		}

		bool _isSerializing = false;

		protected bool IsSerializing {
			get { return _isSerializing; }
			set { _isSerializing = value; }
		}

		[OnSerializing]
		public void OnSerializingMethod (StreamingContext context)
		{
			IsSerializing = true;
		}

		[OnSerialized]
		public void OnSerializedMethod (StreamingContext context)
		{
			IsSerializing = false;
		}

		protected virtual void ClearNavigationProperties ()
		{
		}
		#endregion
		#region "Properties"
		[DataMember]
		public Unit ParentUnit { get; set; }

		public ModifierType ModifierType { get; set; }
		#endregion
	}
}