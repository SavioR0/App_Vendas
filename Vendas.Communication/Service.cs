using Vendas.Library;
using Vendas.Service.Controllers;
using Vendas.Service.Controllers.Interfaces;
using Vendas.Service.Interfaces;

namespace Vendas.Communication
{
    public static class Service
    {
        public static IUserController UserController
        {
            get {
                if (Global.Instance.Distribuida)
                    return null;
                else
                    return new UserController();
            }
        }

        public static IProductController ProductController
        {
            get
            {
                if (Global.Instance.Distribuida)
                    return null;
                else
                    return new ProductController();
            }
        }
    }
}
