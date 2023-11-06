using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Vendas.Entity.Entities
{
    public class Sale : BaseEntity
    {
        public int ProductId { get; set; }
        public int SellerId { get; set; }
        public int ClientId { get; set; }
        public string Flag { get; set; }

        [IgnoreDataMember]
        public virtual Product Product { get; set; }

        [IgnoreDataMember]
        public virtual User Client { get; set; }

        [IgnoreDataMember]
        public virtual User Seller { get; set; }
    }
}
