using System;
using System.Collections.Generic;
using System.Text;

namespace TeamsApp.DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        T Insert(T entity);
        void Update(T entity);
        int DeleteById(int id);
        void SaveChanges();
    }
}
