using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rammstein15.Domain.Entities
{
    public class Customer
    {
        public string CustomerId { get; set; }

        public string CustomerName { get; set; }

        public bool? IsActive { get; set; }
    }
}