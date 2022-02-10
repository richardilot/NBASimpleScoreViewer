using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using NBAScore.ViewModels;
using NBAScore.Views;
using System;

namespace NBAScore
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public async override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var viewmodel = new MainWindowViewModel();
                desktop.MainWindow = new MainWindow
                {
                    DataContext = viewmodel,
                    TheViewModel = viewmodel
                };
                try
                {
                    viewmodel.AllTeams = await MainWindowViewModel.DoGetTeams();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"ERROR: {e}");
                }
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
