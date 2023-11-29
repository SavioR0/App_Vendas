using DevExpress.XtraGrid.Views.Grid;
using FastReport;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using vendas.Reports;
using Vendas.Communication;
using Vendas.DTO;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;

namespace vendas.MenuForms
{
    public partial class FormOrderSale : Form
    {
        private readonly FormHomePage _formHomePage;
        private readonly Dictionary<string, Action> FilterSelected;
        public FormOrderSale(FormHomePage formHomePage)
        {
            _formHomePage = formHomePage;
            InitializeComponent();

            LoadGridSale((TypeUser)Global.Instance.User.TypeUser);

			FilterSelected = new Dictionary<string, Action> {
				{ "Id", FilterById},
				{ "Cliente", FilterByClient},
                { "Data", FilterByDate},
                { "Valor", FilterByValue},
            };
		}

		private void FilterByClient()
        {
            var sales = bindingSourceSales.DataSource as List<SaleDTO>;
            if (sales == null)
                return;
            List<SaleDTO> teste = sales.FindAll(c => c.NameClient.IndexOf(textEditSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            bindingSourceSales.DataSource = teste;
        }
        private void FilterById()
        {
            if (!int.TryParse(textEditSearch.Text, out int id)) throw new ApplicationException("Coloque um Id válido!");
            var allSales = gridSale.DataSource as List<SaleDTO>;
            List<SaleDTO> sale = allSales.FindAll(c => c.Id == id);
            bindingSourceSales.DataSource = sale;
        }
        private void FilterByDate()
        {
            if (!DateTime.TryParse(textEditSearch.Text, out DateTime date)) throw new ApplicationException("Coloque uma data válida!");
			List<SaleDTO> allSales = bindingSourceSales.DataSource as List<SaleDTO>;
            if (allSales == null)
                return;
            List<SaleDTO> sales = allSales.FindAll(c => c.DateSale.Date == date.Date);
            bindingSourceSales.DataSource = sales;
        }
        private void FilterByValue()
        {
            if (!double.TryParse(textEditSearch.Text, out double id)) throw new ApplicationException("Coloque um valor válido!");
            var allSales = gridSale.DataSource as List<SaleDTO>;
            List<SaleDTO> sale = allSales.FindAll(c => c.Id == id);
            bindingSourceSales.DataSource = sale;
        }

        private void LoadNumLabel()
        {
            LabelNumOrder.Text = ((List<SaleDTO>)bindingSourceSales.DataSource).Count.ToString();
        }

        private void LoadGridSale(TypeUser typeUser)
        {
            if (GetTypeUserFunctions<SaleDTO>.typeUserFunctions.TryGetValue((typeUser, typeof(SaleDTO)), out Func<List<SaleDTO>> loadSales)) 
            {
                var sales = loadSales().ToList();

                bindingSourceSales.DataSource = sales;
                LoadNumLabel();
            }
        }
        private void BtnExclude_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover o pedido do sistema?",
                "Remover pedido!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    
                    GridView gridView = gridSale.FocusedView as GridView;
                    var sale = (gridView.GetRow(gridView.FocusedRowHandle) as SaleDTO);
                    if (sale == null) throw new Exception("Selecione uma pedido para que seja excluído.");

                    var message = Service.SaleController.Exclude(sale.Id);
                    if (message != "") throw new Exception(message);
                    LoadGridSale((TypeUser)Global.Instance.User.TypeUser);
                    LoadGrid();
                    MessageBox.Show("Pedido Excluído com sucesso!", "Exclusão do pedido.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao excluir pedido. ", "Exclusão de pedido inválido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnSearchProd_Click(object sender, EventArgs e)
        {
            try
            {
                LoadGridSale((TypeUser)Global.Instance.User.TypeUser);
                if (string.IsNullOrWhiteSpace(textEditSearch.Text)) return;

                if (FilterSelected.TryGetValue(comboBoxFilterSale.Text, out Action LoadFilter))
                {
                    LoadFilter();
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Erro ao filtrar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            textEditSearch.Text = "";
        }

        private void ComboBoxFilterSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterSale.Text != "") textEditSearch.Enabled = true;
            else textEditSearch.Enabled = false;
        }

        private void Register_Click_1(object sender, EventArgs e)
        {
            _formHomePage.BtnRegisterPurchases_Click();
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            GridView gridView = gridSale.FocusedView as GridView;
            var saleList = new List<SaleDTO>();
            for (int i = 0; i < gridView.RowCount; i++)
            {
                if (gridView.GetRow(i) is SaleDTO sale)
                {
                    saleList.Add(sale);
                }
            }
            //var fReport = new Report();
            //fReport.Load(@"../../Reports/OrderReports.frx");

            //fReport.Dictionary.RegisterBusinessObject(saleList, "orderList", 10, true);
            //fReport.Report.Save(@"../../Reports/OrderReports.frx");

            var fReport = GetReportTypes<SaleDTO>.GeneratePDF(TypeReport.Order, saleList);
            (new FormPreviewPDFReport(fReport)).ShowDialog();
        }

        private void UpdateGridButton_Click(object sender, EventArgs e)
        {
            LoadGridSale((TypeUser)Global.Instance.User.TypeUser);
        }


        private void GridViewSales_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            orderDTOBindingSource.Clear();
            LoadGrid();
        }

        private void LoadGrid()
        {

            GridView gridView = gridSale.FocusedView as GridView;
            var sale = (gridView.GetRow(gridView.FocusedRowHandle) as SaleDTO);
            if (sale == null) return;


            var orders = Service.OrderController.FilterDTO(c=> c.SaleId == sale.Id).ToList();
            //sales = sales.FindAll(c => c.NameClient == user.Name);

            orderDTOBindingSource.DataSource = orders;
            LabelNumOrder.Text = orders.Count.ToString();

        }

	}
}
