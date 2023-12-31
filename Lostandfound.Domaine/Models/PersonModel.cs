﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lostandfound.Domaine.Models
{
    [Table("person")]
    public class PersonModel
    {
        [Key]
        public Guid PersonId { get; set; } = Guid.NewGuid();
        [Column(name: "lastname")]
        public string LastName { get; set; }
        [Column(name: "firstname")]
        public string FirstName { get; set; }

        [Column(name: "email", Order = 1)]
        public string Email { get; set; }

        [Column(name: "phone_number")]
        public string PhoneNumber { get; set; }
        [Column(name: "address")]
        public string Address { get; set; }

        public virtual List<ItemModel> Items { get; set; }
    }
}
