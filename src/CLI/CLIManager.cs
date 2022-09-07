using System.Linq;
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
                Command? attribute = (Command)(Attribute.GetCustomAttribute(member, typeof(Command)));
                if (attribute == null)
                {
                    continue;
                }
                commands.Add(new Command());
            }
        }
    }
}