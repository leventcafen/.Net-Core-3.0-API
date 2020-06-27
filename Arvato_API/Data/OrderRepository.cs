using Arvato_API.Dto;
using Arvato_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvato_API.Data
{
    public class OrderRepository:IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public Order AddOrder(Order order)
        {

            _context.OBOP_ORDER.Add(order);
            _context.SaveChanges();

            return order;

        }
    }
}
