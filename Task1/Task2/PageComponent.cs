using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class PageComponent
    {
        public string Header { get; set; }

        public string Body { get; set; }

        public string Footer { get; set; }

        public abstract string ShowPage();
    }
}
