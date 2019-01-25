using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXMiniPage.Models
{
    public class CustomerViewModel
    {
        public int CustomerNumber { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String FullName { get { return FirstName + " " + LastName; } }
        public List<CustomerOrder> Orders = new List<CustomerOrder>();
    }
}
