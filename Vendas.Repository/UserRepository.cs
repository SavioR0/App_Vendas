using app2.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vendas.Entity.Entities;
using Vendas.Repository.Intefaces;
using Vendas.Repository.Interfaces;

namespace Vendas.Repository
{
    public class UserRepository : IDefaultRepository<User>
    {
        private IRepository<User> _repository;


        public UserRepository(SalesContext context = null)
        {
            _repository = new Repository<User>(context ?? new SalesContext());
        }

        public string Add(User entity)
        {
            string message = ValidateData(entity);

            if (message == "")
            {
                message = _repository.Insert(entity);
            }

            return message;
        }

        public List<User> Filter(Expression<Func<User, bool>> condition)
        {
            return _repository.Filter(condition).ToList();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string Remove(User entity)
        {
            throw new NotImplementedException();
        }

        public string Update(User entity)
        {
            throw new NotImplementedException();
        }

        List<User> IDefaultRepository<User>.GetAll()
        {
            throw new NotImplementedException();
        }

        private string ValidateData(User entity)
        {
            if (string.IsNullOrEmpty(entity.Cpf))
                return "CPF Inválido!";

            return "";
        }
    }
}
