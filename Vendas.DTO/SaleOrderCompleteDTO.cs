using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Entity.Entities;

namespace Vendas.DTO
{
	public class SaleOrderCompleteDTO
	{
		public Sale Sale { get; set; }
		public List<Order> Orders { get; set; }
	}
}
