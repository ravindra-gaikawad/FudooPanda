using System;
using System.Collections.Generic;
using System.Text;

namespace FudooPanda.Models
{
    public enum MenuItemType
    {
        Home,
        MyOrders,
        Wallet,
        Settings,
        Support,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; }
    }
}
