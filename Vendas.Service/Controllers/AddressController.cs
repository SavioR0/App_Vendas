using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Http;
using Vendas.Entity.Entities;
using Vendas.Repository;
using Vendas.Service.Interfaces;

namespace Vendas.Service.Controllers
{
    public class AddressController : ApiController, IAddressController
    {
        [HttpPost]
        [Route("excluir")]
        public string Exclude(Address entity)
        {
            return new AddressRepository().Remove(entity);
        }
            
        [HttpPost]
        [Route("filtrar")]
        public IQueryable<Address> Filter(Expression<Func<Address, bool>> condition)
        {
            return new AddressRepository().Filter(condition);
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
            return new AddressRepository().Add(entity);
        }
    }
}