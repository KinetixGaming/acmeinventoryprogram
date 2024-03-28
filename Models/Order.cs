using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeDistributing.Models
{
    public class Order
    {

        public int Id { get; set; }

        public string Status { get; set; }

        public int Quantity { get; set; }

        public string PackagingType { get; set; }

        public int CaseSize { get; set; }

        public int SKU { get; set; }

        public string OrderConfirmation { get; set; }

        public Order()
        { 
        
        
        }
    }
}
