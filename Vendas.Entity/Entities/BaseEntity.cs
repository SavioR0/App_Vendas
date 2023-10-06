using System.ComponentModel.DataAnnotations;

namespace Vendas.Entity.Entities
{
    public class BaseEntity
    {
        [Key()]
        public int Id { get; set; }
    }
}
