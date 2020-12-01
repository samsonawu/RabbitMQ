using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ
{
    [Serializable]
    public class PurchaseOrder
    {
        public decimal AmountToPay { get; set; }
        public string PoNumber { get; set; }
        public string CompanyName { get; set; }
        public string PaymentDayTerms { get; set; }
    }
}
