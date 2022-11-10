using System;

namespace InputHandler;
public delegate void FromInput(string str);
public delegate void NumberDelegate(int number);
public delegate void StringDelegate(string str);

public class Evaluator
{
    public event FromInput OnInput;
    public event NumberDelegate NumberEvent;
    public event StringDelegate TextEvent;

    public Evaluator(string input)
    {
        OnInput += Evaluate;
        OnInput.Invoke(input);
    }
    void Evaluate(string input)
    {
        if (int.TryParse(input, out int number))
        {
            NumberEvent += NumberEventMethod;
            NumberEvent?.Invoke(number);
        }
        else
        {
            TextEvent += TextEventMethod;
            TextEvent?.Invoke(input);
        }
    }
    
    //number event
    public void NumberEventMethod(int number)
    {
        var logger = new NumberLogger(number);
    }
    //text eve nt
    public void TextEventMethod(string str)
    {
        var logger = new TextLogger(str);
    }
    
}