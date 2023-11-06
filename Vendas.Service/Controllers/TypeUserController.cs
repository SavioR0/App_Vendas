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
    public class TypeUserController : ApiController, ITypeUsersController
    {
        [HttpPost]
        [Route("filtrar")]
        public List<TypeUsers> Filter(Expression<Func<TypeUsers, bool>> condition)
        {
            return new TypeUserRepository().Filter(condition);
        }

        [HttpPost]
        [Route("filtrarTodos")]

        List<TypeUsers> ITypeUsersController.GetAll()
        {
            return new TypeUserRepository().GetAll();
        }
    }
}