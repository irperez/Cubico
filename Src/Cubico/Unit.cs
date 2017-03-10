using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;


namespace Cubico
{
#if (!PCL && !NETSTANDARD1_6)
    [Serializable]
#endif
    [DataContract(IsReference = true)]
	[KnownType(typeof(UnitType))]
	[KnownType(typeof(Symbol))]
	[KnownType(typeof(Modifier))]
	public partial class Unit : IEquatable<Unit>
	{
		#region "Constructors"
		public Unit () : base()
		{
		}

		public Unit (UnitType unitType)
		{
			if (unitType == null) {
				throw new ArgumentNullException ("unitType");
			}

			this.UnitType = unitType;
		}

		public bool IsDefault {
			get {
				foreach (Modifier mod in this.Modifiers) {
					if (mod.UnitSourceID == mod.UnitTargetID && mod.UnitSourceID == this.ID) {
						return true;
					}
				}

				return false;
			}
		}
		#endregion
		#region "Primitive Properties"
		[DataMember]
		public int ID { get; set; }

		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public int UnitTypeID { get; set; }
		#endregion
		#region "Navigation Properties"
		[DataMember]
		public UnitType UnitType { get; set; }

		private List<Symbol> _symbols;

		[DataMember]
		public List<Symbol> Symbols {
			get {
				if (_symbols == null && IsSerializing == false) {
					_symbols = new List<Symbol> ();
				}
				return _symbols;
			}
			set {
				if (!object.ReferenceEquals (_symbols, value)) {
					_symbols = value;
				}
			}
		}

		private List<Modifier> _sources;

		[DataMember]
		public List<Modifier> Sources {
			get {
				if (_sources == null && IsSerializing == false) {
					_sources = new List<Modifier> ();
				}
				return _sources;
			}
			set {
				if (!object.ReferenceEquals (_sources, value)) {
					_sources = value;
				}
			}
		}

		private List<Modifier> _modifiers;

		[DataMember]
		public List<Modifier> Modifiers {
			get {
				if (_modifiers == null && IsSerializing == false) {
					_modifiers = new List<Modifier> ();
				}
				return _modifiers;
			}
			set {
				if (!object.ReferenceEquals (_modifiers, value)) {
					_modifiers = value;
				}
			}
		}
		#endregion
		#region "ChangeTracking"
		private bool _isDeserializing;

		protected bool IsDeserializing {
			get { return _isDeserializing; }
			private set { _isDeserializing = value; }
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

		private bool _isSerializing = false;

		protected bool IsSerializing {
			get { return _isSerializing; }
			private set { _isSerializing = value; }
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
			UnitType = null;
			Symbols.Clear ();
			Sources.Clear ();
			Modifiers.Clear ();
		}
		#endregion
		#region "Properties"
		public string DefaultSymbol {
			get {
				Symbol symbol = (from s in this.Symbols
                                 where s.IsDefault = true
                                 select s).FirstOrDefault ();

				if (symbol == null) {
					return string.Empty;
				} else {
					return symbol.Value;
				}
			}
		}
		#endregion
		#region "IEquatable"
		public override int GetHashCode ()
		{
			return this.Name.GetHashCode ();
		}

		public override bool Equals (object obj)
		{
			if ((object)obj == null) {
				return false;
			} else if (!object.ReferenceEquals (obj.GetType (), this.GetType ())) {
				return false;
			} else {
				return this.Equals ((Unit)obj);
			}
		}

		public bool Equals (Unit other)
		{
			if (object.ReferenceEquals (other, null)) {
				return false;
			} else {
				if (this.Name != other.Name) {
					return false;
				} else {
					return true;
				}
			}
		}

		public static bool operator != (Unit left, Unit right)
		{
			return !(left == right);
		}

		public static bool operator == (Unit left, Unit right)
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
			return this.Name;
		}
	}
}