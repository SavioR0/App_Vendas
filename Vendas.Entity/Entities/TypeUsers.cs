using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Vendas.Entity.Entities
{
    public class TypeUsers : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<User> Users { get; set; }
    }
}
