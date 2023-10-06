using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;
using vendas;
using vendas.MenuForms;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;
using Vendas.Management;
using Vendas.View.Loader;

namespace Vendas.View
{
    public partial class FormHomePageAdminUser : Form, IView
    {

        public Form Form { get { return this; } }
        public FormHomePageAdminUser()
        {
            InitializeComponent();
            RefreshGridClient();
            RefreshGridProduct();
            
            gridSale.DataSource = null;
            //gridSale.DataSource = Communication.Service.SaleController.Filter(c => c.Sale.ClientId == Global.Instance.User.Id)

        }
        public void RefreshGridProduct() {
            gridProduct.DataSource = null;
            gridProduct.DataSource = Communication.Service.ProductController.Filter(c => c.Seller.Id == Global.Instance.User.Id);
            if (gridProduct.DataSource != null && TabControlHomePage.SelectedTabPage == ProdutosTab) ChangeEnableButtons(true);
        }
        public void RefreshGridClient()
        {
            gridClient.DataSource = null;
            gridClient.DataSource = Communication.Service.UserController.Filter(c => c.TypeUser == (int)TypeUser.Client);
            if (gridProduct.DataSource != null && TabControlHomePage.SelectedTabPage == ClienteTab) ChangeEnableButtons(true);

        }
        public void ChangeVisibleButtons(bool bolean) {
            btnEdit.Visible = bolean;
            btnRegister.Visible = bolean;
            btnUpdate.Visible = bolean;
            btnExclude.Visible = bolean;
        }
        public void ChangeEnableButtons(bool bolean)
        {
            btnEdit.Enabled = bolean;
            btnExclude.Enabled = bolean;
        }
        private void TabControlHomePage_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            comboBoxFilterProd.Properties.Items.Clear();
            comboBoxFilterProd.Properties.Items.Add("Id");

            comboBoxFilterProd.Text = "";
            textEditSearch.Enabled = false;
            if (TabControlHomePage.SelectedTabPage == ProdutosTab)
            {
                ChangeVisibleButtons(true);
                comboBoxFilterProd.Properties.Items.Add("Nome");
                return;
            }
            ChangeVisibleButtons(false);
            if (TabControlHomePage.SelectedTabPage == ClienteTab) 
            {
                comboBoxFilterProd.Properties.Items.Add("Nome");
                return;
            }
            
            if (TabControlHomePage.SelectedTabPage == VendaTab)
            {
                comboBoxFilterProd.Properties.Items.Add("Produto");
                comboBoxFilterProd.Properties.Items.Add("Cliente");
                return;
            }
            textEditSearch.Text = "";
        }
        private void ComboBoxFilterProd_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBoxFilterProd.Text))
            {
                textEditSearch.Enabled = true;
            }
        }

        //private void BtnRegister_Click(object sender, EventArgs e)
        //{
        //    AppManager.Instance.Load<LoaderController, Product>(new FormRegisterProduct());
        //}

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    GridView gridView = gridProduct.FocusedView as GridView;
        //    AppManager.Instance.Load<LoaderController, Product>(
        //        new FormRegisterProduct(editedProduct: true, product: gridView.GetRow(gridView.FocusedRowHandle) as Product));
        //}

        private void BtnSearchProd_Click(object sender, EventArgs e)
        {

            if (TabControlHomePage.SelectedTabPage == ProdutosTab)
            {
                if (string.IsNullOrWhiteSpace(textEditSearch.Text)) { gridProduct.DataSource = Communication.Service.ProductController.GetAll(); return; }

                if (comboBoxFilterProd.Text == "Id")
                {
                    int id = int.Parse(textEditSearch.Text);
                    gridProduct.DataSource = Communication.Service.ProductController.Filter(c => c.Id == id);
                }
                if (comboBoxFilterProd.Text == "Nome")
                    gridProduct.DataSource = Communication.Service.ProductController.Filter(c => c.Name == textEditSearch.Text.Trim());
                return;
            }
            if (TabControlHomePage.SelectedTabPage == ClienteTab) 
            {
                if (string.IsNullOrWhiteSpace(textEditSearch.Text)) { gridClient.DataSource = Communication.Service.UserController.GetAll(); return; }

                if (comboBoxFilterProd.Text == "Id")
                {
                    int id = int.Parse(textEditSearch.Text.Trim());
                    gridClient.DataSource = Communication.Service.UserController.Filter(c => c.Id == id);
                }
                if (comboBoxFilterProd.Text == "Nome")
                    gridClient.DataSource = Communication.Service.UserController.Filter(c => c.Name == textEditSearch.Text.Trim() && c.TypeUser == (int)TypeUser.Client);
                return;
            }
            if (TabControlHomePage.SelectedTabPage == VendaTab)
            {
                //if (comboBoxFilterProd.Text == "Id")
                //    gridSale.DataSource = Communication.Service.SaleController.Filter(c => c.Id == int.Parse(textEditSearch.Text.Trim()));
                //if (comboBoxFilterProd.Text == "Produto")
                //    gridSale.DataSource = Communication.Service.SaleController.Filter(c => c.IdProduct == textEditSearch.Text.Trim());
                //if (comboBoxFilterProd.Text == "Cliente")
                //    gridSale.DataSource = Communication.Service.SaleController.Filter(c => c.IdClient == textEditSearch.Text.Trim());
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            gridClient.DataSource = null;
            gridClient.DataSource = Communication.Service.UserController.Filter(c => c.TypeUser == (int)TypeUser.Client);
            gridProduct.DataSource = null;
            gridProduct.DataSource = Communication.Service.ProductController.Filter(c => c.Seller.Id == Global.Instance.User.Id);
            gridSale.DataSource = null;
            //gridSale.DataSource = Communication.Service.SaleController.Filter(c => c.Sale.ClientId == Global.Instance.User.Id)
        }

        private void btnExclude_Click(object sender, EventArgs e)
        {

        }
    }
}
