using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FudooPanda.Views;
using FudooPanda.Services;
using Autofac;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FudooPanda
{
    public partial class App : Application
    {
        // IContainer and ContainerBuilder are provided by Autofac
        public static IContainer Container { get; set; }

        public App()
        {
            InitializeComponent();
            ICoreService coreService = new CoreService();
            coreService.InitDatabase();

            var builder = new ContainerBuilder();
            ComponentRegistrar.PrePopulationRegistration(builder);
            ComponentRegistrar.PostPopulationRegistration(builder);
            Container = builder.Build();

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
