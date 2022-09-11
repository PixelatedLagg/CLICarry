namespace CLICarry
{
    public sealed class Flag
    {
        public string Name;
        public FlagValueType FlagValueType;
        public object? Value;
        public Flag(string name, FlagValueType flagValueType = FlagValueType.None)
        {
            Name = name;
            FlagValueType = flagValueType;
        }
        internal Flag SetValue(object? value)
        {
            Value = value;
            return this;
        }
    }
}