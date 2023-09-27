using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;
using Vendas.Management;

namespace Vendas.View
{
    public partial class FormRegisterUser : Form, IView
    {

        public FormRegisterUser() {
            InitializeComponent();
        }
        public Form Form
        {
            get
            {
                return this;
            }
        }
        private bool ValidateFields()
        {
            string message = "";
            Dictionary<TextEdit, string> fields = new Dictionary<TextEdit, string> {
                { nameValue, "Campo nome está vazio"},
                { cpfValue, "Campo cpf está vazio"},
                { telValue, "Campo Telefone está vazio"},
                { dateValue, "Campo data está vazio"},
                { CEPValue, "Campo CEP está vazio"},
                { CityValue, "Campo Cidade está vazio"},
                { NeighborhoodValue, "Campo Bairro está vazio"},
                { StreetValue, "Campo logradouro está vazio"},
                { numberValue, "Campo Número está vazio"},
                { EmailValue, "Campo email está vazio"},
            };
            foreach (KeyValuePair<TextEdit, string> field in fields)
            {
                if (Validations.IsEmptyOrNull(field.Key))
                {
                    MessageBox.Show(field.Value, "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (Validations.ValidateCPF(cpfValue.Text))
            {
                MessageBox.Show(" CPF " + cpfValue.Text + " inválido", "CPF inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Validations.ValidateEmail(out message, EmailValue.Text))
            {
                MessageBox.Show(message, EmailValue.Text);
                return false;
            }
            
            return true;
        }
        private void Btn_register_user_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields()) {
                    var password = Security.Encrypt("TEXTO", Validations.DbFormatCPF(cpfValue.Text));
                    if (Communication.Service.UserController.Filter((User c) => c.Email == EmailValue.Text.Trim() || c.Cpf == cpfValue.Text.Trim()).Count != 0)
                        throw new Exception("Usuário já cadastrado no sistema. Certifique-se que seus dados estão certos e tente novamente.");
                    
                    Communication.Service.UserController.Save(new User
                    {
                        Name = nameValue.Text.Trim(),
                        LastName = LastNameValue.Text.Trim(),
                        Cpf = Validations.DbFormatCPF(cpfValue.Text),
                        Tel = Validations.DbFormatTel(telValue.Text),
                        DateOfBirth = DateTime.Parse(dateValue.Text),
                        Address = new Address
                        {
                            CEP = CEPValue.Text,
                            City = CityValue.Text.Trim(),
                            Neighborhood = NeighborhoodValue.Text.Trim(),
                            Street = StreetValue.Text.Trim(),
                            Number = int.Parse(numberValue.Text),
                        },
                        Email = EmailValue.Text.Trim(),
                        Password = password,
                        TypeUser = IsAdminValue.Enabled ? (int)TypeUser.Admin : (int)TypeUser.Client,
                        UserName = nameValue.Text.Trim().ToLower() + LastNameValue.Text.Trim().ToLower() + cpfValue.Text.Substring(0, 2),
                        Flag = 'I',
                        EditLogin = 1,
                    });
                    AppManager.Instance.CloseForm(view:this);
                    MessageBox.Show("Usuário cadastrado com sucesso! Verifique em seu e-mail sua senha para realizar o login a primeira vez", "Usuário cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NullReferenceException x) { MessageBox.Show(x.Message); }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

    }
}
