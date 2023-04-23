static class Notification
{
  public static void Success(string message)
  {
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
  }

  public static void Error(string message)
  {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    System.Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
  }

  public static void Info(string message)
  {
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    System.Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
  }

  public static void Warning(string message)
  {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    System.Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
  }
}