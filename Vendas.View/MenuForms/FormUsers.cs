using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
        readonly Dictionary<string, Action> FilterSelectedUser  ;
        readonly Dictionary<string, Action> FilterSelectedSale;

        public FormUsers(FormHomePage form = null)
        {
            InitializeComponent();
            LoadGridUsers((TypeUser)Global.Instance.User.TypeUser);
            _formHomePage = form;

            FilterSelectedUser = new Dictionary<string, Action> {
                    { "Id", FilterByID},
                    { "Nome", FilterByName},
                    { "Email", FilterByEmail},
                    { "Telefone", FilterByTel},
                    { "Data Nasc.", FilterByDate},
                    { "CPF", FilterByCPF},
                    { "Usuário", FilterByUserName},
                    { "Tipo Usuário", FilterByTypeUser}
            };

            FilterSelectedSale = new Dictionary<string, Action> {
                { "Id", FilterByIdSale},
                { "Cliente", FilterByClient},
                { "Vendedor", FilterBySeller},
                { "Produto", FilterByProduct},
                { "Valor", FilterByValue},
                { "Estoque", FilterByStock},
            };
        }

        private void FilterByStock()
        {
            if (!int.TryParse(TextEditSearchSale.Text, out int value)) throw new ApplicationException("Coloque um Estoque válido!");

            var allSales = gridSale.DataSource as List<Sale>;
            List<Sale> sale = allSales.FindAll(c => c.Product.Stock == value);
            gridSale.DataSource = sale;
        }

        private void FilterByValue()
        {
            if (!double.TryParse(TextEditSearchSale.Text, out double value)) throw new ApplicationException("Coloque um Id válido!");

            var allSales = gridSale.DataSource as List<Sale>;
            List<Sale> sale = allSales.FindAll(c => c.Product.Value == value);
            gridSale.DataSource = sale;
        }

        private void FilterByProduct()
        {
            var sales = gridSale.DataSource as List<Sale>;
            List<Sale> teste = sales.FindAll(c => c.Product.Name.IndexOf(TextEditSearchSale.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            gridSale.DataSource = teste;
        }

        private void FilterBySeller()
        {
            var sales = gridSale.DataSource as List<Sale>;
            List<Sale> teste = sales.FindAll(c => c.Seller.Name.IndexOf(TextEditSearchSale.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            gridSale.DataSource = teste;
        }

        private void FilterByClient()
        {
            var sales = gridSale.DataSource as List<Sale>;
            List<Sale> teste = sales.FindAll(c => c.Client.Name.IndexOf(TextEditSearchSale.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            gridSale.DataSource = teste;
        }

        private void FilterByIdSale()
        {
            if (!int.TryParse(TextEditSearchSale.Text, out int id)) throw new ApplicationException("Coloque um Id válido!");

            var allSales = gridSale.DataSource as List<Sale>;
            List<Sale> sale = allSales.FindAll(c => c.Id == id);
            gridSale.DataSource = sale;
        }






        private void LoadNumLabel()
        {
            LabelNumUser.Text = ((List<User>)gridUsers.DataSource).Count.ToString();
        }

        private void LoadGridUsers(TypeUser typeUser)
        {
            /*
            if (GetTypeUserFunctions<User>.typeUserFunctions.TryGetValue((typeUser, typeof(User)), out Func<IQueryable<User>> loadUsers))
            {
                var users = loadUsers();
                foreach (var user in users)
                {
                    user.Address = Service.AddressController.Filter(c => c.Id == user.AddressId).FirstOrDefault();
                    user.TypeUsers = Service.TypeUserController.Filter(c => c.Id == user.TypeUser).FirstOrDefault();
                }
                gridUsers.DataSource = users.ToList<User>();
                LoadNumLabel();
            }
            */

            bindingSourceUsuarios.DataSource = Service.UserController.GetAll().ToList();
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
                catch (InvalidOperationException) 
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
            user.Address = Service.AddressController.Filter(c => c.Id == user.AddressId).FirstOrDefault();
            _formHomePage.EditUserButtonClicked(user);
        }

        private void ComboBoxFilterProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFilterUsers.Text != "") textEditSearch.Enabled = true;
            else textEditSearch.Enabled = false;
        }

        private void ComboBoxFilterSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterSale.Text != "") TextEditSearchSale.Enabled = true;
            else TextEditSearchSale.Enabled = false;
        }

        private void BtnSearchProd_Click(object sender, EventArgs e)
        {
            try
            {
                LoadGridUsers((TypeUser)Global.Instance.User.TypeUser);
                if (string.IsNullOrWhiteSpace(textEditSearch.Text)) return;

                if (FilterSelectedUser.TryGetValue(comboBoxFilterUsers.Text, out Action LoadFilter))
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
                var type = Service.TypeUserController.Filter(c1 => c1.Name == value).FirstOrDefault();
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

        private void GridViewUsers_FocusedRowChanged(object sender, EventArgs ex = null)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            
            GridView gridView = gridUsers.FocusedView as GridView;
            var user = (gridView.GetRow(gridView.FocusedRowHandle) as User);
            if (user == null) return;

            if (GetTypeUserFunctions<Sale>.typeUserFunctions.TryGetValue(((TypeUser)Global.Instance.User.TypeUser, typeof(Sale)), out Func<IQueryable<Sale>> loadSales))
            {
                var sales = loadSales().ToList<Sale>();
                foreach (var sale in sales)
                {
                    sale.Seller = Service.UserController.Filter(c => c.Id == sale.SellerId).FirstOrDefault();
                    sale.Client = Service.UserController.Filter(c => c.Id == sale.ClientId).FirstOrDefault();
                    sale.Product = Service.ProductController.Filter(c => c.Id == sale.ProductId).FirstOrDefault();
                }
                sales = sales.FindAll(c => c.Client.Name == user.Name || c.Seller.Name == user.Name);
                gridSale.DataSource = sales.ToList<Sale>();
                LabelNumOrder.Text = sales.Count.ToString();
            }
        }

        private void FilterButtomClick_Click(object sender, EventArgs e)
        {
            try
            {
                LoadGrid();
                if (string.IsNullOrWhiteSpace(TextEditSearchSale.Text)) return;

                if (FilterSelectedSale.TryGetValue(comboBoxFilterSale.Text, out Action LoadFilter))
                {
                    LoadFilter();
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Erro ao filtrar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            TextEditSearchSale.Text = "";
        }
    }
}
