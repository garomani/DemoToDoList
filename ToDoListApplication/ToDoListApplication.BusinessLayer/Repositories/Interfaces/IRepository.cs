using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApplication.BusinessLayer.Entities;

namespace ToDoListApplication.BusinessLayer.Repositories.Interfaces
{
    public interface IRepository<T> where T : Domain
    {
        void Add(T entity);

        bool Delete(T entity);

        IEnumerable<T> FindAll(string filter);

        T FindById(int id);

        void Update(T entity);
    }
}
