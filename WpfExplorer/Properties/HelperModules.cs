using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExplorer.Support.Local.Helpers;

namespace WpfExplorer.Properties
{
    internal class HelperModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.Register<DirectoryManager>();     //필요할때마다 인스턴스 생성
            containerRegistry.RegisterSingleton<DirectoryManager> ();   //싱글턴으로 생성 (어디선가 생성될 때 생성)
        }
    }
}
