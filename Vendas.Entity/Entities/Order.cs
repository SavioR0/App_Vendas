using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Vendas.Entity.Entities
{
	public class Order : BaseEntity
	{
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }


        [IgnoreDataMember]
        public virtual Sale Sale { get; set; }

        [IgnoreDataMember]
        public virtual Product Product { get; set; }
    }
}
