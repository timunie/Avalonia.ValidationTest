using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ValidationTest.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Avalonia.ValidationTest;

public class MainWindow : Window
{
    public MainWindow()
    {
        var container = ((App) Application.Current).Container;
        DataContext = ActivatorUtilities.GetServiceOrCreateInstance(container, typeof(MainViewModel));

        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}