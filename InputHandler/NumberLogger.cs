using System;

namespace InputHandler;
public delegate void NumberLogEvent(int number);
public class NumberLogger
{
    public event NumberLogEvent OnLog;

    public NumberLogger(int number)
    {
        OnLog += (Log);
        OnLog.Invoke(number);
    }  
    public void Log(int number)
    {
        var logger = new Logger<int>(number);
    }
}