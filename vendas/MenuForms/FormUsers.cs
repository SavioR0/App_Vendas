using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        readonly Dictionary<string, Action> FilterSelected;
        public FormUsers(FormHomePage form = null)
        {
            InitializeComponent();
            LoadGridUsers((TypeUser)Global.Instance.User.TypeUser);
            _formHomePage = form;

            FilterSelected = new Dictionary<string, Action> {
                    { "Id", FilterByID},
                    { "Nome", FilterByName},
                    { "Email", FilterByEmail},
                    { "Telefone", FilterByTel},
                    { "Data Nasc.", FilterByDate},
                    { "CPF", FilterByCPF},
                    { "Usuário", FilterByUserName},
                    { "Tipo Usuário", FilterByTypeUser}
            };
        }

        private void LoadNumLabel()
        {
            LabelNumUser.Text = ((List<User>)gridUsers.DataSource).Count.ToString();
        }

        private void LoadGridUsers(TypeUser typeUser)
        {
            if (GetTypeUserFunctions<User>.typeUserFunctions.TryGetValue((typeUser, typeof(User)), out Func<List<User>> loadUsers))
            {
                var users = loadUsers();
                foreach (var user in users)
                {
                    user.Address = Service.AddressController.Filter(c => c.Id == user.AddressId)[0];
                    user.TypeUsers = Service.TypeUserController.Filter(c => c.Id == user.TypeUser)[0];
                }
                gridUsers.DataSource = users;
                LoadNumLabel();
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

        private void RegisterUserButton_Click(object sender, EventArgs e)
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
            if(comboBoxFilterUsers.Text != "") textEditSearch.Enabled = true;
            else textEditSearch.Enabled = false;
        }

        private void BtnSearchProd_Click(object sender, EventArgs e)
        {
            try
            {
                LoadGridUsers((TypeUser)Global.Instance.User.TypeUser);
                if (string.IsNullOrWhiteSpace(textEditSearch.Text)) return;

                if (FilterSelected.TryGetValue(comboBoxFilterUsers.Text, out Action LoadFilter))
                {
                    LoadFilter();  
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Erro ao filtrar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
            textEditSearch.Text = "";
        }
        private void FilterByID()
        {
            if (!int.TryParse(textEditSearch.Text, out int id)) throw new ApplicationException("Coloque um Id válido!");
            
            var allUsers = gridUsers.DataSource as List<User>;
            List<User> users = allUsers.FindAll(c => c.Id == id);
            gridUsers.DataSource = users;   
        }

        private void FilterByTypeUser()
        {
            string value = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((textEditSearch.Text).ToLower());
            var allUsers = gridUsers.DataSource as List<User>;
            try
            {
                var type = Service.TypeUserController.Filter(c1 => c1.Name == value)[0];
                gridUsers.DataSource = allUsers.FindAll(c => c.TypeUsers.Name == type.Name);
            }
            catch (Exception)
            {
                MessageBox.Show("Certifique se digitou corretamente o tipo de usuário e tente novamente", "Erro ao filtrar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FilterByUserName()
        {
            var allUsers = gridUsers.DataSource as List<User>;
            List<User> users = allUsers.FindAll(c => c.UserName.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            gridUsers.DataSource = users;
        }

        private void FilterByCPF()
        {
            var allUsers = gridUsers.DataSource as List<User>;
            List<User> users = allUsers.FindAll(c => c.Cpf.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            gridUsers.DataSource = users;
        }

        private void FilterByDate()
        {
            if (!DateTime.TryParse(textEditSearch.Text, out DateTime date)) throw new ApplicationException("Coloque uma data válida!");
            var allUsers = gridUsers.DataSource as List<User>;
            List<User> users = allUsers.FindAll(c => c.DateOfBirth == date);
            gridUsers.DataSource = users;
        }

        private void FilterByTel()
        {
            if (!long.TryParse(textEditSearch.Text, out long tel)) throw new ApplicationException("Coloque um Telefone válido!");
            var allUsers = gridUsers.DataSource as List<User>;
            List<User> users = allUsers.FindAll(c => c.Tel.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            gridUsers.DataSource = users;
        }

        private void FilterByEmail()
        {
            var allUsers = gridUsers.DataSource as List<User>;
            List<User> users = allUsers.FindAll(c => c.Email.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            gridUsers.DataSource = users;
        }

        private void FilterByName()
        {
            var allUsers = gridUsers.DataSource as List<User>;
            List<User> users = allUsers.FindAll(c => c.Name.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            gridUsers.DataSource = users;
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

        private void UpdateGridButton_Click(object sender, EventArgs e)
        {
            LoadGridUsers((TypeUser)Global.Instance.User.TypeUser);
        }
    }
}
