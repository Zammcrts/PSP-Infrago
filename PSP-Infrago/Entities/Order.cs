using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }

        [Required]
        [Range(0, float.MaxValue)]
        public float TotalCost { get; set; }

        [StringLength(500)]
        public string Details { get; set; }

        [Required]
        [StringLength(100)]
        public string Provider { get; set; }

        [Required]
        [StringLength(100)]
        public string Department { get; set; }

    }
}
