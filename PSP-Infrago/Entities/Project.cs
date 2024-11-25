using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Entities
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Client { get; set; }

        [Required]
        [StringLength(150)]
        public string ProjectName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime AssignationDate { get; set; }

        [Required]
        [Range(0, float.MaxValue)]
        public float Budget { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
