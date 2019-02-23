using System;
using System.Collections.Generic;
using System.Text;

namespace FudooPanda.Core.Entities
{
    public class Order : BaseEntity
    {
        public int ProductId { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
