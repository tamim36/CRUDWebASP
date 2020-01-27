using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Repository;

namespace ServicesHandler
{
    public class ServiceManagement : IServiceManagement
    {

        private readonly IRepositoryManagement _RepositoryManagement;

        public ServiceManagement(IRepositoryManagement repositoryManagement)
        {
            _RepositoryManagement = repositoryManagement;
        }


        public T Get<T>(string Id)
        {
            var st = _RepositoryManagement.Get<T>(Id);
            return st;
        }

        public IEnumerable<T> GetAll<T>()
        {
            IEnumerable<T> res = _RepositoryManagement.GetAll<T>();
            return res;
        }

        public T Create<T>(T record)
        {
            var st = _RepositoryManagement.Create<T>(record);
            return st;
        }

        public void Delete<T>(string id)
        {
            _RepositoryManagement.Delete<T>(id);
        }

        public void UpdateInfo<T>(string Id, T record)
        {
            _RepositoryManagement.UpdateInfo<T>(Id, record);
        }
    }
}
