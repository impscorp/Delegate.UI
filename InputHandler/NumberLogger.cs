using System;

namespace InputHandler;

public class NumberLogger
{
    public event EventHandler OnLog;
    
    public void Log(int number)
    {
        Console.WriteLine(number);
        OnLog?.Invoke(this, EventArgs.Empty);
    }
}