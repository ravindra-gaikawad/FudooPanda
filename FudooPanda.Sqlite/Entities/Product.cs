using System;
using System.Collections.Generic;
using System.Text;

namespace FudooPanda.Sqlite.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
