using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPay.Models
{
    public class Payment
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; }
        public int Amount { get; set; }
        public DateTime TimeCreated { get; set; }

    }
}
