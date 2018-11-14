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
                            var page = new ItemsPage();
                            page.Title = "My Orders";
                            MenuPages.Add(id, new NavigationPage(page));
                            break;
                        }
                    case (int)MenuItemType.Wallet:
                        {
                            var page = new ItemsPage();
                            page.Title = "Wallet";
                            MenuPages.Add(id, new NavigationPage(page));
                            break;
                        }
                    case (int)MenuItemType.Settings:
                        {
                            var page = new ItemsPage();
                            page.Title = "Settings";
                            MenuPages.Add(id, new NavigationPage(page));
                            break;
                        }
                    case (int)MenuItemType.Support:
                        {
                            var page = new ItemsPage();
                            page.Title = "Support";
                            MenuPages.Add(id, new NavigationPage(page));
                            break;
                        }
                    case (int)MenuItemType.About:
                        {
                            var page = new ItemsPage();
                            page.Title = "About";
                            MenuPages.Add(id, new NavigationPage(page));
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