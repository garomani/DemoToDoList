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
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository()
            : base()
        {
        }

        public void Add(Person entity)
        {
            (data as PersonsData).Add(entity);
        }

        public bool Delete(Person entity)
        {
            var info = data as PersonsData;

            if (!info.Remove(entity))
                throw new InvalidOperationException(string.Format("You can not delete the Person {0} does not exists such element", entity.Name));

            return true;
        }

        public IEnumerable<Person> FindAll(string filter)
        {
            return (data as PersonsData).Persons;
        }

        public Person FindById(int id)
        {
            return (data as PersonsData).Persons.FirstOrDefault(t => t.Id == id);
        }

        public void Update(Person entity)
        {
            var info = data as PersonsData;
            if (this.FindById(entity.Id) != null)
            {
                info.Remove(entity);
                info.Add(entity);
            }
            else
                throw new InvalidOperationException(string.Format("You can not update the person {0} does not exists such element", entity.Name));

        }
    }
}
