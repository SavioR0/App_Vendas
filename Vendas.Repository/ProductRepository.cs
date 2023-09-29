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
    public class ProductRepository : IDefaultRepository<Product>
    {
        private IRepository<Product> _repository;

        public ProductRepository(SalesContext context = null)
        {
            _repository = new Repository<Product>(context ?? new SalesContext());
        }
        public string Add(Product entity)
        {
            return _repository.Insert(entity);
        }

        public List<Product> Filter(Expression<Func<Product, bool>> condition)
        {
            return _repository.Filter(condition).ToList();
        }

        public List<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public Product GetById(int id)
        {
            return _repository.GetById(id);
        }

        public string Remove(Product entity)
        {
            return _repository.Delete(entity);
        }

        public string Update(Product entity)
        {
            return _repository.Update(entity);
        }
    }
}
