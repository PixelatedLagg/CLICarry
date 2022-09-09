namespace CLICarry
{
    public sealed class CommandArgs : EventArgs
    {
        public Dictionary<string, object?> Flags = new Dictionary<string, object?>();
        public CommandArgs(List<(string, object?)> flags)
        {
            foreach ((string name, object? value) flag in flags)
            {
                Flags.Add(flag.name, flag.value);
            }
        }
    }
}