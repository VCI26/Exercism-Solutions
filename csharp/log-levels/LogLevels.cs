using System;

static class LogLine
{
    public static string Message(string logLine) => logLine.Split(":")[1].Trim('\r', '\n', '\t').Trim();

    public static string LogLevel(string logLine) => logLine.Split(":")[0].Trim('[', ']').ToLower();

    public static string Reformat(string logLine) => Message(logLine) + " (" + LogLevel(logLine) + ")";

}
