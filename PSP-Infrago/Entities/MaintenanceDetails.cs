using System.ComponentModel.DataAnnotations;

namespace PSP_Infrago.Entities
{
    public class MaintenanceDetails
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string MaintenanceDate { get; set; }
        [StringLength(100)]
        public string Descrption { get; set; }
        public float Cost { get; set; }
        [StringLength(100)]
        public string Maintenance { get; set; }
        [StringLength(100)]
        public string Machinery { get; set; }
        [StringLength(100)]
        public string Photo { get; set; }
    }
}
