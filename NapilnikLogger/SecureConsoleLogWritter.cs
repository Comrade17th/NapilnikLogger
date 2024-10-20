namespace Lesson;

class SecureConsoleLogWritter : ILogger
{
    private ILogger _logger;

    public SecureConsoleLogWritter(ILogger logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public void WriteError(string message)
    {
        if (DateTime.Now.DayOfWeek == DayOfWeek.Friday) 
            _logger.WriteError(message); 
    }
}