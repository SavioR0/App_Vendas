using System.Windows.Forms;
using vendas.MenuForms;
using Vendas.Library;
using Vendas.Management;
using Vendas.View;
using Vendas.View.Loader;
using Vendas.Entity.Entities;
using System;
using System.Collections.Generic;
using Vendas.Entity.Enums;

namespace vendas
{
    public partial class FormHomePage : Form, IView
    {
        private Form frmActive;
        public Form Form { get { return this; } }

        readonly Dictionary<TypeUser, Action> _loadPermissions;
        public FormHomePage()
        {
            InitializeComponent();
            
            _loadPermissions = new Dictionary<TypeUser, Action> {
                {TypeUser.Seller , LoadSellerPermissions},
                {TypeUser.Client , LoadClientPermissions}
            };

            LoadPermissions((TypeUser)Global.Instance.User.TypeUser);
            //labelUserName.Text = Global.Instance.User.Name;
        }

        private void LoadPermissions(TypeUser typeUser)
        {
            if(_loadPermissions.TryGetValue(typeUser, out Action loadPermissions))
                loadPermissions();
        }

        private void LoadSellerPermissions()
        {
            menuToolStripMenuItem.DropDownItems[1].Text = "Clientes";
            menuToolStripMenuItem.DropDownItems[3].Text = "Meus Produtos";
            menuToolStripMenuItem.DropDownItems[5].Text = "Minhas Vendas";
            menuToolStripMenuItem.DropDownItems[2].Visible = false;
            menuToolStripMenuItem.DropDownItems[6].Visible = false;
            //btnUsersMenu.Text = "Clientes";
            // btnProductMenu.Text = "Meus Produtos";
            //btnRegisterUsersMenu.Visible = false;
            //btnRegisterOrders.Visible = false;
            //btnOrdersMenu.Text = "Minhas Vendas";
        }
        private void LoadClientPermissions()
        {
            menuToolStripMenuItem.DropDownItems[1].Visible = false;
            menuToolStripMenuItem.DropDownItems[2].Visible = false;
            menuToolStripMenuItem.DropDownItems[5].Text = "Minhas Compras";
            menuToolStripMenuItem.DropDownItems[4].Visible = false;
            //btnProductMenu.Text = "Produtos";
            //btnUsersMenu.Visible = false;
            //btnRegisterUsersMenu.Visible = false;
            //btnOrdersMenu.Text = "Minhas Compras";
            //btnRegisterProductMenu.Visible = false;
        }

        private void FormShow(Form frm,bool closeForm = true) {
            ActiveFormClose(closeForm);
            frmActive = frm;
            frm.TopLevel = false;
            panelFormSelected.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose(bool closeForm = true) {
            if (frmActive != null && closeForm)
                frmActive.Close();
        }
        private void BtnRegisterUserMenu_Click(object sender, System.EventArgs e)
        {
            ActiveFormClose();
        }
        private void BtnUsersMenu_Click(object sender, System.EventArgs e)
        {
            FormShow(new FormUsers(this));
        }

        public void OpenFormUser(User user = null)
        {
            FormShow(new FormRegisterUser(user));
        }

        public void EditUserButtonClicked(User user)
        {
            OpenFormUser(user: user);
        }

        private void BntRegisterUsersMenu_Click(object sender, System.EventArgs e)
        {
            FormShow(new FormRegisterUser());
        }

        private void BtnPurchasesSalesMenu_Click(object sender, System.EventArgs e)
        {
            FormShow(new FormOrderSale());
        }

        private void BtnRegisterPurchases_Click(object sender, System.EventArgs e)
        {
            FormShow(new FormRegisterOrder());
        }

        public void BtnProductMenu_Click(object sender, System.EventArgs e)
        {
            FormShow(new FormProducts(this));
        }
        public void OpenFormProduct( Product prod = null)
        {
            FormShow(new FormRegisterProduct(prod));
        }

        public void EditProductButtonClicked(Product prod)
        {
            OpenFormProduct(prod: prod);
        }
        private void BtnRegisterProductMenu_Click(object sender, EventArgs e)
        {
            OpenFormProduct();
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            AppManager.Instance.Load<LoaderController, User>(new LoginUser());
            Global.Instance.User = null;
            AppManager.Instance.CloseForm(view: this);
        }
    }
}
