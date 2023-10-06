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

        Dictionary<TypeUser, Action> _loadPermissions;
        public FormHomePage()
        {
            InitializeComponent();
            
            _loadPermissions = new Dictionary<TypeUser, Action> {
                {TypeUser.Seller , LoadSellerPermissions},
                {TypeUser.Client , LoadClientPermissions}
            };

            LoadPermissions((TypeUser)Global.Instance.User.TypeUser);
            labelUserName.Text = Global.Instance.User.Name;
        }

        private void LoadPermissions(TypeUser typeUser)
        {
            if(_loadPermissions.TryGetValue(typeUser, out Action loadPermissions))
                loadPermissions();
        }

        private void LoadSellerPermissions()
        {
            btnUsersMenu.Text = "Clientes";
            btnProductMenu.Text = "Meus Produtos";
            btnRegisterUsersMenu.Visible = false;
            btnRegisterOrders.Visible = false;
            btnOrdersMenu.Text = "Minhas Vendas";
        }
        private void LoadClientPermissions()
        {
            btnProductMenu.Text = "Produtos";
            btnUsersMenu.Visible = false;
            btnRegisterUsersMenu.Visible = false;
            btnOrdersMenu.Text = "Minhas Compras";
            btnRegisterProductMenu.Visible = false;
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
        private void btnRegisterUserMenu_Click(object sender, System.EventArgs e)
        {
            ActiveFormClose();
        }
        private void btnUsersMenu_Click(object sender, System.EventArgs e)
        {
            FormShow(new FormUsers());
        }
        private void bntRegisterUsersMenu_Click(object sender, System.EventArgs e)
        {
            FormShow(new FormRegisterUser());
        }

        private void btnPurchasesSalesMenu_Click(object sender, System.EventArgs e)
        {
            FormShow(new FormOrderSale());
        }

        private void btnRegisterPurchases_Click(object sender, System.EventArgs e)
        {
            FormShow(new FormRegisterOrder());
        }

        public void btnProductMenu_Click(object sender, System.EventArgs e)
        {
            FormShow(new FormProducts(this));
        }
        public void OpenForm( Product prod = null)
        {
            FormShow(new FormRegisterProduct(prod));
        }

        public void EditProductButtonClicked(Product prod)
        {
            OpenForm(prod: prod);
        }
        private void btnRegisterProductMenu_Click(object sender, EventArgs e)
        {
            OpenForm();
        }


        private void btnExit_Click(object sender, System.EventArgs e)
        {
            AppManager.Instance.Load<LoaderController, User>(new LoginUser());
            Global.Instance.User = null;
            AppManager.Instance.CloseForm(view: this);
        }

        
    }
}
