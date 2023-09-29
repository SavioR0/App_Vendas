using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vendas.Entity.Entities;
using Vendas.Library;
using Vendas.Management;
using Vendas.Communication;

namespace vendas
{
    public partial class FormRegisterProduct : Form, IView
    {
        bool EditedProduct;
        public FormRegisterProduct(bool editedProduct = false)
        {
            InitializeComponent();
            EditedProduct = editedProduct;
        }

        public Form Form { get { return this; } }



        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            if (ValidateFields())
            {
                if (EditedProduct)
                {
                    UpdateProduct();
                    return;
                }
                RegisterProduct();
            }
        }

        private void UpdateProduct()
        {
            throw new NotImplementedException();
        }

        private void RegisterProduct()
        {
            try
            {
                var message = Service.ProductController.Save(new Product()
                {
                    Name = nameValue.Text,
                    Description = descriptionValue.Text,
                    Value = float.Parse(valueValue.Text.Replace("R$", "")),
                    Stock = int.Parse(stockValue.Text),
                    Flag = 'I',
                    SellerId = Global.Instance.User.Id,
                });
                if (!string.IsNullOrWhiteSpace(message)) { throw new Exception(message); }
                AppManager.Instance.CloseForm(view: this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            Dictionary<TextEdit, string> fields = new Dictionary<TextEdit, string> {
                { nameValue, "Campo nome está vazio"},
                { descriptionValue, "Campo descrição está vazio"},
                { stockValue, "Campo estoque está vazio"},
                { valueValue, "Campo valor está vazio"},
            };
            foreach (KeyValuePair<TextEdit, string> field in fields)
            {
                if (string.IsNullOrEmpty(field.Key.Text))
                {
                    MessageBox.Show(field.Value, "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
    }
}
