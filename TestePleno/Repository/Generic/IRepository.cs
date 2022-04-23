using System.Collections.Generic;
using TestePleno.Models;

namespace TestePleno.Repository
{
    public interface IRepository<T> where T : IModel
    {
        T Create(T item);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);
    }
}
