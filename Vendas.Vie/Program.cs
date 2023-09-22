using System;
using System.Windows.Forms;

namespace vendas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormRegisterUser());
            //AppManager.Start<LoginController>();
        }
    }
}
