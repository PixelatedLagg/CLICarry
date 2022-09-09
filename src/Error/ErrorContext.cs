namespace CLICarry
{
    public class ErrorContext
    {
        public readonly ErrorType ErrorType;
        public readonly string? Command;
        public readonly string? Flag;
        public readonly string? Value;
        internal ErrorContext(ErrorType errorType, string? command, string? flag, string? value)
        {
            ErrorType = errorType;
            Command = command;
            Flag = flag;
            Value = value;
        }
    }
}