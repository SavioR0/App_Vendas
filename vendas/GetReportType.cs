using FastReport;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            fReport.SetParameterValue("GlobalType", StringUser.returnUserString[Global.Instance.User.TypeUser]);
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
        private static void ConfigureProductReport( Report fReport, List<T> _productList)
        {
            var pathReport = @"../../Reports/ProductReport.frx";
            fReport.Load(pathReport);
            LoadStaticUserData(fReport);

            fReport.Dictionary.RegisterBusinessObject(_productList, "productList", 10, true);
            fReport.Report.Save(pathReport);
            //var pathReport = "../../Reports/ProductReport.frx";
            //fReport.Load(pathReport);
            ////fReport.RegisterData(_productList, "productOrder");
            //fReport.Dictionary.RegisterBusinessObject(_productList, "productList", 10, true);

            

            //fReport.Report.Save(pathReport);
        }
        private static void ConfigureOrderReport( Report fReport, List<T> orderList)
        {
            var pathReport = @"../../Reports/OrderReport.frx";
            fReport.Load(pathReport);
            //fReport.RegisterData(orderList, "listOrder");
            fReport.Dictionary.RegisterBusinessObject(orderList, "orderList", 10, true);
            fReport.Report.Save(pathReport);

            //LoadStaticUserData(fReport);

            fReport.Report.Save(pathReport);
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
