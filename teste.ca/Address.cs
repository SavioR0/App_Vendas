using System.Collections.Generic;
using System.Runtime.Serialization;

namespace teste
{
    public class Address
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

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
            return base.GetHashCode();
        }
    }
}
