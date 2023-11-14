using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Vendas.Entity.Entities;

namespace Vendas.Service.Interfaces
{
    public interface IAddressController
    {
        string Save(Address entity);
        string Exclude(Address entity);
        IQueryable<Address> Filter(Expression<Func<Address, bool>> condition);
        IQueryable<Address> GetAll();
    }
}