using DevExpress.XtraEditors;
using NITGEN.SDK.NBioBSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vendas.Communication;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;

namespace Vendas.View
{
    public partial class FormRegisterUser : Form
    {
        private readonly User _userEdited;
        public string BiometryDataText;
        public byte[] BiometryDataBinary;
        private readonly NBioAPI m_NBioAPI;


        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);


        public FormRegisterUser(User user=null) {
            InitializeComponent();
            _userEdited = user;
            LoadEdit();
            m_NBioAPI = new NBioAPI();
            ClearFields();
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
            DistrictValue.Text = _userEdited.Address.District;
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
                { dateValue, "Campo data está vazio"},
                { CityValue, "Campo Cidade está vazio"},
                { DistrictValue, "Campo Bairro está vazio"},
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
            DistrictValue.Text = null;
            StreetValue.Text = null;
            numberValue.Text = null;
            EmailValue.Text = null;
            comboBoxEditTypeUser.Text = null;
            labelBiomerticAlert.Text = "";
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
                    var user = new User
                    {
                        Name = nameValue.Text.Trim(),
                        LastName = LastNameValue.Text.Trim(),
                        Cpf = Validations.DbFormatCPF(cpfValue.Text),
                        Tel = Validations.DbFormatTel(telValue.Text),
                        DateOfBirth = DateTime.Parse(dateValue.Text),
                        Email = EmailValue.Text.Trim(),
                        Password = Security.Encrypt("TEXTO", Validations.DbFormatCPF(cpfValue.Text)),
                        TypeUser = ReturnTypeUser(comboBoxEditTypeUser.Text),
                        UserName = _userEdited == null ? nameValue.Text.Trim().ToLower() + LastNameValue.Text.Trim().ToLower() + cpfValue.Text.Substring(0, 2) : _userEdited.UserName,
                        BiometryDataText = BiometryDataText,
                        BiometryDataBinary = BiometryDataBinary,
                        Flag = _userEdited == null ? "I" : "U",
                        EditLogin = _userEdited == null ? 1 : 0,
                    };

                    var address = new Address
                    {
                        CEP = CEPValue.Text,
                        State = StateValue.Text,
                        City = CityValue.Text,
                        District = DistrictValue.Text,
                        Street = StreetValue.Text,
                        Number = int.Parse(numberValue.Text),
                    };

                    Address validation = Communication.Service.AddressController.Filter(c=>
                        c.CEP == address.CEP && c.State == address.State & c.City == address.City &&
                        c.District == address.District &&
                        c.Number == address.Number &&
                        c.Street == address.Street).FirstOrDefault();
                    //if (_userEdited != null && !_userEdited.Address.Equals(address))
                    //{ 
                    //    var message = Communication.Service.AddressController.Save(address);
                    //    if (message != "") throw new Exception(message);

                    //    user.AddressId = Communication.Service.AddressController.Filter(c => c.Id == address.Id).FirstOrDefault().Id;
                    //}

                    if (validation != null)
                        user.AddressId = validation.Id;
                    else
                        user.Address = address;
                    var messageSave = Communication.Service.UserController.Save(user);

                    MessageBox.Show(_userEdited == null ? "Usuário cadastrado com sucesso! Para realizar o login a primeira vez verifique em seu e-mail seu username e senha" :
                        "Usuário Atualizado com sucesso!", "Usuário cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
            catch 
                (NullReferenceException x) { MessageBox.Show(x.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch 
                (Exception x) { MessageBox.Show(x.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnRegisterBiometricPrint_Click(object sender, EventArgs e)
        {
            var message = Biometry.RegisterBiometry(ref BiometryDataBinary, ref BiometryDataText);
            if (message != "")
            {
                MessageBox.Show(message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            labelBiomerticAlert.Text = "Biometria cadastrada com sucesso!";
        }

        private void CEPValue_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!IsConnected()) { MessageBox.Show("Verifique sua conexão com a internet", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information); return; };
                //StateValue.Focus();
            
                Address address = SearchCEP.LocalizeCEP(CEPValue.Text.Replace("-", ""));
                if (address != null)
                {
                    StateValue.Text = address.State;
                    CityValue.Text = address.City;
                    DistrictValue.Text = address.District;
                    StreetValue.Text = address.Street;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Boolean IsConnected()
        {
            return InternetGetConnectedState(out int Description, 0);
        }
    }
}
