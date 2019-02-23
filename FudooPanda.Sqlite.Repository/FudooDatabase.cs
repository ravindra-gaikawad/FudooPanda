using FudooPanda.Core;
using FudooPanda.Core.Entities;
using SQLite;
using System;
using System.IO;

namespace FudooPanda.Sqlite.Repository
{
    public class FudooDatabase
    {
        public FudooDatabase()
        {

        }

        public static void Init()
        {
            SQLiteAsyncConnection sqliteAsyncConnection = GetAsyncConnection();
            Type[] types = new Type[] { typeof(Product), typeof(Order), typeof(Item) };
            sqliteAsyncConnection.CreateTablesAsync(CreateFlags.None, types).Wait();

            //sqliteAsyncConnection.CreateTableAsync<Product>().Wait();
            //sqliteAsyncConnection.CreateTableAsync<Order>().Wait();
            //sqliteAsyncConnection.CreateTableAsync<Item>().Wait();
        }

        public static SQLiteAsyncConnection GetAsyncConnection()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Constants.SqliteDbName);
            return new SQLiteAsyncConnection(path);
        }
    }
}
