using System.ComponentModel.DataAnnotations;

namespace PSP_Infrago.Entities
{
    public class MachineryAssignment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Project { get; set; }
        [StringLength(100)]
        public string AssignationDate { get; set; }
        [StringLength(100)]
        public string Machine { get; set; }
        [StringLength(100)]
        public string Photo { get; set; }
    }
}
