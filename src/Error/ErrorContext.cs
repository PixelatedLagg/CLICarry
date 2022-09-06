namespace CLICarry
{
    public class ErrorContext
    {
        public readonly ErrorType ErrorType;
        public readonly string? Command;
        public readonly string? Flag;
        internal ErrorContext(ErrorType errorType, string? command, string? flag)
        {
            ErrorType = errorType;
            Command = command;
            Flag = flag;
        }
    }
}