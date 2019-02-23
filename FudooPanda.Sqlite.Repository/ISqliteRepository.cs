using FudooPanda.Sqlite.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FudooPanda.Sqlite.Repository
{
    public interface ISqliteRepository
    {
        Task<List<T>> GetAsync<T>() where T : BaseEntity;

        Task<T> GetAsync<T>(int id) where T : BaseEntity;

        Task<int> SaveAsync<T>(T item) where T : BaseEntity;

        Task<int> DeleteAsync<T>(T item) where T : BaseEntity;
    }
}
