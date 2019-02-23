using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FudooPanda.Core.Models;

namespace FudooPanda.Services
{
    public class ItemService : IItemService
    {
        private readonly HttpService httpService;

        public ItemService(/*HttpService httpService*/)
        {
            this.httpService = new HttpService();
        }

        Task<List<Item>> IItemService.GetAsync()
        {
            List<Item> items = new List<Item>();

            items.Add(new Item()
            {
                Id = 1,
                Text = "sdfghj",
                Description = "dsf"
            });
            items.Add(new Item()
            {
                Id = 2,
                Text = "puyt",
                Description = "dsf"
            });
            items.Add(new Item()
            {
                Id = 3,
                Text = "lkjhgf",
                Description = "dsf"
            });

            return Task.FromResult(items);
        }

        Task<int> IItemService.SaveAsync(Item item)
        {
            return Task.FromResult(1);
        }
    }
}
