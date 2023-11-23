using System;
using System.Linq;
using System.Windows.Forms;
using vendas;
using Vendas.DTO;
using Vendas.Entity.Entities;
using Vendas.Library;
using Vendas.Management;
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
            if (Validations.ValidatePassword(out string message, PasswordValue.Text, ConfirmPasswordValue.Text))
            {
                MessageBox.Show(message, "Senhas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public void ChooseOpenForm()
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
                    UserCompleteDTO newUser = new UserCompleteDTO
                    {
                        User = new User()
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
                            BiometryDataText = user.BiometryDataText,
                            BiometryDataBinary = user.BiometryDataBinary,
                            Flag = "U",
                            EditLogin = 0,
                        },
                        Address = user.AddressId == null ? null: Communication.Service.AddressController.GetById((int)user.AddressId),
                        TypeUsers = Communication.Service.TypeUserController.GetById(user.TypeUser)
                    };

                    var _message = Communication.Service.UserController.Save(newUser);
                    if (!string.IsNullOrWhiteSpace(_message)) throw new Exception(_message);
                    Global.Instance.User = newUser.User;
                    ChooseOpenForm();
                    //AppManager.Instance.CloseForm(view: this);
                }
            }
            catch (Exception x) {
                MessageBox.Show(x.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
