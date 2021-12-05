using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FindEvent
{
    public class SAX : IStrategy
    {
        private List<Search> lastResult = null;
        public List<Search> AnalyzeFile(Search mysearch, string path)
        {
            XmlReader reader = XmlReader.Create(path);
            List<Search> result = new List<Search>();

            Search find = null;

            while(reader.Read())
            {
                switch(reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "Event")
                        {
                            find = new Search();
                            while(reader.MoveToNextAttribute())
                            {
                                if (reader.Name == "EventName")
                                    find.EventName = reader.Value;
                                if (reader.Name == "PersonName")
                                    find.PersonName = reader.Value;
                                if (reader.Name == "Faculty")
                                    find.Faculty = reader.Value;
                                if (reader.Name == "Department")
                                    find.Department = reader.Value;
                                if (reader.Name == "Responsible")
                                    find.Responsible = reader.Value;
                                if (reader.Name == "Doer")
                                    find.Doer = reader.Value;
                                if (reader.Name == "Deadline")
                                    find.Deadline = reader.Value;
                                if (reader.Name == "Time")
                                    find.Time = reader.Value;
                                if (reader.Name == "Place")
                                    find.Place = reader.Value;
                                if (reader.Name == "Characteristic")
                                    find.Characteristic = reader.Value;
                            }
                            result.Add(find);
                        }
                        break;
                }
            }
            lastResult = Filter(result, mysearch);
            return lastResult;
        }

        private List<Search> Filter(List<Search> allRes, Search myTemplate)
        {
            List<Search> newResult = new List<Search>();
            if (allRes != null)
            {
                foreach (Search i in allRes)
                {
                    if ((myTemplate.EventName == null || myTemplate.EventName == i.EventName) &&
                        (myTemplate.PersonName == null || myTemplate.PersonName == i.PersonName) &&
                        (myTemplate.Faculty == null || myTemplate.Faculty == i.Faculty) &&
                        (myTemplate.Department == null || myTemplate.Department == i.Department) &&
                        (myTemplate.Responsible == null || myTemplate.Responsible == i.Responsible) &&
                        (myTemplate.Doer == null || myTemplate.Doer == i.Doer) &&
                        (myTemplate.Deadline == null || myTemplate.Deadline == i.Deadline) &&
                        (myTemplate.Time == null || myTemplate.Time == i.Time) &&
                        (myTemplate.Place == null || myTemplate.Place == i.Place) &&
                        (myTemplate.Characteristic == null || myTemplate.Characteristic == i.Characteristic))
                        newResult.Add(i);
                }
            }
            return newResult;
        }
    }
}
