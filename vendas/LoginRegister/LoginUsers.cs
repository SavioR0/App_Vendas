using NITGEN.SDK.NBioBSP;
using System;
using System.Windows.Forms;
using vendas;
using Vendas.Communication;
using Vendas.Entity.Entities;
using Vendas.Library;
using Vendas.Management;
using Vendas.View.Loader;
namespace Vendas.View
{
    public partial class LoginUser : Form, IView
    {
        NBioAPI m_NBioAPI;
        private string _version;
        public LoginUser(string version)
        {
            _version = version;
            InitializeComponent();
            m_NBioAPI = new NBioAPI();
            label1.Text = _version;
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
                //if ((TypeUser)user.TypeUser == TypeUser.Admin)
                //{
                //    AppManager.Instance.Load<LoaderController, User>(new FormHomePageAdminUser());
                //    AppManager.Instance.CloseForm(view: this);
                //    return;
                //}
                //if((TypeUser)user.TypeUser == TypeUser.Seller) 
                //{
                //    AppManager.Instance.Load<LoaderController, User>(new FormHomePageDefaultUser());
                //    AppManager.Instance.CloseForm(view: this);
                //}

                AppManager.Instance.Load<LoaderController, User>(new FormHomePage());
                AppManager.Instance.CloseForm(view: this);
            }
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            var teste = Communication.Service.UserController.Login(UserNameValue.Text.Trim(), PasswordValue.Text.Trim());
            if (teste) ChooseOpenForm(Global.Instance.User);
            else MessageBox.Show("Usuário ou senha estão incorretos!");

        }

        //private void lbResgisterUser_Click(object sender, EventArgs e)
        //{
        //    AppManager.Instance.Load<LoaderController, User>(new FormRegisterUser());

        //}

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            Global.Instance.Distribuida = checkEdit1.Checked;
        }
        private User Identify()
        {
            NBioAPI.Type.HFIR hCapturedFIR;
            //listResult.Items.Clear();
            // Get FIR data
            m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);
            uint ret = m_NBioAPI.Capture(out hCapturedFIR);
            if (ret != NBioAPI.Error.NONE)
            {
                MessageBox.Show("Certifique-se que o leitor digital está conectado.\n "+ NBioAPI.Error.GetErrorDescription(ret) + " [" + ret.ToString() + "]", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
                return null;
            }

            m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
            NBioAPI.Type.FIR_PAYLOAD myPayload = new NBioAPI.Type.FIR_PAYLOAD();

            var users = Communication.Service.UserController.GetAll();
            foreach (User user in users)
            {
                NBioAPI.Type.FIR_TEXTENCODE m_textFIR = new NBioAPI.Type.FIR_TEXTENCODE();
                m_textFIR.TextFIR = user.BiometryDataText;
                ret = m_NBioAPI.VerifyMatch(hCapturedFIR, m_textFIR, out bool result, myPayload);
                if (result == true) return user;
            }
            MessageBox.Show("Biometria não cadastrada!");
            return null;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var user = Biometry.Identify(login: true);
            if (user != null)
            {
                Global.Instance.User = user;
                ChooseOpenForm(Global.Instance.User);
            }
        }

    }
}
