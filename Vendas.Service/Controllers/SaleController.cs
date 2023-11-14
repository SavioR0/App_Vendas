using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Http;
using Vendas.Entity.Entities;
using Vendas.Repository;
using Vendas.Service.Interfaces;

namespace Vendas.Service.Controllers
{
    public class SaleController: ApiController, ISaleController
        {
            private string _message = "";

            [HttpPost]
            [Route("salvar")]
            public string Save(Sale entity)
            {
                if (entity.Flag == "U") 
                    _message = new SaleRepository().Update(entity);
                else if (entity.Flag == "I")
                    _message = new SaleRepository().Add(entity);
                else
                    _message = "Flag necessária";
                return _message;
            }

            [HttpPost]
            [Route("excluir")]
            public string Exclude(Sale entity)
            {
                _message = new SaleRepository().Remove(entity);
                return _message;
            }
            public string Exclude(int id)
            {
                _message = new SaleRepository().Remove(id);
                return _message;
            }

            [HttpPost]
            [Route("filtrar")]
            public IQueryable<Sale> Filter(Expression<Func<Sale, bool>> condition)
            {
                return new SaleRepository().Filter(condition);
            }

            [HttpPost]
            [Route("filtrarTodos")]
            public IQueryable<Sale> GetAll()
            {
                return new SaleRepository().GetAll();
        }

        }
}