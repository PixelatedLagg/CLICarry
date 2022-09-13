namespace CLICarry
{
    /// <summary>All ErrorTypes with parsing CLI input.</summary>
    public enum ErrorType
    {
        /// <summary>The provided command does not exist.</summary>
        InvalidCommand,

        /// <summary>The provided flag does not exist.</summary>
        InvalidFlag,

        /// <summary>Too many flags have been provided for the command.</summary>
        TooManyFlags,

        /// <summary>The provided value is not a valid data type.</summary>
        InvalidValue,

        /// <summary>No command has been provided.</summary>
        NoCommandProvided
    }
}