using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Entity.Entities;

namespace Vendas.DTO
{
    public class UserDTO : User
    {
        public string TypeUserName { get; set; }
    }
}
