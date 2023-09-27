
using Vendas.Management;

namespace Vendas.Loader.controller.loginRegisterUser
{
    public class LoginUserLoader : LoaderManagement//<User>
    {
        private IView _view;

        public LoginUserLoader() { }
        public LoginUserLoader(IView view)
        {
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
