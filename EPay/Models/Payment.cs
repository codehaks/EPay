using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EPay.Models
{
    public class Payment
    {

        public Guid Id { get; set; }
        public EventType Type { get; set; }
        public DateTime TimeCreated { get; set; }
        public string UserName { get; set; }
        public int Amount { get; set; }

    }

    public enum EventType
    {
        None = 0,
        Withdraw = 1,
        Deposite = 2
    }

}
