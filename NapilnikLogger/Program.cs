namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogWritter();
            ILogger consoleLogger = new ConsoleLogWritter();
            ILogger secureFileLogger = new SecureFileLogWriter(fileLogger);
            ILogger secureConsoleLogger = new SecureConsoleLogWritter(consoleLogger);
            ILogger consoleAndSecureFileLogger = new ConsoleAndSecureFileLogWriter(consoleLogger, secureFileLogger);
            
            Pathfinder[] pathfinders =
            {
                new Pathfinder(fileLogger),
                new Pathfinder(consoleLogger),
                new Pathfinder(secureFileLogger),
                new Pathfinder(secureConsoleLogger),
                new Pathfinder(consoleAndSecureFileLogger)
            };
        }
    }
}