namespace CLICarry
{
    /// <summary>All valid FlagValueTypes.</summary>
    public enum FlagValueType
    {
        /// <summary>Signed 32-bit integer.</summary>
        Int,

        /// <summary>Double-precision floating-point number.</summary>
        Double,

        /// <summary>Array of characters.</summary>
        String,

        /// <summary>Unsigned 64-bit integer.</summary>
        Ulong,

        /// <summary>No value type, meaning the Flag does not accept a value.</summary>
        None
    }
}