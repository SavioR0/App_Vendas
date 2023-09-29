using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Http;
using Vendas.Entity.Entities;
using Vendas.Library;
using Vendas.Repository;
using Vendas.Service.Interfaces;

namespace Vendas.Service.Controllers
{
    public class UserController : ApiController, IUserController
    {
        private string _message = "";

        [HttpPost]
        [Route("salvar")]
        public string Save(User entity)
        {
            if (entity.Flag == 'U') _message = new UserRepository().Update(entity);
            else if (entity.Flag == 'I')
            {
                _message = new UserRepository().Add(entity);
                //SendEmail.SendEmailClient(
                //    entity.Email,
                //    "compras_vendass@outlook.com",
                //    entity.UserName,
                //    entity.Cpf,
                //    "Login sistema de Compra e Venda"
                 //);
            }
            return _message;
        }

        [HttpPost]
        [Route("excluir")]
        public string Exclude(User entity)
        {

            _message = new UserRepository().Remove(entity);

            return _message;
        }

        [HttpPost]
        [Route("filtrar")]
        public List<User> Filter(Expression<Func<User, bool>> condition)
        {
            return new UserRepository().Filter(condition);
        }

        [HttpPost]
        [Route("filtrarTodos")]
        public List<User> GetAll()
        {
            return new UserRepository().GetAll();
        }

        [HttpPost]
        [Route("login")]
        public bool Login(string userName, string senha)
        {
            var password = Security.Decrypt("TEXTO", senha);
            var users = new UserRepository().Filter((User c) => c.UserName == userName.Trim() &&  c.Password == password);
            if (users.Count == 0) return false;

            Global.Instance.User = users[0];
            return true;
        }
    }
}
