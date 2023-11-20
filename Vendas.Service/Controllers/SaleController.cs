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

namespace Vendas.Service.Controllers
{
    public class SaleController: ApiController, ISaleController
        {
            private string _message = "";

            [HttpPost]
            [Route("salvar")]
            public string Save(Sale entity)
            {
                SalesContext context = new SalesContext();
                using (DbContextTransaction transaction = SalesTransaction.CreateDbContextTransaction(context))
                {
                    if (entity.Flag == "U")
                        _message = new SaleRepository().Update(entity);
                    else if (entity.Flag == "I")
                        _message = new SaleRepository().Add(entity);
                    else
                        _message = "Flag necessária";

                    if (_message == "")
                        transaction.Commit();
                    else
                        transaction.Rollback();
                    return _message;
                }
            

            }

            [HttpPost]
            [Route("excluir")]
            public string Exclude(Sale entity)
            {
                SalesContext context = new SalesContext();
                using (DbContextTransaction transaction = SalesTransaction.CreateDbContextTransaction(context))
                {
                    _message = new SaleRepository().Remove(entity);
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
                    _message = new SaleRepository().Remove(id);
                    if (_message == "")
                        transaction.Commit();
                    else
                        transaction.Rollback();
                    return _message;
                }
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

            [HttpPost]
            [Route("selecionarTodosDTO")]
            public List<SaleDTO> SelectAllDTO(TypeUser typeUser) {
                    return new SaleRepository().SelectAllDTO(typeUser).ToList();
                }

        }
}