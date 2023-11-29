using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vendas.DTO;
using Vendas.Entity.Entities;
using Vendas.Entity.Enums;
using Vendas.Infrastructure;
using Vendas.Library;
using Vendas.Repository.Intefaces;
using Vendas.Repository.Interfaces;

namespace Vendas.Repository
{
    public class SaleRepository : IDefaultRepository<Sale>
    {
        private readonly IRepository<Sale> _repository;
        private SalesContext _db = new SalesContext();

        public SaleRepository(SalesContext context = null)
        {
            _repository = new Repository<Sale>(context ?? new SalesContext());
        }
        public string Add(Sale entity)
        {
            string message = _repository.Insert(entity);
            return message;
        }

        public IQueryable<Sale> Filter(Expression<Func<Sale, bool>> condition)
        {
            return _repository.Filter(condition);
        }

        public IQueryable<SaleDTO> FilterDTO(Expression<Func<SaleDTO, bool>> condition, TypeUser typeUser)
        {
            return SelectAllDTO(typeUser).Where(condition);
        }

        public IQueryable<Sale> GetAll()
        {
            return _repository.GetAll();
        }

        public Sale GetById(int id)
        {
            return _repository.Filter(c => c.Id == id).FirstOrDefault();
        }

        public string Remove(Sale entity)
        {
            return _repository.Delete(entity);
        }

        public string Remove(int id)
        {
            return _repository.Delete(id);
        }

        public string Update(Sale entity)
        {
            string message = _repository.Update(entity);
            return message;
        }

		public IQueryable<SaleDTO> SelectAllDTO(TypeUser typeUser)
		{
			var LoadReturnGrid = new Dictionary<TypeUser, Func<IQueryable<SaleDTO>>>{
				{ TypeUser.Admin,() => LoadAdminGrid() },
				{ TypeUser.Client,() => LoadClientGrid() },
				{ TypeUser.Seller,() => LoadSellerGrid() },
			};

			if (LoadReturnGrid.TryGetValue(typeUser, out Func<IQueryable<SaleDTO>> loadGrid))
			{
				var data = loadGrid();
				return data;
			}
			return null;
		}

		private IQueryable<SaleDTO> LoadSellerGrid()
		{
            return (from s in _db.Sale 
                    join o in _db.Order on s.Id equals o.SaleId
                    where (s.ClientId == Global.Instance.User.Id || o.Product.SellerId == Global.Instance.User.Id)
                    join c in _db.Users on s.ClientId equals c.Id
                    select new SaleDTO
                    {
                        Id = s.Id,
                        NameClient = c.Name,
                        DateSale = s.DateSale,
                        Value = s.Value,
                    }).Distinct();
        }

		private IQueryable<SaleDTO> LoadAdminGrid()
		{
            return (from s in _db.Sale
                    join o in _db.Order on s.Id equals o.SaleId
                    join c in _db.Users on s.ClientId equals c.Id
                    select new SaleDTO
                    {
                        Id = s.Id,
                        NameClient = c.Name,
                        DateSale = s.DateSale,
                        Value = s.Value,
                    }).Distinct();
        }

		private IQueryable<SaleDTO> LoadClientGrid()
		{
            return (from s in _db.Sale
                    where (s.ClientId == Global.Instance.User.Id)
                    join o in _db.Order on s.Id equals o.SaleId
                    join c in _db.Users on s.ClientId equals c.Id
                    select new SaleDTO
                    {
                        Id = s.Id,
                        NameClient = c.Name,
                        DateSale = s.DateSale,
                        Value = s.Value,
                    }
			 ).Distinct();
		}
	}
}
