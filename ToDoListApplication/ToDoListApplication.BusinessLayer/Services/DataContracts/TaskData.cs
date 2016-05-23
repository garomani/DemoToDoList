using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using ToDoListApplication.BusinessLayer.Entities;

namespace ToDoListApplication.BusinessLayer.Services.DataContracts
{
    [DataContract]
    public class TaskData
    {
        [DataMember(Name="id")]
        public int Id { get; set; }

        [DataMember(Name="description")]
        public string Description { get; set; }

        [DataMember(Name="dateCreation")]
        public DateTime CreatedOn { get; set; }

        [DataMember(Name="assignedTo")]
        public PersonData AssignedTo { get; set; }

    }
}
