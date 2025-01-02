using WpfExplorer.Properties;

namespace WpfExplorer
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                .AddWireDataContext<WireDataContext>()      //app 실행전에 WireDataContext의 클래스 안의 view,viewmodel 연결 관계를 추가해 줌
                .AddInversionModule<HelperModules>()
                .Run();
        }
    }
}
