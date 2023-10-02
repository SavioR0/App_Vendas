using System;
using System.Windows.Forms;
using Vendas.Management;

namespace vendas.ClientUser
{
    public partial class FormRegisterSale : Form, IView
    {
        public Form Form { get { return this; } }
        public FormRegisterSale()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AppManager.Instance.CloseForm(view:this);
        }
    }
}
