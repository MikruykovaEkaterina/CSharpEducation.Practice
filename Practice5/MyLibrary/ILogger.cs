using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
  internal interface ILogger
  {
    static void Trace(string message) { }
    static void Info(string message) { }
    static void Debug(string message) { }
    static void Warning(string message) { }
    static void Error(string message) { }
    static void Fatal(string message) { }
    static void Log(string message, LogLevel logLevel) { }
  }

  public enum LogLevel
  {
    Debug,
    Info,
    Warning,
    Error,
    Fatal,
    Trace
  }
}
