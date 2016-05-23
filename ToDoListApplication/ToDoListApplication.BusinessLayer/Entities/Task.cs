using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApplication.BusinessLayer.Entities
{
    public class Task : Domain
    {
        public string Description { get; set; }
        public int PersonId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}
