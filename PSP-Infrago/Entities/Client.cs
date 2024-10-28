using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string ExteriorNumber { get; set; }
        public string State { get; set; }
        public string Township { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Project { get; set; }
    }
}
