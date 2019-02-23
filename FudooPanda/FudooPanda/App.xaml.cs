using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FudooPanda.Views;
using FudooPanda.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FudooPanda
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            ICoreService coreService = new CoreService();
            coreService.InitDatabase();

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
