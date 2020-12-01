using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ
{
    [Serializable]
    public class Payment
    {
        public decimal AmountToPay { get; set; }
        public string CardNumber { get; set; }
        public string Name { get; set; }
    }
}
