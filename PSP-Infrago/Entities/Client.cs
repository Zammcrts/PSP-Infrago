using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Required]
        [StringLength(15)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        [StringLength(200)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(10)]
        public string ExteriorNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [Required]
        [StringLength(50)]
        public string Township { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(10)]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [StringLength(100)]
        public string Project { get; set; }
    }
}
