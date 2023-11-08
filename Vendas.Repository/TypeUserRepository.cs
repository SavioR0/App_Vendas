using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vendas.Entity.Entities;
using Vendas.Infrastructure;
using Vendas.Repository.Intefaces;
using Vendas.Repository.Interfaces;

namespace Vendas.Repository
{
    public class TypeUserRepository : IDefaultRepository<TypeUsers>
    {
        private readonly IRepository<TypeUsers> _repository;

        public TypeUserRepository(SalesContext context = null)
        {
            _repository = new Repository<TypeUsers>(context ?? new SalesContext());
        }
        public string Add(TypeUsers entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TypeUsers> Filter(Expression<Func<TypeUsers, bool>> condition)
        {
            return _repository.Filter(condition);
        }

        public IQueryable<TypeUsers> GetAll()
        {
            return _repository.GetAll();
        }

        public TypeUsers GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string Remove(TypeUsers entity)
        {
            throw new NotImplementedException();
        }

        public string Update(TypeUsers entity)
        {
            throw new NotImplementedException();
        }
    }
}
