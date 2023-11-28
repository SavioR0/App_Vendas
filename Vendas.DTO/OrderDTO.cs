using Vendas.Entity.Entities;

namespace Vendas.DTO
{
	public class OrderDTO
	{
		public ProductDTO ProductDTO { get; set; }
		public double ValueOrder{ get; set; }
		public int Quantity { get; set; }

	}
}
