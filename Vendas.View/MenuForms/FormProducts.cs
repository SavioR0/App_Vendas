using DevExpress.XtraGrid.Views.Grid;
using FastReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using vendas.Reports;
using Vendas.Communication;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;

namespace vendas.MenuForms
{
    public partial class FormProducts : Form
    {
        private readonly FormHomePage _formHomePage;
        private readonly Dictionary<string, Action> FilterSelected;
        public FormProducts(FormHomePage formHomePage)
        {
            InitializeComponent();
            if ((TypeUser)Global.Instance.User.TypeUser == TypeUser.Client)
                panelControl1.Visible = false;
            LoadGridProduct((TypeUser)Global.Instance.User.TypeUser);
            _formHomePage = formHomePage;

            FilterSelected = new Dictionary<string, Action> {
                { "Id", FilterById},
                { "Nome", FilterByName},
                { "Descrição", FilterByDescription},
                { "Estoque", FilterByEstoque},
                { "Valor", FilterByValue},
                { "Vendedor", FilterBySeller},
            };
        }

        private void FilterBySeller()
        {
            var allProds = gridProduct.DataSource as List<Product>;
            List<Product> prods = allProds.FindAll(c => c.Seller.Name.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            gridProduct.DataSource = prods;
        }

        private void FilterByValue()
        {
            if (!double.TryParse(textEditSearch.Text, out double value)) throw new ApplicationException("Coloque um Valor válido!");

            var allProds = gridProduct.DataSource as List<Product>;
            List<Product> prods = allProds.FindAll(c => c.Value == value);
            gridProduct.DataSource = prods;
        }

        private void FilterByEstoque()
        {
            if (!int.TryParse(textEditSearch.Text, out int stock)) throw new ApplicationException("Coloque um Estoque válido!");

            var allProds = gridProduct.DataSource as List<Product>;
            List<Product> prods = allProds.FindAll(c => c.Stock == stock);
            gridProduct.DataSource = prods;
        }

        private void FilterByDescription()
        {
            var allProds = gridProduct.DataSource as List<Product>;
            List<Product> prods = allProds.FindAll(c => c.Description.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            gridProduct.DataSource = prods;
        }

        private void FilterByName()
        {
            var allProds = gridProduct.DataSource as List<Product>;
            List<Product> prods = allProds.FindAll(c => c.Name.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            gridProduct.DataSource = prods;
        }

        private void FilterById()
        {
            if (!int.TryParse(textEditSearch.Text, out int id)) throw new ApplicationException("Coloque um Id válido!");

            var allProds = gridProduct.DataSource as List<Product>;
            List<Product> prods= allProds.FindAll(c => c.Id == id);
            gridProduct.DataSource = prods;
        }

        private void LoadGridProduct(TypeUser typeUser) {
            if (GetTypeUserFunctions<Product>.typeUserFunctions.TryGetValue((typeUser, typeof(Product)), out Func<IQueryable< Product>> loadProducts))
            {
                var products = loadProducts().ToList<Product>();
                foreach (var product in products)
                {
                    product.Seller = Service.UserController.Filter(c => c.Id == product.SellerId).FirstOrDefault();
                }
                gridProduct.DataSource = products;
                LoadNumLabel();
            }
        }

        private void LoadNumLabel()
        {
            LabelNumProd.Text = ((List<Product>)gridProduct.DataSource).Count.ToString();
        }

        private void BtnExclude_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover o produto do sistema?", "Remover Produto!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GridView gridView = gridProduct.FocusedView as GridView;
                var prod = (gridView.GetRow(gridView.FocusedRowHandle) as Product);
                var message = Service.ProductController.Exclude(prod.Id);
                if (message != "") MessageBox.Show("Certifique a conexão com o banco e a possíbilidade que exitir alguma venda com o referente produto.", "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadGridProduct((TypeUser)Global.Instance.User.TypeUser);
            }
        }

        public void BtnEdit_Click(object sender, EventArgs e)
        {
            GridView gridView = gridProduct.FocusedView as GridView;
            var prod = (gridView.GetRow(gridView.FocusedRowHandle) as Product);
            _formHomePage.EditProductButtonClicked(prod);
        }

        private void ComboBoxFilterProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterProd.Text != "") textEditSearch.Enabled = true;
            else textEditSearch.Enabled = false;
        }

        private void BtnSearchProd_Click(object sender, EventArgs e)
        {
            try
            {
                LoadGridProduct((TypeUser)Global.Instance.User.TypeUser);
                if (string.IsNullOrWhiteSpace(textEditSearch.Text)) return;

                if (FilterSelected.TryGetValue(comboBoxFilterProd.Text, out Action LoadFilter))
                {
                    LoadFilter();
                }
            }
            catch (ApplicationException ex) {
                MessageBox.Show(ex.Message, "Erro ao filtrar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textEditSearch.Text = "";
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            gridProduct.Refresh();
            GridView gridView = gridProduct.FocusedView as GridView;
            var productList = new List<Product>();
            for (int i = 0; i < gridView.RowCount; i++)
            {
                productList.Add((gridView.GetRow(i)) as Product);
            }
            var fReport = GetReportTypes<Product>.GeneratePDF(TypeReport.Product, productList);
            (new FormPreviewPDFReport(fReport)).ShowDialog();
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            _formHomePage.BtnRegisterProductMenu_Click();
        }

        private void UpdateGridButton_Click(object sender, EventArgs e)
        {
            LoadGridProduct((TypeUser)Global.Instance.User.TypeUser);
        }
    }
}
