namespace Lesson;

class FileLogWritter : ILogger
{
    public void WriteError(string message)
    {
        File.WriteAllText("log.txt", message);
    }
}