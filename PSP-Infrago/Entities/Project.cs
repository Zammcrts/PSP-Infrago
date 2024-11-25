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

        [StringLength(200)]
        public string Client { get; set; }

        [StringLength(150)]
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime AssignationDate { get; set; }

        [Range(0, float.MaxValue)]
        public float Budget { get; set; }

        public string Status { get; set; }
    }
}
