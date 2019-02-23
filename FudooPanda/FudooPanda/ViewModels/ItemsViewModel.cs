using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using FudooPanda.Models;
using FudooPanda.Views;
using FudooPanda.Sqlite.Repository;

namespace FudooPanda.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Sqlite.Entities.Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<Sqlite.Entities.Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Sqlite.Entities.Item>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Sqlite.Entities.Item;
                Items.Add(newItem);
                ISqliteRepository sqliteRepository = new SqliteRepository();
                await sqliteRepository.SaveAsync<Sqlite.Entities.Item>(newItem);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                ISqliteRepository sqliteRepository = new SqliteRepository();
                var items = await sqliteRepository.GetAsync<Sqlite.Entities.Item>();
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}