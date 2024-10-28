using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_Infrago.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public float TotalCost { get; set; }
        public string Details { get; set; }
        public string Provider { get; set; }
        public string Department { get; set; }

    }
}
