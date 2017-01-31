using System;
using System.Runtime.Serialization;

namespace Cubico
{
#if (!PCL && !NETSTANDARD1_4)
	[Serializable]
#endif
    [DataContract]
	public class ConversionResult : IEquatable<ConversionResult>
	{
		#region "Constructors"
		public ConversionResult ()
		{
			_result = Cubico.Result.NoError;
			_value = 0;
		}

		public ConversionResult (double value)
		{
			_result = Cubico.Result.NoError;
			_value = value;
		}

		public ConversionResult (double value, string symbol)
		{
			_result = Cubico.Result.NoError;
			_value = value;
			_symbol = symbol;
		}

		public ConversionResult (double value, Result result)
		{
			_result = result;
			_value = value;
		}

		public ConversionResult (Result result)
		{
			_result = result;
		}
		#endregion
		#region "Properties"
		Result _result;

		[DataMember]
		public Result Result {
			get { return _result; }
			set { _result = value; }
		}

		double _value;

		[DataMember]
		public double Value {
			get { return _value; }
			set { _value = value; }
		}

		string _symbol;

		[DataMember]
		public string Symbol {
			get { return _symbol; }
			set { _symbol = value; }
		}
		#endregion
		#region "IEquatable"
		public override int GetHashCode ()
		{
			return (this.Value.ToString () + this.Symbol.ToString () + this.Result.ToString ()).GetHashCode ();
		}

		public override bool Equals (object obj)
		{
			if (obj == null) {
				return false;
			} else if (!object.ReferenceEquals (obj.GetType (), typeof(ConversionResult))) {
				return false;
			}

			ConversionResult CrObj = (ConversionResult)obj;

			return this.Equals (CrObj);
		}

		public bool Equals (ConversionResult other)
		{
			if (other == null) {
				return false;
			}

			if (other.Value != this.Value) {
				return false;
			} else if (other.Symbol != this.Symbol) {
				return false;
			} else if (other.Result != this.Result) {
				return false;
			} else {
				return true;
			}
		}

		public static bool operator != (ConversionResult left, ConversionResult right)
		{
			return !left.Equals (right);
		}

		public static bool operator == (ConversionResult left, ConversionResult right)
		{
			return left.Equals (right);
		}
		#endregion
	}
}