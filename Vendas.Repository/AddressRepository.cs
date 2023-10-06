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
        private IRepository<Address> _repository;

        public AddressRepository(SalesContext context = null)
        {
            _repository = new Repository<Address>(context ?? new SalesContext());
        }
        public string Add(Address entity)
        {
            return _repository.Insert(entity);
        }

        public List<Address> Filter(Expression<Func<Address, bool>> condition)
        {
            return _repository.Filter(condition).ToList();
        }

        public List<Address> GetAll()
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
