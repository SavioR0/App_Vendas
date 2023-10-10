
using System;
using System.Collections.Generic;
using Vendas.Communication;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Library;

namespace vendas
{
    public class GetTypeUserFunctions<T> where T : class
    {
        public static Dictionary<(TypeUser, Type), Func<List<T>>> typeUserFunctions = new Dictionary<(TypeUser, Type), Func<List<T>>>()  {
                {(TypeUser.Admin , typeof(T)), () =>  LoadGridAdmin() },
                {(TypeUser.Seller, typeof(T)) , () => LoadGridSeller() },
                {(TypeUser.Client , typeof(T)), () => LoadGridClient() }
        };
        private static List<T> LoadGridAdmin()
        {
            if (typeof(T) == typeof(User))
                return Service.UserController.GetAll() as List<T>;
            if (typeof(T) == typeof(Product))
                return Service.ProductController.GetAll() as List<T>;
            if (typeof(T) == typeof(Sale))
                return Service.SaleController.GetAll() as List<T>;
            return null;
        }

        private static List<T> LoadGridSeller()
        {
            if (typeof(T) == typeof(User))
                return Service.UserController.Filter(c => (TypeUser)c.TypeUser == TypeUser.Client) as List<T>;
            if (typeof(T) == typeof(Product))
                return Service.ProductController.Filter(c => c.SellerId == Global.Instance.User.Id) as List<T>;
            if (typeof(T) == typeof(Sale))
                return Service.SaleController.Filter(c => c.SellerId == Global.Instance.User.Id) as List<T>;
            return null;
        }
        private static List<T> LoadGridClient()
        {
            if (typeof(T) == typeof(Product))
                return Service.ProductController.GetAll() as List<T>;
            if (typeof(T) == typeof(Sale))
                return Service.SaleController.Filter(c=> c.ClientId == Global.Instance.User.Id) as List<T>;
            return null;
        }
    }

}
