using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Units
{
	[DataContract(IsReference = true)]
	[KnownType(typeof(Unit))]
	[Serializable()]
	public partial class UnitType : IEquatable<UnitType>
	{
        #region "Constructors"
		public UnitType() : base()
		{

		}
		#endregion

		#region "Primitive Properties"

		private int _iD;
		[DataMember()]
		public int ID {
			get { return _iD; }
			set {
				if (!Equals(_iD, value)) {
					_iD = value;
				}
			}
		}

		private string _name;
		[DataMember()]
		public string Name {
			get { return _name; }
			set {
				if (!Equals(_name, value)) {
					_name = value;
				}
			}
		}

		private string _description;
		[DataMember()]
		public string Description {
			get { return _description; }
			set {
				if (!Equals(_description, value)) {
					_description = value;
				}
			}
		}


		#endregion

		#region "Navigation Properties"

		[DataMember()]
		public List<Unit> Units {
			get {
				if (_units == null && IsSerializing == false) {
					_units = new List<Unit>();
			    }
				return _units;
			}
			set {
				if (!object.ReferenceEquals(_units, value)) {
					_units = value;
				}
			}
		}


		private List<Unit> _units;
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

		protected virtual void ClearNavigationProperties()
		{
			Units.Clear();
		}

		#endregion

		#region "IEquatable(Of UnitType)"
		public override int GetHashCode()
		{
			return (this.Name).GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (obj == null || !object.ReferenceEquals(obj.GetType(), typeof(UnitType))) {
				return false;
			}

			UnitType unitTypeObj = (UnitType)obj;

			return this.Equals(unitTypeObj);
		}

		public bool Equals(UnitType other)
		{
			if (other == null) {
				return false;
			}

			if (this.Name != other.Name) {
				return false;
			} else {
				return true;
			}
		}

		public static bool operator !=(UnitType left, UnitType right)
		{
			if (left == null && right == null) {
				return true;
			} else if (left == null || right == null) {
				return true;
			} else {
				return !left.Equals(right);
			}
		}

		public static bool operator ==(UnitType left, UnitType right)
		{
			if (left == null && right == null) {
				return false;
			} else if (left == null || right == null) {
				return false;
			} else {
				return left.Equals(right);
			}
		}
		#endregion
	}

}