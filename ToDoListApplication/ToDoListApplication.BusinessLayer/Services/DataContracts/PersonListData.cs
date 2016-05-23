using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApplication.BusinessLayer.Services.DataContracts
{
    [DataContract]
    public class PersonListData
    {
        [DataMember(Name = "values")]
        public IList<PersonData> Values { get; set; }

        [DataMember(Name = "count")]
        public int Count { get; set; }
    }
}
