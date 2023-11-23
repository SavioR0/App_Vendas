using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Entity.Entities;

namespace Vendas.DTO
{
    public class UserCompleteDTO
    {
        public User User { get; set; }
        public Address Address { get; set; }
        public TypeUsers TypeUsers { get; set; }
    }
}
