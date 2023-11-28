using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Http;
using Vendas.DTO;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Infrastructure;
using Vendas.Repository;
using Vendas.Service.Interfaces;

namespace Vendas.Service.Controllers.Interfaces
{
    public class ProductController : ApiController, IProductController
    {
        private string _message = "";

        [HttpPost]
        [Route("salvar")]
        public string Save(Product entity)
        {
            SalesContext context = new SalesContext();
            using (DbContextTransaction transaction = SalesTransaction.CreateDbContextTransaction(context))
            {
                if (entity.Flag == "U")
                {
                    _message = new ProductRepository().Update(entity);
                }
                else if (entity.Flag == "I")
                {
                    _message = new ProductRepository().Add(entity);
                }

                if (_message == "")
                    transaction.Commit();
                else
                    transaction.Rollback();
                return _message;
            }
        }

        [HttpPost]
        [Route("excluir")]
        public string Exclude(Product entity)
        {
            SalesContext context = new SalesContext();
            using (DbContextTransaction transaction = SalesTransaction.CreateDbContextTransaction(context))
            {
                _message = new ProductRepository().Remove(entity);
                if (_message == "")
                    transaction.Commit();
                else
                    transaction.Rollback();
                return _message;
            }
        }

        public string Exclude(int id)
        {
            SalesContext context = new SalesContext();
            using (DbContextTransaction transaction = SalesTransaction.CreateDbContextTransaction(context))
            {
                _message = new ProductRepository().Remove(id);
                if (_message == "")
                    transaction.Commit();
                else
                    transaction.Rollback();
                return _message;
            }
        }

        [HttpPost]
        [Route("filtrar")]
        public IQueryable<Product> Filter(Expression<Func<Product, bool>> condition)
        {
            return new ProductRepository().Filter(condition);
        }

        [HttpPost]
        [Route("filtrarTodos")]
        public IQueryable<Product> GetAll()
        {
            return new ProductRepository().GetAll();
        }

        [HttpPost]
        [Route("selecionartodosDTO")]
        public List<ProductDTO> SelectAllDTO(TypeUser typeUser) {
            return new ProductRepository().SelectAllDTO(typeUser).ToList();
        }

        [HttpPost]
        [Route("filtrarDTO")]
        public IQueryable<ProductDTO> FilterDTO(TypeUser typeUser, Expression<Func<ProductDTO, bool>> condition)
        {
            return new ProductRepository().SelectAllDTO(typeUser).Where(condition);
        }

	}
}