using Arvato_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvato_API.Data
{
    public class OrderDetailRepository :IOrderDetailRepository
    {
        private readonly DataContext _context;

        public OrderDetailRepository(DataContext context)
        {
            _context = context;
        }


        public OrderDetail AddOrderDetail(OrderDetail orderDetail)
        {

            _context.OBOP_ORDER_DETAIL.Add(orderDetail);
            _context.SaveChanges();

            return orderDetail;

        }
    }
}
