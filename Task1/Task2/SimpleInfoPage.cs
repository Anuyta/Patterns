using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class SimpleInfoPage : PageComponent
    {
        public string Header { get; set; }

        public string Body { get; set; }

        public string Footer { get; set; }

        public override string ShowPage()
        {
            return string.Format("\t\tPage:\n\t\t<head>{0}</head>\t\t\n<body>{1}</body>\t\t\n<footer>{2}</footer>\n ", 
                Header, Body, Footer);
        }
    }
}
