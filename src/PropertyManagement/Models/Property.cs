using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyManagement.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public float RentAmount { get; set; }
        public bool IsOccupied { get; set; }
        public string PropertyDescription { get; set; }
        public double NumOfBaths { get; set; }
        public int NumOfBeds { get; set; }
        public int DateConstructed { get; set; }
        public bool HeatIncluded { get; set; }
        public bool WaterSewerIncluded { get; set; }
        public ICollection<Payment> PaymentHistory { get; set; }

    }
}
