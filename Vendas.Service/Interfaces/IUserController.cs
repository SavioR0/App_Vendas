using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vendas.Entity.Entities;

namespace Vendas.Service.Interfaces
{
    public interface IUserController
    {
        string Save(User entity);
        string Exclude(User entity);
        string Exclude(int id);
        IQueryable<User> Filter(Expression<Func<User, bool>> condition);
        IQueryable<User> GetAll();

        bool Login(string userName, string password);
    }
}