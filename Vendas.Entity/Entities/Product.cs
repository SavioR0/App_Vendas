using System.Runtime.Serialization;

namespace Vendas.Entity.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public char Flag { get; set; }
        public int SellerId { get; set; }

        [IgnoreDataMember]
        public virtual User Seller { get; set; }

    }
}
