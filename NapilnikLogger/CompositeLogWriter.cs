namespace Lesson;

class CompositeLogWriter : ILogger
{
    private ILogger[] _loggers;

    public CompositeLogWriter(params ILogger[] loggers)
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