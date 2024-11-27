using System.ComponentModel.DataAnnotations;

namespace PSP_Infrago.Entities
{
    public class Maintenance
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int EquipmentId { get; set; }
        public int MaintenanceDate { get; set; }
        [StringLength(100)]
        public string MaintenanceType { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        public float Cost { get; set; }
        [StringLength(100)]
        public string Details { get; set; }
        [StringLength(100)]
        public string Photo { get; set; }
    }
}