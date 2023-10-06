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
        public FormUsers()
        {
            InitializeComponent();
            ExecuteLoadFunction((TypeUser)Global.Instance.User.TypeUser);
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
            if (GetTypeUserFunctions<User>.typeUserFunctions.TryGetValue((typeUser, typeof(Product)), out Func<List<User>> loadUsers))
            {
                var users = loadUsers();
                foreach (var user in users)
                {
                    user.Address = Service.AddressController.Filter(c => c.Id == user.AddressId)[0];
                }
                gridUsers.DataSource = users;
            }
        }

        private void btnExclude_Click(object sender, EventArgs e)
        {
            GridView gridView = gridUsers.FocusedView as GridView;
            var user = (gridView.GetRow(gridView.FocusedRowHandle) as User);
            Service.UserController.Exclude(user.Id);
            LoadGridUsers((TypeUser)Global.Instance.User.TypeUser);
        }
    }
}
