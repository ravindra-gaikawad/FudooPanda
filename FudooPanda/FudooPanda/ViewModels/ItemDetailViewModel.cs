using System;

using FudooPanda.Models;
using FudooPanda.Core.Entities;
using FudooPanda.Core.Models;

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
