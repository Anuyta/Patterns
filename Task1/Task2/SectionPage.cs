using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class SectionPage : PageComponent
    {
        private IList<PageComponent> pages = new List<PageComponent>();

        public string Header { get; set; }

        public string Body { get; set; }

        public string Footer { get; set; }

        public void AddPage(SimpleInfoPage simplePage)
        {
            pages.Add(simplePage);
        }

        public override string ShowPage()
        {
            return string.Format("\tSection:\n\t<head>{0}</head>\n\t<body>{1}</body>\n\t<footer>{2}</footer>\n ",
                Header, Body, Footer);
        }

        public string ShowSectionPages()
        {
            string res = "";
            foreach (var page in pages)
            {
                res += page.ShowPage();
                res += "\n";
            }

            return res;
        }
    }
}
