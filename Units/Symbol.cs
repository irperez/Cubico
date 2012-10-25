using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.Serialization;


namespace Units
{
    /// <summary>
    /// Represents a unit of measure's symbol, or alternate methods to identify a unit of measure.
    /// </summary>
    /// <example>Inch = ", inches, in, in. etc.</example>
	[DataContract(IsReference = true)]
	[KnownType(typeof(Unit))]
	[Serializable()]
	public partial class Symbol 
	{

		#region "Primitive Properties"

		[DataMember()]
		public int Id {get;set;}

		[DataMember()]
		public string Value {get;set;}

		[DataMember()]
		public bool IsDefault {get;set;}
			
		[DataMember()]
		public int UnitId {get;set;}			
		#endregion

		#region "Navigation Properties"

		[DataMember()]
		public Unit Unit {
			get { return _unit; }
			set {
				if (!object.ReferenceEquals(_unit, value)) {
					Unit previousValue = _unit;
					_unit = value;
					FixupUnit(previousValue);
				}
			}
		}

		private Unit _unit;


		#endregion

		#region "ChangeTracking"

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
		#endregion

		#region "Association Fixup"

		private void FixupUnit(Unit previousValue)
		{
			if (IsDeserializing) {
				return;
			}

			if (previousValue != null && previousValue.Symbols.Contains(this)) {
				previousValue.Symbols.Remove(this);
			}

			if (Unit != null) {
				if (!Unit.Symbols.Contains(this)) {
					Unit.Symbols.Add(this);
				}

				UnitId = Unit.ID;
			}

		}

		#endregion

        public override string ToString()
        {
            return this.Value;
        }
	}

}

