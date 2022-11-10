using System;

namespace InputHandler;
public delegate void LoggerEvent<T> (T arg);
public class Logger<T>
{
    public event LoggerEvent<T> OnLog;

    public Logger(T message)
    {
        OnLog += (Log);
        OnLog.Invoke(message);
    }
    
    void Log(T message)
    {
        if (message is string)
        {
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("Not a string");
        }
    }
}