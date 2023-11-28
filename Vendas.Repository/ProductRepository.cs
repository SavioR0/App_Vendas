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
    public class ProductRepository : IDefaultRepository<Product>
    {
        private readonly IRepository<Product> _repository;
        private SalesContext _db = new SalesContext();

        public ProductRepository(SalesContext context = null)
        {
            _repository = new Repository<Product>(context ?? new SalesContext());
        }
        public string Add(Product entity)
        {

            Validate(entity);
            if (_repository.GetAll().Any(c => entity.Name == c.Name))
                throw new Exception("Produto já cadastrado no sistema.");
            return _repository.Insert(entity);
        }

        public IQueryable<Product> Filter(Expression<Func<Product, bool>> condition)
        {
            return _repository.Filter(condition);
        }

        public IQueryable<ProductDTO> FilterDTO()
        {
            return (from p in _db.Product
                    join u in _db.Users on p.SellerId equals u.Id
                    select new ProductDTO
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Description = p.Description,
                        Stock = p.Stock,
                        SellerName = u.Name,
                        Value = p.Value
                    }); 
        }

        public IQueryable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public Product GetById(int id)
        {
            return _repository.GetById(id);
        }

        public string Remove(Product entity)
        {
            return _repository.Delete(entity);
        }

        public string Remove(int id)
        {
            return _repository.Delete(id);
        }

        public string Update(Product entity)
        {
            if (_repository.Filter(c => entity.Name.Trim() == c.Name.Trim() && c.Id != entity.Id).Any())
                throw new Exception("Produto já cadastrado no sistema.");
            return _repository.Update(entity);
        }

        private void Validate(Product entity)
        {
            if (string.IsNullOrEmpty(entity.Name))
                throw new Exception("Nome não preenchido. ");

            if (string.IsNullOrEmpty(entity.Description))
                throw new Exception("Descrição não preenchido. ");

            if (entity.Stock == 0)
                throw new Exception("Estoque não preenchida. ");

            //if (entity.)
            //    throw new Exception("CPF não preenchido. ");            //if (entity.)
            //    throw new Exception("CPF não preenchido. ");
        }

        private IQueryable<ProductDTO> LoadAllGrid()
        {
            return (from p in _db.Product
                    join u in _db.Users on p.SellerId equals u.Id
                    select new ProductDTO
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Description = p.Description,
                        Value = p.Value,
                        Stock = p.Stock,
                        SellerName = u.Name
                    }
             );
        }
        private IQueryable<ProductDTO> LoadSellerGrid()
        {
            return (from p in _db.Product
                    join u in _db.Users on p.SellerId equals u.Id where (TypeUser)u.TypeUser == TypeUser.Seller
                    select new ProductDTO
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Description = p.Description,
                        Value = p.Value,
                        Stock = p.Stock,
                        SellerName = u.Name
                    }
             );
        }

        public IQueryable<ProductDTO> SelectAllDTO(TypeUser typeUser)
        {
            var LoadReturnGrid = new Dictionary<TypeUser, Func<IQueryable<ProductDTO>>>{
                { TypeUser.Admin,() => LoadAllGrid() },
                { TypeUser.Client,() => LoadAllGrid() },
                { TypeUser.Seller,() => LoadSellerGrid() },
            };

            if (LoadReturnGrid.TryGetValue(typeUser, out Func<IQueryable<ProductDTO>> loadGrid))
            {
                var data = loadGrid();
                return data;
            }
            return null;
        }
    }
}
