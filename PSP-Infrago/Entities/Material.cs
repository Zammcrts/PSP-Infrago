using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Entities
{
    public class Material
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string MaterialName { get; set; }

        [Required]
        [StringLength(100)]
        public string QuantityInStock { get; set; }

        [Required]
        [Range(0, float.MaxValue)]
        public float PricePerUnit { get; set; }

    }
}
