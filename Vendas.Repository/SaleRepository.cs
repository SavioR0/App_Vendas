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
    public class SaleRepository : IDefaultRepository<Sale>
    {
        private readonly IRepository<Sale> _repository;

        public SaleRepository(SalesContext context = null)
        {
            _repository = new Repository<Sale>(context ?? new SalesContext());
        }
        public string Add(Sale entity)
        {
            string message = _repository.Insert(entity);
            return message;
        }

        public List<Sale> Filter(Expression<Func<Sale, bool>> condition)
        {
            return _repository.Filter(condition).ToList();
        }

        public List<Sale> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public Sale GetById(int id)
        {
            return _repository.Filter(c => c.Id == id).FirstOrDefault();
        }

        public string Remove(Sale entity)
        {
            return _repository.Delete(entity);
        }

        public string Remove(int id)
        {
            return _repository.Delete(id);
        }

        public string Update(Sale entity)
        {
            string message = _repository.Update(entity);
            return message;
        }
    }
}
