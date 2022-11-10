namespace InputHandler;
public delegate void InputEventHandler();
public class Input<T>
{
    //create on Input event
    public static event InputEventHandler _OnInput;
    //create a private variable to hold the value
    private static T _value;
    
    public Input(T value)
    {
        _value = value;
        //subscribe to the Input event
        _OnInput += Event;
        _OnInput.Invoke();
    }

    //create a method to handle the Input event
    static void Event() {
        Console.WriteLine("Input Event");
//if input is a string, print the string
        var ev = new Evaluator(_value.ToString());
        

    }
    
    
}