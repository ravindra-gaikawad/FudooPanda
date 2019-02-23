using System;

using FudooPanda.Models;
using FudooPanda.Sqlite.Entities;

namespace FudooPanda.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
