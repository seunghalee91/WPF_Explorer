using System.Windows;
using WpfExplorer.Forms.UI.Views;
using WpfExplorer.Support.UI.Units;

namespace WpfExplorer
{
    internal class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ExplorerWindow win = new ExplorerWindow();
            win.ShowDialog();
        }
    }
}
