using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Entities
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string DepartmentName { get; set; }

        [StringLength(100)]
        public string Order { get; set; }
    }
}
