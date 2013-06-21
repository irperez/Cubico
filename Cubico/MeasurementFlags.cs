using System;

namespace Cubico
{
	[Flags]
    public enum MeasurementFlags : int
	{
		None = 0,

        // Stops the data string unit being changed by reading user input.
		ForceUnit = 1,

        // Enforces a maximum value on the data string.
		UseMaxBound = 2,

        // Enforces a minimum value on the data string.
		UseMinBound = 4
	}
}