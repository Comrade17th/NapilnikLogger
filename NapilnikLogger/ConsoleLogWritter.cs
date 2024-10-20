namespace Lesson;

class ConsoleLogWritter : ILogger
{
    public void WriteError(string message)
    {
        Console.WriteLine(message);
    }
}