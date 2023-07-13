using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaTreeDataGrid.ViewModels;
using AvaloniaTreeDataGrid.Views;

namespace AvaloniaTreeDataGrid
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }

            if (Current != null)
            {
                Current.RequestedThemeVariant = Avalonia.Styling.ThemeVariant.Dark;
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
