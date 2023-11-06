using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Vendas.Entity.Entities
{
    public class Address : BaseEntity
    {
        public string CEP{ get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<User> Users { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Address)) return false;
            Address address = obj as Address;
            if (CEP == address.CEP &&
                State == address.State &&
                City == address.City &&
                District == address.District &&
                Number == address.Number &&
                Street == address.Street)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = 1972441119;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CEP);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(State);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(City);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(District);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Street);
            hashCode = hashCode * -1521134295 + Number.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<ICollection<User>>.Default.GetHashCode(Users);
            return hashCode;
        }
    }
}
