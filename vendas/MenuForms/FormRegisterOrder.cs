using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vendas.Communication;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;

namespace vendas.MenuForms
{
    public partial class FormRegisterOrder : Form
    {
        private List<Product> _listProduct = new List<Product>();
        public FormRegisterOrder()
        {
            InitializeComponent();
            gridOrders.DataSource = _listProduct;
            btnExclude.Enabled = false;
            LoadNameProducts();
        }

        private void LoadNameProducts()
        {
            var prods = Service.ProductController.GetAll();
            foreach (var prod in prods)
            {
                ComboBoxProduct.Properties.Items.Add(prod.Name);
            }
            btnExclude.Enabled = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ComboBoxProduct.Text))
            {
                MessageBox.Show("Selecione um produto válido e tente novamente", "Produto Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var prod = Service.ProductController.Filter(c => c.Name == ComboBoxProduct.Text)[0];
            if (prod == null) 
            {
                MessageBox.Show("O produto especificado não existe.","Produto Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            prod.Seller = Service.UserController.Filter(c => (c.TypeUser == (int)TypeUser.Seller || c.TypeUser == (int)TypeUser.Admin) && prod.SellerId == c.Id)[0];

            for (int i = 0; i <int.Parse(numValueEdit.Text); i++)
            {
                _listProduct.Add(prod);
            }
            gridOrders.RefreshDataSource();

            UpdateValueText();
        }

        private void UpdateValueText()
        {
            double valueOrder = 0.0;
            foreach (var prod in _listProduct)
                valueOrder += prod.Value;
            ValueTextEdit.Text = "R$ " + valueOrder.ToString("0.00");
        }

        private void ComboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveOrderList(object sender, EventArgs e)
        {
            GridView gridView = gridOrders.FocusedView as GridView;
            var prod = (gridView.GetRow(gridView.FocusedRowHandle) as Product);
            _listProduct.Remove(_listProduct.Find(c => c.Id == prod.Id));
            gridOrders.RefreshDataSource();
            UpdateValueText();
        }

        private void RegisterOrders(object sender, EventArgs e)
        {
            if (_listProduct.Count == 0) 
            {
                MessageBox.Show("Cadastre novos produtos no carrinho e tente novamente.", "Carrinho vazio!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            try
            {
                foreach (var prod in _listProduct)
                {
                    // Cadastro da Venda
                    string message = Service.SaleController.Save(new Sale
                    {
                        ProductId = prod.Id,
                        ClientId = Global.Instance.User.Id,
                        SellerId = prod.SellerId,
                        Flag = 'I',
                    });
                    if (message != "") throw new Exception(message);
                    // Cadastro da Venda
                    message = Service.ProductController.Save(new Product
                    {
                        Id = prod.Id,
                        Name = prod.Name,
                        Value = prod.Value,
                        Description = prod.Description,
                        Stock = prod.Stock--,
                        Flag = 'U',
                        SellerId = prod.SellerId,
                    });
                    if (message != "") throw new Exception(message);
                }
                ClearFields();
                MessageBox.Show("Todos os pedidos foram cadastrados com sucesso. Consulte a aba de pedidos e consulte todos os pedidos cadastrados", "Pedidos Cadastrados com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao cadastrar Pedido. " + ex, "Cadastro de Pedido inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            _listProduct = null;
            gridOrders.DataSource = null;
            ComboBoxProduct.Text = "";
            numValueEdit.Text = "";
        }

    }
}
