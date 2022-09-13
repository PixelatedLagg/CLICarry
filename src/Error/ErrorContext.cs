namespace CLICarry
{
    /// <summary>The context of an error from parsing CLI input.</summary>
    public class ErrorContext
    {
        /// <summary>The ErrorType of the ErrorContext.</summary>
        public readonly ErrorType ErrorType;

        /// <summary>The command related to the error, if any.</summary>
        public readonly string Command;

        /// <summary>The flag related to the error, if any.</summary>
        public readonly string Flag;

        /// <summary>The flag value related to the error, if any.</summary>
        public readonly string Value;

        /// <summary>Create a new ErrorContext instance.</summary>
        /// <param name="errorType">The ErrorType of the ErrorContext.</param>
        /// <param name="command">The command related to the error, if any.</param>
        /// <param name="flag">The flag related to the error, if any.</param>
        /// <param name="value">The flag value related to the error, if any.</param>
        internal ErrorContext(ErrorType errorType, string command, string flag, string value)
        {
            ErrorType = errorType;
            Command = command;
            Flag = flag;
            Value = value;
        }
    }
}