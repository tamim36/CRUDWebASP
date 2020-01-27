using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesHandler
{
    public interface IServiceManagement
    {
        T Get<T>(string Id);
        IEnumerable<T> GetAll<T>();
        T Create<T>(T record);
        void Delete<T>(string id);
        void UpdateInfo<T>(string Id, T record);
    }
}
