using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Vendas.Entity.Entities
{
    public class Address : BaseEntity
    {
        public string CEP { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<User> Users { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Address)) return false;
            Address address = obj as Address;
            if (CEP == address.CEP &&
                       City == address.City &&
                        Neighborhood == address.Neighborhood &&
                        Number == address.Number &&
                        Street == address.Street)
                return true;
            return false;
        }
    }
}
