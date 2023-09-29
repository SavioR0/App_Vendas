using System;
using System.Windows.Forms;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;
using Vendas.Management;
using Vendas.View.Loader;

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
            get{return this;}
        }

        public void ChooseOpenForm(User user)
        {
            //MessageBox.Show(((TypeUser)user.TypeUser == TypeUser.Admin).ToString() + "  " + user.TypeUser + " " + TypeUser.Admin);
            if (user.EditLogin == 1) { AppManager.Instance.Load<LoaderController, User>(new FormEditLogin()); AppManager.Instance.CloseForm(1); }
            else {
                if ((TypeUser)user.TypeUser == TypeUser.Admin)
                {
                    AppManager.Instance.Load<LoaderController, User>(new FormHomePageAdminUser());
                    AppManager.Instance.CloseForm(view: this);
                }
                else
                {
                    AppManager.Instance.Load<LoaderController, User>(new FormHomePageDefaultUser());
                    AppManager.Instance.CloseForm(view: this);
                }
            }
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            var teste = Communication.Service.UserController.Login(UserNameValue.Text.Trim(), PasswordValue.Text.Trim());
            if (teste) ChooseOpenForm(Global.Instance.User);
            else MessageBox.Show("Usuário ou senha estão incorretos!");

        }

        private void lbResgisterUser_Click(object sender, EventArgs e)
        {
            AppManager.Instance.Load<LoaderController, User>(new FormRegisterUser());
            
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            Global.Instance.Distribuida = checkEdit1.Checked;
        }
    }
}
