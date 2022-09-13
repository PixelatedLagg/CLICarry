namespace CLICarry
{
    /// <summary>Designate a CLI.</summary>
    public interface CLI
    {
        /// <summary>Called when parsing CLI input results in error.</summary>
        /// <param name="context">The ErrorContext associated with the error.</param>
        void Error(ErrorContext context);
    }
}