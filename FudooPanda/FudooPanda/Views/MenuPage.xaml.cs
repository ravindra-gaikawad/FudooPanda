using FudooPanda.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FudooPanda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Home, Title="Home", Icon="home.png"},
                 new HomeMenuItem {Id = MenuItemType.MyOrders, Title="My Orders", Icon="order.png"},
                new HomeMenuItem {Id = MenuItemType.Wallet, Title="Wallet", Icon="wallet.png"},
                 new HomeMenuItem {Id = MenuItemType.Settings, Title="Settings", Icon="setting.png"},
                new HomeMenuItem {Id = MenuItemType.Support, Title="Support", Icon="support.png"},
                new HomeMenuItem {Id = MenuItemType.About, Title="About" , Icon="globe.png"}
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}