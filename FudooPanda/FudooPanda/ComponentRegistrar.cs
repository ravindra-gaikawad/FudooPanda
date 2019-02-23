using Autofac;
using FudooPanda.Services;
using FudooPanda.Sqlite.Repository;
using FudooPanda.ViewModels;
using FudooPanda.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace FudooPanda
{
    public class ComponentRegistrar
    {
        public static void PrePopulationRegistration(ContainerBuilder builder)
        {
        }

        public static void PostPopulationRegistration(ContainerBuilder builder)
        {
            builder.RegisterType<CoreService>().As<ICoreService>().SingleInstance();
            builder.RegisterType<HttpService>().As<IHttpService>().SingleInstance();
            builder.RegisterType<ItemService>().As<IItemService>().SingleInstance();
            builder.RegisterType<SqliteRepository>().As<ISqliteRepository>().SingleInstance();
            builder.RegisterType<FudooDatabase>().SingleInstance();

            builder.RegisterType<ItemsViewModel>().InstancePerDependency();
            builder.RegisterType<ItemsPage>().InstancePerDependency();
        }
    }
}
