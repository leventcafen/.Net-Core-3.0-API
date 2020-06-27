using Arvato_API.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arvato_API.Dto
{
    public class OrderDto
    {
        [Required(ErrorMessage = "The account code is empty")]
        public string AccountCode { get; set; }
        public int Number { get; set; }
        public DateTime? OrderTime { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "Order Total should be greater than or equal to 0")]
        public decimal OrderTotal { get; set; }
        public List<OrderDetailDto> OrderDetails { get; set; }
    }
}
