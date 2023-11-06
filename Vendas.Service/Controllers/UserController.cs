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
            if (entity.Flag == "U") _message = new UserRepository().Update(entity);
            else if (entity.Flag == "I")
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
        public string Exclude(int id)
        {
            _message = new UserRepository().Remove(id);
            return _message;
        }

        [HttpPost]
        [Route("filtrar")]
        public List<User> Filter(Expression<Func<User, bool>> condition)
        {
            return new UserRepository().Filter(condition) as List<User>;
        }

        [HttpPost]
        [Route("filtrarTodos")]
        public List<User> GetAll()
        {
            return new UserRepository().GetAll() as List<User>;
        }

        [HttpPost]
        [Route("login")]
        public bool Login(string userName, string senha)
        {
            var password = Security.Decrypt("TEXTO", senha);
            var user = new UserRepository().Filter((User c) => c.UserName == userName.Trim() &&  c.Password == password)[0];
            if (user == null) return false;
            user.TypeUsers = new TypeUserRepository().Filter((TypeUsers c) => c.Id == user.TypeUser)[0];

            Global.Instance.User = user;
            return true;
        }
    }
}
