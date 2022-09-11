namespace CLICarry
{
    public sealed class CommandArgs : EventArgs
    {
        public FlagList Flags = new FlagList();
        public CommandArgs(FlagList flags)
        {
            Flags = flags;
        }
    }
}