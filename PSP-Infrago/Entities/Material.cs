using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Entities
{
    public class Material
    {
        public int Id { get; set; }
        public string MaterialName { get; set; }
        public string QuantityInStock { get; set; }
        public float PricePerUnit { get; set; }

    }
}
