using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListApplication.BusinessLayer.Entities
{
    public class Person : Domain
    {
        public string PersonalId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
