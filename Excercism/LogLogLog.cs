/*
 * The C# enum type represents a fixed set of named constants (an enumeration). 
 * Its chief purpose is to provide a type-safe way of interacting with numeric constants, 
 * limiting the available values to a pre-defined set. A simple enum can be defined as follows:

enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}
*/

using System;

enum LogLevel
{
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
    Unknown = 0
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        switch (logLine.Substring(1, 3)) //select string inside [] LogLine.ParseLogLevel("[INF]: File deleted")
        {
            case "TRC": return LogLevel.Trace; 
            case "DBG": return LogLevel.Debug; 
            case "INF": return LogLevel.Info; 
            case "WRN": return LogLevel.Warning; 
            case "ERR": return LogLevel.Error; 
            case "FTL": return LogLevel.Fatal; 
            default: return LogLevel.Unknown; 
        }
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:" + message;
    }
}