using System;
using System.Collections.Generic;
using System.Linq;
using Vendas.Communication;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;

namespace vendas
{

    public class GetTypeUserFunctions<T> where T : class
    {

        public static Dictionary<(TypeUser, Type), Func<IQueryable<T>>> typeUserFunctions = new Dictionary<(TypeUser, Type), Func<IQueryable<T>>>()  {
                {(TypeUser.Admin , typeof(T)), () =>  LoadGridAdmin() },
                {(TypeUser.Seller, typeof(T)) , () => LoadGridSeller() },
                {(TypeUser.Client , typeof(T)), () => LoadGridClient() }
        };
        private static IQueryable<T> LoadGridAdmin()
        {
            if (typeof(T) == typeof(User))
                return Service.UserController.GetAll() as IQueryable<T>;
            if (typeof(T) == typeof(Product))
                return Service.ProductController.GetAll() as IQueryable<T>;
            if (typeof(T) == typeof(Sale))
                return Service.SaleController.GetAll() as IQueryable<T>;
            return null;
        }

        private static IQueryable<T> LoadGridSeller()
        {
            if (typeof(T) == typeof(User))
                return Service.UserController.Filter(c => (TypeUser)c.TypeUser == TypeUser.Client) as IQueryable<T>;
            if (typeof(T) == typeof(Product))
                return Service.ProductController.Filter(c => c.SellerId == Global.Instance.User.Id) as IQueryable<T>;
            if (typeof(T) == typeof(Sale))
                return Service.SaleController.Filter(c => c.SellerId == Global.Instance.User.Id) as IQueryable<T>;
            return null;
        }
        private static IQueryable<T> LoadGridClient()
        {
            if (typeof(T) == typeof(Product))
                return Service.ProductController.GetAll() as IQueryable<T>;
            if (typeof(T) == typeof(Sale))
                return Service.SaleController.Filter(c => c.ClientId == Global.Instance.User.Id) as IQueryable<T>;
            return null;
        }
    }

}
