using System;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.ValidationTest.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Avalonia.ValidationTest;

public class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        Container = ConfigureDependencyInjection();
            
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();
        }

        base.OnFrameworkInitializationCompleted();
    }
        
    public IServiceProvider Container { get; private set; }

    private static IServiceProvider ConfigureDependencyInjection()
    {
        var serviceCollection = new ServiceCollection();
            
        serviceCollection.AddTransient<MainViewModel>();
         
        return serviceCollection.BuildServiceProvider();
    }
}