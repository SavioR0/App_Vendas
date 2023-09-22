namespace Vendas.Entity.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }

        //[IgnoreDataMember]
        //public virtual ICollection<Venda> Vendas { get; set; }
    }
}
