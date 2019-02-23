using System;
using System.Collections.Generic;
using System.Text;

namespace FudooPanda.Sqlite.Entities
{
    public class Item : BaseEntity
    {
        public string Text { get; set; }

        public string Description { get; set; }
    }
}
