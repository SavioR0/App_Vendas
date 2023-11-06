using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Vendas.Entity.Entities
{
    
    public class Product : BaseEntity
    {
        private int stockValue;
        public string Name { get; set; }
        public double Value { get; set; }
        public string Description { get; set; }
        public int Stock
        {
            get
            {
                return stockValue;
            }
            set
            {
                if (value < 0)
                {
                    throw new ApplicationException("Estoque inválido!");
                }
                stockValue = value; // Defina o valor na variável de campo
            }
        }
        public string Flag { get; set; }
        public int SellerId { get; set; }

        [IgnoreDataMember]
        public virtual User Seller { get; set; }

    }
}
