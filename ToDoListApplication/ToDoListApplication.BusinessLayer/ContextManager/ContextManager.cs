using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApplication.BusinessLayer.Entities;
using ToDoListApplication.BusinessLayer.Repositories.Data;

namespace ToDoListApplication.BusinessLayer.ContextManager
{
    public sealed class ContextManager
    {
        private IDictionary<Type, Func<IEntityData>> entities;
        private static ContextManager instance = null;

        private ContextManager()
        {
            entities = new Dictionary<Type, Func<IEntityData>>()
            {
                  {typeof(Person), GetPersons},
                  {typeof(ToDoListApplication.BusinessLayer.Entities.Task), GetTasks}

            };
        }

        public static ContextManager Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ContextManager();
                }
                return instance;
            }
        }

        public IEntityData GetData(Type type)
        {
            return entities[type]();
        }

        private PersonsData GetPersons()
        {
            return new PersonsData();
        }

        private TasksData GetTasks()
        {
            return new TasksData(); 
        }
    }
}
