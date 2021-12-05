using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace FindEvent
{
    public class LINQtoXml : IStrategy
    {
        private List<Search> find = null;
        XDocument doc = new XDocument();
        public List<Search> AnalyzeFile(Search mysearch, string path)
        {
            doc = XDocument.Load(@path);
            find = new List<Search>();
            List<XElement> matches = (from val in doc.Descendants("Event")
                                      where ((mysearch.EventName == null || mysearch.EventName == val.Attribute("Event Name").Value) &&
                                      (mysearch.PersonName == null || mysearch.PersonName == val.Attribute("PersonName").Value) &&
                                      (mysearch.Faculty == null || mysearch.Faculty == val.Attribute("Faculty").Value) &&
                                      (mysearch.Department == null || mysearch.Department == val.Attribute("Department").Value) &&
                                      (mysearch.Responsible == null || mysearch.Responsible == val.Attribute("Responsible").Value) &&
                                      (mysearch.Doer == null || mysearch.Doer == val.Attribute("Doer").Value) &&
                                      (mysearch.Deadline == null || mysearch.Deadline == val.Attribute("Deadline").Value) &&
                                      (mysearch.Time == null || mysearch.Time == val.Attribute("Time").Value) &&
                                      (mysearch.Place == null || mysearch.Place == val.Attribute("Place").Value) &&
                                      (mysearch.Characteristic == null || mysearch.Characteristic == val.Attribute("Characteristic").Value)
                                      )
                                      select val).ToList();
            foreach(XElement match in matches)
            {
                Search res = new Search();
                res.EventName = match.Attribute("EventName").Value;
                res.PersonName = match.Attribute("PersonName").Value;
                res.Faculty = match.Attribute("Faculty").Value;
                res.Department = match.Attribute("Department").Value;
                res.Responsible = match.Attribute("Responsible").Value;
                res.Doer = match.Attribute("Doer").Value;
                res.Deadline = match.Attribute("Deadline").Value;
                res.Time = match.Attribute("Time").Value;
                res.Place = match.Attribute("Place").Value;
                res.Characteristic = match.Attribute("Characteristic").Value;
                find.Add(res);
            }
            return find;
        }
    }
}
