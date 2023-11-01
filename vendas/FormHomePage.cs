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
        }
        private void LoadClientPermissions()
        {
            menuToolStripMenuItem.DropDownItems[5].Text = "Minhas Compras";
            menuToolStripMenuItem.DropDownItems[1].Visible = false;
            menuToolStripMenuItem.DropDownItems[2].Visible = false;
            menuToolStripMenuItem.DropDownItems[4].Visible = false;
        }

        public void FormShow(Form frm,bool closeForm = true) {
            ActiveFormClose(closeForm);
            frmActive = frm;
            frm.TopLevel = false;
            panelFormSelected.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }

        private void ActiveFormClose(bool closeForm = true) {
            if (frmActive != null && closeForm)
                frmActive.Close();
        }
        private void BtnRegisterUserMenu_Click(object sender= null, System.EventArgs e= null)
        {
            FormShow(new FormHome(this));
        }
        public void BtnUsersMenu_Click(object sender=null, System.EventArgs e= null)
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

        public void BntRegisterUsersMenu_Click(object sender= null, System.EventArgs e= null)
        {
            FormShow(new FormRegisterUser());
        }

        public void BtnPurchasesSalesMenu_Click(object sender= null, System.EventArgs e = null)
        {
            FormShow(new FormOrderSale(this));
        }

        public void BtnRegisterPurchases_Click(object sender= null, System.EventArgs e = null)
        {
            FormShow(new FormRegisterOrder());
        }

        public void BtnProductMenu_Click(object sender= null, System.EventArgs e= null)
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
        public void BtnRegisterProductMenu_Click(object sender= null, EventArgs e= null)
        {
            OpenFormProduct();
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            FormShow(new FormHome(this), closeForm: false);
        }

        private void listarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new FormUsers(this));
        }

        private void RegisterUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormUser();
        }

        private void ListProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new FormProducts(this));
        }

        private void RegisterProductsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFormProduct();
        }

        private void ListOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new FormOrderSale(this));
        }

        private void cadastroDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new FormRegisterOrder());
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new FormHome(this));
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            AppManager.Instance.Load<LoaderController, User>(new LoginUser(Vendas.Library.Version.Instance.version));
            Global.Instance.User = null;
            AppManager.Instance.CloseForm(view: this);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new FormAbout());
        }


    }
}
