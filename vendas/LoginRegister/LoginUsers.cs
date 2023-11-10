using NITGEN.SDK.NBioBSP;
using System;
using System.Threading;
using System.Windows.Forms;
using vendas;
using Vendas.Communication;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;
using Vendas.Management;
using Vendas.View.Loader;

namespace Vendas.View
{
    public partial class LoginUser : Form, IView
    {
        private readonly NBioAPI m_NBioAPI;
        private readonly string _version;
        public bool ConfirmLogin = false;
        public LoginUser(string version)
        {
            _version = version;
            InitializeComponent();
            m_NBioAPI = new NBioAPI();
            label1.Text = _version;
            Thread thread = new Thread(SimpleButton1_Click);
            thread.Start();
        }

        delegate void SetCloseFormCallback(User user);

        public Form Form
        {
            get{return this;}
        }

        public void ChooseOpenForm(User user)
        {
            if (user.EditLogin == 1) { AppManager.Instance.Load<LoaderController, User>(new FormEditLogin()); AppManager.Instance.CloseForm(1); }
            else {
                AppManager.Instance.Load<LoaderController, User>(new FormHomePage());
                AppManager.Instance.CloseForm(view: this);
            }
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {

            var teste = Communication.Service.UserController.Login(UserNameValue.Text.Trim(), PasswordValue.Text.Trim());
            if (teste)
            {
                ConfirmLogin = true;
                ChooseOpenForm(Global.Instance.User);
            }
            else MessageBox.Show("Usuário ou senha estão incorretos!");

        }

        private void CheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            Global.Instance.Distribuida = checkEdit1.Checked;
        }

        private void  SimpleButton1_Click()
        {
            try
            {
                Biometry.Identify(out User user, login: true, confirmLogin: ConfirmLogin);
                if (user != null)
                {
                    Global.Instance.User = user;

                    SetCloseFormCallback d = new SetCloseFormCallback(ChooseOpenForm);
                    this.Invoke(d, new object[] {
                        Global.Instance.User
                    });

                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SimpleButton1_Click();
            }
            catch (ArgumentException)
            {
                AppManager.Instance.CloseForm();
            }
            catch (Exception)
            { }
        }

    }
}
