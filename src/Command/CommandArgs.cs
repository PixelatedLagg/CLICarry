using System;

namespace CLICarry
{
    /// <summary>Arguments for when a Command is called.</summary>
    public sealed class CommandArgs : EventArgs
    {
        /// <summary>All of the Flags used when the Command was called.</summary>
        public FlagList Flags = new FlagList();

        /// <summary>Create a new CommandArgs instance.</summary>
        /// <param name="flags">All of the Flags used when the Command was called.</param>
        public CommandArgs(FlagList flags)
        {
            Flags = flags;
        }
    }
}