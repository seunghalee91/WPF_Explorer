using System.Windows;

namespace WpfExplorer.Forms.UI.Views
{
    public class ExplorerWindow : Window
    {
        static ExplorerWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExplorerWindow), new FrameworkPropertyMetadata(typeof(ExplorerWindow)));
        }
    }
}
