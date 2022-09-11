using System.Reflection;

namespace CLICarry
{
    public static class CLIManager
    {
        public static void Run<T>(string[] input) where T : class, CLI
        {
            T instance = Activator.CreateInstance<T>();
            if (input.Length == 0) //check if command is provided
            {
                instance.Error(new ErrorContext(ErrorType.NoCommandProvided, null, null, null));
                return;
            }
            if (input[0].Substring(1)[0] == '-')
            {
                instance.Error(new ErrorContext(ErrorType.NoCommandProvided, input[0], null, null));
                return;
            }
            List<Command> commands = new List<Command>();
            MethodInfo[] methods = typeof(T).GetMethods();
            int flagCount = 0;
            bool checkingType = false;
            FlagList flags = new FlagList();
            Flag currentFlag = new Flag("default");
            foreach (MethodInfo method in methods)
            {
                Command? command = (Command?)(Attribute.GetCustomAttribute(method, typeof(Command)));
                if (command != null)
                {
                    if (input[0] == command.Name) //check if command matches
                    {
                        for (int i = 1; i < input.Length; i++)
                        {
                            if (input[i][0] == '-') //check if string is a flag
                            {
                                if (checkingType)
                                {
                                    checkingType = false;
                                    switch (currentFlag.FlagValueType)
                                    {
                                        case FlagValueType.Int:
                                            int intResult;
                                            if (Int32.TryParse(input[i], out intResult))
                                            {
                                                flags.Add(currentFlag.SetValue(intResult));
                                                continue;
                                            }
                                            instance.Error(new ErrorContext(ErrorType.InvalidValue, input[0], input[i - 1], input[i]));
                                            return;
                                        case FlagValueType.Double:
                                            double doubleResult;
                                            if (Double.TryParse(input[i], out doubleResult))
                                            {
                                                flags.Add(currentFlag.SetValue(doubleResult));
                                                continue;
                                            }
                                            instance.Error(new ErrorContext(ErrorType.InvalidValue, input[0], input[i - 1], input[i]));
                                            return;
                                        case FlagValueType.String:
                                            flags.Add(currentFlag.SetValue(input[i]));
                                            continue;
                                        case FlagValueType.Ulong:
                                            ulong ulongResult;
                                            if (UInt64.TryParse(input[i], out ulongResult))
                                            {
                                                flags.Add(currentFlag.SetValue(ulongResult));
                                                continue;
                                            }
                                            instance.Error(new ErrorContext(ErrorType.InvalidValue, input[0], input[i - 1], input[i]));
                                            return;
                                    }
                                }
                                currentFlag = command.Flags.First(x => x.Name == input[i].Substring(1));
                                flagCount++;
                                if (flagCount > command.Flags.Length) //check for too many flags
                                {
                                    instance.Error(new ErrorContext(ErrorType.TooManyFlags, input[0], input[i], null));
                                    return;
                                }
                                if (input[i].Substring(1) != currentFlag.Name) //check for invalid flag
                                {
                                    instance.Error(new ErrorContext(ErrorType.InvalidFlag, input[0], input[i], null));
                                    return;
                                }
                                if (currentFlag.FlagValueType != FlagValueType.None) //check if looking for value
                                {
                                    checkingType = true;
                                }
                                else
                                {
                                    flags.Add(currentFlag.SetValue(null));
                                }
                            }
                            else
                            {
                                if (!checkingType)
                                {
                                    instance.Error(new ErrorContext(ErrorType.InvalidFlag, input[0], input[i], null));
                                    return;
                                }
                                checkingType = false;
                                switch (currentFlag.FlagValueType)
                                {
                                    case FlagValueType.Int:
                                        int intResult;
                                        if (Int32.TryParse(input[i], out intResult))
                                        {
                                            flags.Add(currentFlag.SetValue(intResult));
                                            continue;
                                        }
                                        instance.Error(new ErrorContext(ErrorType.InvalidValue, input[0], input[i - 1], input[i]));
                                        return;
                                    case FlagValueType.Double:
                                        double doubleResult;
                                        if (Double.TryParse(input[i], out doubleResult))
                                        {
                                            flags.Add(currentFlag.SetValue(doubleResult));
                                            continue;
                                        }
                                        instance.Error(new ErrorContext(ErrorType.InvalidValue, input[0], input[i - 1], input[i]));
                                        return;
                                    case FlagValueType.String:
                                        flags.Add(currentFlag.SetValue(input[i]));
                                        break;
                                    case FlagValueType.Ulong:
                                        ulong ulongResult;
                                        if (UInt64.TryParse(input[i], out ulongResult))
                                        {
                                            flags.Add(currentFlag.SetValue(ulongResult));
                                            continue;
                                        }
                                        instance.Error(new ErrorContext(ErrorType.InvalidValue, input[0], input[i - 1], input[i]));
                                        return;
                                }
                            }
                        }
                        method.Invoke(instance, new object[] { new CommandArgs(flags) });
                        return;
                    }
                }
            }
            instance.Error(new ErrorContext(ErrorType.InvalidCommand, input[0], null, null));
        }
    }
}