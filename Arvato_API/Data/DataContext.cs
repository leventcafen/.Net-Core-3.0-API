using Arvato_API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvato_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        //public DbSet<OBOP_ORDER> Order { get; set; }
        //public DbSet<OBOP_ORDER_DETAIL> OrderDetail { get; set; }
        //public DbSet<ITEM_MASTER> ItemMaster { get; set; }

        public DbSet<Order> OBOP_ORDER { get; set; }
        public DbSet<OrderDetail> OBOP_ORDER_DETAIL { get; set; }
        public DbSet<ItemMaster> ITEM_MASTER { get; set; }
    }
}
