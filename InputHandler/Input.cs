namespace InputHandler;
public delegate void sampleEventHandler();
public class Input<T>
{
    //create on Input event
    public static event sampleEventHandler _OnInput;
    //create a private variable to hold the value
    private T _value;
    
    public Input(T value)
    {
        _value = value;
        //subscribe to the Input event
        _OnInput += new sampleEventHandler(Event);
        
        _OnInput.Invoke();
    }

    //create a method to handle the Input event
    static void Event() {
        Console.WriteLine("\n Input Event");
    }
    
    
}