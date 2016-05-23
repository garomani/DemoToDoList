using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApplication.BusinessLayer.Entities;
using ToDoListApplication.BusinessLayer.Services.DataContracts;

namespace ToDoListApplication.BusinessLayer.Mappers
{
    public static class PersonDataMappingExtentions
    {
        public static PersonData MapToPersonData(this Person entity)
        {
            return new PersonData
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                PersonalId = entity.PersonalId
            };
        }
    }
}
