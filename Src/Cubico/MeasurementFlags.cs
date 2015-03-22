using System;

namespace Cubico
{
	[Flags]
	public enum MeasurementFlags : int
	{
		None = 0,
		ForceUnit = 1, // Stops the data string unit being changed by reading user input.
		UseMaxBound = 2, // Enforces a maximum value on the data string.
		UseMinBound = 4 // Enforces a minimum value on the data string.
	}
}