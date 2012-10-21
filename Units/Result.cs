namespace Units
{
    public enum Result
    {
        /// <summary>
        /// No error occured.
        /// </summary>
        NoError = 0,

        /// <summary>
        /// A general error occured.
        /// </summary>
        GenericError,

        /// <summary>
        /// Specified unit was not found.
        /// </summary>
        UnitNotFound,

        /// <summary>
        /// Specified unit group was not found.
        /// </summary>
        GroupNotFound,

        /// <summary>
        /// Unit exists.
        /// </summary>
        UnitExists,

        /// <summary>
        /// Specified unit was invalid.
        /// </summary>
        BadUnit,

        /// <summary>
        /// Specified value was invalid.
        /// </summary>
        BadValue,

        /// <summary>
        /// Two units were used that are not in the same group.
        /// </summary>
        UnitMismatch,

        /// <summary>
        /// An input value was too high.
        /// </summary>
        ValueTooHigh,

        /// <summary>
        /// An input value was too low.
        /// </summary>
        ValueTooLow
    }
}

