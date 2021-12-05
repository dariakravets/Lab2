using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvent
{
    public class Search
    {
        public string EventName = null;
        public string PersonName = null;
        public string Faculty = null;
        public string Department = null;
        public string Responsible = null;
        public string Doer = null;
        public string Deadline = null;
        public string Time = null;
        public string Place = null;
        public string Characteristic = null;

        public Search() { }

        public bool Compare (Search obj)
        {
            if ((this.EventName == obj.EventName) &&
                (this.PersonName == obj.PersonName) &&
                (this.Faculty == obj.Faculty) &&
                (this.Department == obj.Department) &&
                (this.Responsible == obj.Responsible) &&
                (this.Doer == obj.Doer) &&
                (this.Deadline == obj.Deadline) &&
                (this.Time == obj.Time) &&
                (this.Place == obj.Place) &&
                (this.Characteristic == obj.Characteristic))
                return true;
            else return false;
        }
    }
}
