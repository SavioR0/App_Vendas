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
    public partial class FormOrderSale : Form
    {
        private readonly FormHomePage _formHomePage;
        public FormOrderSale(FormHomePage formHomePage)
        {
            _formHomePage = formHomePage;
            InitializeComponent();

            LoadGridSale((TypeUser)Global.Instance.User.TypeUser);
        }

        private void LoadGridSale(TypeUser typeUser)
        {
            if (GetTypeUserFunctions<Sale>.typeUserFunctions.TryGetValue((typeUser, typeof(Sale)), out Func<List<Sale>> loadSales)) 
            {
                var sales = loadSales();
                foreach (var sale in sales)
                {
                    sale.Seller = Service.UserController.Filter(c => c.Id == sale.SellerId)[0];
                    sale.Client = Service.UserController.Filter(c => c.Id == sale.ClientId)[0];
                    sale.Product = Service.ProductController.Filter(c => c.Id == sale.ProductId)[0];
                }
                gridSale.DataSource = sales;
                gridSale.RefreshDataSource();
            }
        }
        private void BtnExclude_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover o pedido do sistema?", "Remover pedido!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    GridView gridView = gridSale.FocusedView as GridView;
                    var sale = (gridView.GetRow(gridView.FocusedRowHandle) as Sale);
                    var message = Service.SaleController.Exclude(sale.Id);
                    if (message != "") throw new Exception(message);
                    LoadGridSale((TypeUser)Global.Instance.User.TypeUser);
                    MessageBox.Show("Pedido Excluído com sucesso!", "Exclusão do pedido.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir pedido. " + ex, "Exclusão de pedido inválido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnSearchProd_Click(object sender, EventArgs e)
        {
            LoadGridSale((TypeUser)Global.Instance.User.TypeUser);
            if (string.IsNullOrWhiteSpace(textEditSearch.Text)) return;

            if (comboBoxFilterSale.Text == "Id")
            {
                if (int.TryParse(textEditSearch.Text, out int id))
                    gridSale.DataSource = Service.SaleController.Filter(c => c.Id == id);
                else
                    MessageBox.Show("Insira um id Válido", "Id inválido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (comboBoxFilterSale.Text == "Vendedor")
            {
                var sales = gridSale.DataSource as List<Sale>;
                List<Sale> teste = sales.FindAll(c => c.Seller.Name.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
                gridSale.DataSource = teste;
            }
            else if (comboBoxFilterSale.Text == "Cliente")
            {
                var sales = gridSale.DataSource as List<Sale>;
                List<Sale> teste = sales.FindAll(c => c.Client.Name.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
                gridSale.DataSource = teste;
            }
            else if (comboBoxFilterSale.Text == "Produto")
            {
                var sales = gridSale.DataSource as List<Sale>;
                List<Sale> teste = sales.FindAll(c => c.Product.Name.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
                gridSale.DataSource = teste;
            }
            textEditSearch.Text = "";
        }

        private void ComboBoxFilterSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterSale.Text != "") textEditSearch.Enabled = true;
            else textEditSearch.Enabled = false;
        }

        private void Register_Click_1(object sender, EventArgs e)
        {
            _formHomePage.BtnRegisterPurchases_Click();
        }
    }
}
