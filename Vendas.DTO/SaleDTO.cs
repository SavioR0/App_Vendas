using Vendas.Entity.Entities;

namespace Vendas.DTO
{
    public class SaleDTO : Sale
    {
        public string NameSeller { get; set; }
        public string NameProduct{ get; set; }
        public double ValueProduct { get; set; }
        public int StockProduct { get; set; }

        public string NameClient { get; set; }
    }
}
