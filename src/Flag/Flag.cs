namespace CLICarry
{
    public sealed class Flag
    {
        public readonly string Name;
        public readonly FlagValueType FlagValueType;
        public Flag(string name, FlagValueType flagValueType = FlagValueType.None)
        {
            Name = name;
            FlagValueType = flagValueType;
        }
    }
}