// See https://aka.ms/new-console-template for more information
//read console Input and trigger on Input event

using InputHandler;

public delegate void sampleEventHandler();
class Program {
    public static event sampleEventHandler _show;
    static void Main() {
        var x = Console.ReadLine();
        var input = new Input<string?>(x);
    }
}