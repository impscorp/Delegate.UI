using System;

namespace InputHandler;

public class Evaluator
{
    public event EventHandler OnInput;
    public event EventHandler NumberEvent;
    public event EventHandler TextEvent;
    
    public void Evaluate(string input)
    {
        OnInput?.Invoke(this, EventArgs.Empty);
        if (int.TryParse(input, out int number))
        {
            NumberEvent?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            TextEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}