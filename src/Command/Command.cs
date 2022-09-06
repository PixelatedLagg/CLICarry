namespace CLICarry
{
    [AttributeUsage(AttributeTargets.Method)]
    public class Command : Attribute
    {
        public string Name;
        public Flag[] Flags;
        public Command(string name)
        {
            Name = name;
            Flags = new Flag[0];
        }
        public Command(string name, string flag1, FlagValueType value1)
        {
            Name = name;
            Flags = new Flag[1];
            Flags[0] = new Flag(flag1, value1);
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2)
        {
            Name = name;
            Flags = new Flag[2];
            Flags[0] = new Flag(flag1, value1);
            Flags[1] = new Flag(flag2, value2);
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3)
        {
            Name = name;
            Flags = new Flag[1];
            Flags[0] = new Flag(flag1, value1);
            Flags[1] = new Flag(flag2, value2);
            Flags[2] = new Flag(flag3, value3);
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4)
        {
            Name = name;
            Flags = new Flag[1];
            Flags[0] = new Flag(flag1, value1);
            Flags[1] = new Flag(flag2, value2);
            Flags[2] = new Flag(flag3, value3);
            Flags[3] = new Flag(flag4, value4);
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4, string flag5, FlagValueType value5)
        {
            Name = name;
            Flags = new Flag[1];
            Flags[0] = new Flag(flag1, value1);
            Flags[1] = new Flag(flag2, value2);
            Flags[2] = new Flag(flag3, value3);
            Flags[3] = new Flag(flag4, value4);
            Flags[4] = new Flag(flag5, value5);
        }
    }
}