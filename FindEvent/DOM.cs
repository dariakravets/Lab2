using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FindEvent
{
    public class DOM : IStrategy
    {
        XmlDocument doc = new XmlDocument();

        public List<Search> AnalyzeFile(Search mysearch, string path)
        {
            doc.Load(path);
            List<List<Search>> info = new List<List<Search>>();

            if (mysearch.EventName == null && mysearch.PersonName == null &&
                mysearch.Faculty == null && mysearch.Department == null &&
                mysearch.Responsible == null && mysearch.Doer == null &&
                mysearch.Deadline == null && mysearch.Time == null &&
                mysearch.Place == null && mysearch.Characteristic == null)
                return ErrorCatch(doc);

            if (mysearch.EventName != null)
                info.Add(SearchByAttribute("Event", "Event Name", mysearch.EventName, doc));
            if (mysearch.PersonName != null)
                info.Add(SearchByAttribute("Event", "Person Name", mysearch.PersonName, doc));
            if (mysearch.Faculty != null)
                info.Add(SearchByAttribute("Event", "Faculty", mysearch.Faculty, doc));
            if (mysearch.Department != null)
                info.Add(SearchByAttribute("Event", "Department", mysearch.Department, doc));
            if (mysearch.Responsible != null)
                info.Add(SearchByAttribute("Event", "Responsible", mysearch.Responsible, doc));
            if (mysearch.Doer != null)
                info.Add(SearchByAttribute("Event", "Doer", mysearch.Doer, doc));
            if (mysearch.Deadline != null)
                info.Add(SearchByAttribute("Event", "Deadline", mysearch.Deadline, doc));
            if (mysearch.Time != null)
                info.Add(SearchByAttribute("Event", "Time", mysearch.Time, doc));
            if (mysearch.Place != null)
                info.Add(SearchByAttribute("Event", "Place", mysearch.Place, doc));
            if (mysearch.Characteristic != null)
                info.Add(SearchByAttribute("Event", "Characteristic", mysearch.Characteristic, doc));

            return Cross(info, mysearch);
        }

        public List<Search> SearchByAttribute(string nodeName, string attribute, string myTemplate, XmlDocument doc)
        {
            List<Search> find = new List<Search>();

            if (myTemplate != null)
            {
                XmlNodeList list = doc.SelectNodes("//" + nodeName + "[@" + attribute + "=\"" + myTemplate + "\"]");
                foreach (XmlNode e in list)
                {
                    find.Add(Info(e));
                }
            }
            return find;
        }

        public List<Search> ErrorCatch(XmlDocument doc)
        {
            List<Search> result = new List<Search>();
            XmlNodeList list = doc.SelectNodes("//" + "Event");
            foreach (XmlNode e in list)
            {
                result.Add(Info(e));
            }
            return result;
        }

        public Search Info(XmlNode node)
        {
            Search search = new Search();
            search.EventName = node.Attributes.GetNamedItem("EventName").Value;
            search.PersonName = node.Attributes.GetNamedItem("PersonName").Value;
            search.Faculty = node.Attributes.GetNamedItem("Faculty").Value;
            search.Department = node.Attributes.GetNamedItem("Department").Value;
            search.Responsible = node.Attributes.GetNamedItem("Responsible").Value;
            search.Doer = node.Attributes.GetNamedItem("Doer").Value;
            search.Deadline = node.Attributes.GetNamedItem("Deadline").Value;
            search.Time = node.Attributes.GetNamedItem("Time").Value;
            search.Place = node.Attributes.GetNamedItem("Place").Value;
            search.Characteristic = node.Attributes.GetNamedItem("Characteristic").Value;
            return search;
        }

        public List<Search> Cross(List<List<Search>> list, Search myTemplate)
        {
            List<Search> result = new List<Search>();
            List<Search> clear = CheckNodes(list, myTemplate);

            foreach (Search elem in clear)
            {
                bool isIn = false;
                foreach (Search s in result)
                    if (s.Compare(elem))
                        isIn = true;

                if (!isIn)
                    result.Add(elem);
            }
            return result;
        }

        public List<Search> CheckNodes(List<List<Search>> list, Search myTemplate)
        {
            List<Search> newResult = new List<Search>();
            foreach(List<Search> elem in list)
            {
                foreach(Search s in elem)
                {
                    if ((myTemplate.EventName == null || myTemplate.EventName == s.EventName) &&
                        (myTemplate.PersonName == null || myTemplate.PersonName == s.PersonName) &&
                        (myTemplate.Faculty == null || myTemplate.Faculty == s.Faculty) &&
                        (myTemplate.Department == null || myTemplate.Department == s.Department) &&
                        (myTemplate.Responsible == null || myTemplate.Responsible == s.Responsible) &&
                        (myTemplate.Doer == null || myTemplate.Doer == s.Doer) &&
                        (myTemplate.Deadline == null || myTemplate.Deadline == s.Deadline) &&
                        (myTemplate.Time == null || myTemplate.Time == s.Time) &&
                        (myTemplate.Place == null || myTemplate.Place == s.Place) &&
                        (myTemplate.Characteristic == null || myTemplate.Characteristic == s.Characteristic))
                        newResult.Add(s);
                }
            }
            return newResult;
        }
    }
}
