using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Repository
{
    public interface IRepositoryManagement
    {
        T Get<T>(string Id);
        IEnumerable<T> GetAll<T>();
        T Create<T>(T record);
        void Delete<T>(string id);
        void UpdateInfo<T>(string Id, T record);
    }
}
