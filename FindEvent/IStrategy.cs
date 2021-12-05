using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvent
{
    interface IStrategy
    {
        List<Search> AnalyzeFile(Search mysearch, string path);
    }
}