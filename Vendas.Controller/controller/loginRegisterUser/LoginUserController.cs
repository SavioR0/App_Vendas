using Vendas.Entity.Entities;
using Vendas.Management;
using Vendas.Repository;

namespace Vendas.Controller.controller.loginRegisterUser
{
    public class LoginUserController : LoaderManagement//<User>
    {
        private IView _view;
        //public UserRepository _userModel;

        public LoginUserController() { }
        public LoginUserController(IView view)
        {
            //_userModel = model;
            _view = view;

        }
        public override IView View
        {
            get
            {
                return _view;
            }
        }

        public override bool CloseLastView  {
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
