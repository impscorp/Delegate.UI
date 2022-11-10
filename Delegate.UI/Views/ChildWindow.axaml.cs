using System;
using System.Drawing.Text;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Delegate.UI.Views;

public partial class ChildWindow : Window
{
    public delegate void MyDelegate(string message);
    ChildWindow? childWindow;
    private MyDelegate? _myDelegate;

    public string windowTitle { get; set; }

    /// <summary>
    /// constructor needed for the xaml
    /// </summary>
    public ChildWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }
    
    public ChildWindow(MyDelegate? myDelegate = null)
    {
        InitializeComponent();
        _myDelegate = myDelegate;
        childWindow = this;
        windowTitle = "Child Window " + DateTime.Now.ToString("HH:mm:ss:tt");
        Title = windowTitle;
#if DEBUG
        this.AttachDevTools();
#endif
    }
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        _myDelegate?.Invoke("Hello from " + windowTitle);
        childWindow?.Close();
    }
    
    private void Button_Click_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Random rnd = new Random();
        int dice = rnd.Next(1, 7);
        _myDelegate?.Invoke("Dice: " + dice);
    }
}