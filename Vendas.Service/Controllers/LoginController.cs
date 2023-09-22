using app2.data;
using System.Collections.Generic;
using System.Web.Http;
using Vendas.Entity.Entities;
using Vendas.Repository;

namespace Vendas.Service.Controllers
{
    public class LoginController : ApiController
    {
        private string _message = "";

        [HttpPost]
        [Route("salvar")]
        public string Save(User entity)
        {
            var context = new SalesContext();

            _message = new UserRepository().Add(entity);

            return _message;
        }

        [Route("excluir")]
        public string Exclude(User entity)
        {
            var context = new SalesContext();

            _message = new UserRepository().Remove(entity);

            return _message;
        }

        [Route("filtrar")]
        public List<User> Filter(User entity)
        {
            return new UserRepository().Filter(c => c.Id == entity.Id);
        }
    }
}
