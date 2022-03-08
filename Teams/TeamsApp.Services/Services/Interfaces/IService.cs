using System;
using System.Collections.Generic;
using System.Text;

namespace TeamsApp.Services.Services.Interfaces
{
    public interface IService<T>
    {
        T GetById(int id);
        List<T> GetAll();
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(int id);
    }
}
