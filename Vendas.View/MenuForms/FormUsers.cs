using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using vendas.Reports;
using Vendas.Communication;
using Vendas.DTO;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;

namespace vendas.MenuForms
{
    public partial class FormUsers : Form
    {
        private readonly FormHomePage _formHomePage;
        readonly Dictionary<string, Action> FilterSelectedUser;
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
                { "Data", FilterByDate},
            };
        }

        //private void FilterByStock()
        //{
        //    if (!int.TryParse(TextEditSearchSale.Text, out int value)) throw new ApplicationException("Coloque um Estoque válido!");

        //    var allSales = bindingSourceSales.DataSource as List<SaleDTO>;
        //    List<SaleDTO> sale = allSales.FindAll(c => c.StockProduct == value);
        //    bindingSourceSales.DataSource = sale;
        //}


        //private void FilterBySeller()
        //{
        //    var allSales = bindingSourceSales.DataSource as List<SaleDTO>;
        //    List<SaleDTO> sales = allSales.FindAll(c => c.NameSeller.IndexOf(TextEditSearchSale.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        //    bindingSourceSales.DataSource = sales;
        //}

        private void FilterByClient()
        {
            var allSales = bindingSourceSales.DataSource as List<SaleDTO>;
            List<SaleDTO> sales = allSales.FindAll(c => c.NameClient.IndexOf(TextEditSearchSale.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            bindingSourceSales.DataSource = sales;
        }

        private void FilterByIdSale()
        {
            if (!int.TryParse(TextEditSearchSale.Text, out int id)) throw new ApplicationException("Coloque um Id válido!");

            var allSales = bindingSourceSales.DataSource as List<SaleDTO>;
            List<SaleDTO> sale = allSales.FindAll(c => c.Id == id);
            bindingSourceSales.DataSource = sale;
        }



        private void LoadNumLabel()
        {
            LabelNumUser.Text = ((List<UserDTO>)bindingSourceUsuarios.DataSource).Count.ToString();
        }

        private void LoadGridUsers(TypeUser typeUser)
        {
            try
            {
                if (GetTypeUserFunctions<UserDTO>.typeUserFunctions.TryGetValue((typeUser, typeof(UserDTO)), out Func<List<UserDTO>> loadUsers))
                {
                    var users = loadUsers();
                    bindingSourceUsuarios.DataSource = users.ToList();
                    LoadNumLabel();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar os dados ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            
            var allUsers = bindingSourceUsuarios.DataSource as List<UserDTO>;
            List<UserDTO> users = allUsers.FindAll(c => c.Id == id);
            bindingSourceUsuarios.DataSource = users;   
        }

        private void FilterByTypeUser()
        {
            string value = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((textEditSearch.Text).ToLower());
            var allUsers = bindingSourceUsuarios.DataSource as List<UserDTO>;

            bindingSourceUsuarios.DataSource = allUsers.FindAll(c => c.TypeUserName.IndexOf(TextEditSearchSale.Text, StringComparison.OrdinalIgnoreCase) >= 0);

        }

        private void FilterByUserName()
        {
            var allUsers = bindingSourceUsuarios.DataSource as List<UserDTO>;
            List<UserDTO> users = allUsers.FindAll(c => c.UserName.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            bindingSourceUsuarios.DataSource = users;
        }

        private void FilterByCPF()
        {
            var allUsers = bindingSourceUsuarios.DataSource as List<UserDTO>;
            List<UserDTO> users = allUsers.FindAll(c => c.Cpf.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            bindingSourceUsuarios.DataSource = users;
        }

        private void FilterByDate()
        {
            if (!DateTime.TryParse(textEditSearch.Text, out DateTime date)) throw new ApplicationException("Coloque uma data válida!");
            var allUsers = bindingSourceUsuarios.DataSource as List<UserDTO>;
            List<UserDTO> users = allUsers.FindAll(c => c.DateOfBirth == date);
            bindingSourceUsuarios.DataSource = users;
        }

        private void FilterByTel()
        {
            if (!long.TryParse(textEditSearch.Text, out long tel)) throw new ApplicationException("Coloque um Telefone válido!");
            var allUsers = bindingSourceUsuarios.DataSource as List<UserDTO>;
            List<UserDTO> users = allUsers.FindAll(c => c.Tel.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            bindingSourceUsuarios.DataSource = users;
        }

        private void FilterByEmail()
        {
            var allUsers = bindingSourceUsuarios.DataSource as List<UserDTO>;
            List<UserDTO> users = allUsers.FindAll(c => c.Email.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            bindingSourceUsuarios.DataSource = users;
        }

        private void FilterByName()
        {
            var allUsers = bindingSourceUsuarios.DataSource as List<UserDTO>;
            List<UserDTO> users = allUsers.FindAll(c => c.Name.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            bindingSourceUsuarios.DataSource = users;
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
            var user = (gridView.GetRow(gridView.FocusedRowHandle) as UserDTO);
            if (user == null) return;

            if (GetTypeUserFunctions<SaleDTO>.typeUserFunctions.TryGetValue(((TypeUser)Global.Instance.User.TypeUser, typeof(SaleDTO)), out Func<List<SaleDTO>> loadSales))
            {
                var sales = loadSales().ToList<SaleDTO>();
                sales = sales.FindAll(c => c.NameClient == user.Name);

                bindingSourceSales.DataSource = sales;
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
