using System.ComponentModel.DataAnnotations;

namespace PSP_Infrago.Entities
{
    public class Machinery
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Code { get; set; }
        [StringLength(100)]
        public string Model { get; set; }
        [StringLength(100)]
        public string Name { get; set; } // machine
        [StringLength(100)]
        public string Capacity { get; set; }
        [StringLength(100)]
        public string Details { get; set; }
        [StringLength(100)]
        public string Assignment { get; set; }
        [StringLength(100)]
        public string Photo { get; set; }

    }
}
