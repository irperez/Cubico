using System;
using System.Runtime.Serialization;

namespace Cubico
{
    // Represents a unit of measure's symbol, or alternate methods to identify a unit of measure.
    // Inch = ", inches, in, in. etc.
#if (!PCL && !NETSTANDARD1_4)
    [Serializable]
#endif
    [DataContract(IsReference = true)]
	[KnownType(typeof(Unit))]
	public partial class Symbol
	{
		#region "Constructors"
		public Symbol ()
		{
		}

		public Symbol (Unit unit)
		{
			if (unit == null) {
				throw new ArgumentNullException ("unit");
			}

			this.Unit = unit;
		}
		#endregion
		#region "Primitive Properties"
		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public string Value { get; set; }

		[DataMember]
		public bool IsDefault { get; set; }

		[DataMember]
		public int UnitId { get; set; }
		#endregion
		#region "Navigation Properties"
		[DataMember]
		public Unit Unit {
			get { return _unit; }
			set {
				if (!object.ReferenceEquals (_unit, value)) {
					Unit previousValue = _unit;
					_unit = value;
					FixupUnit (previousValue);
				}
			}
		}

		Unit _unit;
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
		#endregion
		#region "Association Fixup"
		void FixupUnit (Unit previousValue)
		{
			if (IsDeserializing) {
				return;
			}

			if (previousValue != null && previousValue.Symbols.Contains (this)) {
				previousValue.Symbols.Remove (this);
			}

			if (Unit != null) {
				if (!Unit.Symbols.Contains (this)) {
					Unit.Symbols.Add (this);
				}

				UnitId = Unit.ID;
			}
		}
		#endregion
		#region "IEquatable"
		public override int GetHashCode ()
		{
			return this.Value.GetHashCode ();
		}

		public override bool Equals (object obj)
		{
			if ((object)obj == null) {
				return false;
			} else if (!object.ReferenceEquals (obj.GetType (), this.GetType ())) {
				return false;
			} else {
				return this.Equals ((Symbol)obj);
			}
		}

		public bool Equals (Symbol other)
		{
			if ((object)other == null) {
				return false;
			} else {
				if (this.Value != other.Value) {
					return false;
				} else {
					return true;
				}
			}
		}

		public static bool operator != (Symbol left, Symbol right)
		{
			return !(left == right);
		}

		public static bool operator == (Symbol left, Symbol right)
		{
			if (object.ReferenceEquals (left, right)) {
				return true;
			} else if ((object)left == null || (object)right == null) {
				return false;
			} else {
				return left.Equals (right);
			}
		}
		#endregion
		public override string ToString ()
		{
			return this.Value;
		}
	}
}