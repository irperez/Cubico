namespace Cubico
{
	public enum Result : int
	{
        // No error occured.
		NoError = 0,

        // A general error occured.
		GenericError,

        // Specified unit was not found.
		UnitNotFound,

        // Specified unit group was not found.
		GroupNotFound,

        // Unit exists.
		UnitExists,

        // Specified unit was invalid.
		BadUnit,

        // Specified value was invalid.
		BadValue,

        // Two units were used that are not in the same group.
		UnitMismatch,

        // An input value was too high.
		ValueTooHigh,

        // An input value was too low.
		ValueTooLow
	}
}