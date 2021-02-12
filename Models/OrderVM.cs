using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTemplate.Models
{
    public class OrderVM
    {
        public int id { get; set; }
        public string customerId { get; set; }
        public string orderDate { get; set; }

        public int shipVia { get; set; }

        public double freight { get; set; }

    }
}
