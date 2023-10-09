using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Http;
using Vendas.Entity.Entities;
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
            if (entity.Flag == 'U')
            {
                _message = new ProductRepository().Update(entity);
            }
            else if (entity.Flag == 'I')
            {
                _message = new ProductRepository().Add(entity);
            }
            return _message;
        }

        [HttpPost]
        [Route("excluir")]
        public string Exclude(Product entity)
        {
            _message = new ProductRepository().Remove(entity);
            return _message;
        }

        public string Exclude(int id)
        {
            _message = new ProductRepository().Remove(id);
            return _message;
        }

        [HttpPost]
        [Route("filtrar")]
        public List<Product> Filter(Expression<Func<Product, bool>> condition)
        {
            return new ProductRepository().Filter(condition) as List<Product>;
        }

        [HttpPost]
        [Route("filtrarTodos")]
        public List<Product> GetAll()
        {
            return new ProductRepository().GetAll() as List<Product>;
        }
    }
}