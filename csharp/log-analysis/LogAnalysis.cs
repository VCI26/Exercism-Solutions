using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string message, string delimeter)
    {
        return message.Split(delimeter)[1];
    }    

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string message, string delimeterStart, string delimeterEnd)
    {
        return message.Split(delimeterStart)[1].Split(delimeterEnd)[0];
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string message)
    {
        return message.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string message)
    {
        return message.SubstringBetween("[", "]");
    }
}