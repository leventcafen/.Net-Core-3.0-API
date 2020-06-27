using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvato_API.Model
{
    public class Order
    {
        public int ID { get; set; }
        public string ACCOUNT { get; set; }
        public int NUMBER { get; set; }
        public DateTime? ORDER_TIME { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string CUSTOMER_EMAIL { get; set; }
        public decimal ORDER_TOTAL { get; set; }
     
    }
}
