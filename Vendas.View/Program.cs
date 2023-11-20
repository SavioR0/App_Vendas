using System;
using System.Windows.Forms;
using Vendas.Infrastructure;
using Vendas.Management;
using Vendas.View.Loader;

namespace Vendas.View
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var context = new SalesContext())
            {
                context.Initialization();
            }

            Application.SetCompatibleTextRenderingDefault(false);
            
            AppManager.Start<LoaderController>(new LoginUser(Library.Version.Instance.version));
        }
    }
}
