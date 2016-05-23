using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApplication.BusinessLayer.Entities;
using ToDoListApplication.BusinessLayer.Repositories.Data;
using ToDoListApplication.BusinessLayer.Repositories.Interfaces;

namespace ToDoListApplication.BusinessLayer.Repositories.Implementations
{
    public abstract class Repository<T> : IRepository<T> where T : Domain
    {
        protected IEntityData data;
        
        public Repository()
        {
            data = ContextManager.ContextManager.Instance.GetData(typeof(T));    
        }
        
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll(string filter)
        {
            throw new NotImplementedException();
        }

        public T FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
