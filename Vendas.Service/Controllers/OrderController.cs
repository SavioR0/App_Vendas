using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Http;
using Vendas.DTO;
using Vendas.Entity.Entities;
using Vendas.Repository;
using Vendas.Service.Interfaces;

namespace Vendas.Service.Controllers
{
	public class OrderController : ApiController, IOrderController
	{
		string message = "";

		[HttpPost]
		[Route("salvar")]
		public string Save(Order entity)
		{
			throw new NotImplementedException();
		}
		[HttpPost]
		[Route("excluir")]
		public string Exclude(Order entity)
		{
			throw new NotImplementedException();
		}
		[HttpPost]
		[Route("filtrar")]
		public IQueryable<Order> Filter(Expression<Func<Order, bool>> condition)
		{
			throw new NotImplementedException();
		}

		[HttpPost]
		[Route("filtrarDTO")]
		public IQueryable<OrderDTO> FilterDTO(Expression<Func<OrderDTO, bool>> condition)
		{
			return new OrderRepository().FilterDTO(condition);
		}
		[HttpPost]
		[Route("selecionarTodos")]
		public IQueryable<Order> GetAll()
		{
			throw new NotImplementedException();
		}
		[HttpPost]
		[Route("selecionarTodosDTO")]
		public List<OrderDTO> GetAllDTO()
		{
			return new OrderRepository().GetAllDTO().ToList();
		}
		[HttpPost]
		[Route("selecionarPorId")]
		public Order GetById(int id)
		{
			throw new NotImplementedException();
		}
		[HttpPost]
		[Route("selecionarPorProp")]
		public Order GetByProps(Order address)
		{
			throw new NotImplementedException();
		}
		
	}
}