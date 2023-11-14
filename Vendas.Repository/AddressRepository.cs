using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vendas.Entity.Entities;
using Vendas.Infrastructure;
using Vendas.Repository.Intefaces;
using Vendas.Repository.Interfaces;

namespace Vendas.Repository
{
    public class AddressRepository : IDefaultRepository<Address>
    {
        private readonly IRepository<Address> _repository;

        public AddressRepository(SalesContext context = null)
        {
            _repository = new Repository<Address>(context ?? new SalesContext());
        }
        public string Add(Address entity)
        {
            if (!ValidateEntity(entity))
                return "Já cadastrado";
            return _repository.Insert(entity);
        }

        private bool ValidateEntity(Address entity)
        {
            if(_repository.GetAll().Any(c => c.Equals(entity)))
                return false;
            return true;
        }

        public IQueryable<Address> Filter(Expression<Func<Address, bool>> condition)
        {
            return _repository.Filter(condition);
        }

        public IQueryable<Address> GetAll()
        {
            return _repository.GetAll();
        }

        public Address GetById(int id)
        {
            return _repository.GetById(id);
        }

        public string Remove(Address entity)
        {
            return _repository.Delete(entity);
        }

        public string Update(Address entity)
        {
            return _repository.Update(entity);
        }
    }
}
