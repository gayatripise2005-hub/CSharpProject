using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProject.Project1
{
    public class Event: BaseEntity
    {
        public string EventName { get; set; }
        public string Location { get; set; }
        public override string ToString()
        {
            return $" id:{Id},EventName: {EventName}, Location: {Location}";
        }
    }
}
