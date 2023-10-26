


using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using vendas.Reports;
using Vendas.Communication;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;

namespace vendas.MenuForms
{
    public partial class FormUsers : Form
    {
        private readonly FormHomePage _formHomePage;

        public FormUsers(FormHomePage form = null)
        {
            InitializeComponent();
            ExecuteLoadFunction((TypeUser)Global.Instance.User.TypeUser);
            _formHomePage = form;
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
                try
                {
                    GridView gridView = gridUsers.FocusedView as GridView;
                    var user = (gridView.GetRow(gridView.FocusedRowHandle) as User);
                    var message = Service.UserController.Exclude(user.Id);
                    if (message != "") throw new InvalidOperationException(message);
                        LoadGridUsers((TypeUser)Global.Instance.User.TypeUser);
                }
                catch (InvalidOperationException ex) 
                {
                    MessageBox.Show("Ocorreu uma exceção! \nCertiique-se de que o Usuário não está vinculado em algum relacionamento. Não é possível a exclusão caso o usuário tenha algum produto ou alguma venda vinculada ao seu nome. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO : " + ex.Message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            _formHomePage.OpenFormUser();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            GridView gridView = gridUsers.FocusedView as GridView;
            var user = (gridView.GetRow(gridView.FocusedRowHandle) as User);
            user.Address = Service.AddressController.Filter(c => c.Id == user.AddressId)[0];
            _formHomePage.EditUserButtonClicked(user);
        }

        private void ComboBoxFilterProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFilterProd.Text != "") textEditSearch.Enabled = true;
            else textEditSearch.Enabled = false;
        }

        private void BtnSearchProd_Click(object sender, EventArgs e)
        {
            LoadGridUsers((TypeUser)Global.Instance.User.TypeUser);
            if (string.IsNullOrWhiteSpace(textEditSearch.Text)) return;

            if (comboBoxFilterProd.Text == "Id")
            {
                if (int.TryParse(textEditSearch.Text, out int id))
                    gridUsers.DataSource = Service.UserController.Filter(c => c.Id == id);
                else
                    MessageBox.Show("Insira um id Válido", "Id inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (comboBoxFilterProd.Text == "Nome")
            {
                var users = gridUsers.DataSource as List<User>;
                List<User> teste = users.FindAll(c => c.Name.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
                gridUsers.DataSource = teste;
            }
            textEditSearch.Text = "";
        }

        

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            gridUsers.Refresh();
            GridView gridView = gridUsers.FocusedView as GridView;
            var userList = new List<User>();
            for (int i =0; i< gridView.RowCount;i++) 
            {
                userList.Add((gridView.GetRow(i)) as User);
            }
            var fReport = GetReportTypes<User>.GeneratePDF(TypeReport.User, userList);
            (new FormPreviewPDFReport(fReport)).ShowDialog();
        }
    }
}
