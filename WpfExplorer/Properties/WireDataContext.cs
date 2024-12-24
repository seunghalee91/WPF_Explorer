using Jamesnet.Wpf.Global.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExplorer.Forms.Local.ViewModels;
using WpfExplorer.Forms.UI.Views;

namespace WpfExplorer.Properties
{
    public class WireDataContext : ViewModelLocationScenario
    {
        //view, viewmodel을 연결시키기 위한 시나리오를 가지는 클래스
        protected override void Match(ViewModelLocatorCollection items)
        {
            //view, viewmodel 연결 코드
            items.Register<ExplorerWindow, ExplorerWindowViewModel>();
        }
    }
}
