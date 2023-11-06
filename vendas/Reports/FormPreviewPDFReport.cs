using FastReport;
using System.IO;
using System.Windows.Forms;

namespace vendas.Reports
{
    public partial class FormPreviewPDFReport : Form
    {
        private readonly Report _fReport;
        public FormPreviewPDFReport(Report fReport)
        {
            InitializeComponent();
            _fReport = fReport;
            ExportPDF();
        }

        private void ExportPDF()
        {
            // Exportar o relatório para PDF
            _fReport.Prepare();

            FastReport.Export.PdfSimple.PDFSimpleExport export = new FastReport.Export.PdfSimple.PDFSimpleExport();
            var tempPath = Path.GetTempFileName();
            export.Export(_fReport, tempPath);

            pdfViewer1.LoadFromFile(tempPath);

            //export.Export(fReport, outputPath);
            //fReport.Export();

            // Libere os recursos do relatório
            _fReport.Dispose();

            // Abrir o PDF com o aplicativo padrão
            //System.Diagnostics.Process.Start(outputPath);
        }
    }
}
