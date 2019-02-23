using Autofac;
using FudooPanda.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FudooPanda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Home, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Home:
                        {
                            var page = new HomePage();
                            page.Title = "Home";
                            MenuPages.Add(id, new NavigationPage(page));
                            break;
                        }
                    case (int)MenuItemType.MyOrders:
                        {                            
                            ItemsPage itemsPage;
                            using (var scope = App.Container.BeginLifetimeScope())
                            {
                                itemsPage = scope.Resolve<ItemsPage>();
                                itemsPage.Title = "My Orders";
                                MenuPages.Add(id, new NavigationPage(itemsPage));
                            }
                            
                            break;
                        }
                    case (int)MenuItemType.Wallet:
                        {
                            ItemsPage itemsPage;
                            using (var scope = App.Container.BeginLifetimeScope())
                            {
                                itemsPage = scope.Resolve<ItemsPage>();
                                itemsPage.Title = "Wallet";
                                MenuPages.Add(id, new NavigationPage(itemsPage));
                            }
                            break;
                        }
                    case (int)MenuItemType.Settings:
                        {
                            ItemsPage itemsPage;
                            using (var scope = App.Container.BeginLifetimeScope())
                            {
                                itemsPage = scope.Resolve<ItemsPage>();
                                itemsPage.Title = "Wallet";
                                MenuPages.Add(id, new NavigationPage(itemsPage));
                            }

                            break;
                        }
                    case (int)MenuItemType.Support:
                        {
                            ItemsPage itemsPage;
                            using (var scope = App.Container.BeginLifetimeScope())
                            {
                                itemsPage = scope.Resolve<ItemsPage>();
                                itemsPage.Title = "Support";
                                MenuPages.Add(id, new NavigationPage(itemsPage));
                            }

                            break;
                        }
                    case (int)MenuItemType.About:
                        {
                            ItemsPage itemsPage;
                            using (var scope = App.Container.BeginLifetimeScope())
                            {
                                itemsPage = scope.Resolve<ItemsPage>();
                                itemsPage.Title = "About";
                                MenuPages.Add(id, new NavigationPage(itemsPage));
                            }

                            break;
                        }
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}