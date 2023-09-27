using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Vendas.Entity.Entities;

namespace Vendas.Service.Interfaces
{
    public interface IUserController
    {
        string Save(User entity);
        string Exclude(User entity);
        List<User> Filter(Expression<Func<User, bool>> condition);
        bool Login(string userName, string password);
    }
}