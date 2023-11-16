using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vendas.Communication;
using Vendas.Entity.Entities;
using Vendas.Library;

namespace vendas.MenuForms
{
    public partial class FormRegisterProduct : Form
    {
        public Form Form { get { return this; } }
        private Product _editedProduct;
        public FormRegisterProduct(Product product = null)
        {
            
            InitializeComponent();

            if (product != null)
                bindingSourceProduct.DataSource = new List<Product> { product };
            //ClearFields();
            SetFields(product);
            
        }

        private void SetFields(Product product)
        {
            if (product == null) return;
            _editedProduct = product;
            btnRegisterEditProduct.Text = "Editar Produto";
        }
        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            if (ValidateFields())
            {
                if (_editedProduct != null)
                {
                    UpdateProduct();
                    return;
                }
                RegisterProduct();
            }
        }
        private void UpdateProduct()
        {
            try
            {
                _editedProduct.Flag = "U";
                var message = Service.ProductController.Save(new Product()
                {
                    Id = _editedProduct.Id,
                    Name = nameValue.Text,
                    Description = descriptionValue.Text,
                    Value = float.Parse(valueValue.Text.Replace("R$", "")),
                    Stock = int.Parse(stockValue.Text),
                    Flag = "U",
                    SellerId = Global.Instance.User.Id,
                });
                if (!string.IsNullOrWhiteSpace(message)) { throw new Exception(message); }
                ClearFields();
                MessageBox.Show("Produto Editado com sucesso. Consulte a aba de \"Produtos\" para consultar os produtos editados.", "Produto Editado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    Flag = "I",
                    SellerId = Global.Instance.User.Id,
                });

                if (!string.IsNullOrWhiteSpace(message)) { throw new Exception(message); }
                ClearFields();
                MessageBox.Show("Produto cadastrado com sucesso. Consulte a aba de \"Produtos\" para consultar os produtos cadastrados.", "Produto Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            nameValue.Text = null;
            descriptionValue.Text = null;
            valueValue.Text = null;
            stockValue.Text = null;
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
