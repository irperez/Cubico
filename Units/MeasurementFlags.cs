using System;

namespace Units
{

    [Flags()]
    public enum MeasurementFlags : int
    {
        None = 0,

        /// <summary>
        /// Stops the data string unit being changed by reading user input.
        /// </summary>
        ForceUnit = 1,

        /// <summary>
        /// Enforces a maximum value on the data string.
        /// </summary>
        UseMaxBound = 2,

        /// <summary>
        /// Enforces a minimum value on the data string.
        /// </summary>
        UseMinBound = 4
    }
}