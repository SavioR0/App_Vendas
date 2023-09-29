using System;
using System.Windows.Forms;
using Vendas.Management;

namespace Vendas.View
{
    public partial class FormHomePageDefaultUser : Form, IView
    {
        public Form Form{get{ return this;}}
        public FormHomePageDefaultUser()
        {
            InitializeComponent();
        }
    }
}
