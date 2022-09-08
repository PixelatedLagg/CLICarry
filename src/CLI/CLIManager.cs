using System.Reflection;

namespace CLICarry
{
    public static class CLIManager
    {
        public static void Run<T>(string[] input) where T : class, CLI
        {
            List<Command> commands = new List<Command>();
            MemberInfo[] MyMemberInfo = typeof(T).GetMethods();
            foreach (MemberInfo member in MyMemberInfo)
            {
                Command? attribute = (Command?)(Attribute.GetCustomAttribute(member, typeof(Command)));
                if (attribute != null)
                {
                    commands.Add(attribute);
                }
            }
            foreach (Command command in commands)
            {
                if (input[0] == command.Name) //check if command matches
                {
                    if (input.Length - 1 != command.Flags.Length)
                    {

                    }
                    return;
                }
                //non command error
            }
        }
    }
}