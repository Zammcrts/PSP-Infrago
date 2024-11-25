using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Entities
{
    public class MaterialAssignment
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Project { get; set; }

        [StringLength(100)]
        public string Material { get; set; }

        [Range(0, float.MaxValue)]
        public float Quantity { get; set; }
    }
}
