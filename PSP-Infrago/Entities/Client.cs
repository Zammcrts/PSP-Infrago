using System.ComponentModel.DataAnnotations;

namespace PSP_Infrago.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(100)]
        public string Street { get; set; }
        [StringLength(10)]
        public string ExteriorNumber { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(50)]
        public string Township { get; set; }
        [StringLength(50)]
        public string City { get; set; }

        [StringLength(10)]
        public string ZipCode { get; set; }

        [StringLength(100)]
        public string Project { get; set; }
    }
}
