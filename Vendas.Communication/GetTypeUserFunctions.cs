using System;
using System.Collections.Generic;
using System.Linq;
using Vendas.Communication;
using Vendas.DTO;
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
            if (typeof(T) == typeof(UserDTO))
                return Service.UserController.SelectAllDTO(TypeUser.Admin).ToList() as List<T>;
            if (typeof(T) == typeof(ProductDTO))
                return Service.ProductController.SelectAllDTO(TypeUser.Admin).ToList() as List<T>;
            if (typeof(T) == typeof(SaleDTO))
                return Service.SaleController.SelectAllDTO(TypeUser.Admin).ToList() as List<T>;
            return null;
        }
        private static List<T> LoadGridSeller()
        {
            if (typeof(T) == typeof(UserDTO))
                return Service.UserController.SelectAllDTO(TypeUser.Seller).ToList() as List<T>;
            if (typeof(T) == typeof(ProductDTO))
                return Service.ProductController.SelectAllDTO(TypeUser.Seller).ToList() as List<T>;
            if (typeof(T) == typeof(SaleDTO))
                return Service.SaleController.SelectAllDTO(TypeUser.Seller).ToList() as List<T>;
            return null;
        }
        private static List<T> LoadGridClient()
        {
            if (typeof(T) == typeof(ProductDTO))
                return Service.ProductController.SelectAllDTO(TypeUser.Client).ToList() as List<T>;
            if (typeof(T) == typeof(SaleDTO))
                return Service.SaleController.SelectAllDTO(TypeUser.Client).ToList() as List<T>;
            return null;
        }
    }

}
