using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ValidationTest.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace Avalonia.ValidationTest
{
    public class MainWindow : Window
    {
        private MainViewModel? ViewModel => DataContext as MainViewModel;
        
        public MainWindow()
        {
            var container = ((App) Application.Current).Container;
            DataContext = ActivatorUtilities.GetServiceOrCreateInstance(container, typeof(MainViewModel));

            Initialized += MainWindow_Loaded;
            
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        
        private void MainWindow_Loaded(object? sender, EventArgs e)
        {
            ViewModel!.Load();
        }
    }
}