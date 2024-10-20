namespace Lesson;

class ConsoleAndSecureFileLogWriter : ILogger
{
    private ILogger[] _loggers;

    public ConsoleAndSecureFileLogWriter(params ILogger[] loggers)
    {
        _loggers = loggers;
    }


    public void WriteError(string message)
    {
        foreach (ILogger logger in _loggers)
        {
            logger.WriteError(message);
        }
    }
}