using System.Windows.Forms;
using Vendas.Entity.Enums;

namespace Vendas.Management
{
    public interface IView
    {
        //string Title { get; set; }
        Form Form { get; } 
        void Close();
    }
}
