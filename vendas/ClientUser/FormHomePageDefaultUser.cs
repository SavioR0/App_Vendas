using System;
using System.Windows.Forms;
using vendas.ClientUser;
using Vendas.Entity.Entities;
using Vendas.Library;
using Vendas.Management;
using Vendas.View.Loader;

namespace Vendas.View
{
    public partial class FormHomePageDefaultUser : Form, IView
    {
        public Form Form{get{ return this;}}
        public FormHomePageDefaultUser()
        {
            InitializeComponent();

            gridProduct.DataSource = Communication.Service.ProductController.Filter(c => c.Seller.Id == Global.Instance.User.Id);
            //gridSale.DataSource = Communication.Service.SaleController.Filter(c => c.Sale.ClientId == Global.Instance.User.Id)
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            AppManager.Instance.Load<LoaderController, Sale>(new FormRegisterSale());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void TabControlHomePage_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (TabControlHomePageDefautUser.SelectedTabPage ==ProdutosTab) 
            {
                btnEdit.Visible = false;
                btnExclude.Visible = false;
                btnRegister.Location = new System.Drawing.Point(14, 527);
                return;
            }
            if (TabControlHomePageDefautUser.SelectedTabPage == VendaTab)
            {
                btnEdit.Visible = true;
                btnExclude.Visible = true;
                btnRegister.Location = new System.Drawing.Point(288, 527); 

                return;
            }
        }
    }
}
