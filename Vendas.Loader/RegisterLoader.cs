using Vendas.Entity.Entities;
using Vendas.Management;
using Vendas.Repository;

namespace Vendas.Loader
{
    public class RegisterLoader : LoaderManagement//<User>
    {
        public IView _view { get; set; }
        public UserRepository _userModel;
        public RegisterLoader() { }
        public RegisterLoader(IView view)
        {
            this._view = view;
        }
        public override IView View
        {
            get
            {
                return _view;
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
