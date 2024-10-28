using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Entities
{
    public class MaterialAssignment
    {
        public int Id { get; set; }
        public string Project { get; set; }
        public string Material { get; set; }
        public int Quantity { get; set; }
    }
}
