using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
  public class ConsoleLogger: ILogger
  {
    static public void Trace(string message)
    {
      Log(message, LogLevel.Trace);
    }
    static public void Info(string message)
    {
      Log(message, LogLevel.Info);
    }
    static public void Debug(string message)
    {
      Log(message, LogLevel.Debug);
    }
    static public void Warning(string message)
    {
      Log(message, LogLevel.Warning);
    }
    static public void Error(string message)
    {
      Log(message, LogLevel.Error);
    }
    static public void Fatal(string message)
    {
      Log(message, LogLevel.Fatal);
    }
    static public void Log(string message, LogLevel logLevel)
    {
      DateTime currentTime = DateTime.Now;
      Console.WriteLine($"| {currentTime.ToLongTimeString()} | ConsoleLogger | {logLevel} | {message} |");
    }

  }
}
