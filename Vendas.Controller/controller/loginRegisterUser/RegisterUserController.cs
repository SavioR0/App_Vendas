using Vendas.Entity;
using Vendas.Entity.Entities;
using Vendas.Repository;
using Vendas.Repository.Interfaces;
using Vendas.View;

namespace Vendas.Controller.controller.loginRegisterUser
{
    public class RegisterUserController : Controller<User>
    {
        private IView _view;
        public UserRepository _userModel;

        public override IView View => throw new System.NotImplementedException();

        public RegisterUserController() { }
        public RegisterUserController(UserRepository model)
        {
            _userModel = model;
        }
        //public override IView View
        //{
        //    get
        //    {
        //        return _view ?? new FormRegisterUser(this);
        //    }
        //}

        public override bool Loadable()
        {
            return true;
        }

        public void RegisterUser(User user) {
            //if (_userModel == null) _userModel = this.Model;
            _userModel.Add(user);
        }


    }
}
