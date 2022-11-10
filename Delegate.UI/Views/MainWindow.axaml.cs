using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Delegate.UI.Views
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        
        private void Button_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            
            var child = new ChildWindow(Writedelegate);
            child.Show();
            child.Position = new PixelPoint(new Random().Next(0, 400), new Random().Next(0, 400));
            
        }
        public void Writedelegate(string text)
        {
            this.FindControl<TextBox>("Delegatetext").Text = text;
        }
    }
}