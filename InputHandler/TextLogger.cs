using System;

namespace InputHandler;
public delegate void TextLogEvent(string number);
public class TextLogger
{
    public event TextLogEvent OnLog;

    public TextLogger(string text)
    {
        OnLog += (Log);
        OnLog.Invoke(text);
    }
    
    public void Log(string Log)
    {
        Logger<string> logger = new Logger<string>(Log);
    }
}