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
            public string Save(SaleOrderCompleteDTO entity)
            {

                if (entity.Sale.Id != 0)
                {
                    _message = new SaleRepository().Update(entity.Sale);
                }
                else
                {
                    _message = new SaleRepository().Add(entity.Sale);
                    var dateSale = entity.Sale.DateSale.Date;
                    Sale saleId = new SaleRepository().GetAll().OrderByDescending(d => d.DateSale).FirstOrDefault();

                    foreach (Order order in entity.Orders)
                    {
                        order.SaleId = saleId.Id;
                        _message = new OrderRepository().Add(order);
                    }
                }

                return _message;
            }

            [HttpPost]
            [Route("excluir")]
            public string Exclude(Sale entity)
            {
                SalesContext context = new SalesContext();
                using (DbContextTransaction transaction = SalesTransaction.CreateDbContextTransaction(context))
                {
                    var orders = new OrderRepository().Filter(c => c.SaleId == entity.Id);
                    foreach (var order in orders)
                        _message = new OrderRepository().Remove(order);

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
                    var orders = new OrderRepository().Filter(c => c.SaleId == id);
                    foreach (var order in orders)
                        _message = new OrderRepository().Remove(order);

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

            public IQueryable<SaleDTO> FilterDTO(Expression<Func<SaleDTO, bool>> condition, TypeUser typeUser)
            {
                return new SaleRepository().FilterDTO(condition, typeUser);
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