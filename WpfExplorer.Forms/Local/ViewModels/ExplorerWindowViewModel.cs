using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfExplorer.Support.Local.Helpers;

namespace WpfExplorer.Forms.Local.ViewModels
{
    public class ExplorerWindowViewModel
    {
        public ExplorerWindowViewModel(DirectoryManager directoryManager)   //의존성 주입
        {
            MessageBox.Show(directoryManager.DownloadDirectory);    //directory 조회 확인
        }
    }
}
