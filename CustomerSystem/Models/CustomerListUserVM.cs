using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSystem.Models
{
    public class CustomerListUserVM
    {
        public User user { get; set; }
        public List<Customer> customers { get; set; }
    }
}
