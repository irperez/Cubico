namespace Cubico
{
	public enum Result : int
	{
		NoError = 0, // No error occured.
		GenericError, // A general error occured.
		UnitNotFound, // Specified unit was not found.
		GroupNotFound, // Specified unit group was not found.
		UnitExists, // Unit exists.
		BadUnit, // Specified unit was invalid.
		BadValue, // Specified value was invalid.
		UnitMismatch, // Two units were used that are not in the same group.
		ValueTooHigh, // An input value was too high.
		ValueTooLow // An input value was too low.
	}
}