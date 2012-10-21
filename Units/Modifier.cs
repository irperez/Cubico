using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Units
{
	[DataContract(IsReference = true)]
	[Serializable()]
	public partial class Modifier : INotifyPropertyChanged
	{
        #region "Contructors"
		public Modifier() : base()
		{

		}
		#endregion

		#region "Primitive Properties"

		[DataMember()]
		public int ID {get;set;}
			
		[DataMember()]
		public decimal Value {get;set;}
			
		[DataMember()]
		public int Order {get;set;}
			
		[DataMember()]
		public int UnitSourceID {get;set;}
			
		[DataMember()]
		public int UnitTargetID {get;set;}
			
		[DataMember()]
		public Nullable<int> Precision {get;set;}
			
		#endregion
        
		#region "ChangeTracking"

		internal event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged;
		
		private bool _isDeserializing;
		protected bool IsDeserializing {
			get { return _isDeserializing; }
			private set { _isDeserializing = value; }
		}

		[OnDeserializing()]
		public void OnDeserializingMethod(StreamingContext context)
		{
			IsDeserializing = true;
		}

		[OnDeserialized()]
		public void OnDeserializedMethod(StreamingContext context)
		{
			IsDeserializing = false;
		}

		private bool _isSerializing = false;
		protected bool IsSerializing {
			get { return _isSerializing; }
			private set { _isSerializing = value; }
		}

		[OnSerializing()]
		public void OnSerializingMethod(StreamingContext context)
		{
			IsSerializing = true;
		}

		[OnSerialized()]
		public void OnSerializedMethod(StreamingContext context)
		{
			IsSerializing = false;
		}

		protected virtual void ClearNavigationProperties()
		{
		}

		#endregion

        #region "Properties"
		[DataMember()]
		public Unit ParentUnit {get;set;}
		
        public ModifierType ModifierType {get;set;}			
		#endregion
	}

}


		

		



