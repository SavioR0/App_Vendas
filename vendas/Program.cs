using System;
using System.Windows.Forms;
using vendas;
using Vendas.Management;
using Vendas.View.Loader;

namespace Vendas.View
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new teste());
            AppManager.Start<LoaderController>(new LoginUser());
        }
    }
}
