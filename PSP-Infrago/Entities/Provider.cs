using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Entities
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ProviderName { get; set; }

        [Required]
        [StringLength(15)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(10)]
        public string ExteriorNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [StringLength(100)]
        public string State { get; set; }

        [Required]
        [StringLength(50)]
        public string Township { get; set; }

        [Required]
        [StringLength(10)]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Required]
        [StringLength(100)]
        public string Material { get; set; }
    }
}
