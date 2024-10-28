using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public string Order { get; set; }
        public string Material { get; set; }
        public float Quantity { get; set; }
        public float PricePerUnit { get; set; }

    }
}
