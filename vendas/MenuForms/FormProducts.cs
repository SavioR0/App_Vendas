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
    public partial class FormProducts : Form
    {
        private FormHomePage _formHomePage;
        public FormProducts(FormHomePage formHomePage)
        {
            InitializeComponent();
            LoadGridProduct((TypeUser)Global.Instance.User.TypeUser);
            _formHomePage = formHomePage;
        }

        private void LoadGridProduct(TypeUser typeUser) {
            if (GetTypeUserFunctions<Product>.typeUserFunctions.TryGetValue((typeUser, typeof(Product)), out Func<List<Product>> loadProducts))
            {
                var products = loadProducts();
                foreach (var product in products)
                {
                    product.Seller = Service.UserController.Filter(c => c.Id == product.SellerId)[0];
                }
                gridProduct.DataSource = products;
            }
        }

        private void btnExclude_Click(object sender, System.EventArgs e)
        {
            GridView gridView = gridProduct.FocusedView as GridView;
            var prod = (gridView.GetRow(gridView.FocusedRowHandle) as Product);
            Service.ProductController.Exclude(prod.Id);
            LoadGridProduct((TypeUser)Global.Instance.User.TypeUser);
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            GridView gridView = gridProduct.FocusedView as GridView;
            var prod = (gridView.GetRow(gridView.FocusedRowHandle) as Product);
            _formHomePage.EditProductButtonClicked(prod);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _formHomePage.OpenForm();
        }
    }
}
