using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListApplication.BusinessLayer.Entities;
using ToDoListApplication.BusinessLayer.Repositories.Data;
using ToDoListApplication.BusinessLayer.Repositories.Interfaces;

namespace ToDoListApplication.BusinessLayer.Repositories.Implementations
{
    public class TaskRepository : Repository<Task>, ITaskRepository
    {
        public TaskRepository()
            : base()
        {
        }

        public void Add(Task entity)
        {
            (data as TasksData).Add(entity);
        }
        public bool Delete(Task entity)
        {
            var info = data as TasksData;

            if (!info.Remove(entity))
                throw new InvalidOperationException(string.Format("You can not delete the Task {0} does not exists such element", entity.Description));

            return true;
        }

        public IEnumerable<Task> FindAll(string filter)
        {
            return (data as TasksData).Tasks;
        }

        public Task FindById(int id)
        {
            return (data as TasksData).Tasks.FirstOrDefault(t => t.Id == id);
        }

        public void Update(Task entity)
        {
            var info = data as TasksData;
            if (this.FindById(entity.Id) != null)
            {
                info.Remove(entity);
                info.Add(entity);
            }
            else
                throw new InvalidOperationException(string.Format("You can not update the Task {0} does not exists such element", entity.Description));

        }

     
    }
}
