using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApplication.BusinessLayer.Entities;

namespace ToDoListApplication.BusinessLayer.Repositories.Data
{
    public class PersonsData : IEntityData
    {
        public List<Person> Persons { get; private set; }

        public PersonsData()
        {
            Persons = new List<Person>
            {
                new Person{
                    Id = 1,
                    Name = "Juan Perez",
                    PersonalId = "23423421",
                    Email = "jperez@gmail.com"
                },
                new Person{
                    Id = 2,
                    Name = "Carlos Garcia",
                    PersonalId = "30675989",
                    Email = "cgarcia@gmail.com"
                },
                new Person{
                    Id = 3,
                    Name = "Mario Gomez",
                    PersonalId = "21548734",
                    Email = "mgomez@hotmail.com"
                },
                new Person{
                    Id = 4,
                    Name = "Alberto Rodriguez",
                    PersonalId = "8471434",
                    Email = "arodriguez@gmail.com"
                }
            };
        }

        public void AddRange(IEnumerable<Person> list)
        {
            Persons.AddRange(list);
        }

        public void Add(Person entity)
        {
            Persons.Add(entity);
        }

        public bool Remove(Person entity)
        {
            return Persons.Remove(entity);
        }
    }
}
