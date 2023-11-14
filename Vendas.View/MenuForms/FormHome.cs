using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vendas.Entity.Enums;
using Vendas.Library;

namespace vendas.MenuForms
{
    public partial class FormHome : Form
    {
        private readonly FormHomePage _formHomePage;
        private readonly Dictionary<TypeUser, Action> _loadPermissions;
        public FormHome(FormHomePage formHomePage)
        {
            InitializeComponent();
            _formHomePage = formHomePage;

            _loadPermissions = new Dictionary<TypeUser, Action> {
                {TypeUser.Seller , LoadSellerPermissions},
                {TypeUser.Client , LoadClientPermissions}
            };

            LoadPermissions((TypeUser)Global.Instance.User.TypeUser);
            //labelUserName.Text = Global.Instance.User.Name;

        }

        private void LoadPermissions(TypeUser typeUser)
        {
            if (_loadPermissions.TryGetValue(typeUser, out Action loadPermissions))
                loadPermissions();

        }

        private void LoadSellerPermissions()
        {
            tileItem6.Visible = false;
            tileItem1.Visible = false;
            tileItem3.Text = "Clientes";
            tileItem5.Text = "Meus Produtos";
            tileItem2.Text = "Minhas Vendas";
        }
        private void LoadClientPermissions()
        {
            tileItem2.Text = "Minhas Compras";
            tileItem5.Text = "Produtos";
            tileItem6.Visible = false;
            tileItem3.Visible = false;
            tileItem8.Visible = false;
        }

        private void TileUsers_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _formHomePage.BtnUsersMenu_Click();
        }

        private void TileProducts_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _formHomePage.BtnProductMenu_Click();
        }

        private void TileRegisterUser_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _formHomePage.BntRegisterUsersMenu_Click();
        }

        private void TileItem8_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _formHomePage.BtnRegisterProductMenu_Click();
        }

        private void TileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _formHomePage.BtnPurchasesSalesMenu_Click();
        }

        private void TileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _formHomePage.BtnRegisterPurchases_Click();
        }
    }
}
