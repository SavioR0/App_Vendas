using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vendas.DTO;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;

namespace Vendas.Service.Interfaces
{
    public interface IProductController
    {
        string Save(Product entity);
        string Exclude(Product entity);
        string Exclude(int id);
        IQueryable<Product> Filter(Expression<Func<Product, bool>> condition);
        List<ProductDTO> SelectAllDTO(TypeUser typeUSer);
        IQueryable<Product> GetAll();

    }
}