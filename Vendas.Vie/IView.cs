using System.Windows.Forms;

namespace Vendas.View
{
    public interface IView
    {
        //string Title { get; set; }
        Form Form { get; }
        void Close();
    }
}
