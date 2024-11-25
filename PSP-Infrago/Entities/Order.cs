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

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public float TotalCost { get; set; }

        [StringLength(500)]
        public string Details { get; set; }

        [StringLength(100)]
        public string Provider { get; set; }

        [StringLength(100)]
        public string Department { get; set; }

    }
}
