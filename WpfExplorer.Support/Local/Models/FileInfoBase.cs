using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Controls;

namespace WpfExplorer.Support.Local
{
    internal partial class FileInfoBase : ObservableObject
    {
        [ObservableProperty]
        private bool _isDenied;
    
        public string Name { get; set; }
        public string FullPath { get; set; }
        public int Depth { get; set; }
        public long Length { get; set; }
        public IconType IconType { get; set; }

        public void test()
        { 
            IsDenied = true;    //IsDenied를 생성하지 않았지만 [ObservableProperty]어트리뷰트 사용으로 자동으로 생성된 것.
        }
    }
}
