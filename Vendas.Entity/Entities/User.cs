using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Vendas.Entity.Enums;

namespace Vendas.Entity.Entities
{
    public class User : BaseEntity
    {
        public User() => Sales = new List<Sale>();

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }
        public string Tel { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? AddressId{ get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int TypeUser { get; set; }
        public string UserName { get; set; }
        public string Flag { get; set; }
        public int EditLogin { get; set; }
        public byte[] BiometryDataBinary { get; set; }
        public string BiometryDataText { get; set; }

        [IgnoreDataMember]
        public virtual Address Address { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Sale> Sales { get; set; }

        [IgnoreDataMember]
        public virtual TypeUsers TypeUsers { get; set; }
    }
}
