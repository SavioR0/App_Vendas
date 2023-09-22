namespace Vendas.Entity.Entities
{
    public class Address : BaseEntity
    {
        public string CEP { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
    }
}
