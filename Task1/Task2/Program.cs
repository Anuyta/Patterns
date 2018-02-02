using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainPage = new MainPage() { Header = "Main page", Body = "Main body", Footer = "Main footer" };
            var sectionPage1 = new SectionPage() { Header = " First Section page", Body = "First Section body", Footer = "First Section footer" };
            var sectionPage2 = new SectionPage() { Header = "Second Section page", Body = "Second Section body", Footer = "Second Section footer" };
            var page1 = new SimpleInfoPage() { Header = "First page", Body = "First body", Footer = "First footer" };
            var page2 = new SimpleInfoPage() { Header = "Second page", Body = "Second body", Footer = "Second footer" };

            sectionPage1.AddPage(page1);
            sectionPage1.AddPage(page2);


            mainPage.AddPage(sectionPage1);
            mainPage.AddPage(sectionPage2);

            

            Console.WriteLine(mainPage.ShowAllPages());
            Console.ReadLine();
        }
    }
}
