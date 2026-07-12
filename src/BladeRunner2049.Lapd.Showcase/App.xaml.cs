using System.Windows;

namespace BladeRunner2049.Lapd.Showcase;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        Window window;
        if (e.Args.Length > 0)
        {
            var typeName = $"BladeRunner2049.Lapd.Showcase.Windows.{e.Args[0]}Window";
            var type = System.Type.GetType(typeName);
            window = type is not null && System.Activator.CreateInstance(type) is Window w
                ? w
                : new MainWindow();
        }
        else
        {
            window = new MainWindow();
        }

        window.Show();
    }
}
