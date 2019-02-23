using FudooPanda.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FudooPanda.Services
{
    public interface IItemService
    {
        Task<List<Item>> GetAsync();

        Task<int> SaveAsync(Item item);
    }
}
