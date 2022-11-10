using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Delegate.UI.Views;

public partial class ChildTimerWindow : Window
{
    public delegate void MyDelegate(string message);
    ChildWindow? childWindow;
    private MyDelegate? _myDelegate;
    private int _sec { get; set; }
    public event EventHandler<string>? myEvent;
    
    public ChildTimerWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }
    
    public ChildTimerWindow(int sec, MyDelegate? myDelegate = null)
    {
        InitializeComponent();
        _myDelegate = myDelegate;
        

#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}