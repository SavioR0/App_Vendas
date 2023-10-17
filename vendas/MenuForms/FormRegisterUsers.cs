using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;
using Vendas.Communication;
using Vendas.Management;
using Vendas.View.Loader;
using vendas;

namespace Vendas.View
{
    public partial class FormRegisterUser : Form
    {
        private readonly User _userEdited;
        public byte[] BiometryData;

        public FormRegisterUser(User user=null) {
            InitializeComponent();
            _userEdited = user;
            LoadEdit();
            
        }

        private void LoadEdit()
        {
            if (_userEdited == null) return;
            LoadFieldsValues();
            LoadPermissionsEdited();
            
        }

        private void LoadPermissionsEdited()
        {
            EmailValue.ReadOnly = true;
            cpfValue.ReadOnly = true;

        }

        private void LoadFieldsValues()
        {
            nameValue.Text = _userEdited.Name;
            LastNameValue.Text = _userEdited.LastName;
            cpfValue.Text = _userEdited.Cpf;
            telValue.Text = _userEdited.Tel;
            dateValue.Text = _userEdited.DateOfBirth.ToString("d");
            CEPValue.Text = _userEdited.Address.CEP;
            CityValue.Text = _userEdited.Address.City;
            NeighborhoodValue.Text = _userEdited.Address.Neighborhood;
            numberValue.Text = _userEdited.Address.Number.ToString();
            EmailValue.Text = _userEdited.Email;
            comboBoxEditTypeUser.Text = ReturnTextTypeUser((TypeUser)_userEdited.TypeUser);
        }

        private string ReturnTextTypeUser(TypeUser typeUser)
        {
            var selectedText = new Dictionary<TypeUser, string>
            { { TypeUser.Admin, "Administrador"},
              { TypeUser.Client, "Cliente" },
              { TypeUser.Seller, "Vendedor"}
            };
            return selectedText[typeUser];
        }

        private bool ValidateFields()
        {
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
            if (Validations.ValidateEmail(out string message, EmailValue.Text))
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
                    if ( _userEdited == null && (Communication.Service.UserController.Filter((User c) =>  c.BiometricData == BiometryData || c.Email == EmailValue.Text.Trim() || c.Cpf == cpfValue.Text.Trim()).Count != 0))
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
                        UserName = _userEdited == null ? nameValue.Text.Trim().ToLower() + LastNameValue.Text.Trim().ToLower() + cpfValue.Text.Substring(0, 2) : _userEdited.UserName,
                        BiometricData = BiometryData,
                        Flag = _userEdited == null ? 'I' : 'U',
                        EditLogin = _userEdited == null ? 1 : 0,
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
                    if (_userEdited != null  && !(_userEdited.Address.CEP == address.CEP &&
                        _userEdited.Address.City == address.City &&
                        _userEdited.Address.Neighborhood == address.Neighborhood &&
                        _userEdited.Address.Number == address.Number &&
                        _userEdited.Address.Street == address.Street)) 
                    {
                        var message = Communication.Service.AddressController.Save(address);
                        if (message != "") throw new Exception(message);

                        user.AddressId = Communication.Service.AddressController.Filter(c => c.Id == address.Id)[0].Id;
                    }

                    if (adressRegistered.Count == 1) 
                    {
                        user.AddressId = adressRegistered[0].Id;
                        user.Address = adressRegistered[0];
                    }
                    else user.Address = address;

                    var messageSave = Communication.Service.UserController.Save(user);
                    if (messageSave != "") throw new Exception("Certifique que os dados do usuário foram editados e tente novamente.\n ERRO: " + messageSave);

                    var messageBox = _userEdited == null ? "Usuário cadastrado com sucesso! Para realizar o login a primeira vez verifique em seu e-mail seu username e senha" :
                        "Usuário Atualizado com sucesso!";
                    MessageBox.Show(messageBox, "Usuário cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
            catch (NullReferenceException x) { MessageBox.Show(x.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception x) { MessageBox.Show(x.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnRegisterBiometricPrint_Click(object sender, EventArgs e)
        {
            AppManager.Instance.Load<LoaderController, User>(new Biometric(this));
        }
    }
}
