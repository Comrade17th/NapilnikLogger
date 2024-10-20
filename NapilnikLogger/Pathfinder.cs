namespace Lesson;

public class Pathfinder
{
    private ILogger _logger;

    public Pathfinder(ILogger logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public void Find(string message)
    {
        _logger.WriteError(message);
    }
}