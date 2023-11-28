using FastReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vendas.Communication;
using Vendas.DTO;
using Vendas.Entity.Enums;
using Vendas.Library;

namespace vendas
{
    public static class GetReportTypes<T> where T : class
    {
        public static Dictionary<TypeReport, Action< Report, List<T>>> ConfigureReport = new Dictionary<TypeReport, Action<Report, List<T>>>()
        {
            { TypeReport.User, ( fReport, _itemsList) => ConfigureUserReport(fReport, _itemsList)},
            { TypeReport.Product, ( fReport, _itemsList) => ConfigureProductReport(fReport, _itemsList)},
            { TypeReport.Order, ( fReport, _itemsList) => ConfigureOrderReport(fReport, _itemsList)}
        };

        private static void LoadStaticUserData(Report fReport)
        {
            fReport.SetParameterValue("GlobalName", Global.Instance.User.Name);
            fReport.SetParameterValue("GlobalType", Global.Instance.User.TypeUsers.Name);
            fReport.SetParameterValue("GlobalEmail", Global.Instance.User.Email);
            fReport.SetParameterValue("GlobalCPF", Global.Instance.User.Cpf);
            fReport.SetParameterValue("GlobalUserName", Global.Instance.User.UserName);
            fReport.SetParameterValue("GlobalTel", Global.Instance.User.Tel);
        }
        private static void ConfigureUserReport(Report fReport, List<T> _userList)
        {
            var pathReport = @"../../Reports/UserReport.frx";

            fReport.Load(pathReport);
            fReport.Dictionary.RegisterBusinessObject(_userList, "userList", 10, true);

            LoadStaticUserData(fReport);


            if (fReport.FindObject("Text12") is TextObject txtObject)
            {
                txtObject.AfterData += (sendere, ex) =>
                {
                    if (txtObject.Text != null && int.TryParse(txtObject.Text, out int userType))
                    {

                        txtObject.Text = Service.TypeUserController.Filter(c => c.Id == userType).FirstOrDefault().Name;
                    }
                };
            }
            fReport.Report.Save(pathReport);
            //ExportPDF(fReport, pathReport, outputPath);
        }
        private static void ConfigureProductReport( Report fReport, List<T> productList)
        {
                var pathReport = @"../../Reports/ProductReports.frx";
                
                fReport.Load(pathReport);
                fReport.Dictionary.RegisterBusinessObject(productList, "productList", 10, true);
                LoadStaticUserData(fReport);

            if (fReport.FindObject("Text12") is TextObject txtObject)
            {
                txtObject.AfterData += (sendere, ex) =>
                {
                    var list = productList as List<ProductDTO>;
                    if (fReport.FindObject("Text1") is TextObject txtObject2)
                        txtObject.Text = list.Find( c => c.Id == int.Parse(txtObject2.Text)).SellerName;
                };
            }
            fReport.Report.Save(pathReport);
        }
        private static void ConfigureOrderReport( Report fReport, List<T> orderList)
        {
            var pathReport = @"../../Reports/OrderReports.frx";

            fReport.Load(pathReport);
            fReport.Dictionary.RegisterBusinessObject(orderList as List<SaleDTO>, "orderList", 10, true);
            LoadStaticUserData(fReport);

            var list = orderList as List<SaleDTO>;
            SaleDTO order;
            if (fReport.FindObject("Text4") is TextObject txtObject)
            {
                txtObject.AfterData += (send, e) =>
                {
                    if (!int.TryParse(txtObject.Text, out int idSale)) throw new Exception("Id de pedidos Inválido para a geração do relatório.");
                    order = list.Find(c => c.Id == idSale);

                    //if (fReport.FindObject("Text1") is TextObject txtObject1)
                    //{
                    //    txtObject1.AfterData += (sendere, ex) =>
                    //    {
                    //        txtObject1.Text = order.NameProduct;
                    //    };
                    //}
                    //if (fReport.FindObject("Text5") is TextObject txtObject2)
                    //{
                    //    txtObject2.AfterData += (sendere, ex) =>
                    //    {
                    //        txtObject2.Text = order.NameSeller;
                    //    };
                    //}

                    if (fReport.FindObject("Text8") is TextObject txtObject3)
                    {
                        txtObject3.AfterData += (sendere, ex) =>
                        {
                            txtObject3.Text = order.NameClient;
                        };
                    }

                    //if (fReport.FindObject("Text10") is TextObject textObject4)
                    //{
                    //    textObject4.AfterData += (sendere, ex) =>
                    //    {
                    //        textObject4.Text = order.ValueProduct.ToString();
                    //    };
                    //}
                };

            }

            //fReport.Dictionary.RegisterBusinessObject(orderList, "orderList", 10, true);

            //LoadStaticUserData(fReport);
        }

        public static Report GeneratePDF(TypeReport _typeReport, List<T> listItems)
        {
            try
            {
                var fReport = new Report();
                ConfigureReport[_typeReport](fReport, listItems);
                return fReport;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Gerar o relatório.  " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
