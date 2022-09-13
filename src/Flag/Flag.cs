namespace CLICarry
{
    /// <summary>Store information about a Command flag.</summary>
    public sealed class Flag
    {
        /// <summary>The Flag name.</summary>
        public string Name;

        /// <summary>The Flag FlagValueType.</summary>
        public FlagValueType FlagValueType;

        /// <summary>The Flag value, if any. Will be null before any CLI input parsing.</summary>
        public object Value;

        /// <summary>Create a new Flag instance.</summary>
        /// <param name="name">The Flag name.</param>
        /// <param name="flagValueType">The Flag FlagValueType.</param>
        public Flag(string name, FlagValueType flagValueType = FlagValueType.None)
        {
            Name = name;
            FlagValueType = flagValueType;
        }

        /// <summary>Set the Flag value.</summary>
        /// <param name="value">The Flag value.</param>
        internal Flag SetValue(object value)
        {
            Value = value;
            return this;
        }
    }
}