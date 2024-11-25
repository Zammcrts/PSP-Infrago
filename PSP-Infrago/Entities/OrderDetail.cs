using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Entities
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Order { get; set; }

        [StringLength(100)]
        public string Material { get; set; }

        [Range(0, float.MaxValue)]
        public float Quantity { get; set; }

        [Range(0, float.MaxValue)]
        public float PricePerUnit { get; set; }

    }
}
