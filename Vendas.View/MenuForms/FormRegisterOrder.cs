using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vendas.Communication;
using Vendas.DTO;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;

namespace vendas.MenuForms
{
	public partial class FormRegisterOrder : Form
    {
        private List<OrderDTO> _listProduct = new List<OrderDTO>();
        public FormRegisterOrder()
        {
            InitializeComponent();
            OrderDTOBindingSource .DataSource = _listProduct;
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
            if (numValueEdit.Text == "0")
            { 
                MessageBox.Show("Selecione uma quantidade Válida", "Quantidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var productDTO = Service.ProductController.FilterDTO((TypeUser)Global.Instance.User.TypeUser, c => c.Name == ComboBoxProduct.Text).FirstOrDefault();
            if(string.IsNullOrWhiteSpace(ComboBoxProduct.Text) && productDTO == null)
            {
                MessageBox.Show("Selecione um produto válido e tente novamente", "Produto Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //if(int.TryParse())
            int quantity = int.Parse(numValueEdit.Text);
            OrderDTO order = new OrderDTO
            {
                ProductDTO = productDTO,
                ValueOrder = productDTO.Value * quantity,
                Quantity = quantity,
            };
            _listProduct.Add(order);

            OrderDTOBindingSource.DataSource = _listProduct;
            gridOrders.RefreshDataSource();
            UpdateValueText();
		}

		private void UpdateValueText()
        {
            double valueOrder = 0.0;
            foreach (var prod in _listProduct)
                valueOrder += prod.ValueOrder;
            ValueEdit.Text = "R$ " + valueOrder.ToString("0.00");
        }


        private void RemoveOrderList(object sender, EventArgs e)
        {
            GridView gridView = gridOrders.FocusedView as GridView;
            var prod = (gridView.GetRow(gridView.FocusedRowHandle) as OrderDTO);
            _listProduct.Remove(_listProduct.Find(c => c.ProductDTO.Id == prod.ProductDTO.Id));
            gridOrders.RefreshDataSource();
            UpdateValueText();
        }

        private List<Order> LoadListOrders() {
            var list = new List<Order>();
            foreach (var prod in _listProduct)
            {
                list.Add(new Order
                {
                    Quantity = prod.Quantity,
                    ProductId = prod.ProductDTO.Id
                }) ;
            }
            return list;
                // Cadastro da Venda
                //string message = Service.SaleController.Save(new Sale
                //{
                //    ProductId = prod.Id,
                //    ClientId = Global.Instance.User.Id,
                //    SellerId = prod.SellerId,
                //    Flag = "I",
                //});
                //if (message != "") throw new Exception(message);
                // Update estoque produto
                //message = Service.ProductController.Save(new Product
                //{
                //    Id = prod.Id,
                //    Name = prod.Name,
                //    Value = prod.Value,
                //    Description = prod.Description,
                //    Stock = Service.ProductController.Filter(c => c.Id == prod.Id).FirstOrDefault().Stock - 1,
                //    Flag = "U",
                //    SellerId = prod.SellerId,
                //});
                //if (message != "") throw new Exception(message);
            //}
        }

        private void RegisterOrders(object sender, EventArgs e)
        {
			if (_listProduct.Count == 0)
			{
				MessageBox.Show("Cadastre novos produtos no carrinho e tente novamente.", "Carrinho vazio!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
            try
            {
                var NewOrderSale = new SaleOrderCompleteDTO
                {
                    Sale = new Sale
                    {
                        ClientId = Global.Instance.User.Id,
                        DateSale = DateTime.Now,
                        Value = double.Parse(ValueEdit.Text.Replace("R$", ""))
                    },
                    Orders = LoadListOrders(),
				};
                Service.SaleController.Save(NewOrderSale);
				ClearFields();
				MessageBox.Show("Todos os pedidos foram cadastrados com sucesso. Consulte a aba de pedidos e consulte todos os pedidos cadastrados", "Pedidos Cadastrados com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
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
