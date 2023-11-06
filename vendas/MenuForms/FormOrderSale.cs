using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using vendas.Reports;
using Vendas.Communication;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;

namespace vendas.MenuForms
{
    public partial class FormOrderSale : Form
    {
        private readonly FormHomePage _formHomePage;
        private readonly Dictionary<string, Action> FilterSelected;
        public FormOrderSale(FormHomePage formHomePage)
        {
            _formHomePage = formHomePage;
            InitializeComponent();

            LoadGridSale((TypeUser)Global.Instance.User.TypeUser);

            FilterSelected = new Dictionary<string, Action> {
                { "Id", FilterById},
                { "Cliente", FilterByClient},
                { "Vendedor", FilterBySeller},
                { "Produto", FilterByProduct},
                { "Valor", FilterByValue},
                { "Estoque", FilterByStock},
            };
        }

        private void FilterByStock()
        {
            if (!int.TryParse(textEditSearch.Text, out int value)) throw new ApplicationException("Coloque um Estoque válido!");

            var allSales = gridSale.DataSource as List<Sale>;
            List<Sale> sale = allSales.FindAll(c => c.Product.Stock == value);
            gridSale.DataSource = sale;
        }

        private void FilterByValue()
        {
            if (!double.TryParse(textEditSearch.Text, out double value)) throw new ApplicationException("Coloque um Id válido!");

            var allSales = gridSale.DataSource as List<Sale>;
            List<Sale> sale = allSales.FindAll(c => c.Product.Value == value);
            gridSale.DataSource = sale;
        }

        private void FilterByProduct()
        {
            var sales = gridSale.DataSource as List<Sale>;
            List<Sale> teste = sales.FindAll(c => c.Product.Name.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            gridSale.DataSource = teste;
        }

        private void FilterBySeller()
        {
            var sales = gridSale.DataSource as List<Sale>;
            List<Sale> teste = sales.FindAll(c => c.Seller.Name.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            gridSale.DataSource = teste;
        }

        private void FilterByClient()
        {
            var sales = gridSale.DataSource as List<Sale>;
            List<Sale> teste = sales.FindAll(c => c.Client.Name.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            gridSale.DataSource = teste;
        }

        private void FilterById()
        {
            if (!int.TryParse(textEditSearch.Text, out int id)) throw new ApplicationException("Coloque um Id válido!");

            var allSales = gridSale.DataSource as List<Sale>;
            List<Sale> sale = allSales.FindAll(c => c.Id == id);
            gridSale.DataSource = sale;
        }

        private void LoadNumLabel()
        {
            LabelNumOrder.Text = ((List<Sale>)gridSale.DataSource).Count.ToString();
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
                LoadNumLabel();
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
            try
            {
                LoadGridSale((TypeUser)Global.Instance.User.TypeUser);
                if (string.IsNullOrWhiteSpace(textEditSearch.Text)) return;

                if (FilterSelected.TryGetValue(comboBoxFilterSale.Text, out Action LoadFilter))
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

        private void ComboBoxFilterSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterSale.Text != "") textEditSearch.Enabled = true;
            else textEditSearch.Enabled = false;
        }

        private void Register_Click_1(object sender, EventArgs e)
        {
            _formHomePage.BtnRegisterPurchases_Click();
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            GridView gridView = gridSale.FocusedView as GridView;
            var saleList = new List<Sale>();
            for (int i = 0; i < gridView.RowCount; i++)
            {
                if (gridView.GetRow(i) is Sale sale)
                {
                    saleList.Add(sale);
                }
            }
            //var fReport = new Report();
            //report.Load(@"../../Reports/OrderReports.frx");

            //report.Dictionary.RegisterBusinessObject(Service.UserController.GetAll(), "userList", 10, true);
            //report.Dictionary.RegisterBusinessObject(Service.ProductController.GetAll(), "productList", 10, true);
            //fReport.Dictionary.RegisterBusinessObject(saleList, "orderList", 10, true);
            //fReport.Report.Save(@"../../Reports/OrderReports.frx");

            var fReport = GetReportTypes<Sale>.GeneratePDF(TypeReport.Order, saleList);
            (new FormPreviewPDFReport(fReport)).ShowDialog();
        }

        private void UpdateGridButton_Click(object sender, EventArgs e)
        {
            LoadGridSale((TypeUser)Global.Instance.User.TypeUser);
        }

    }
}
