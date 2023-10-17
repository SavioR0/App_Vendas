using System;
using System.Windows.Forms;

namespace vendas.MenuForms
{
    public partial class FormHome : Form
    {
        private FormHomePage _formHomePage;
        public FormHome(FormHomePage formHomePage)
        {
            InitializeComponent();
            _formHomePage = formHomePage;

            LoadComponentHomePage();
        }

        private void LoadComponentHomePage()
        {
            //tileItem6.Visible = false;
        }

        private void tileUsers_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _formHomePage.BtnUsersMenu_Click();
        }

        private void tileProducts_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _formHomePage.BtnProductMenu_Click();
        }

        private void tileRegisterUser_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _formHomePage.BntRegisterUsersMenu_Click();
        }

        private void tileItem8_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _formHomePage.BtnRegisterProductMenu_Click();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _formHomePage.BtnPurchasesSalesMenu_Click();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _formHomePage.BtnRegisterPurchases_Click();
        }
    }
}
