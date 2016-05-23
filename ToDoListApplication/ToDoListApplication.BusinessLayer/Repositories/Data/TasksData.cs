using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListApplication.BusinessLayer.Entities;


namespace ToDoListApplication.BusinessLayer.Repositories.Data
{
    public class TasksData : IEntityData
    {
        public List<Task> Tasks { get; private set; }

        public TasksData()
        {
            Random rnd = new Random();
            Tasks = new List<Task>
            {
                new Task
                {
                    Id = 1,
                    Description = "Define users and workflow",
                    CreationDate = DateTime.Today.AddDays(rnd.Next(15, 60) * -1),
                    PersonId = rnd.Next(1, 5)
                },
                new Task
                {
                    Id = 2,
                    Description = "Define the relationship between resources and business systems.",
                    CreationDate = DateTime.Today.AddDays(rnd.Next(15, 60) * -1),
                    PersonId = rnd.Next(1, 5)
                },
                new Task
                {
                    Id = 3,
                    Description = "Define the server configuration.",
                    CreationDate = DateTime.Today.AddDays(rnd.Next(15, 60) * -1),
                    PersonId = rnd.Next(1, 5)
                },
                new Task
                {
                    Id = 4,
                    Description = "	Identify the implementation team.",
                    CreationDate = DateTime.Today.AddDays(rnd.Next(15, 60) * -1),
                    PersonId = rnd.Next(1, 5)
                },
                new Task
                {
                    Id = 5,
                    Description = "Order prerequisite software.",
                    CreationDate = DateTime.Today.AddDays(rnd.Next(15, 60) * -1),
                    PersonId = rnd.Next(1, 5)
                },
                new Task
                {
                    Id = 6,
                    Description = "Install test and QA servers and prerequisite software",
                    CreationDate = DateTime.Today.AddDays(rnd.Next(15, 60) * -1),
                    PersonId = rnd.Next(1, 5)
                },
                new Task
                {
                    Id = 7,
                    Description = "TVerify connectivity from test and QA servers.",
                    CreationDate = DateTime.Today.AddDays(rnd.Next(15, 61) * -1),
                    PersonId = rnd.Next(1, 5)
                },
                new Task
                {
                    Id = 8,
                    Description = "Install production servers and prerequisite software",
                    CreationDate = DateTime.Today.AddDays(rnd.Next(15, 60) * -1),
                    PersonId = rnd.Next(1, 5)
                },
                new Task
                {
                    Id = 9,
                    Description = "Create configuration level objects",
                    CreationDate = DateTime.Today.AddDays(rnd.Next(15, 60) * -1),
                    PersonId = rnd.Next(1, 5)
                },
                new Task
                {
                    Id = 10,
                    Description = "Configure servers",
                    CreationDate = DateTime.Today.AddDays(rnd.Next(15, 60) * -1),
                    PersonId = rnd.Next(1, 5)
                },
                new Task
                {
                    Id = 11,
                    Description = "Evaluate the addition and deletion of user IDs",
                    CreationDate = DateTime.Today.AddDays(rnd.Next(15, 60) * -1),
                    PersonId = rnd.Next(1, 5)
                },                
                new Task
                {
                    Id = 12,
                    Description = "Monitor system performance and adjust hardware as required.",
                    CreationDate = DateTime.Today.AddDays(rnd.Next(15, 60) * -1),
                    PersonId = rnd.Next(1, 5)
                },
                new Task
                {
                    Id = 12,
                    Description = "Batch schedule download/process",
                    CreationDate = DateTime.Today.AddDays(rnd.Next(15, 60) * -1),
                    PersonId = rnd.Next(1, 5)
                }
            };
        }

        public void AddRange(IEnumerable<Task> list)
        {
            Tasks.AddRange(list);
        }

        public void Add(Task entity)
        {
            Tasks.Add(entity);
        }

        public bool Remove(Task entity)
        {
            return Tasks.Remove(entity);
        }
    }
}
