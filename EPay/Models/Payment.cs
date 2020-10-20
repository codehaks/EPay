using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EPay.Models
{
    public class Payment
    {
        public string CustomerName { get; set; }
        public int Amount { get; set; }
        public int OrderId { get; set; }
    }

    public enum EventType
    {
        Debit = 1,
        Deposite = 2
    }

    public class PaymentEvent
    {
        public Guid Id { get; set; }
        public EventType Type { get; set; }

        [Column(TypeName = "jsonb")]
        public string Data { get; set; }

        public DateTime TimeCreated { get; set; }
    }
}
