using System.ComponentModel.DataAnnotations;

namespace PSP_Infrago.Entities
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public float Cost { get; set; }
        [Required]
        [StringLength(100)]
        public string Details { get; set; }
    }
}
