using FudooPanda.Core;
using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FudooPanda.Sqlite.Repository
{
    public class SqliteRepository : ISqliteRepository
    {
        //private readonly FudooDatabase fudooDatabase;
        private readonly SQLiteAsyncConnection sqliteAsyncConnection;

        public SqliteRepository(/*FudooDatabase fudooDatabase*/)
        {
            //this.fudooDatabase = new FudooDatabase();
            sqliteAsyncConnection = FudooDatabase.GetAsyncConnection();
        }

        async Task<int> ISqliteRepository.DeleteAsync<T>(T item)
        {
            return await sqliteAsyncConnection.DeleteAsync<T>(item);
        }

        async Task<List<T>> ISqliteRepository.GetAsync<T>()
        {
            var items = await sqliteAsyncConnection.ExecuteScalarAsync<List<T>>($"Select * from {typeof(T).Name}");

            if (items.IsNullOrEmpty())
            {
                return new List<T>();
            }

            return items;
        }

        async Task<T> ISqliteRepository.GetAsync<T>(int id)
        {
            return await sqliteAsyncConnection.ExecuteScalarAsync<T>($"Select * from {typeof(T).Name} where Id={id}");
        }

        async Task<int> ISqliteRepository.SaveAsync<T>(T item)
        {
            if (item.Id != 0)
            {
                return await sqliteAsyncConnection.UpdateAsync(item);
            }
            else
            {
                return await sqliteAsyncConnection.InsertAsync(item);
            }
        }
    }
}
