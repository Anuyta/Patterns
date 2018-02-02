using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MainPage : PageComponent
    {
        private IList<PageComponent> pages = new List<PageComponent>();

        public string Header { get; set; }

        public string Body { get; set; }

        public string Footer { get; set; }

        public void AddPage(SectionPage sectionPage)
        {
            pages.Add(sectionPage);
        }

        public override string ShowPage()
        {
            return string.Format("Main:\n<head>{0}</head>\n<body>{1}</body>\n<footer>{2}</footer>\n ",
                Header, Body, Footer);
        }

        public string ShowAllPages()
        {
            string res = ShowPage();
            foreach (var page in pages)
            {
                res += page.ShowPage();
                res += "\n";
                res += ((SectionPage)page).ShowSectionPages();
            }

            return res;
        }
    }
}
