using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Http;
using Vendas.Entity.Entities;
using Vendas.Infrastructure;
using Vendas.Repository;
using Vendas.Service.Interfaces;

namespace Vendas.Service.Controllers
{
    public class AddressController : ApiController, IAddressController
    {
        private string _message = "";
        [HttpPost]
        [Route("excluir")]
        public string Exclude(Address entity)
        {
            SalesContext context = new SalesContext();
            using (DbContextTransaction transaction = SalesTransaction.CreateDbContextTransaction(context))
            {
                _message =  new AddressRepository().Remove(entity);
                if (_message == "")
                    transaction.Commit();
                else
                    transaction.Rollback();
                return _message;
            }
        }
            
        [HttpPost]
        [Route("filtrar")]
        public IQueryable<Address> Filter(Expression<Func<Address, bool>> condition)
        {
            return new AddressRepository().Filter(condition);
        }

        [HttpPost]
        [Route("PegarPorId")]
        public Address GetById(int id)
        {
            return new AddressRepository().GetById(id);
        }

        [HttpPost]
        [Route("PegarPorProps")]
        public Address GetByProps(Address address)
        {
            return new AddressRepository().GetByProps(address);
        }

        [HttpPost]
        [Route("filtrarTodos")]
        public IQueryable<Address> GetAll()
        {
            return new AddressRepository().GetAll() ;
        }
        [HttpPost]
        [Route("salvar")]
        public string Save(Address entity)
        {
            SalesContext context = new SalesContext();
            using (DbContextTransaction transaction = SalesTransaction.CreateDbContextTransaction(context))
            {
                _message = new AddressRepository().Add(entity);

                if (_message == "")
                    transaction.Commit();
                else
                    transaction.Rollback();
                return _message;
            }
        }
    }
}