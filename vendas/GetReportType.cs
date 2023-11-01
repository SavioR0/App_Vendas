using FastReport;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vendas.Communication;
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
            fReport.SetParameterValue("GlobalType", StringUser.returnUserString[(int)Global.Instance.User.TypeUser]);
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

            TextObject txtObject = fReport.FindObject("Text12") as TextObject;

            if (txtObject != null)
            {
                txtObject.AfterData += (sendere, ex) =>
                {
                    if (txtObject.Text != null && int.TryParse(txtObject.Text, out  int userType))
                    {
                        if (StringUser.returnUserString.TryGetValue(userType, out string userTypeText))
                        {
                            txtObject.Text = userTypeText;
                        }
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
            TextObject txtObject = fReport.FindObject("Text12") as TextObject;

            if (txtObject != null)
            {
                txtObject.AfterData += (sendere, ex) =>
                {
                    if (txtObject.Text != null && int.TryParse(txtObject.Text, out int userID))
                    {
                        txtObject.Text = Service.UserController.Filter(c => c.Id == userID)[0].Name;
                    }
                };
            }
            //fReport.Report.Save(pathReport);
        }
        private static void ConfigureOrderReport( Report fReport, List<T> orderList)
        {
            var pathReport = @"../../Reports/OrderReports.frx";

            fReport.Load(pathReport);
            fReport.Dictionary.RegisterBusinessObject(orderList, "orderList", 10, true);
            LoadStaticUserData(fReport);

            TextObject txtObject1 = fReport.FindObject("Text1") as TextObject;

            if (txtObject1 != null)
            {
                txtObject1.AfterData += (sendere, ex) =>
                {
                    if (txtObject1.Text != null && int.TryParse(txtObject1.Text, out int productID))
                    {
                        txtObject1.Text = Service.ProductController.Filter(c => c.Id == productID)[0].Name;
                    }
                };
            }
            TextObject txtObject2 = fReport.FindObject("Text5") as TextObject;

            if (txtObject2 != null)
            {
                txtObject2.AfterData += (sendere, ex) =>
                {
                    if (txtObject2.Text != null && int.TryParse(txtObject2.Text, out int sellerID))
                    {
                        txtObject2.Text = Service.UserController.Filter(c => c.Id == sellerID)[0].Name;
                    }
                };
            }
            TextObject txtObject3 = fReport.FindObject("Text8") as TextObject;

            if (txtObject3 != null)
            {
                txtObject3.AfterData += (sendere, ex) =>
                {
                    if (txtObject3.Text != null && int.TryParse(txtObject3.Text, out int clientID))
                    {
                        txtObject3.Text = Service.UserController.Filter(c => c.Id == clientID)[0].Name;
                    }
                };
            }
            TextObject txtObject4 = fReport.FindObject("Text10") as TextObject;

            if (txtObject4 != null)
            {
                txtObject4.AfterData += (sendere, ex) =>
                {
                    if (txtObject4.Text != null && int.TryParse(txtObject4.Text, out int productID))
                    {
                        txtObject4.Text = Service.ProductController.Filter(c => c.Id == productID)[0].Value.ToString();
                    }
                };
            }

            fReport.Dictionary.RegisterBusinessObject(orderList, "orderList", 10, true);

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
