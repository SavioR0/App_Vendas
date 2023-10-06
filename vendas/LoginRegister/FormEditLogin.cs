using System;
using System.Windows.Forms;
using vendas;
using Vendas.Communication;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;
using Vendas.Management;
using Vendas.View;
using Vendas.View.Loader;

namespace Vendas.View
{
    public partial class FormEditLogin : Form, IView
    {
        public FormEditLogin()
        {
            InitializeComponent();
        }

        public Form Form { get { return this; } }
        private bool ValidateFields() {
            string message = "";
            if (Validations.ValidatePassword(out message, PasswordValue.Text, ConfirmPasswordValue.Text))
            {
                MessageBox.Show(message, "Senhas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public void ChooseOpenForm(TypeUser typeUser)
        {
            AppManager.Instance.Load<LoaderController, User>(new FormHomePage());
            AppManager.Instance.CloseForm(view: this);
        }

        private void Btn_register_user_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
                    var password = Security.Encrypt("TEXTO", PasswordValue.Text);
                    User user = Global.Instance.User;
                    User newUser = new User()
                    {
                        Id = user.Id,
                        Name = user.Name,
                        LastName = user.LastName,
                        Cpf = user.Cpf,
                        Tel = user.Tel,
                        DateOfBirth = user.DateOfBirth,
                        AddressId = user.AddressId,
                        Email = user.Email,
                        Password = password,
                        TypeUser = user.TypeUser,
                        UserName = user.UserName,
                        Flag = 'U',
                        EditLogin = 0,
                    };
                    var _message = Communication.Service.UserController.Save(newUser);
                    if (!string.IsNullOrWhiteSpace(_message)) throw new Exception(_message);
                    Global.Instance.User = newUser;
                    ChooseOpenForm((TypeUser)newUser.TypeUser);
                    AppManager.Instance.CloseForm(view: this);
                }
            }
            catch (Exception x) {
                MessageBox.Show(x.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
