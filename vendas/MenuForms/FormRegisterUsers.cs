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
    public partial class FormRegisterUser : Form
    {

        public FormRegisterUser() {
            InitializeComponent();
            
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

        private void ClearFields(){
            nameValue.Text = null;
            LastNameValue.Text = null;
            cpfValue.Text = null;
            telValue.Text = null;
            dateValue.Text = null;
            CEPValue.Text = null;
            CityValue.Text = null;
            NeighborhoodValue.Text = null;
            StreetValue.Text = null;
            numberValue.Text = null;
            EmailValue.Text = null;
            comboBoxEditTypeUser.Text = null;
        }

        private int ReturnTypeUser(string value) {
            if (value == "Administrador")
                return (int)TypeUser.Admin;
            if (value == "Vendedor")
                return (int)TypeUser.Seller;
            else
                return (int)TypeUser.Client;
        }

        private void Btn_register_user_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields()) {
                    var password = Security.Encrypt("TEXTO", Validations.DbFormatCPF(cpfValue.Text));
                    if (Communication.Service.UserController.Filter((User c) => c.Email == EmailValue.Text.Trim() || c.Cpf == cpfValue.Text.Trim()).Count != 0)
                        throw new Exception("Usuário já cadastrado no sistema. Certifique-se que seus dados estão certos e tente novamente.");
                    var user = new User
                    {
                        Name = nameValue.Text.Trim(),
                        LastName = LastNameValue.Text.Trim(),
                        Cpf = Validations.DbFormatCPF(cpfValue.Text),
                        Tel = Validations.DbFormatTel(telValue.Text),
                        DateOfBirth = DateTime.Parse(dateValue.Text),
                        Email = EmailValue.Text.Trim(),
                        Password = password,
                        TypeUser = ReturnTypeUser(comboBoxEditTypeUser.Text),
                        UserName = nameValue.Text.Trim().ToLower() + LastNameValue.Text.Trim().ToLower() + cpfValue.Text.Substring(0, 2),
                        Flag = 'I',
                        EditLogin = 1,
                    };

                    var address = new Address
                    {
                        CEP = CEPValue.Text,
                        City = CityValue.Text.Trim(),
                        Neighborhood = NeighborhoodValue.Text.Trim(),
                        Street = StreetValue.Text.Trim(),
                        Number = int.Parse(numberValue.Text),
                    };
                    var adressRegistered = Communication.Service.AddressController.Filter(
                        c => c.CEP == address.CEP &&
                        c.City == address.City &&
                        c.Neighborhood == address.Neighborhood &&
                        c.Number == address.Number &&
                        c.Street == address.Street
                    );

                    if (adressRegistered.Count == 1) user.AddressId = adressRegistered[0].Id;
                    else user.Address = address;

                    Communication.Service.UserController.Save(user);
                    MessageBox.Show("Usuário cadastrado com sucesso! Para realizar o login a primeira vez verifique em seu e-mail seu username e senha", "Usuário cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
            catch (NullReferenceException x) { MessageBox.Show(x.Message); }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

    }
}
