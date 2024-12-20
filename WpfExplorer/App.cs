using Jamesnet.Wpf.Controls;
using System.Windows;
using WpfExplorer.Forms.UI.Views;

namespace WpfExplorer
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()     //main window 뭐로 사용할건지 지정
        {
            return new ExplorerWindow();
        }
    }
}
