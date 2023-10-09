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
        private readonly FormHomePage _formHomePage;
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

        private void BtnExclude_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover o usuário do sistema?", "Remover Usuário!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GridView gridView = gridProduct.FocusedView as GridView;
                var prod = (gridView.GetRow(gridView.FocusedRowHandle) as Product);
                var message = Service.ProductController.Exclude(prod.Id);
                if (message != "") MessageBox.Show(message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadGridProduct((TypeUser)Global.Instance.User.TypeUser);
            }
        }

        public void BtnEdit_Click(object sender, EventArgs e)
        {
            GridView gridView = gridProduct.FocusedView as GridView;
            var prod = (gridView.GetRow(gridView.FocusedRowHandle) as Product);
            _formHomePage.EditProductButtonClicked(prod);
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            _formHomePage.OpenFormProduct();
        }
    }
}
