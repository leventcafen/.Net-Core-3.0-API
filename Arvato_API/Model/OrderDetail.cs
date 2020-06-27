using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvato_API.Model
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int ORDER_ID { get; set; }
        public int ITEM_ID { get; set; }
        public int QUANTITY { get; set; }
      
    }
}
