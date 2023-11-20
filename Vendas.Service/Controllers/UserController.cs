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
            SalesContext context = new SalesContext();
            using (DbContextTransaction transaction = SalesTransaction.CreateDbContextTransaction(context)) {
                if (entity.Flag == "U") _message = new UserRepository(context).Update(entity);
                else if (entity.Flag == "I")
                {
                    _message = new UserRepository().Add(entity);
                    SendEmail.SendEmailClient(
                        entity.Email,
                        "compras_vendass@outlook.com",
                        entity.UserName,
                        entity.Cpf,
                        "Login sistema de Compra e Venda"
                    );
                }
                if (_message == "")
                    transaction.Commit();
                else
                    transaction.Rollback();
                return _message;
            }
                
        }

        [HttpPost]
        [Route("excluir")]
        public string Exclude(User entity)
        {
            SalesContext context = new SalesContext();
            using (DbContextTransaction transaction = SalesTransaction.CreateDbContextTransaction(context))
            {
                _message = new UserRepository().Remove(entity);
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
                _message = new UserRepository().Remove(id);
                if (_message == "")
                    transaction.Commit();
                else
                    transaction.Rollback();
                return _message;
            }
        }

        [HttpPost]
        [Route("filtrar")]
        public IQueryable<User> Filter(Expression<Func<User, bool>> condition)
        {
            return new UserRepository().Filter(condition);
        }

        [HttpPost]
        [Route("filtrarTodos")]
        public IQueryable<User> GetAll()
        {
            return new UserRepository().GetAll();
        }

        [HttpPost]
        [Route("login")]
        public bool Login(string userName, string senha)
        {
            var password = Security.Decrypt("TEXTO", senha);
            User user = new UserRepository().Filter((User c) => c.UserName == userName.Trim() &&  c.Password == password).FirstOrDefault();
            if (user == null) return false;
            user.TypeUsers = new TypeUserRepository().Filter((TypeUsers c) => c.Id == user.TypeUser).FirstOrDefault();

            Global.Instance.User = user;
            return true;
        }

        [HttpGet]
        [Route("selecionartodosdto")]
        public List<UserDTO> SelectAllDTO(TypeUser typeUser)
        {
            return new UserRepository().SelectAllDTO(typeUser).ToList();
        }

    }
}
