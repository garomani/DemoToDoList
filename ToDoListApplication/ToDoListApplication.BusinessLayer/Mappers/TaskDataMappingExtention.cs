using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListApplication.BusinessLayer.Entities;
using ToDoListApplication.BusinessLayer.Services.DataContracts;

namespace ToDoListApplication.BusinessLayer.Mappers
{
    public static class TaskDataMappingExtention
    {
        public static TaskData MapToTaskData(this Task entity, IList<Person> persons)
        {
            return new TaskData
            {
                Id = entity.Id,
                Description = entity.Description,
                CreatedOn = entity.CreationDate,
                AssignedTo = persons.SingleOrDefault(p => p.Id == entity.PersonId).MapToPersonData()
            };
        }

        public static Task MapToTask(this TaskData entity)
        {
            return new Task
            {
                Id = entity.Id,
                Description = entity.Description,
                CreationDate = entity.CreatedOn,
                PersonId = entity.AssignedTo.Id
            };
        }
    }
}
