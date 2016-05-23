using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApplication.BusinessLayer.Services.DataContracts
{
    [DataContract]
    public class TaskListData
    {
        [DataMember(Name="values")]
        public IList<TaskData> Values { get; set; }

        [DataMember(Name="count")]
        public int Count { get; set; }
    }
}
