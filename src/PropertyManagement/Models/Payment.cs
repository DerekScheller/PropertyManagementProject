using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyManagement.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public float PaymentAmount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateRecieved { get; set; }
        public int TenantId { get; set; }
        public int PropertyId { get; set; }
    }
}
