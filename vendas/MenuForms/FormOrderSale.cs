using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Vendas.Communication;
using Vendas.Entity.Enums;
using Vendas.Library;
using Vendas.Entity.Entities;

namespace vendas.MenuForms
{
    public partial class FormOrderSale : Form
    {
        public FormOrderSale()
        {
            InitializeComponent();

            LoadGridProduct((TypeUser)Global.Instance.User.TypeUser);
        }

        private void LoadGridProduct(TypeUser typeUser)
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

        private void SimpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void BtnExclude_Click(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
