using System;
using System.Linq;
using System.Linq.Expressions;
using Vendas.DTO;
using Vendas.Entity.Entities;

namespace Vendas.Service.Interfaces
{
	public interface IOrderController
	{
        string Save(Order entity);
        string Exclude(Order entity);
        IQueryable<Order> Filter(Expression<Func<Order, bool>> condition);
        IQueryable<Order> GetAll();
        Order GetById(int id);
        Order GetByProps(Order address);
        IQueryable<OrderDTO> FilterDTO(Expression<Func<OrderDTO, bool>> condition);

    }
}