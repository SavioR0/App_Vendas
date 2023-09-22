using System;
using System.Windows.Forms;

namespace Vendas.View
{
    public partial class LoginUser : Form, IView
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        public Form Form
        {
            get
            {
                return this;
            }
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {

        }

        private void lbResgisterUser_Click(object sender, EventArgs e)
        {
            //AppManager.Instance.Load<RegisterUserController, User>();

        }
    }
}
