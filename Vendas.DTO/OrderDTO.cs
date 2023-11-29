using Vendas.Entity.Entities;

namespace Vendas.DTO
{
	public class OrderDTO : BaseEntity
	{
		public ProductDTO ProductDTO { get; set; }
		public double ValueOrder{ get; set; }
		public int Quantity { get; set; }
		public int SaleId { get; set; }

	}
}
