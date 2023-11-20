using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vendas.DTO;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Infrastructure;
using Vendas.Repository.Intefaces;
using Vendas.Repository.Interfaces;

namespace Vendas.Repository
{
    public class UserRepository : IDefaultRepository<User>
    {
        private readonly IRepository<User> _repository;
        private SalesContext _db = new SalesContext();


        public UserRepository(SalesContext context = null)
        {
            _repository = new Repository<User>(context ?? new SalesContext());
        }

        public string Add(User entity)
        {
            if (_repository.GetAll().Any((User c) => c.Email == entity.Email.Trim() || c.Cpf == entity.Cpf))
                throw new Exception("Usuário já cadastrado no sistema. Certifique-se que seus dados estão certos e tente novamente.");
            Validate(entity);
            return _repository.Insert(entity);
        }

        public IQueryable<User> Filter(Expression<Func<User, bool>> condition)
        {
            return _repository.Filter(condition);
        }

        public User GetById(int id)
        {
            return _repository.Filter(c=> c.Id == id).FirstOrDefault();
        }

        public string Remove(User entity)
        {
            return _repository.Delete(entity);
        }

        public string Remove(int id)
        {
            return _repository.Delete(id);
        }

        public string Update(User entity)
        {
            Validate(entity);
            string message = _repository.Update(entity);
            return message;
        }

        public IQueryable<User> GetAll()
        {
            return _repository.GetAll();
        }

        private void Validate(User entity) 
        {
            if(string.IsNullOrEmpty( entity.Name))
                throw new Exception("Nome não preenchido. ");

            if (string.IsNullOrEmpty(entity.LastName))
                throw new Exception("Sobrenome não preenchido. ");

            if (string.IsNullOrEmpty(entity.Password))
                throw new Exception("Senha não preenchida. ");

            if (string.IsNullOrEmpty(entity.Cpf))
                throw new Exception("CPF não preenchido. ");
        }

        private IQueryable<UserDTO> LoadAdminGrid() {
            return (from u in _db.Users
                    join t in _db.TypeUsers on u.TypeUser equals t.Id
                    join a in _db.Addresses on u.AddressId equals a.Id
                    select new UserDTO
                    {
                        Id = u.Id,
                        Name = u.Name,
                        LastName = u.LastName,
                        Cpf = u.Cpf,
                        DateOfBirth = u.DateOfBirth,
                        TypeUserName = t.Name,
                        Email = u.Email,
                        TypeUser = u.TypeUser,
                        AddressId = u.AddressId,
                        Address = a,
                        Tel = u.Tel,
                    }
             );
        }
        private IQueryable<UserDTO> LoadSellerGrid() {
            return (from u in _db.Users
                    where (TypeUser)u.TypeUser == TypeUser.Client
                    join t in _db.TypeUsers on u.TypeUser equals t.Id
                    join a in _db.Addresses on u.AddressId equals a.Id
                    select new UserDTO
                    {
                        Id = u.Id,
                        Name = u.Name,
                        LastName = u.LastName,
                        Cpf = u.Cpf,
                        DateOfBirth = u.DateOfBirth,
                        TypeUserName = t.Name,
                        Email = u.Email,
                        TypeUser = u.TypeUser,
                        AddressId = u.AddressId,
                        Address = a,
                        Tel = u.Tel,
                    }
             );
        }

        public IQueryable<UserDTO> SelectAllDTO(TypeUser typeUser)
        {
            var LoadReturnGrid = new Dictionary<TypeUser, Func<IQueryable<UserDTO>>>{
                { TypeUser.Admin,() => LoadAdminGrid() },
                { TypeUser.Seller,() => LoadSellerGrid() },
            };

            if (LoadReturnGrid.TryGetValue(typeUser, out Func<IQueryable<UserDTO>> loadGrid)) {
                var data = loadGrid();
                return data;
            }
            return null;


        }
    }
}
