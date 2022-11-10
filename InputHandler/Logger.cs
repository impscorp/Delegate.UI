using System;

namespace InputHandler;

public class Logger
{
    public event EventHandler OnLog;
    
//write log 
    public void WriteLog(string message)
    {
        OnLog?.Invoke(this, new LogEventArgs(message));
    }
    
//log event args
    public class LogEventArgs : EventArgs
    {
        public string Message { get; set; }
        public LogEventArgs(string message)
        {
            Message = message;
        }
    }
    
}