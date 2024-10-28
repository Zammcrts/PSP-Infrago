using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime AssignationDate { get; set; }
        public float Budget { get; set; }
        public string Status { get; set; }
    }
}
