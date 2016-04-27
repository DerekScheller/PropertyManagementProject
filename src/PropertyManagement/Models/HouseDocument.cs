using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyManagement.Models
{
    public class HouseDocument
    {
        public int HouseDocumentId { get; set; }
        public byte[] Lease { get; set; }
        public int TenantId { get; set; }

    }
}
