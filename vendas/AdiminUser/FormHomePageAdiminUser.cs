using System;
using System.Windows.Forms;
using vendas;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;
using Vendas.Management;
using Vendas.View.Loader;

namespace Vendas.View
{
    public partial class FormHomePageAdminUser : Form, IView
    {
        public FormHomePageAdminUser()
        {
            InitializeComponent();

            gridClient.DataSource = Communication.Service.UserController.Filter(c => c.TypeUser == (int)TypeUser.Client);
            gridProduct.DataSource = Communication.Service.ProductController.Filter(c => c.Seller.Id == Global.Instance.User.Id);


        }
        public Form Form {get{return this;}}
        public void ChangeVisibleButtons(bool bolean) {
            btnEdit.Visible = bolean;
            btnRegister.Visible = bolean;
            btnUpdate.Visible = bolean;
            btnExclude.Visible = bolean;
        }
        private void TabControlHomePage_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (TabControlHomePage.SelectedTabPage == ClienteTab) 
            {
                ChangeVisibleButtons(false);
                comboBoxFilterProd.Text = "";
                textEditSearch.Enabled = false;

                comboBoxFilterProd.Properties.Items.Clear();
                comboBoxFilterProd.Properties.Items.Add("Id");
                comboBoxFilterProd.Properties.Items.Add("Nome");
                return;
            }
            if (TabControlHomePage.SelectedTabPage == ProdutosTab)
            {
                ChangeVisibleButtons(true);
                comboBoxFilterProd.Text = "";
                textEditSearch.Enabled = false;

                comboBoxFilterProd.Properties.Items.Clear();
                comboBoxFilterProd.Properties.Items.Add("Id");
                comboBoxFilterProd.Properties.Items.Add("Nome");
                return;
            }
            if (TabControlHomePage.SelectedTabPage == VendaTab)
            {
                comboBoxFilterProd.Text = "";
                textEditSearch.Enabled = false;
                comboBoxFilterProd.Properties.Items.Clear();
                comboBoxFilterProd.Properties.Items.Add("Id");
                comboBoxFilterProd.Properties.Items.Add("Produto");
                comboBoxFilterProd.Properties.Items.Add("Cliente");

                return;
            }
        }
        private void ComboBoxFilterProd_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBoxFilterProd.Text))
            {
                textEditSearch.Enabled = true;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            AppManager.Instance.Load<LoaderController, Product>(new FormRegisterProduct());
        }

        private void BtnSearchProd_Click(object sender, EventArgs e)
        {

            if (TabControlHomePage.SelectedTabPage == ProdutosTab)
            {
                if (string.IsNullOrWhiteSpace(textEditSearch.Text)) { gridProduct.DataSource = Communication.Service.ProductController.GetAll(); return; }

                if (comboBoxFilterProd.Text == "Id")
                    gridProduct.DataSource = Communication.Service.ProductController.Filter(c => c.Id == int.Parse(textEditSearch.Text.Trim()));
                if (comboBoxFilterProd.Text == "Nome")
                    gridProduct.DataSource = Communication.Service.ProductController.Filter(c => c.Name == textEditSearch.Text.Trim());
                return;
            }
            if (TabControlHomePage.SelectedTabPage == ClienteTab) 
            {
                if (string.IsNullOrWhiteSpace(textEditSearch.Text)) { gridClient.DataSource = Communication.Service.UserController.GetAll(); return; }

                if (comboBoxFilterProd.Text == "Id")
                    gridClient.DataSource = Communication.Service.UserController.Filter(c => c.Id == int.Parse(textEditSearch.Text.Trim()));
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
    }
}
