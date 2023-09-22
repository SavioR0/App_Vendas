using System;

namespace Vendas.Entity.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Tel { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public int TypeUser { get; set; }

    }
}
