using System;
using teste;

namespace teste.ca
{
    class Program
    {
        static void Main()
        {
            var address = new Address
            {
                Id = 0,
                CEP = "35650000",
                State = "MG",
                City = "Pitangui",
                District = "Centro",
                Street = "Praça Getúlio Vargas",
                Number = 154,
            };

            var address2 = new Address
            {
                Id = 0,
                CEP = "35650000",
                State = "MG",
                City = "Pitangui",
                District = "Centr",
                Street = "Praça Getúlio Vargas",
                Number = 154,
            };

            var test = address.Equals(address2);
        }
    }
}
