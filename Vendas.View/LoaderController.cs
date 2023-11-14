
using Vendas.Management;

namespace Vendas.View.Loader
{
    public class LoaderController : LoaderManagement//<User>
    {
        private IView _view;

        public LoaderController() { }
        public LoaderController(IView view)
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
