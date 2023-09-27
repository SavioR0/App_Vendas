using System;

namespace Vendas.Entity.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }
        public string Tel { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int TypeUser { get; set; }
        public string UserName { get; set; }
        public char Flag { get; set; }
        public int EditLogin { get; set; }
        int teste;
    }
}
