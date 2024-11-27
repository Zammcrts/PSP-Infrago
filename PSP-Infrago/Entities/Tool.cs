using System.ComponentModel.DataAnnotations;

namespace PSP_Infrago.Entities
{
    public class Tool
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public int QuantityAvailable { get; set; }
        [StringLength(60)]
        public string ToolAssignment { get; set; }
        [StringLength(100)]
        public string Photo { get; set; }
    }
}
