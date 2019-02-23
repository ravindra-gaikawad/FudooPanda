using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FudooPanda.Views;
using FudooPanda.Sqlite.Repository;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FudooPanda
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            FudooDatabase.Init();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
