using System.Windows.Forms;
using Vendas.Entity.Entities;
using Vendas.Management;
using Vendas.Repository;
using Vendas.Service.Controllers;

namespace Vendas.Controller.controller.loginRegisterUser
{
    public class RegisterController : LoaderManagement//<User>
    {
        public IView view { get; set; }
        public UserRepository _userModel;

        public override IView View
        {
            get
            {
                return view;
            }
        }

        public override bool CloseLastView
        {
            get
            {
                return false;
            }
        }

        public override bool Loadable()
        {
            return true;
        }


    }
}
