using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApplication.BusinessLayer.Repositories.Interfaces;
using ToDoListApplication.BusinessLayer.Services.DataContracts;
using ToDoListApplication.BusinessLayer.Mappers;

namespace ToDoListApplication.BusinessLayer.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository repository)
        {
            _personRepository = repository;
        }

        public PersonListData GetAll()
        {
            var list = _personRepository.FindAll("");
            var data = list.Select(p => p.MapToPersonData()).ToList();

            return new PersonListData
            {
                Values = data,
                Count = data.Count
            };
        }
    }
}
