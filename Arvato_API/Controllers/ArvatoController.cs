using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arvato_API.Data;
using Arvato_API.Dto;
using Arvato_API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Arvato_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArvatoController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly DataContext _dataContext;

        public ArvatoController(DataContext dataContext, IOrderRepository orderRepository,IOrderDetailRepository orderDetailRepository)
        {
            _dataContext = dataContext;
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
        }

        [HttpPost("OrderRequest")]
        public IActionResult OrderRequest(OrderDto orderDto)
        {
            if (orderDto.OrderTime > DateTime.Now)
            {
                return BadRequest("Datetime does not greater than today");
            }
            else
            {
                var order = new Order
                {
                    ACCOUNT = orderDto.AccountCode,
                    NUMBER = orderDto.Number,
                    ORDER_TIME = orderDto.OrderTime,
                    CUSTOMER_NAME = orderDto.CustomerName,
                    CUSTOMER_EMAIL = orderDto.CustomerEmail,
                    ORDER_TOTAL = orderDto.OrderTotal

                };
                _orderRepository.AddOrder(order);


                foreach (var detail in orderDto.OrderDetails)
                {
                    
                    var ItemId =_dataContext.ITEM_MASTER.FirstOrDefault(x => x.CODE == detail.ItemCode);
                    if (ItemId == null )
                    {
                        return BadRequest("Item Code does not exists in database");
                    }
                    else
                    {
                        _orderDetailRepository.AddOrderDetail(new OrderDetail
                        {
                            ITEM_ID = ItemId.ID,
                            ORDER_ID = order.ID,
                            QUANTITY = detail.Quantity,
                        });
                    }

                }
            }

            return Ok("success");
        }
    }
}