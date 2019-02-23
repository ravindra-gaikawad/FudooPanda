using FudooPanda.Core;
using SQLite;
using System;
using System.IO;

namespace FudooPanda.Sqlite
{
    public class FudooDatabase
    {
        public FudooDatabase()
        {
        
        }

        public static void Init()
        {
            SQLiteAsyncConnection sqliteAsyncConnection = GetAsyncConnection();
            sqliteAsyncConnection.CreateTableAsync<Entities.Product>().Wait();
            sqliteAsyncConnection.CreateTableAsync<Entities.Order>().Wait();
            sqliteAsyncConnection.CreateTableAsync<Entities.Item>().Wait();
        }

        public static SQLiteAsyncConnection GetAsyncConnection()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Constants.SqliteDbName);
            return new SQLiteAsyncConnection(path);
        }
    }
}
