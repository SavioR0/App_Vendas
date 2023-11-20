using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vendas.DTO;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;

namespace Vendas.Service.Interfaces
{
    public interface IUserController
    {
        string Save(User entity);
        string Exclude(User entity);
        string Exclude(int id);
        IQueryable<User> Filter(Expression<Func<User, bool>> condition);
        IQueryable<User> GetAll();
        List<UserDTO> SelectAllDTO(TypeUser typeUser);

        bool Login(string userName, string password);
    }
}