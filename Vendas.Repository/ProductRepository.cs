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
        private readonly IRepository<Product> _repository;

        public ProductRepository(SalesContext context = null)
        {
            _repository = new Repository<Product>(context ?? new SalesContext());
        }
        public string Add(Product entity)
        {
            if (_repository.GetAll().Any(c => entity.Name == c.Name))
                throw new Exception("Produto já cadastrado no sistema.");
            return _repository.Insert(entity);
        }

        public IQueryable<Product> Filter(Expression<Func<Product, bool>> condition)
        {
            return _repository.Filter(condition);
        }

        public IQueryable<Product> GetAll()
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

        public string Remove(int id)
        {
            return _repository.Delete(id);
        }

        public string Update(Product entity)
        {
            if (_repository.GetAll().Any(c => entity.Name.Trim() == c.Name.Trim()))
                throw new Exception("Produto já cadastrado no sistema.");
            return _repository.Update(entity);
        }
    }
}
