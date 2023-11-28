using System;
using System.Linq;
using System.Linq.Expressions;
using Vendas.DTO;
using Vendas.Entity.Entities;
using Vendas.Infrastructure;
using Vendas.Repository.Intefaces;
using Vendas.Repository.Interfaces;

namespace Vendas.Repository
{
	public class OrderRepository : IDefaultRepository<Order>
	{
		private IRepository<Order> _repository;
		private SalesContext _db = new SalesContext(); 
		public OrderRepository(SalesContext context = null)
		{
			_repository = new Repository<Order>(context ?? new SalesContext());
		}
		public string Add(Order entity)
		{
			var _message = _repository.Insert(entity);
			return _message;
		}

		public IQueryable<Order> Filter(Expression<Func<Order, bool>> condition)
		{
			return  _repository.Filter(condition);
		}

		public IQueryable<Order> GetAll()
		{
			return _repository.GetAll();
		}

		public Order GetById(int id)
		{
			return (Order)_repository.Filter(c=> c.Id == id);
		}

		public string Remove(Order entity)
		{
			return _repository.Delete(entity);
		}

		public IQueryable<OrderDTO> FilterDTO(Expression<Func<OrderDTO, bool>> condition)
		{
			return GetAllDTO().Where(condition);
		}

		public IQueryable<OrderDTO> GetAllDTO()
		{
			return (from o in _db.Order
					join s in _db.Sale on o.SaleId equals s.Id
					join p in _db.Product on o.ProductId equals p.Id
					join u in _db.Users on p.SellerId equals u.Id
					select new OrderDTO
					{
						ProductDTO = new ProductDTO
						{
							Name = p.Name,
							Description = p.Description,
							SellerName = u.Name,
							Stock = p.Stock,
						},
						Quantity = o.Quantity,
						ValueOrder = o.Quantity * p.Value,
						
					}) ;
		}

		public string Update(Order entity)
		{
			return _repository.Update(entity);
		}
	}
}
