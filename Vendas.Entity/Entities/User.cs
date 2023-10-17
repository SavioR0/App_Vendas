﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Vendas.Entity.Entities
{
    public class User : BaseEntity
    {
        public User() => Sales = new List<Sale>();

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }
        public string Tel { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int AddressId{ get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int TypeUser { get; set; }
        public string UserName { get; set; }
        public char Flag { get; set; }
        public int EditLogin { get; set; }
        public byte[] BiometricData { get; set; }

        [IgnoreDataMember]
        public virtual Address Address { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
