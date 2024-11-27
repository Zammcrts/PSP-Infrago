using System.ComponentModel.DataAnnotations;

namespace PSP_Infrago.Entities
{
    public class ProjectDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        [StringLength(100)]
        public string ServiceType { get; set; }
        public float Cost { get; set; }
        [Required]
        [StringLength(100)]
        public string Project { get; set; }
        [Required]
        [StringLength(100)]
        public string Service { get; set; }
        [Required]
        [StringLength(100)]
        public string Photo { get; set; }
    }
}
