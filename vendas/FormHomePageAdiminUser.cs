using System;
using System.Windows.Forms;
using Vendas.Management;

namespace Vendas.View
{
    public partial class FormHomePageAdminUser : Form, IView
    {
        public FormHomePageAdminUser()
        {
            InitializeComponent();
        }

        public Form Form {get{return this;}}

        private void FormHomePageAdiminUser_Load(object sender, EventArgs e)
        {

        }
    }
}
