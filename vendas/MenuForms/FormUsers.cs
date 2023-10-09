using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vendas.Communication;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;

namespace vendas.MenuForms
{
    public partial class FormUsers : Form
    {
        private readonly FormHomePage _form;
        public FormUsers(FormHomePage form = null)
        {
            InitializeComponent();
            ExecuteLoadFunction((TypeUser)Global.Instance.User.TypeUser);
            _form = form;
        }

        private void ExecuteLoadFunction(TypeUser typeUser)
        {
            if (GetTypeUserFunctions<User>.typeUserFunctions.TryGetValue((typeUser, typeof(User)), out Func<List<User>> loadGrid))
            {
                gridUsers.DataSource = loadGrid();
            }
        }

        private void LoadGridUsers(TypeUser typeUser)
        {
            if (GetTypeUserFunctions<User>.typeUserFunctions.TryGetValue((typeUser, typeof(User)), out Func<List<User>> loadUsers))
            {
                var users = loadUsers();
                foreach (var user in users)
                {
                    user.Address = Service.AddressController.Filter(c => c.Id == user.AddressId)[0];
                }
                gridUsers.DataSource = users;
            }
        }

        private void BtnExclude_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover o usuário do sistema?", "Remover Usuário!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GridView gridView = gridUsers.FocusedView as GridView;
                var user = (gridView.GetRow(gridView.FocusedRowHandle) as User);
                var message = Service.UserController.Exclude(user.Id);
                if (message != "") MessageBox.Show(message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadGridUsers((TypeUser)Global.Instance.User.TypeUser);
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            //_form.
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            GridView gridView = gridUsers.FocusedView as GridView;
            var user = (gridView.GetRow(gridView.FocusedRowHandle) as User);
            user.Address = Service.AddressController.Filter(c => c.Id == user.AddressId)[0];
            _form.EditUserButtonClicked(user);
        }
    }
}
