using System;

namespace CLICarry
{
    /// <summary>Designate a command.</summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class Command : Attribute
    {
        /// <summary>The Command name.</summary>
        public string Name;

        /// <summary>An array of all Command Flags.</summary>
        public Flag[] Flags;

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        public Command(string name)
        {
            Name = name;
            Flags = new Flag[0];
        }

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        public Command(string name, string flag1, FlagValueType value1)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1)
            };
        }

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        public Command(string name, string flag1, FlagValueType value1, string flag2, FlagValueType value2)
        {
            Name = name;
            Flags = new Flag[]
            {
                new Flag(flag1, value1),
                new Flag(flag2, value2)
            };
        }

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        /// <param name="flag3">Name of Flag 3.</param>
        /// <param name="value3">FlagValueType of Flag 3.</param>
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

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        /// <param name="flag3">Name of Flag 3.</param>
        /// <param name="value3">FlagValueType of Flag 3.</param>
        /// <param name="flag4">Name of Flag 4.</param>
        /// <param name="value4">FlagValueType of Flag 4.</param>
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

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        /// <param name="flag3">Name of Flag 3.</param>
        /// <param name="value3">FlagValueType of Flag 3.</param>
        /// <param name="flag4">Name of Flag 4.</param>
        /// <param name="value4">FlagValueType of Flag 4.</param>
        /// <param name="flag5">Name of Flag 5.</param>
        /// <param name="value5">FlagValueType of Flag 5.</param>
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

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        /// <param name="flag3">Name of Flag 3.</param>
        /// <param name="value3">FlagValueType of Flag 3.</param>
        /// <param name="flag4">Name of Flag 4.</param>
        /// <param name="value4">FlagValueType of Flag 4.</param>
        /// <param name="flag5">Name of Flag 5.</param>
        /// <param name="value5">FlagValueType of Flag 5.</param>
        /// <param name="flag6">Name of Flag 6.</param>
        /// <param name="value6">FlagValueType of Flag 6.</param>
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

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        /// <param name="flag3">Name of Flag 3.</param>
        /// <param name="value3">FlagValueType of Flag 3.</param>
        /// <param name="flag4">Name of Flag 4.</param>
        /// <param name="value4">FlagValueType of Flag 4.</param>
        /// <param name="flag5">Name of Flag 5.</param>
        /// <param name="value5">FlagValueType of Flag 5.</param>
        /// <param name="flag6">Name of Flag 6.</param>
        /// <param name="value6">FlagValueType of Flag 6.</param>
        /// <param name="flag7">Name of Flag 7.</param>
        /// <param name="value7">FlagValueType of Flag 7.</param>
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

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        /// <param name="flag3">Name of Flag 3.</param>
        /// <param name="value3">FlagValueType of Flag 3.</param>
        /// <param name="flag4">Name of Flag 4.</param>
        /// <param name="value4">FlagValueType of Flag 4.</param>
        /// <param name="flag5">Name of Flag 5.</param>
        /// <param name="value5">FlagValueType of Flag 5.</param>
        /// <param name="flag6">Name of Flag 6.</param>
        /// <param name="value6">FlagValueType of Flag 6.</param>
        /// <param name="flag7">Name of Flag 7.</param>
        /// <param name="value7">FlagValueType of Flag 7.</param>
        /// <param name="flag8">Name of Flag 8.</param>
        /// <param name="value8">FlagValueType of Flag 8.</param>
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

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        /// <param name="flag3">Name of Flag 3.</param>
        /// <param name="value3">FlagValueType of Flag 3.</param>
        /// <param name="flag4">Name of Flag 4.</param>
        /// <param name="value4">FlagValueType of Flag 4.</param>
        /// <param name="flag5">Name of Flag 5.</param>
        /// <param name="value5">FlagValueType of Flag 5.</param>
        /// <param name="flag6">Name of Flag 6.</param>
        /// <param name="value6">FlagValueType of Flag 6.</param>
        /// <param name="flag7">Name of Flag 7.</param>
        /// <param name="value7">FlagValueType of Flag 7.</param>
        /// <param name="flag8">Name of Flag 8.</param>
        /// <param name="value8">FlagValueType of Flag 8.</param>
        /// <param name="flag9">Name of Flag 9.</param>
        /// <param name="value9">FlagValueType of Flag 9.</param>
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

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        /// <param name="flag3">Name of Flag 3.</param>
        /// <param name="value3">FlagValueType of Flag 3.</param>
        /// <param name="flag4">Name of Flag 4.</param>
        /// <param name="value4">FlagValueType of Flag 4.</param>
        /// <param name="flag5">Name of Flag 5.</param>
        /// <param name="value5">FlagValueType of Flag 5.</param>
        /// <param name="flag6">Name of Flag 6.</param>
        /// <param name="value6">FlagValueType of Flag 6.</param>
        /// <param name="flag7">Name of Flag 7.</param>
        /// <param name="value7">FlagValueType of Flag 7.</param>
        /// <param name="flag8">Name of Flag 8.</param>
        /// <param name="value8">FlagValueType of Flag 8.</param>
        /// <param name="flag9">Name of Flag 9.</param>
        /// <param name="value9">FlagValueType of Flag 9.</param>
        /// <param name="flag10">Name of Flag 10.</param>
        /// <param name="value10">FlagValueType of Flag 10.</param>
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

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        /// <param name="flag3">Name of Flag 3.</param>
        /// <param name="value3">FlagValueType of Flag 3.</param>
        /// <param name="flag4">Name of Flag 4.</param>
        /// <param name="value4">FlagValueType of Flag 4.</param>
        /// <param name="flag5">Name of Flag 5.</param>
        /// <param name="value5">FlagValueType of Flag 5.</param>
        /// <param name="flag6">Name of Flag 6.</param>
        /// <param name="value6">FlagValueType of Flag 6.</param>
        /// <param name="flag7">Name of Flag 7.</param>
        /// <param name="value7">FlagValueType of Flag 7.</param>
        /// <param name="flag8">Name of Flag 8.</param>
        /// <param name="value8">FlagValueType of Flag 8.</param>
        /// <param name="flag9">Name of Flag 9.</param>
        /// <param name="value9">FlagValueType of Flag 9.</param>
        /// <param name="flag10">Name of Flag 10.</param>
        /// <param name="value10">FlagValueType of Flag 10.</param>
        /// <param name="flag11">Name of Flag 11.</param>
        /// <param name="value11">FlagValueType of Flag 11.</param>
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

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        /// <param name="flag3">Name of Flag 3.</param>
        /// <param name="value3">FlagValueType of Flag 3.</param>
        /// <param name="flag4">Name of Flag 4.</param>
        /// <param name="value4">FlagValueType of Flag 4.</param>
        /// <param name="flag5">Name of Flag 5.</param>
        /// <param name="value5">FlagValueType of Flag 5.</param>
        /// <param name="flag6">Name of Flag 6.</param>
        /// <param name="value6">FlagValueType of Flag 6.</param>
        /// <param name="flag7">Name of Flag 7.</param>
        /// <param name="value7">FlagValueType of Flag 7.</param>
        /// <param name="flag8">Name of Flag 8.</param>
        /// <param name="value8">FlagValueType of Flag 8.</param>
        /// <param name="flag9">Name of Flag 9.</param>
        /// <param name="value9">FlagValueType of Flag 9.</param>
        /// <param name="flag10">Name of Flag 10.</param>
        /// <param name="value10">FlagValueType of Flag 10.</param>
        /// <param name="flag11">Name of Flag 11.</param>
        /// <param name="value11">FlagValueType of Flag 11.</param>
        /// <param name="flag12">Name of Flag 12.</param>
        /// <param name="value12">FlagValueType of Flag 12.</param>
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

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        /// <param name="flag3">Name of Flag 3.</param>
        /// <param name="value3">FlagValueType of Flag 3.</param>
        /// <param name="flag4">Name of Flag 4.</param>
        /// <param name="value4">FlagValueType of Flag 4.</param>
        /// <param name="flag5">Name of Flag 5.</param>
        /// <param name="value5">FlagValueType of Flag 5.</param>
        /// <param name="flag6">Name of Flag 6.</param>
        /// <param name="value6">FlagValueType of Flag 6.</param>
        /// <param name="flag7">Name of Flag 7.</param>
        /// <param name="value7">FlagValueType of Flag 7.</param>
        /// <param name="flag8">Name of Flag 8.</param>
        /// <param name="value8">FlagValueType of Flag 8.</param>
        /// <param name="flag9">Name of Flag 9.</param>
        /// <param name="value9">FlagValueType of Flag 9.</param>
        /// <param name="flag10">Name of Flag 10.</param>
        /// <param name="value10">FlagValueType of Flag 10.</param>
        /// <param name="flag11">Name of Flag 11.</param>
        /// <param name="value11">FlagValueType of Flag 11.</param>
        /// <param name="flag12">Name of Flag 12.</param>
        /// <param name="value12">FlagValueType of Flag 12.</param>
        /// <param name="flag13">Name of Flag 13.</param>
        /// <param name="value13">FlagValueType of Flag 13.</param>
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

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        /// <param name="flag3">Name of Flag 3.</param>
        /// <param name="value3">FlagValueType of Flag 3.</param>
        /// <param name="flag4">Name of Flag 4.</param>
        /// <param name="value4">FlagValueType of Flag 4.</param>
        /// <param name="flag5">Name of Flag 5.</param>
        /// <param name="value5">FlagValueType of Flag 5.</param>
        /// <param name="flag6">Name of Flag 6.</param>
        /// <param name="value6">FlagValueType of Flag 6.</param>
        /// <param name="flag7">Name of Flag 7.</param>
        /// <param name="value7">FlagValueType of Flag 7.</param>
        /// <param name="flag8">Name of Flag 8.</param>
        /// <param name="value8">FlagValueType of Flag 8.</param>
        /// <param name="flag9">Name of Flag 9.</param>
        /// <param name="value9">FlagValueType of Flag 9.</param>
        /// <param name="flag10">Name of Flag 10.</param>
        /// <param name="value10">FlagValueType of Flag 10.</param>
        /// <param name="flag11">Name of Flag 11.</param>
        /// <param name="value11">FlagValueType of Flag 11.</param>
        /// <param name="flag12">Name of Flag 12.</param>
        /// <param name="value12">FlagValueType of Flag 12.</param>
        /// <param name="flag13">Name of Flag 13.</param>
        /// <param name="value13">FlagValueType of Flag 13.</param>
        /// <param name="flag14">Name of Flag 14.</param>
        /// <param name="value14">FlagValueType of Flag 14.</param>
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

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        /// <param name="flag3">Name of Flag 3.</param>
        /// <param name="value3">FlagValueType of Flag 3.</param>
        /// <param name="flag4">Name of Flag 4.</param>
        /// <param name="value4">FlagValueType of Flag 4.</param>
        /// <param name="flag5">Name of Flag 5.</param>
        /// <param name="value5">FlagValueType of Flag 5.</param>
        /// <param name="flag6">Name of Flag 6.</param>
        /// <param name="value6">FlagValueType of Flag 6.</param>
        /// <param name="flag7">Name of Flag 7.</param>
        /// <param name="value7">FlagValueType of Flag 7.</param>
        /// <param name="flag8">Name of Flag 8.</param>
        /// <param name="value8">FlagValueType of Flag 8.</param>
        /// <param name="flag9">Name of Flag 9.</param>
        /// <param name="value9">FlagValueType of Flag 9.</param>
        /// <param name="flag10">Name of Flag 10.</param>
        /// <param name="value10">FlagValueType of Flag 10.</param>
        /// <param name="flag11">Name of Flag 11.</param>
        /// <param name="value11">FlagValueType of Flag 11.</param>
        /// <param name="flag12">Name of Flag 12.</param>
        /// <param name="value12">FlagValueType of Flag 12.</param>
        /// <param name="flag13">Name of Flag 13.</param>
        /// <param name="value13">FlagValueType of Flag 13.</param>
        /// <param name="flag14">Name of Flag 14.</param>
        /// <param name="value14">FlagValueType of Flag 14.</param>
        /// <param name="flag15">Name of Flag 15.</param>
        /// <param name="value15">FlagValueType of Flag 15.</param>
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

        /// <summary>Create a new Command instance.</summary>
        /// <param name="name">The Command name.</param>
        /// <param name="flag1">Name of Flag 1.</param>
        /// <param name="value1">FlagValueType of Flag 1.</param>
        /// <param name="flag2">Name of Flag 2.</param>
        /// <param name="value2">FlagValueType of Flag 2.</param>
        /// <param name="flag3">Name of Flag 3.</param>
        /// <param name="value3">FlagValueType of Flag 3.</param>
        /// <param name="flag4">Name of Flag 4.</param>
        /// <param name="value4">FlagValueType of Flag 4.</param>
        /// <param name="flag5">Name of Flag 5.</param>
        /// <param name="value5">FlagValueType of Flag 5.</param>
        /// <param name="flag6">Name of Flag 6.</param>
        /// <param name="value6">FlagValueType of Flag 6.</param>
        /// <param name="flag7">Name of Flag 7.</param>
        /// <param name="value7">FlagValueType of Flag 7.</param>
        /// <param name="flag8">Name of Flag 8.</param>
        /// <param name="value8">FlagValueType of Flag 8.</param>
        /// <param name="flag9">Name of Flag 9.</param>
        /// <param name="value9">FlagValueType of Flag 9.</param>
        /// <param name="flag10">Name of Flag 10.</param>
        /// <param name="value10">FlagValueType of Flag 10.</param>
        /// <param name="flag11">Name of Flag 11.</param>
        /// <param name="value11">FlagValueType of Flag 11.</param>
        /// <param name="flag12">Name of Flag 12.</param>
        /// <param name="value12">FlagValueType of Flag 12.</param>
        /// <param name="flag13">Name of Flag 13.</param>
        /// <param name="value13">FlagValueType of Flag 13.</param>
        /// <param name="flag14">Name of Flag 14.</param>
        /// <param name="value14">FlagValueType of Flag 14.</param>
        /// <param name="flag15">Name of Flag 15.</param>
        /// <param name="value15">FlagValueType of Flag 15.</param>
        /// <param name="flag16">Name of Flag 16.</param>
        /// <param name="value16">FlagValueType of Flag 16.</param>
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