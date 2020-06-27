using Arvato_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvato_API.Data
{
    public interface IOrderRepository
    {
        Order AddOrder(Order order);
    }
}
