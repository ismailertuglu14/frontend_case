using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.DTOs.Cart
{
    public record struct AddToCartDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
