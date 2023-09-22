using System;
using System.Windows.Forms;
using Vendas.Controller.controller.loginRegisterUser;
using Vendas.Entity.Enums;
using Vendas.Entity.Entities;


namespace Vendas.View
{
    public partial class FormRegisterUser : Form, IView
    {
        private RegisterUserController _controller;
        public FormRegisterUser(RegisterUserController controller)
        {
            InitializeComponent();
            _controller = controller;
        }
        public Form Form
        {
            get
            {
                return this;
            }
        }

        private void Btn_register_user_Click(object sender, EventArgs e)
        {
            _controller.RegisterUser(new User
            {
                Name = nameValue.Text,
                Cpf = cpfValue.Text,
                Tel = telValue.Text,
                DateOfBirth = DateTime.Parse(dateValue.Text),
                Address = new Address
                {
                    CEP = CEPEdit.Text,
                    City = CityEdit.Text,
                    Neighborhood = NeighborhoodEdit.Text,
                    Street = StreetEdit.Text,
                    Number = int.Parse(numberEdit.Text),
                },
                Email = EmailEdit.Text,
                TypeUser = IsAdmin.Enabled ? (int)TypeUser.Admin : (int)TypeUser.Client,
            });
        }

    }
}
