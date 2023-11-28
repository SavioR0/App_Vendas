using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Vendas.Entity.Entities
{
	public class Sale : BaseEntity
    {

        public int ClientId { get; set; }
        public double Value { get; set; }
        public DateTime DateSale { get; set; }

        [IgnoreDataMember]
        public virtual User Client { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Order> Orders { get; set; }

    }
}
