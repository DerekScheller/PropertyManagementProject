using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyManagement.Models
{
    public class Tenant
    {
        public int TenantId { get; set; }
        public double PhoneNumber { get; set; }
        public string ForwardingAddress { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Payment> PaymentHistory { get; set; }

    }
}
