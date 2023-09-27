using System.Windows.Forms;

namespace Vendas.Management
{
    public interface IView
    {
        //string Title { get; set; }
        Form Form { get; }
        void Close();
    }
}
