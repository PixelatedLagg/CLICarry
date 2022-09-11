namespace CLICarry
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class Command : Attribute
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
            Flags = new Flag[]
            {
                new Flag(flag1, value1)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2),
                new Flag(flag3, value3)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2),
                new Flag(flag3, value3),
                new Flag(flag4, value4)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4, string flag5, FlagValueType value5)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2),
                new Flag(flag3, value3),
                new Flag(flag4, value4),
                new Flag(flag5, value5)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4, string flag5, FlagValueType value5, string flag6, FlagValueType value6)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2),
                new Flag(flag3, value3),
                new Flag(flag4, value4),
                new Flag(flag5, value5),
                new Flag(flag6, value6)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4, string flag5, FlagValueType value5, string flag6, FlagValueType value6, string flag7, FlagValueType value7)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2),
                new Flag(flag3, value3),
                new Flag(flag4, value4),
                new Flag(flag5, value5),
                new Flag(flag6, value6),
                new Flag(flag7, value7)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4, string flag5, FlagValueType value5, string flag6, FlagValueType value6, string flag7, FlagValueType value7, string flag8, FlagValueType value8)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2),
                new Flag(flag3, value3),
                new Flag(flag4, value4),
                new Flag(flag5, value5),
                new Flag(flag6, value6),
                new Flag(flag7, value7),
                new Flag(flag8, value8)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4, string flag5, FlagValueType value5, string flag6, FlagValueType value6, string flag7, FlagValueType value7, string flag8, FlagValueType value8, string flag9, FlagValueType value9)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2),
                new Flag(flag3, value3),
                new Flag(flag4, value4),
                new Flag(flag5, value5),
                new Flag(flag6, value6),
                new Flag(flag7, value7),
                new Flag(flag8, value8),
                new Flag(flag9, value9)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4, string flag5, FlagValueType value5, string flag6, FlagValueType value6, string flag7, FlagValueType value7, string flag8, FlagValueType value8, string flag9, FlagValueType value9, string flag10, FlagValueType value10)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2),
                new Flag(flag3, value3),
                new Flag(flag4, value4),
                new Flag(flag5, value5),
                new Flag(flag6, value6),
                new Flag(flag7, value7),
                new Flag(flag8, value8),
                new Flag(flag9, value9),
                new Flag(flag10, value10)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4, string flag5, FlagValueType value5, string flag6, FlagValueType value6, string flag7, FlagValueType value7, string flag8, FlagValueType value8, string flag9, FlagValueType value9, string flag10, FlagValueType value10, string flag11, FlagValueType value11)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2),
                new Flag(flag3, value3),
                new Flag(flag4, value4),
                new Flag(flag5, value5),
                new Flag(flag6, value6),
                new Flag(flag7, value7),
                new Flag(flag8, value8),
                new Flag(flag9, value9),
                new Flag(flag10, value10),
                new Flag(flag11, value11)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4, string flag5, FlagValueType value5, string flag6, FlagValueType value6, string flag7, FlagValueType value7, string flag8, FlagValueType value8, string flag9, FlagValueType value9, string flag10, FlagValueType value10, string flag11, FlagValueType value11, string flag12, FlagValueType value12)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2),
                new Flag(flag3, value3),
                new Flag(flag4, value4),
                new Flag(flag5, value5),
                new Flag(flag6, value6),
                new Flag(flag7, value7),
                new Flag(flag8, value8),
                new Flag(flag9, value9),
                new Flag(flag10, value10),
                new Flag(flag11, value11),
                new Flag(flag12, value12)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4, string flag5, FlagValueType value5, string flag6, FlagValueType value6, string flag7, FlagValueType value7, string flag8, FlagValueType value8, string flag9, FlagValueType value9, string flag10, FlagValueType value10, string flag11, FlagValueType value11, string flag12, FlagValueType value12, string flag13, FlagValueType value13)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2),
                new Flag(flag3, value3),
                new Flag(flag4, value4),
                new Flag(flag5, value5),
                new Flag(flag6, value6),
                new Flag(flag7, value7),
                new Flag(flag8, value8),
                new Flag(flag9, value9),
                new Flag(flag10, value10),
                new Flag(flag11, value11),
                new Flag(flag12, value12),
                new Flag(flag13, value13)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4, string flag5, FlagValueType value5, string flag6, FlagValueType value6, string flag7, FlagValueType value7, string flag8, FlagValueType value8, string flag9, FlagValueType value9, string flag10, FlagValueType value10, string flag11, FlagValueType value11, string flag12, FlagValueType value12, string flag13, FlagValueType value13, string flag14, FlagValueType value14)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2),
                new Flag(flag3, value3),
                new Flag(flag4, value4),
                new Flag(flag5, value5),
                new Flag(flag6, value6),
                new Flag(flag7, value7),
                new Flag(flag8, value8),
                new Flag(flag9, value9),
                new Flag(flag10, value10),
                new Flag(flag11, value11),
                new Flag(flag12, value12),
                new Flag(flag13, value13),
                new Flag(flag14, value14)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4, string flag5, FlagValueType value5, string flag6, FlagValueType value6, string flag7, FlagValueType value7, string flag8, FlagValueType value8, string flag9, FlagValueType value9, string flag10, FlagValueType value10, string flag11, FlagValueType value11, string flag12, FlagValueType value12, string flag13, FlagValueType value13, string flag14, FlagValueType value14, string flag15, FlagValueType value15)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2),
                new Flag(flag3, value3),
                new Flag(flag4, value4),
                new Flag(flag5, value5),
                new Flag(flag6, value6),
                new Flag(flag7, value7),
                new Flag(flag8, value8),
                new Flag(flag9, value9),
                new Flag(flag10, value10),
                new Flag(flag11, value11),
                new Flag(flag12, value12),
                new Flag(flag13, value13),
                new Flag(flag14, value14),
                new Flag(flag15, value15)
            };
        }
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2, string flag3, FlagValueType value3, string flag4, FlagValueType value4, string flag5, FlagValueType value5, string flag6, FlagValueType value6, string flag7, FlagValueType value7, string flag8, FlagValueType value8, string flag9, FlagValueType value9, string flag10, FlagValueType value10, string flag11, FlagValueType value11, string flag12, FlagValueType value12, string flag13, FlagValueType value13, string flag14, FlagValueType value14, string flag15, FlagValueType value15, string flag16, FlagValueType value16)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2),
                new Flag(flag3, value3),
                new Flag(flag4, value4),
                new Flag(flag5, value5),
                new Flag(flag6, value6),
                new Flag(flag7, value7),
                new Flag(flag8, value8),
                new Flag(flag9, value9),
                new Flag(flag10, value10),
                new Flag(flag11, value11),
                new Flag(flag12, value12),
                new Flag(flag13, value13),
                new Flag(flag14, value14),
                new Flag(flag15, value15),
                new Flag(flag16, value16)
            };
        }
    }
}