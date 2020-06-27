using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arvato_API.Dto
{
    public class OrderDetailDto
    {
        [Required(ErrorMessage = "The item code is empty")]
        public string ItemCode { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "Quantity should be greater than or equal to 0")]
        public int Quantity { get; set; }
    }
}
