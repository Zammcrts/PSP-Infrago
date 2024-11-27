using System.ComponentModel.DataAnnotations;

namespace PSP_Infrago.Entities
{
    public class ToolAssignment
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Date { get; set; }
        [StringLength(100)]
        public string Tool { get; set; }
        [StringLength(100)]
        public string Project { get; set; }
        [StringLength(100)]
        public string Photo { get; set; }
    }
}
